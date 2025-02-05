package com.example.drdmobileapp.ui.home;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInEmployeeID;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import androidx.navigation.Navigation;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.ui.admin.viewrecords.ViewRecordsFragment;
import com.example.drdmobileapp.ui.emergency_loan.EmergencyLoanFragment;
import com.example.drdmobileapp.ui.loaninfo.UserLoanInfoFragment;
import com.example.drdmobileapp.ui.login.LoginActivity;
import com.example.drdmobileapp.ui.regular_loan.RegularLoanFragment;
import com.example.drdmobileapp.ui.special_loan.SpecialLoanFragment;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class HomeFragment extends Fragment {
    private TextView TextViewName, TextViewID, TextViewDateHired;
    private Button btnLoanStatus, btnRegularLoan, btnSpecialLoan, btnEmergencyLoan;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        String employeeID = getLoggedInEmployeeID();
        Log.d("HomeFragment", "Logged-in EmployeeID: " + employeeID);

        if (employeeID == null) {
            // If null, start the LoginActivity
            Intent intent = new Intent(getActivity(), LoginActivity.class);
            startActivity(intent);
            // Finish the current activity to prevent going back to HomeFragment
            requireActivity().finish();
            return null;
        }

        View view = inflater.inflate(R.layout.fragment_home, container, false);
        btnLoanStatus = view.findViewById(R.id.btnLoanStatus);
        btnRegularLoan = view.findViewById(R.id.btnRloan);
        btnSpecialLoan = view.findViewById(R.id.btnSloan);
        btnEmergencyLoan = view.findViewById(R.id.btnEloan);
        TextViewName = view.findViewById(R.id.name);
        TextViewID = view.findViewById(R.id.id);
        TextViewDateHired = view.findViewById(R.id.datehired);

        // Get the FirebaseDatabase reference
        FirebaseDatabase database = FirebaseDatabase.getInstance();
        DatabaseReference usersRef = database.getReference("Users");

        usersRef.orderByChild("EmployeeID").equalTo(employeeID)
                .addListenerForSingleValueEvent(new ValueEventListener() {
                    @Override
                    public void onDataChange(@NonNull DataSnapshot snapshot) {
                        if (snapshot.exists()) {
                            for (DataSnapshot userSnapshot : snapshot.getChildren()) {

                                String firstName = userSnapshot.child("FirstName").getValue(String.class);
                                String middleInitial = userSnapshot.child("MiddleInitial").getValue(String.class);
                                String lastName = userSnapshot.child("LastName").getValue(String.class);
                                String employeeId = userSnapshot.child("EmployeeID").getValue(String.class);
                                String dateHired = userSnapshot.child("DateHired").getValue(String.class);


                                TextViewName.setText(firstName + " " + lastName);
                                TextViewID.setText(employeeId);
                                TextViewDateHired.setText(dateHired);
                                break; // Exit the loop after finding the first matching user
                            }
                        } else {
                            // Handle the case when the user's information is not found
                            TextViewName.setText("User not found");
                        }
                    }

                    @Override
                    public void onCancelled(@NonNull DatabaseError error) {
                        // Handle any errors that occur during the retrieval
                        TextViewName.setText("Error retrieving user information");
                    }
                });

        NavHostFragment.findNavController(HomeFragment.this);

        // Loan Status button
        btnLoanStatus.setOnClickListener(v -> {
            Navigation.findNavController(v).navigate(R.id.nav_user_Loan_info);

        });


        // Regular Loan button
        btnRegularLoan.setOnClickListener(v -> {
            Navigation.findNavController(v).navigate(R.id.nav_regular_loan);
        });

        // Special Loan button
        btnSpecialLoan.setOnClickListener(v -> {
            Navigation.findNavController(v).navigate(R.id.nav_special_loan);

        });
        // Emergency Loan button
        btnEmergencyLoan.setOnClickListener(v -> {
            Navigation.findNavController(v).navigate(R.id.nav_emergency_loan);
        });

        return view;
    }

}

