package com.example.drdmobileapp.ui.regular_loan;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInEmployeeID;
import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInTableName;

import android.content.Intent;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.loan_application_success;
import com.example.drdmobileapp.ui.home.HomeFragment;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.HashMap;

public class RegularLoanFragment extends Fragment {
    private EditText EditTextSalaryAmt, EditTextMonthsToPay;
    private Button btnApply;
    private ImageButton btnBack;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        FirebaseDatabase db = FirebaseDatabase.getInstance();
        DatabaseReference root = db.getReference().child("Users");

        View view = inflater.inflate(R.layout.fragment_regular_loan, container, false);
        btnBack = view.findViewById(R.id.btnBack_Rloan);
        btnApply = view.findViewById(R.id.btnApply_Rloan);
        EditTextSalaryAmt = view.findViewById(R.id.basic_salary_input);
        EditTextMonthsToPay = view.findViewById(R.id.months_to_pay_input);

        EditTextMonthsToPay.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {
                // Do nothing
            }

            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                // Do nothing
            }

            @Override
            public void afterTextChanged(Editable s) {
                try {
                    if (!s.toString().isEmpty()) {
                        int value = Integer.parseInt(s.toString());
                        if (value < 1) {
                            s.replace(0, s.length(), "1");
                        } else if (value > 24) {
                            s.replace(0, s.length(), "24");
                        }
                    }
                } catch (NumberFormatException e) {
                    // Handle the exception by clearing the input or showing an error message
                    s.clear();
                    Toast.makeText(getContext(), "Invalid input. Please enter a valid number.", Toast.LENGTH_SHORT).show();
                }
            }
        });

        btnBack.setOnClickListener(v -> {
            NavHostFragment.findNavController(RegularLoanFragment.this)
                    .navigate(R.id.nav_home);
        });


        // Apply btn block
        btnApply.setOnClickListener(v -> {
            root.child(getLoggedInTableName()).child("HasLoan").addListenerForSingleValueEvent(new ValueEventListener() {
                @Override
                public void onDataChange(@NonNull DataSnapshot snapshot) {
                    boolean hasLoan = Boolean.TRUE.equals(snapshot.getValue(Boolean.class));
                    if (hasLoan) {
                        // Display error message
                        Toast.makeText(getContext(), "You have already applied for a loan.", Toast.LENGTH_SHORT).show();
                    } else {
                        if (EditTextSalaryAmt.getText().toString().isEmpty()) {
                            EditTextSalaryAmt.setError("Salary Amount cannot be empty.");
                        }
                        if (EditTextMonthsToPay.getText().toString().isEmpty()) {
                            EditTextMonthsToPay.setError("Months to Pay cannot be empty.");
                        }
                        //add confirmation dialogbox that displays the Salary Amount: Integer.parseInt(EditTextSalaryAmt.getText().toString()
                        //and MonthsToPay: Integer.parseInt(EditTextMonthsToPay.getText().toString()

                        double LoanAmt, IntRate = 0, LoanInt, TakeHomeLoan, ServiceCharge, MonthlyAmort, MonthsToPay;

                        LoanAmt = Integer.parseInt(EditTextSalaryAmt.getText().toString().trim()) * 2.5;
                        MonthsToPay = Integer.parseInt(EditTextMonthsToPay.getText().toString().trim());

                        if(MonthsToPay >= 1){
                            IntRate = 0.62;
                        }
                        if(MonthsToPay >= 6){
                            IntRate = 0.65;
                        }
                        if(MonthsToPay >= 11){
                            IntRate = 0.68;
                        }
                        if(MonthsToPay >= 16){
                            IntRate = 0.75;
                        }
                        if(MonthsToPay >= 21){
                            IntRate = 0.80;
                        }

                        LoanInt = LoanAmt * MonthsToPay * IntRate;
                        ServiceCharge = LoanInt * .02;
                        TakeHomeLoan = (LoanAmt - (LoanInt + ServiceCharge)) * -1;
                        MonthlyAmort = (TakeHomeLoan / MonthsToPay);

                        root.child(getLoggedInTableName()).child("CompLoanAmount").setValue(LoanAmt);
                        root.child(getLoggedInTableName()).child("CompLoanInterest").setValue(LoanInt);
                        root.child(getLoggedInTableName()).child("CompTakeHomeLoan").setValue(TakeHomeLoan);
                        root.child(getLoggedInTableName()).child("CompServiceCharge").setValue(ServiceCharge);
                        root.child(getLoggedInTableName()).child("CompMonthlyAmort").setValue(MonthlyAmort);
                        root.child(getLoggedInTableName()).child("CompMonthsToPay").setValue(MonthsToPay);

                        root.child(getLoggedInTableName()).child("HasLoan").setValue(true);
                        root.child(getLoggedInTableName()).child("CompLoanType").setValue("Regular");
                        root.child(getLoggedInTableName()).child("Status").setValue("Pending");


                        requireActivity().getSupportFragmentManager().popBackStack();
                        Intent intent = new Intent(getActivity(), loan_application_success.class);
                        startActivity(intent);

                    }
                }
                @Override
                public void onCancelled(@NonNull DatabaseError error) {
                    // Handle any errors
                    Toast.makeText(getContext(), "Error: " + error.getMessage(), Toast.LENGTH_SHORT).show();
                }
            });
        });

        return view;

    }
    @Override
    public void onDestroyView() {
        super.onDestroyView();
    }
}
