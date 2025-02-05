package com.example.drdmobileapp.ui.special_loan;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInTableName;

import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import androidx.lifecycle.ViewModelProvider;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.databinding.FragmentSpecialLoanBinding;
import com.example.drdmobileapp.ui.home.HomeFragment;
import com.example.drdmobileapp.ui.regular_loan.RegularLoanFragment;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class SpecialLoanFragment extends Fragment {

    private FragmentSpecialLoanBinding binding;
    private EditText EditTextLoanAmt, EditTextMonthsToPay;
    private Button btnApply;
    private ImageButton btnBack;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        FirebaseDatabase db = FirebaseDatabase.getInstance();
        DatabaseReference root = db.getReference().child("Users");

        View view = inflater.inflate(R.layout.fragment_special_loan, container, false);
        btnBack = view.findViewById(R.id.btnBack_Sloan);
        btnApply = view.findViewById(R.id.btnApply_Sloan);

        EditTextLoanAmt = view.findViewById(R.id.loan_amount_input);
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
                        } else if (value > 18) {
                            s.replace(0, s.length(), "18");
                        }
                    }
                } catch (NumberFormatException e) {
                    // Handle the exception by clearing the input or showing an error message
                    s.clear();
                    Toast.makeText(getContext(), "Invalid input. Please enter a valid number.", Toast.LENGTH_SHORT).show();
                }
            }
        });

        // BackBtn to home
        btnBack.setOnClickListener(v -> {
            NavHostFragment.findNavController(SpecialLoanFragment.this)
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
                        double loanAmount, intRate = 0, totalLoan, monthlyAmort, loanInterest, monthsToPay;


                        loanAmount = Integer.parseInt(EditTextLoanAmt.getText().toString());
                        monthsToPay = Integer.parseInt(EditTextMonthsToPay.getText().toString());
                        if (EditTextLoanAmt.getText().toString().isEmpty()) {
                            Toast.makeText(getContext(), "Loan Amount cannot be empty.", Toast.LENGTH_SHORT).show();
                        }
                        if (EditTextMonthsToPay.getText().toString().isEmpty()) {
                            Toast.makeText(getContext(), "Months to Pay cannot be empty.", Toast.LENGTH_SHORT).show();
                        }

                        if(Integer.parseInt(EditTextLoanAmt.getText().toString()) >= 1){
                            intRate = 0.60;
                        }
                        if(Integer.parseInt(EditTextLoanAmt.getText().toString()) >= 7){
                            intRate = 0.62;
                        }
                        if(Integer.parseInt(EditTextLoanAmt.getText().toString()) >= 13){
                            intRate = 0.65;
                        }


                        loanInterest = loanAmount * monthsToPay * intRate;
                        totalLoan = loanAmount + loanInterest;
                        monthlyAmort = (totalLoan / monthsToPay);

                        // Proceed with the loan application
                        root.child(getLoggedInTableName()).child("LoanAmount").setValue(Integer.parseInt(EditTextLoanAmt.getText().toString()));
                        root.child(getLoggedInTableName()).child("MonthsToPay").setValue(Integer.parseInt(EditTextMonthsToPay.getText().toString()));

                        //Loanable Amount = (50K up to 100K) provided that the member is already 5 years or above.
                        //Loan Interest = Loan Amount * number of months to pay * Interest rate
                        //Interest Rate Table:
                        //Number of months to Pay                               Interest rate
                        //1-6                                                   0.60%
                        //7-12                                                  0.62%
                        //13-18                                                 0.65%
                        //
                        //Total Amount of Loan  = Loan Amount + Loan Interest
                        //Monthly Amortization = Total Amount of Loan / Number of Months to Pay

                        root.child(getLoggedInTableName()).child("InterestRate").setValue(Integer.parseInt(EditTextMonthsToPay.getText().toString()));
                        root.child(getLoggedInTableName()).child("HasLoan").setValue(true);
                        root.child(getLoggedInTableName()).child("LoanType").setValue("Regular");
                        root.child(getLoggedInTableName()).child("MonthlyAmort").setValue(monthlyAmort);
                        requireActivity().getSupportFragmentManager().popBackStack();                    }
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