package com.example.bmicalcu_rodriguez;

import android.content.Context;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.view.WindowManager;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
TextView Output;
EditText Weight, Height;
String receivedHeight, receivedWeight;
ConstraintLayout mainLayout;

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

        Weight = findViewById(R.id.txtfieldWeight);
        Height = findViewById(R.id.txtfieldHeight);
        Output = findViewById(R.id.txtResult);




    }

    public void btnCalculateOnClick(View view) {
        if (TextUtils.isEmpty(Weight.getText())){
            Weight.setError("Missing Weight Input!");
        }

        if(TextUtils.isEmpty(Height.getText())){
            Height.setError("Missing Height Input!");
        }

        else{
            receivedWeight = String.valueOf(Weight.getText());
            receivedHeight = String.valueOf(Height.getText());

            float intWeight = Integer.parseInt(receivedWeight), intHeight = Integer.parseInt(receivedHeight), BMI;
            BMI = (intWeight * 703) / (intHeight * intHeight);

            if (BMI < 18.5){
                Output.setText("Total BMI: " + BMI + "\n" + "Weight Status:  Underweight");
            }
            if (BMI >= 18.5  && BMI <= 24.9){
                Output.setText("Total BMI: " + BMI + "\n" + "Weight Status:  Normal");
            }
            if (BMI >= 25 && BMI <= 29.9){
                Output.setText("Total BMI: " + BMI + "\n" + "Weight Status:  Overweight");
            }
            if (BMI >= 30){
                Output.setText("Total BMI: " + BMI + "\n" + "Weight Status:  Obese");
            }


        }


    }
}