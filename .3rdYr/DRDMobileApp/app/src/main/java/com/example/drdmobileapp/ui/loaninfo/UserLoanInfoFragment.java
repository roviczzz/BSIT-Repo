package com.example.drdmobileapp.ui.loaninfo;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInDateHired;
import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInEmployeeID;
import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInName;

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
import com.example.drdmobileapp.ui.home.HomeFragment;
import com.example.drdmobileapp.ui.regular_loan.RegularLoanFragment;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;


public class UserLoanInfoFragment extends Fragment {
    private TextView TextViewName, TextViewID, TextViewDateHired;
    private Button btnBack, btnBack2;
    private View home;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_user_loan_info, container, false);
        btnBack = view.findViewById(R.id.btnback_noloan);
        btnBack2 = view.findViewById(R.id.btnback_hasloan);
        TextViewName = view.findViewById(R.id.info_name);
        TextViewID = view.findViewById(R.id.info_id);
        TextViewDateHired = view.findViewById(R.id.info_date);

        // Get the FirebaseDatabase reference
        FirebaseDatabase database = FirebaseDatabase.getInstance();
        DatabaseReference usersRef = database.getReference("Users");

        TextViewName.setText(getLoggedInName("firstName"));
        TextViewDateHired.setText(getLoggedInDateHired());
        TextViewID.setText(getLoggedInEmployeeID());

        btnBack.setOnClickListener(v -> {
            NavHostFragment.findNavController(UserLoanInfoFragment.this)
                    .navigate(R.id.nav_home);
        });

        btnBack2.setOnClickListener(v -> {
            NavHostFragment.findNavController(UserLoanInfoFragment.this)
                    .navigate(R.id.nav_home);
        });

        return view;
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
    }
}