package com.example.salaryloanapp_rodriguez;

import android.content.Intent;
import android.os.Bundle;
import android.util.Patterns;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Registration extends AppCompatActivity {
    EditText firstName, lastName, basicMonthlySalary, emailAddress, password, confirmPassword;
    TextView txtlogin;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_registration);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        firstName = (EditText) findViewById(R.id.editFname);
        lastName = (EditText) findViewById(R.id.editLname);
        basicMonthlySalary = (EditText) findViewById(R.id.editBasicMonthlySalary);
        emailAddress = (EditText) findViewById(R.id.editRegEmail);
        password = (EditText) findViewById(R.id.editRegPass);
        confirmPassword = (EditText) findViewById(R.id.editRegPassConf);
        txtlogin = findViewById(R.id.textLogin);

    }

    public void loginOnClick(View view) {
        Intent sendToLogin = new Intent(this, MainActivity.class);
        startActivity(sendToLogin);
    }

    public void signUpOnClick(View view) {
        if (errorTrapping()) return;

        Computations computations = Computations.getInstance();

        computations.addRegistration(firstName.getText().toString(), lastName.getText().toString(),
                Double.parseDouble(basicMonthlySalary.getText().toString()), emailAddress.getText().toString(),
                password.getText().toString());

        Toast.makeText(getApplicationContext(), "Registration Successful!", Toast.LENGTH_LONG).show();

        Intent returnLoginIntent = new Intent(this, MainActivity.class);
        startActivity(returnLoginIntent);
        finish();
    }

    private boolean errorTrapping() {
        boolean hasError = false;

        if (firstName.getText().toString().isEmpty()) {
            firstName.setError("First name is required!");
            hasError = true;
        } else if (!isLettersOnly(firstName.getText().toString())) {
            firstName.setError("can only be letters!");
            hasError = true;
        }

        if (lastName.getText().toString().isEmpty()) {
            lastName.setError("Last name is required!");
            hasError = true;
        } else if (!isLettersOnly(lastName.getText().toString())) {
            lastName.setError("can only be letters!");
            hasError = true;
        }

        if (basicMonthlySalary.getText().toString().isEmpty()) {
            basicMonthlySalary.setError("Missing Basic Monthly input!");
            hasError = true;
        }

        if (emailAddress.getText().toString().isEmpty()) {
            emailAddress.setError("Missing Email input!");
            hasError = true;
        } else if (!Patterns.EMAIL_ADDRESS.matcher(emailAddress.getText().toString()).matches()) {
            emailAddress.setError("Invalid Email!");
            hasError = true;
        } else if (Computations.getInstance().emailExists(emailAddress.getText().toString())) {
            emailAddress.setError("Email already exists!");
            hasError = true;
        }

        if (password.getText().toString().isEmpty()) {
            password.setError("Missing password input!");
            hasError = true;
        } else if (password.length() < 8) {
            password.setError("Password must be 8 characters long!");
            hasError = true;
        }

        if (confirmPassword.getText().toString().isEmpty()) {
            confirmPassword.setError("Missing confirm password input!");
            hasError = true;
        } else if (!password.getText().toString().equals(confirmPassword.getText().toString())) {
            if (password.length() >= 8) {
                confirmPassword.setError("Passwords do not match!");
            }
            hasError = true;
        }

        return hasError;
    }

    private boolean isLettersOnly(String input) {
        for (char c : input.toCharArray()) {
            if (!Character.isLetter(c) && !Character.isWhitespace(c))  {
                return false;
            }
        }
        return true;
    }
}