package com.example.membershipregistration_rodriguez;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Login extends AppCompatActivity {
    public String receivedUser, receivedPassword, receivedFirstname, receivedLastname, receivedEmail, receivedBirthdate;
    EditText txtUsername, txtPassword;
    TextView txtError;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_login);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        // assignation
        txtUsername = findViewById(R.id.logged_txtUsername);
        txtPassword = findViewById(R.id.login_txtPassword);
        txtError =  findViewById(R.id.login_txtError);

        // Receive user & password data from registration
        Bundle bundle = getIntent().getExtras();
        receivedUser = bundle.getString("USERNAME");
        receivedPassword = bundle.getString("PASSWORD");
        receivedFirstname = bundle.getString("FIRSTNAME");
        receivedLastname = bundle.getString("LASTNAME");
        receivedEmail = bundle.getString("EMAIL");
        receivedBirthdate = bundle.getString("BIRTHDATE");



    }

    public void btnLoginOnClick(View view) {
        String username = txtUsername.getText().toString();
        String password = txtPassword.getText().toString();

        // Intent send user to logged activity
        Intent intent = new Intent(Login.this, LoginSuccess.class);
        Bundle bundle = new Bundle();

        bundle.putString("USERNAME", username);
        bundle.putString("FIRSTNAME", receivedFirstname);
        bundle.putString("LASTNAME", receivedLastname);
        bundle.putString("EMAIL", receivedEmail);
        bundle.putString("BIRTHDATE", receivedBirthdate);
        intent.putExtras(bundle);

        if (!username.equals(receivedUser) || !password.equals(receivedPassword)){
            // error
            txtError.setVisibility(View.VISIBLE);
        }
        else {
            // proceed
            startActivity(intent);

        }




    }
}