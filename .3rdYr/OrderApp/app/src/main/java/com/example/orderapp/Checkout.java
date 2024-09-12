package com.example.orderapp;

import android.content.Intent;
import android.graphics.RenderEffect;
import android.graphics.Shader;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class Checkout extends AppCompatActivity {
    ImageView imgBanner;
    Boolean boolM1, boolM2, boolM3, boolM4, boolM5, boolM6, boolM7;
    TextView txtMenu, txtPrice, txtTotalPrice;
    int totalM1, totalM2, totalM3, totalM4, totalM5, totalM6, totalM7, totalAll;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_checkout);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        imgBanner = findViewById(R.id.imageBanner2);
        imgBanner.setRenderEffect(RenderEffect.createBlurEffect(24.0f, 24.0f, Shader.TileMode.CLAMP));

        txtMenu = findViewById(R.id.txtMenuReceipt);
        txtPrice = findViewById(R.id.txtMenuPrice);

        Bundle bundle = getIntent().getExtras();
        boolM1 = bundle.getBoolean("M1");
        boolM2 = bundle.getBoolean("M2");
        boolM3 = bundle.getBoolean("M3");
        boolM4 = bundle.getBoolean("M4");
        boolM5 = bundle.getBoolean("M5");
        boolM6 = bundle.getBoolean("M6");
        boolM7 = bundle.getBoolean("M7");

        String qnt1 = bundle.getString("QntM1");
        String qnt2 = bundle.getString("QntM2");
        String qnt3 = bundle.getString("QntM3");
        String qnt4 = bundle.getString("QntM4");
        String qnt5 = bundle.getString("QntM5");
        String qnt6 = bundle.getString("QntM6");
        String qnt7 = bundle.getString("QntM7");


        if (boolM1){
            txtMenu.append("Original Boneless Chicken \n");
            totalM1 = Integer.parseInt(qnt1) * 215;
            txtPrice.append("Php " + totalM1 + "\n");
        }
        if (boolM2){
            txtMenu.append("Yangnyeom w/ Garlic \n");
            totalM2 = Integer.parseInt(qnt2) * 230;
            txtPrice.append("Php " + totalM2 + "\n");
        }
        if (boolM3){
            txtMenu.append("Snow Cheese \n");
            totalM3 = Integer.parseInt(qnt3) * 230;
            txtPrice.append("Php " + totalM3 + "\n");
        }
        if (boolM4){
            txtMenu.append("24 Cheddar \n");
            totalM4 = Integer.parseInt(qnt4) * 230;
            txtPrice.append("Php " + totalM4 + "\n");
        }
        if (boolM5){
            txtMenu.append("Garlic \n");
            totalM5 = Integer.parseInt(qnt5) * 230;
            txtPrice.append("Php " + totalM5 + "\n");
        }
        if (boolM6){
            txtMenu.append("Jack Danniels \n");
            totalM6 = Integer.parseInt(qnt6) * 220;
            txtPrice.append("Php " + totalM6 + "\n");
        }
        if (boolM7){
            txtMenu.append("Yangnyeom \n");
            totalM7 = Integer.parseInt(qnt7) * 220;
            txtPrice.append("Php " + totalM7 + "\n");
        }

        totalAll = totalM1 + totalM2 + totalM3 + totalM4 + totalM5 + totalM6 + totalM7 + 40;
        txtTotalPrice = findViewById(R.id.txtMenuTotal);
        txtTotalPrice.append("" + totalAll);


    }

    public void btnConfirmOnClick(View view) {
        Intent sender = new Intent(this, OrderSuccess.class);
        startActivity(sender);
    }
}