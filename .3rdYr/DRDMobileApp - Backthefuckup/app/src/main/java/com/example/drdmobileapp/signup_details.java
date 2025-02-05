package com.example.drdmobileapp;

import static com.example.drdmobileapp.signup.getRegisteredEmployeeID;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.example.drdmobileapp.ui.login.LoginActivity;

import java.util.Objects;

public class signup_details extends AppCompatActivity {

    private TextView empID;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_signup_details);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            Objects.requireNonNull(getSupportActionBar()).setTitle("");

            Window window = this.getWindow();
            window.clearFlags(WindowManager.LayoutParams.FLAG_TRANSLUCENT_STATUS);
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this,R.color.primary_blue)); // here is your color


            empID = findViewById(R.id.empID);
            empID.setText(getRegisteredEmployeeID());

            return insets;
        });
    }

    public void onClickSignIn(View view) {
        Intent in = new Intent(this, LoginActivity.class);
        startActivity(in);
        finish();
    }
}