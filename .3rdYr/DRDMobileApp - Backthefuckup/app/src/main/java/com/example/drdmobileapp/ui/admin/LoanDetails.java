package com.example.drdmobileapp.ui.admin;

import android.os.Bundle;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.drdmobileapp.R;

public class LoanDetails extends AppCompatActivity {
    TextView txtView, txtView1, txtView2, txtView3, txtView4, txtView5;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_loan_details);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);

            txtView = findViewById(R.id.employee_name);
            txtView1 = findViewById(R.id.employeeID);
            txtView2 = findViewById(R.id.employee_loantype);
            txtView3 = findViewById(R.id.employee_datehired);
            txtView4 = findViewById(R.id.employee_amount);
            txtView5 = findViewById(R.id.employee_mos);

            Bundle extras = getIntent().getExtras();
            String value1 = extras.getString("EmployeeID");
            String value2 = extras.getString("FirstName");
            String value3 = extras.getString("CompLoanType");
            String value4 = extras.getString("DateHired");
            String value5 = extras.getString("CompAmount");
            String value6 = extras.getString("CompMonthsToPay");

            txtView.setText(value2);
            txtView1.setText(value1);
            txtView2.setText(value3);
            txtView3.setText(value4);
            txtView4.setText(value5);
            txtView5.setText(value6);





            return insets;
        });
    }
}