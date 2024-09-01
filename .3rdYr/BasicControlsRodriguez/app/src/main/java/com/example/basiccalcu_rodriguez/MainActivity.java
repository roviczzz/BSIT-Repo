package com.example.basiccalcu_rodriguez;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    TextView userField;

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

        userField = (TextView) findViewById(R.id.userInput);
    }

    public void btnOnClick0(View view) {
        userField.setText(String.valueOf(userField.getText() + "0"));
    }

    public void btnOnClick1(View view) {
        userField.setText(String.valueOf(userField.getText() + "1"));
    }

    public void btnOnClick2(View view) {
        userField.setText(String.valueOf(userField.getText() + "2"));
    }

    public void btnOnClick3(View view) {
        userField.setText(String.valueOf(userField.getText() + "3"));
    }

    public void btnOnClick4(View view) {
        userField.setText(String.valueOf(userField.getText() + "4"));
    }

    public void btnOnClick5(View view) {
        userField.setText(String.valueOf(userField.getText() + "5"));
    }

    public void btnOnClick6(View view) {
        userField.setText(String.valueOf(userField.getText() + "6"));
    }

    public void btnOnClick7(View view) {
        userField.setText(String.valueOf(userField.getText() + "7"));
    }

    public void btnOnClick8(View view) {
        userField.setText(String.valueOf(userField.getText() + "8"));
    }

    public void btnOnClick9(View view) {
        userField.setText(String.valueOf(userField.getText() + "9"));
    }

    public void btnOnClickDiv(View view) {
        userField.setText(String.valueOf(userField.getText() + "/"));

    }

    public void btnOnClickMult(View view) {
        userField.setText(String.valueOf(userField.getText() + "*"));

    }

    public void btnOnClickPlus(View view) {
        userField.setText(String.valueOf(userField.getText() + "+"));

    }

    public void btnOnClickMin(View view) {
        userField.setText(String.valueOf(userField.getText() + "-"));

    }
}