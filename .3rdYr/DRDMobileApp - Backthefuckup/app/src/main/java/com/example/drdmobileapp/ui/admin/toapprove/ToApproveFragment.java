package com.example.drdmobileapp.ui.admin.toapprove;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInEmployeeID;

import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TableLayout;
import android.widget.TableRow;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.ui.admin.LoanDetails;
import com.example.drdmobileapp.ui.admin.home.AdminHomeFragment;
import com.example.drdmobileapp.ui.login.LoginActivity;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class ToApproveFragment extends Fragment {
    private TextView Tname, Tloantype, Tamount, Tstatus, Tdetails;
    private ImageButton btnBack;

    int rowIndex = 0;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        String employeeID = getLoggedInEmployeeID();
        Log.d("ToApproveFragment", "Logged-in EmployeeID: " + employeeID);

        if (employeeID == null) {
            // If null, start the LoginActivity
            Intent intent = new Intent(getActivity(), LoginActivity.class);
            startActivity(intent);
            // Finish the current activity to prevent going back to HomeFragment
            requireActivity().finish();
            return null;
        }

        View view = inflater.inflate(R.layout.fragment_loan_status_admin, container, false);
        btnBack = view.findViewById(R.id.btnBack_admin2);
//        Tname = view.findViewById(R.id.tname);
//        Tloantype = view.findViewById(R.id.tloantype);
//        Tamount = view.findViewById(R.id.tamount);
//        Tstatus = view.findViewById(R.id.tstatus);

        DatabaseReference databaseRef = FirebaseDatabase.getInstance().getReference();
        databaseRef.addValueEventListener(new ValueEventListener() {

            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                TableLayout tableLayout = view.findViewById(R.id.table_layout);

                // Iterate through each table in the database
                for (DataSnapshot tableSnapshot : dataSnapshot.getChildren()) {
                    // Iterate through each user in the table
                    for (DataSnapshot userSnapshot : tableSnapshot.getChildren()) {
                        String firstName = userSnapshot.child("FirstName").getValue(String.class);
                        String lastName = userSnapshot.child("LastName").getValue(String.class);
                        String loanType = userSnapshot.child("CompLoanType").getValue(String.class);
                        Long loanAmountLong  = userSnapshot.child("CompLoanAmount").getValue(Long.class);
                        String loanAmount = String.valueOf(loanAmountLong);
                        String status = userSnapshot.child("Status").getValue(String.class);

                        // Merge the first name and last name
                        String mergedName = firstName + " " + lastName;

                        // Create a new TableRow for each row
                        TableRow tableRow = new TableRow(getContext());
                        tableRow.setLayoutParams(new TableLayout.LayoutParams(TableLayout.LayoutParams.MATCH_PARENT, TableLayout.LayoutParams.WRAP_CONTENT));

                        // Create and add the TextView for the merged name
                        TextView nameTextView = new TextView(getContext());
                        nameTextView.setText(mergedName);
                        nameTextView.setTextColor(Color.BLACK);
                        nameTextView.setTextSize(10);
                        nameTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
                        nameTextView.setLayoutParams(new TableRow.LayoutParams(300, ViewGroup.LayoutParams.WRAP_CONTENT));
                        tableRow.addView(nameTextView);

                        // Create and add the TextView for the loan type
                        TextView loanTypeTextView = new TextView(getContext());
                        loanTypeTextView.setText(loanType);
                        loanTypeTextView.setTextColor(Color.BLACK);
                        loanTypeTextView.setTextSize(10);
                        loanTypeTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
                        loanTypeTextView.setLayoutParams(new TableRow.LayoutParams(200, ViewGroup.LayoutParams.WRAP_CONTENT));
                        tableRow.addView(loanTypeTextView);

                        // Create and add the TextView for the loan amount
                        TextView loanAmountTextView = new TextView(getContext());
                        loanAmountTextView.setText(loanAmount);
                        loanAmountTextView.setTextColor(Color.BLACK);
                        loanAmountTextView.setTextSize(10);
                        loanAmountTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
                        loanAmountTextView.setLayoutParams(new TableRow.LayoutParams(200, ViewGroup.LayoutParams.WRAP_CONTENT));
                        tableRow.addView(loanAmountTextView);

                        // Create and add the TextView for the status
                        TextView statusTextView = new TextView(getContext());
                        statusTextView.setText(status);
                        statusTextView.setTextColor(Color.BLACK);
                        statusTextView.setTextSize(10);
                        statusTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
                        statusTextView.setLayoutParams(new TableRow.LayoutParams(200, ViewGroup.LayoutParams.WRAP_CONTENT));
                        tableRow.addView(statusTextView);

                        // Create a new TextView for the "details" text
                        TextView detailsTextView = new TextView(getContext());
                        detailsTextView.setText("details");
                        detailsTextView.setTextColor(Color.BLACK);
                        detailsTextView.setTextSize(10);
                        detailsTextView.setTextAlignment(View.TEXT_ALIGNMENT_CENTER);
                        detailsTextView.setLayoutParams(new TableRow.LayoutParams(100, ViewGroup.LayoutParams.WRAP_CONTENT));
                        detailsTextView.setClickable(true);

                        // Set the click listener for the "details" text view
                        int finalRowIndex = tableLayout.getChildCount();
                        String employeeID = userSnapshot.child("EmployeeID").getValue(String.class);
                        String employeeName = userSnapshot.child("FirstName").getValue(String.class) + " " + userSnapshot.child("LastName").getValue(String.class);
                        String employeeLoanType = userSnapshot.child("CompLoanType").getValue(String.class);
                        String employeeDateHired = userSnapshot.child("DateHired").getValue(String.class);
                        Long employeeAmountLong = userSnapshot.child("CompLoanAmount").getValue(Long.class);
                        String employeeAmount = String.valueOf(employeeAmountLong);
                        Integer employeeMOSInt = userSnapshot.child("CompMonthsToPay").getValue(Integer.class);
                        String employeeMOS = String.valueOf(employeeMOSInt);



                        detailsTextView.setOnClickListener(v -> {
                            Intent intent = new Intent(getActivity(), LoanDetails.class);
                            intent.putExtra("rowIndex", finalRowIndex);
                            intent.putExtra("EmployeeID", employeeID);
                            intent.putExtra("FirstName", employeeName);
                            intent.putExtra("CompLoanType", employeeLoanType);
                            intent.putExtra("DateHired", employeeDateHired);
                            intent.putExtra("CompAmount", employeeAmount);
                            intent.putExtra("CompMonthsToPay", employeeMOS);

                            startActivity(intent);
                        });

                        // Add the "details" text view to the current table row
                        tableRow.addView(detailsTextView);

                        // Add the table row to the table layout
                        tableLayout.addView(tableRow);
                    }
                }
            }
            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
                // Handle any errors
            }
        });



        // BackBtn to home
        btnBack.setOnClickListener(v -> {
            NavHostFragment.findNavController(ToApproveFragment.this)
                    .navigate(R.id.nav_home_admin);

        });

        return view;
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
    }
}

