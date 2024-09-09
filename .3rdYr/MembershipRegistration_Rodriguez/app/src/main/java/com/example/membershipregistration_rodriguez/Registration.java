package com.example.membershipregistration_rodriguez;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.EditText;
import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Registration extends AppCompatActivity {
EditText txtUsername, txtPassword, txtFirstname, txtLastname, txtEmail, txtBirthdate;


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

        txtUsername = findViewById(R.id.regis_txtUsername);
        txtPassword = findViewById(R.id.regis_txtPassword);
        txtFirstname = findViewById(R.id.regis_txtFirstname);
        txtLastname = findViewById(R.id.regis_txtLastname);
        txtEmail = findViewById(R.id.regis_txtEmail);
        txtBirthdate = findViewById(R.id.regis_txtBirthdate);

    }

    public void btnRegisterOnClick(View view) {
        //Intent send user & password to login
        Intent sender = new Intent(Registration.this, Login.class);
        Bundle bundle = new Bundle();

        bundle.putString("USERNAME", txtUsername.getText().toString());
        bundle.putString("PASSWORD", txtPassword.getText().toString());
        bundle.putString("FIRSTNAME", txtFirstname.getText().toString());
        bundle.putString("LASTNAME", txtLastname.getText().toString());
        bundle.putString("EMAIL", txtEmail.getText().toString());
        bundle.putString("BIRTHDATE", txtBirthdate.getText().toString());
        sender.putExtras(bundle);


        if (!TextUtils.isEmpty(txtUsername.getText()) && !TextUtils.isEmpty(txtPassword.getText()) && !TextUtils.isEmpty(txtFirstname.getText()) && !TextUtils.isEmpty(txtLastname.getText()) && !TextUtils.isEmpty(txtEmail.getText()) && !TextUtils.isEmpty(txtBirthdate.getText())){
            // proceed
            startActivity(sender);
            finish();
        }
        else{
            txtUsername.setError("User name is required!");
            txtPassword.setError("Password is required!");
            txtFirstname.setError("First name is required!");
            txtLastname.setError("Last name is required!");
            txtEmail.setError("Email is required!");
            txtBirthdate.setError("Birthdate is required!");
        }


    }

}