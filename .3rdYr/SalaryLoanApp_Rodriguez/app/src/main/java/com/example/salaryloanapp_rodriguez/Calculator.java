package com.example.salaryloanapp_rodriguez;

import android.content.Intent;
import android.os.Bundle;
import android.text.InputFilter;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.text.DecimalFormat;
import java.util.Locale;

public class Calculator extends AppCompatActivity {
    TextView name, basicSalary, loanableAmt, interest, interestRate, takeHomeLoan, serviceCharge, monthlyAmort;
    EditText editloanAmt, editMonthsPay;
    private int userIndex;
    private double maximumLoanableAmount;
    DecimalFormat df = new DecimalFormat("#,###.####");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_calculator);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        name = (TextView) findViewById(R.id.textName);
        basicSalary = (TextView) findViewById(R.id.textBasicSalary);
        loanableAmt = (TextView) findViewById(R.id.textLoanableAmt);
        interestRate = (TextView) findViewById(R.id.textInterestRate);
        interest = (TextView) findViewById(R.id.textInterest);
        serviceCharge = (TextView) findViewById(R.id.textServiceCharge);
        takeHomeLoan = (TextView) findViewById(R.id.textTakeHomeLoan);
        monthlyAmort = (TextView) findViewById(R.id.textMonthlyAmort);

        editloanAmt = (EditText) findViewById(R.id.editLoanAmt);
        editMonthsPay = (EditText) findViewById(R.id.editMonthsPay);


        Computations computations = Computations.getInstance();
        String email = getIntent().getStringExtra("email");
        userIndex = computations.getUserIndexByEmail(email);
        maximumLoanableAmount = computations.getLoanAmount(userIndex);

        name.setText(computations.getFullName(userIndex));

        basicSalary.setText(String.format("Php %s", df.format(computations.getBasicMonthlySalary(userIndex))));
        loanableAmt.setText(String.format("Php %s", df.format(maximumLoanableAmount)));
        interestRate.setText(String.format(Locale.US, "%.2f%%", computations.getInterestRate(userIndex) * 100));
        interest.setText(String.format("Php %s", df.format(computations.getInterest(userIndex))));
        serviceCharge.setText(String.format("Php %s", df.format(computations.getServiceCharge(userIndex))));
        takeHomeLoan.setText(String.format("Php %s", df.format(computations.getTakeHomeLoan(userIndex))));
        monthlyAmort.setText(String.format("Php %s", df.format(computations.getMonthlyAmortization(userIndex))));
    }

    public void calculateOnClick(View view) {
        boolean hasError = errorTrapping();
        if (hasError) return;

        Computations computations = Computations.getInstance();
        computations.activityComputation(userIndex, Double.parseDouble(editloanAmt.getText().toString()), Integer.parseInt(editMonthsPay.getText().toString()));

        interestRate.setText(String.format(Locale.US, "%.2f%%", computations.getInterestRate(userIndex) * 100));
        interest.setText(String.format("Php %s", df.format(computations.getInterest(userIndex))));
        serviceCharge.setText(String.format("Php %s", df.format(computations.getServiceCharge(userIndex))));
        takeHomeLoan.setText(String.format("Php %s", df.format(computations.getTakeHomeLoan(userIndex))));
        monthlyAmort.setText(String.format("Php %s", df.format(computations.getMonthlyAmortization(userIndex))));

    }
    private boolean errorTrapping() {
        boolean hasError = false;

        if (editMonthsPay.getText().toString().isEmpty()) {
            editMonthsPay.setError("Invalid number of months");
            hasError = true;
        }

        else if (Integer.parseInt(editMonthsPay.getText().toString()) > 25) {
            editMonthsPay.setError("Number of months exceeds more than 25!");
            hasError = true;
        }

        if (editloanAmt.getText().toString().isEmpty()) {
            editloanAmt.setError("Loan amount required!");
            hasError = true;
        }
        else if(Double.parseDouble(editloanAmt.getText().toString()) > maximumLoanableAmount){
            editloanAmt.setError("Loan amount exceeds limit!");
            hasError = true;
        }

        return hasError;
    }

    public void signOutOnClick(View view) {
        Intent sendToLogin = new Intent(this, MainActivity.class);
        startActivity(sendToLogin);
        finish();
    }
}