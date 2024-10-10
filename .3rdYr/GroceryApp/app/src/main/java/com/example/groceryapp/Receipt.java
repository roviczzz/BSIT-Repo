package com.example.groceryapp;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.text.DecimalFormat;

public class Receipt extends AppCompatActivity {
    TextView itemNames, itemPrices, itemQuantities, itemAmounts, total;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_receipt);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        Computations computations = Computations.getInstance();
        itemNames = (TextView) findViewById(R.id.textItems);
        itemPrices = (TextView) findViewById(R.id.textPrice);
        itemQuantities = (TextView) findViewById(R.id.textQuantity);
        itemAmounts = (TextView) findViewById(R.id.textAmount);
        total = (TextView) findViewById(R.id.textTotalPrice);

        DecimalFormat decimal = new DecimalFormat("0.00");
        itemNames.setText(computations.getNameReceipt());
        itemPrices.setText(computations.getPriceReceipt());
        itemQuantities.setText(computations.getQuantityReceipt());
        itemAmounts.setText(computations.getAmountsReceipt());
        total.setText(String.format("Php %s", decimal.format(computations.getTotal())));

    }

    public void newComputeOnClick(View view) {
        Intent returnIntent = new Intent(this, GroceryCalculator.class);
        startActivity(returnIntent);
        finish();
    }
}