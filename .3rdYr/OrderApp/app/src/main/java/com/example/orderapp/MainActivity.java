package com.example.orderapp;

import android.content.Intent;
import android.graphics.RenderEffect;
import android.graphics.Shader;
import android.os.Build;
import android.os.Bundle;
import android.text.InputFilter;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
ImageView imgBanner;
CheckBox checkM1, checkM2, checkM3, checkM4, checkM5, checkM6, checkM7;
EditText qtyM1, qtyM2, qtyM3, qtyM4, qtyM5, qtyM6, qtyM7;
Boolean boolM1 = false, boolM2 = false, boolM3 = false, boolM4 = false, boolM5 = false, boolM6 = false, boolM7 = false;

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

        imgBanner = findViewById(R.id.imageBanner);
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.S) {
            imgBanner.setRenderEffect(RenderEffect.createBlurEffect(24.0f, 24.0f, Shader.TileMode.CLAMP));
        }

        checkM1 = findViewById(R.id.chkM1);
        checkM2 = findViewById(R.id.chkM2);
        checkM3 = findViewById(R.id.chkM3);
        checkM4 = findViewById(R.id.chkM4);
        checkM5 = findViewById(R.id.chkM5);
        checkM6 = findViewById(R.id.chkM6);
        checkM7 = findViewById(R.id.chkM7);

        qtyM1 = findViewById(R.id.txtQtyM1);
        qtyM2 = findViewById(R.id.txtQtyM2);
        qtyM3 = findViewById(R.id.txtQtyM3);
        qtyM4 = findViewById(R.id.txtQtyM4);
        qtyM5 = findViewById(R.id.txtQtyM5);
        qtyM6 = findViewById(R.id.txtQtyM6);
        qtyM7 = findViewById(R.id.txtQtyM7);


    }

    public void btnProceedOnClick(View view) {
        if(checkM1.isChecked())
            boolM1 = true;
        if(checkM2.isChecked())
            boolM2 = true;
        if(checkM3.isChecked())
            boolM3 = true;
        if(checkM4.isChecked())
            boolM4 = true;
        if(checkM5.isChecked())
            boolM5 = true;
        if(checkM6.isChecked())
            boolM6 = true;
        if(checkM7.isChecked())
            boolM7 = true;



        // sender intent
        Intent sender = new Intent(this, Checkout.class);
        Bundle bundle = new Bundle();

        bundle.putString("QntM1", qtyM1.getText().toString());
        bundle.putString("QntM2", qtyM2.getText().toString());
        bundle.putString("QntM3", qtyM3.getText().toString());
        bundle.putString("QntM4", qtyM4.getText().toString());
        bundle.putString("QntM5", qtyM5.getText().toString());
        bundle.putString("QntM6", qtyM6.getText().toString());
        bundle.putString("QntM7", qtyM7.getText().toString());
        bundle.putBoolean("M1", boolM1);
        bundle.putBoolean("M2", boolM2);
        bundle.putBoolean("M3", boolM3);
        bundle.putBoolean("M4", boolM4);
        bundle.putBoolean("M5", boolM5);
        bundle.putBoolean("M6", boolM6);
        bundle.putBoolean("M7", boolM7);
        sender.putExtras(bundle);

        if (!TextUtils.isEmpty(qtyM1.getText().toString()) || !TextUtils.isEmpty(qtyM2.getText().toString()) || !TextUtils.isEmpty(qtyM3.getText().toString()) || !TextUtils.isEmpty(qtyM4.getText().toString()) || !TextUtils.isEmpty(qtyM5.getText().toString()) || !TextUtils.isEmpty(qtyM6.getText().toString()) || !TextUtils.isEmpty(qtyM7.getText().toString())){
            // proceed
            startActivity(sender);
            finish();
        }
        else{
            Toast.makeText(this, "Select at least one menu!",
                    Toast.LENGTH_LONG).show();
        }

    }

    public void chkM1OnClick(View view) {
        qtyM1.setEnabled(checkM1.isChecked());
        qtyM1.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM1.setText("1");
    }

    public void chkM2OnClick(View view) {
        qtyM2.setEnabled(checkM2.isChecked());
        qtyM2.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM2.setText("1");
    }

    public void chkM3OnClick(View view) {
        qtyM3.setEnabled(checkM3.isChecked());
        qtyM3.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM3.setText("1");
    }

    public void chkM4OnClick(View view) {
        qtyM4.setEnabled(checkM4.isChecked());
        qtyM4.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM4.setText("1");
    }

    public void chkM5OnClick(View view) {
        qtyM5.setEnabled(checkM5.isChecked());
        qtyM5.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM5.setText("1");
    }

    public void chkM6OnClick(View view) {
        qtyM6.setEnabled(checkM6.isChecked());
        qtyM6.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM6.setText("1");
    }

    public void chkM7OnClick(View view) {
        qtyM7.setEnabled(checkM7.isChecked());
        qtyM7.setFilters(new InputFilter[]{new InputFilterMinMax(0, 6)});
        qtyM7.setText("1");
    }
}