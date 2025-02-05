package com.example.drdmobileapp.ui.emergency_loan;

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
import android.widget.Spinner;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.databinding.FragmentEmergencyLoanBinding;
import com.example.drdmobileapp.ui.home.HomeFragment;
import com.example.drdmobileapp.ui.regular_loan.RegularLoanFragment;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class EmergencyLoanFragment extends Fragment {

    private EditText EditTextLoanAmt, EditTextMonthsToPay;
    private Button btnApply;
    private ImageButton btnBack;
    private Spinner MOP;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        FirebaseDatabase db = FirebaseDatabase.getInstance();
        DatabaseReference root = db.getReference().child("Users");

        View view = inflater.inflate(R.layout.fragment_emergency_loan, container, false);
        btnBack = view.findViewById(R.id.btnBack_Eloan);
        btnApply = view.findViewById(R.id.btnApply_Eloan);
        MOP = view.findViewById(R.id.mode_of_payment_input);
        EditTextMonthsToPay = view.findViewById(R.id.months_to_pay_input);
        EditTextLoanAmt = view.findViewById(R.id.loan_amount_input);

        String[] mopOptions = {"Cash", "Online Payment"};
        ArrayAdapter<String> adapter = new ArrayAdapter<>(getActivity(), android.R.layout.simple_spinner_item, mopOptions);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        MOP.setAdapter(adapter);

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
                        } else if (value > 6) {
                            s.replace(0, s.length(), "6");
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
            NavHostFragment.findNavController(EmergencyLoanFragment.this)
                    .navigate(R.id.nav_home);
        });


        // Apply btn block
        btnApply.setOnClickListener(v -> {
            root.child(getLoggedInTableName()).child("HasLoan").addListenerForSingleValueEvent(new ValueEventListener() {
                @Override
                public void onDataChange(@NonNull DataSnapshot snapshot) {
                    boolean hasLoan = Boolean.TRUE.equals(snapshot.getValue(Boolean.class));

                    String loanAmountInput = EditTextLoanAmt.getText().toString().trim();
                    String monthsToPayInput = EditTextMonthsToPay.getText().toString().trim();

                    if (hasLoan) {
                        // Display error message
                        Toast.makeText(getContext(), "You have already applied for a loan.", Toast.LENGTH_SHORT).show();
                    } else {
                        if (loanAmountInput.isEmpty()) {
                            EditTextLoanAmt.setError("Salary Amount cannot be empty.");
                        }
                        if (monthsToPayInput.isEmpty()) {
                            EditTextMonthsToPay.setError("Months to Pay cannot be empty.");
                        }
                        //add confirmation dialogbox that displays the Salary Amount: Integer.parseInt(EditTextSalaryAmt.getText().toString()
                        //and MonthsToPay: Integer.parseInt(EditTextMonthsToPay.getText().toString()

                        double loanAmount = Double.parseDouble(loanAmountInput);
                        double monthsToPay = Double.parseDouble(monthsToPayInput);
                        double cash, installment, serviceCharge, intRate = 0, interest;

                        if (loanAmount >= 1 && loanAmount <= 6) {
                            intRate = 0.60;
                        }

                        serviceCharge = loanAmount * 0.01;
                        cash = loanAmount + serviceCharge;
                        interest = loanAmount * serviceCharge;
                        installment = (loanAmount + serviceCharge + interest) / monthsToPay;

                        // Proceed with the loan application
                        root.child(getLoggedInTableName()).child("CompLoanAmount").setValue(loanAmount);
                        root.child(getLoggedInTableName()).child("CompMonthsToPay").setValue(monthsToPay);
                        root.child(getLoggedInTableName()).child("CompInterestRate").setValue(monthsToPay);

                        root.child(getLoggedInTableName()).child("HasLoan").setValue(true);
                        root.child(getLoggedInTableName()).child("CompLoanType").setValue("Emergency");
                        requireActivity().getSupportFragmentManager().popBackStack();
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