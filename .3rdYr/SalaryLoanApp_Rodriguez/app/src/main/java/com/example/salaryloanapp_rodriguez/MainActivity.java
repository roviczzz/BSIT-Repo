package com.example.salaryloanapp_rodriguez;

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

public class MainActivity extends AppCompatActivity {
    TextView txtregister;
    EditText email, password;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        email = (EditText) findViewById(R.id.editLoginEmail);
        password = (EditText) findViewById(R.id.editLoginPass);
        txtregister = findViewById(R.id.textCreateAcc);
    }

    public void registerOnClick(View view) {
        Intent sendToRegister = new Intent(this, Registration.class);
        startActivity(sendToRegister);
    }

    public void loginOnClick(View view) {
        boolean hasError = errorTrapping();
        if (hasError) return;

        Computations computations = Computations.getInstance();
        int loginOutput = computations.login(email.getText().toString(), password.getText().toString());

        switch (loginOutput) {
            case 0:
                Intent loginIntent = new Intent(MainActivity.this, Calculator.class);
                loginIntent.addFlags(Intent.FLAG_ACTIVITY_REORDER_TO_FRONT);
                loginIntent.putExtra("email", email.getText().toString());

                startActivity(loginIntent);
                finish();
                break;
            case 1:
                email.setError("Email does not exist");
                break;
            case 2:
                email.setError("Incorrect Password");
                break;
        }
    }

    private boolean errorTrapping() {
        boolean hasError = false;

        if (email.getText().toString().isEmpty()) {
            email.setError("Email is required!");
            hasError = true;
        }

        if (password.getText().toString().isEmpty()) {
            password.setError("Password is required!");
            hasError = true;
        }

        return hasError;
    }
}