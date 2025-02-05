package com.example.drdmobileapp.ui.admin.home;

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
import androidx.fragment.app.FragmentTransaction;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.ui.admin.toapprove.ToApproveFragment;
import com.example.drdmobileapp.ui.admin.viewrecords.ViewRecordsFragment;
import com.example.drdmobileapp.ui.loaninfo.UserLoanInfoFragment;
import com.example.drdmobileapp.ui.login.LoginActivity;
import com.example.drdmobileapp.ui.regular_loan.RegularLoanFragment;
import com.example.drdmobileapp.ui.special_loan.SpecialLoanFragment;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class AdminHomeFragment extends Fragment {
    private TextView TextViewPendingNo, TextViewRecordsNo;
    private Button btnPending, btnRecords;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        String employeeID = getLoggedInEmployeeID();
        Log.d("AdminHomeFragment", "Logged-in EmployeeID: " + employeeID);

        if (employeeID == null) {
            // If null, start the LoginActivity
            Intent intent = new Intent(getActivity(), LoginActivity.class);
            startActivity(intent);
            // Finish the current activity to prevent going back to HomeFragment
            requireActivity().finish();
            return null;
        }

        View view = inflater.inflate(R.layout.fragment_home_admin, container, false);
        btnPending = view.findViewById(R.id.button);
        btnRecords = view.findViewById(R.id.button2);
        TextViewPendingNo = view.findViewById(R.id.NopendingLoans);
        TextViewRecordsNo = view.findViewById(R.id.NoViewLoans);


        // Pending loans button
        btnPending.setOnClickListener(v -> {
            NavHostFragment.findNavController(AdminHomeFragment.this)
                    .navigate(R.id.nav_loan_records);
        });


        // View Records button
        btnRecords.setOnClickListener(v -> {
            NavHostFragment.findNavController(AdminHomeFragment.this)
                    .navigate(R.id.nav_loan_status);
        });
        // get pending and records No.

        return view;
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
    }
}

