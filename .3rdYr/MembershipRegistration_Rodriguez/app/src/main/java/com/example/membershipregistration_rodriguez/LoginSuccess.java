package com.example.membershipregistration_rodriguez;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class LoginSuccess extends AppCompatActivity {
    public String receivedUser, receivedFirstname, receivedLastname, receivedEmail, receivedBirthdate;
    TextView txtUsername, txtFirstname, txtLastname, txtEmail, txtBirthdate;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_login_success);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        txtUsername = findViewById(R.id.logged_txtUsername);
        txtFirstname = findViewById(R.id.logged_txtFirstname);
        txtLastname = findViewById(R.id.logged_txtLastname);
        txtEmail = findViewById(R.id.logged_txtEmail);
        txtBirthdate = findViewById(R.id.logged_txtBirthdate);

        Bundle bundle = getIntent().getExtras();
        receivedUser = bundle.getString("USERNAME");
        receivedFirstname = bundle.getString("FIRSTNAME");
        receivedLastname = bundle.getString("LASTNAME");
        receivedEmail = bundle.getString("EMAIL");
        receivedBirthdate = bundle.getString("BIRTHDATE");

        txtUsername.setText(receivedUser);
        txtFirstname.setText(receivedFirstname);
        txtLastname.setText(receivedLastname);
        txtEmail.setText(receivedEmail);
        txtBirthdate.setText(receivedBirthdate);


    }

    public void btnLogoutOnClick(View view) {
        Intent intent = new Intent(this, Registration.class);
        startActivity(intent);
    }
}