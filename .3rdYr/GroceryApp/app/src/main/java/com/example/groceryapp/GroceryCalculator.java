package com.example.groceryapp;

import static android.app.ProgressDialog.show;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class GroceryCalculator extends AppCompatActivity {
    EditText editItem, editPrice, editQty;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_grocery_calculator);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        editItem = findViewById(R.id.editItemName);
        editPrice = findViewById(R.id.editPrice);
        editQty = findViewById(R.id.editQuantity);

    }

    private boolean validateInputs(){
        boolean valid = true;
        if (editItem.getText().toString().isEmpty()){
            editItem.setError("Item name cannot be empty");
            valid = false;
        }

        String priceText = editPrice.getText().toString();
        if (priceText.isEmpty()){
            editPrice.setError("Price cannot be empty");
            valid = false;
        } else{
            double price = Double.parseDouble(priceText);
                if (price <= 0) {
                    editPrice.setError("Price must be greater than zero");
                    valid = false;
                }
        }

        String quantityText = editQty.getText().toString();
        if (quantityText.isEmpty()){
            editQty.setError("Quantity cannot be empty");
            valid = false;
        }else{
            int quantity = Integer.parseInt(quantityText);
            if (quantity <= 0){
                editQty.setError("Quantity must be greater than zero");
                valid = false;
            }
        }
        return valid;
    }



    public void addOnClick(View view) {
        if (!validateInputs()) {return; }

        String item = editItem.getText().toString().toUpperCase();
        double price = Double.parseDouble(editPrice.getText().toString());
        int quantity = Integer.parseInt(editQty.getText().toString());

        Computations computations = Computations.getInstance();

        if (computations.isAlreadyAdded(item)){
            computations.addItem(item, price, quantity);
            Toast.makeText(getApplicationContext(), String.format("Item: %s has been updated!", item), Toast.LENGTH_LONG).show();
        } else{
            computations.addItem(item, price, quantity);
            Toast.makeText(getApplicationContext(), "Adding Successful!", Toast.LENGTH_LONG).show();
        }
        editItem.setText("");
        editPrice.setText("");
        editQty.setText("");

    }

    public void computeOnClick(View view) {
        Computations computations = Computations.getInstance();
        if(computations.isItemListEmpty()){
            Toast.makeText(getApplicationContext(), "Please add items first!", Toast.LENGTH_SHORT).show();
            return;
        }

        computations.createReceipt();
        Intent receiptIntent = new Intent(this, Receipt.class);
        startActivity(receiptIntent);
        finish();

    }

    public void clearOnClick(View view) {
        Computations computations = Computations.getInstance();
        if(computations.isItemListEmpty()){
            Toast.makeText(getApplicationContext(), "Item list is already empty!", Toast.LENGTH_SHORT).show();
            return;
        }
        computations.clearItems();
        Toast.makeText(getApplicationContext(), "Items Cleared", Toast.LENGTH_SHORT).show();
    }
}