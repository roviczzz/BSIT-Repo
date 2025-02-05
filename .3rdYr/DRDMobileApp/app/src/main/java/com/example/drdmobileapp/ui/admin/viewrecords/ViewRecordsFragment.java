package com.example.drdmobileapp.ui.admin.viewrecords;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInEmployeeID;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import androidx.navigation.fragment.NavHostFragment;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.ui.admin.home.AdminHomeFragment;
import com.example.drdmobileapp.ui.login.LoginActivity;
import com.example.drdmobileapp.ui.regular_loan.RegularLoanFragment;
import com.example.drdmobileapp.ui.special_loan.SpecialLoanFragment;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class ViewRecordsFragment extends Fragment {
    private TextView TextViewName, TextViewID, TextViewDateHired;
    private ImageButton btnBack;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        String employeeID = getLoggedInEmployeeID();
        Log.d("ViewRecordsFragment", "Logged-in EmployeeID: " + employeeID);

        if (employeeID == null) {
            // If null, start the LoginActivity
            Intent intent = new Intent(getActivity(), LoginActivity.class);
            startActivity(intent);
            // Finish the current activity to prevent going back to HomeFragment
            requireActivity().finish();
            return null;
        }

        View view = inflater.inflate(R.layout.fragment_viewrecords_admin, container, false);
        btnBack = view.findViewById(R.id.btnBack_admin1);


        // BackBtn to home
        btnBack.setOnClickListener(v -> {
            NavHostFragment.findNavController(ViewRecordsFragment.this)
                    .navigate(R.id.nav_home_admin);
        });

        return view;
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
    }
}

