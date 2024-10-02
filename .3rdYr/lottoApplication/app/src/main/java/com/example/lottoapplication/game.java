package com.example.lottoapplication;

import android.os.Bundle;
import android.text.InputFilter;
import android.text.TextUtils;
import android.util.Log;
import android.view.Gravity;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;

public class game extends AppCompatActivity {
    EditText editDigit1, editDigit2, editDigit3, editDigit4, editDigit5, editDigit6;
    TextView result1, result2, result3, result4, result5, result6, message, entry;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_game);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        editDigit1 = findViewById(R.id.editDigit1);
        editDigit2 = findViewById(R.id.editDigit2);
        editDigit3 = findViewById(R.id.editDigit3);
        editDigit4 = findViewById(R.id.editDigit4);
        editDigit5 = findViewById(R.id.editDigit5);
        editDigit6 = findViewById(R.id.editDigit6);

        editDigit1.setFilters(new InputFilter[]{new InputFilterMinMax(1, 42)});
        editDigit2.setFilters(new InputFilter[]{new InputFilterMinMax(1, 42)});
        editDigit3.setFilters(new InputFilter[]{new InputFilterMinMax(1, 42)});
        editDigit4.setFilters(new InputFilter[]{new InputFilterMinMax(1, 42)});
        editDigit5.setFilters(new InputFilter[]{new InputFilterMinMax(1, 42)});
        editDigit6.setFilters(new InputFilter[]{new InputFilterMinMax(1, 42)});

        editDigit1.setGravity(Gravity.CENTER_HORIZONTAL);
        editDigit2.setGravity(Gravity.CENTER_HORIZONTAL);
        editDigit3.setGravity(Gravity.CENTER_HORIZONTAL);
        editDigit4.setGravity(Gravity.CENTER_HORIZONTAL);
        editDigit5.setGravity(Gravity.CENTER_HORIZONTAL);
        editDigit6.setGravity(Gravity.CENTER_HORIZONTAL);

        result1 = findViewById(R.id.textResult1);
        result2 = findViewById(R.id.textResult2);
        result3 = findViewById(R.id.textResult3);
        result4 = findViewById(R.id.textResult4);
        result5 = findViewById(R.id.textResult5);
        result6 = findViewById(R.id.textResult6);

        result1.setGravity(Gravity.CENTER_HORIZONTAL);
        result2.setGravity(Gravity.CENTER_HORIZONTAL);
        result3.setGravity(Gravity.CENTER_HORIZONTAL);
        result4.setGravity(Gravity.CENTER_HORIZONTAL);
        result5.setGravity(Gravity.CENTER_HORIZONTAL);
        result6.setGravity(Gravity.CENTER_HORIZONTAL);

        message = findViewById(R.id.textMessage);
        entry = findViewById(R.id.textEntry);

    }

    public void submitOnClick(View view) {
        String digit1 = editDigit1.getText().toString();
        String digit2 = editDigit2.getText().toString();
        String digit3 = editDigit3.getText().toString();
        String digit4 = editDigit4.getText().toString();
        String digit5 = editDigit5.getText().toString();
        String digit6 = editDigit6.getText().toString();

        Log.d("PlayActivity", "Submit button clicked");
        if (TextUtils.isEmpty(digit1) || TextUtils.isEmpty(digit2) || TextUtils.isEmpty(digit3) || TextUtils.isEmpty(digit4) || TextUtils.isEmpty(digit5) || TextUtils.isEmpty(digit6)) {
            Toast.makeText(this, "Please select 6 numbers", Toast.LENGTH_SHORT).show();
        }
        else if (hasDuplicateDigits(digit1, digit2, digit3, digit4, digit5, digit6)) {
            Toast.makeText(this, "Invalid entry, try removing duplicate digits", Toast.LENGTH_SHORT).show();
        }
        else {
            ArrayList<Integer> selectedNumbers = new ArrayList<>();
            selectedNumbers.add(Integer.parseInt(digit1));
            selectedNumbers.add(Integer.parseInt(digit2));
            selectedNumbers.add(Integer.parseInt(digit3));
            selectedNumbers.add(Integer.parseInt(digit4));
            selectedNumbers.add(Integer.parseInt(digit5));
            selectedNumbers.add(Integer.parseInt(digit6));

            HashSet<Integer> winningNumbers = LottoUtils.generateWinningNumbers(6, 42);

            displaySelectedNumbers(selectedNumbers);
            displayWinningNumbers(winningNumbers);
            checkMatches(selectedNumbers, winningNumbers);

        }
    }

        public boolean hasDuplicateDigits(String digit1, String digit2, String digit3, String digit4, String digit5, String digit6) {
        // Create a HashSet to track seen numbers (as strings)
        Set<String> seenDigits  = new HashSet<>();

        // Create an array of the digit strings
        String[] digits = {digit1, digit2, digit3, digit4, digit5, digit6};

        // Loop through the array and check for duplicates
        for (String digit : digits) {
            // If the number is already in the set, we have a duplicate
            if (seenDigits .contains(digit)) {
                return true; // Duplicate found
            }

            // Otherwise, add the number to the set
            seenDigits.add(digit);
        }

        // No duplicates found
        return false;
    }

    private void displaySelectedNumbers(ArrayList<Integer> selectedNumbers) {
        entry.setText(String.valueOf(selectedNumbers.get(0) + " " + selectedNumbers.get(1) + " " +
                selectedNumbers.get(2) + " " + selectedNumbers.get(3) + " " + selectedNumbers.get(4) + " "
                + selectedNumbers.get(5)));
    }


    private void displayWinningNumbers(HashSet<Integer> winningNumbers) {
        int i = 0;
        for (Integer number : winningNumbers) {
            switch (i) {
                case 0:
                    result1.setText(String.valueOf(number));
                    break;
                case 1:
                    result2.setText(String.valueOf(number));
                    break;
                case 2:
                    result3.setText(String.valueOf(number));
                    break;
                case 3:
                    result4.setText(String.valueOf(number));
                    break;
                case 4:
                    result5.setText(String.valueOf(number));
                    break;
                case 5:
                    result6.setText(String.valueOf(number));
                    break;
            }
            i++;
        }
    }


        private void checkMatches(ArrayList<Integer> selectedNumbers, HashSet<Integer> winningNumbers) {
        int matches = 0;

        for (Integer number : selectedNumbers) {
            if (winningNumbers.contains(number)) {
                matches++;
            }
        }

        String prizeMessage = LottoUtils.calculatePrize(matches);
        Log.d("TextViewDebug", "Text to set: " + prizeMessage);
        message.setText(prizeMessage);
    }

}