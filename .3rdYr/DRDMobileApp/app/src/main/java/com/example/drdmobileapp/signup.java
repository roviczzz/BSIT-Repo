package com.example.drdmobileapp;

import android.app.Activity;
import android.app.DatePickerDialog;
import android.content.Intent;
import android.icu.util.Calendar;
import android.os.Bundle;
import android.text.TextWatcher;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.Query;
import com.google.firebase.database.ValueEventListener;

import java.util.Random;

import java.sql.Date;
import java.text.SimpleDateFormat;
import java.util.HashMap;
import java.util.Locale;
import java.util.Objects;

public class signup extends AppCompatActivity {
    EditText Fname, Mname, Lname, Password, DateHired;
    private static String signedEmployeeID;

    FirebaseDatabase db = FirebaseDatabase.getInstance();
    DatabaseReference root = db.getReference().child("Users");
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_signup);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            Objects.requireNonNull(getSupportActionBar()).setTitle("");

            Window window = this.getWindow();
            window.clearFlags(WindowManager.LayoutParams.FLAG_TRANSLUCENT_STATUS);
            window.addFlags(WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS);
            window.setStatusBarColor(ContextCompat.getColor(this,R.color.primary_blue)); // here is your color

            Fname = findViewById(R.id.firstName);
            Mname = findViewById(R.id.middleInitial);
            Lname = findViewById(R.id.lastName);
            Password = findViewById(R.id.password);
            DateHired = findViewById(R.id.dateHired);

            return insets;
        });
    }


    public void onClickSignIn(View view) {
        this.finish();
    }

    public void onClickSignUp(View view) {
        final String empFname = Fname.getText().toString().trim();
        final String empMname = Mname.getText().toString().trim();
        final String empLname = Lname.getText().toString().trim();
        final String empPass = Password.getText().toString().trim();
        final String empDateHired = DateHired.getText().toString().trim();

        if (empFname.isEmpty()) {
            Fname.setError("Please enter your first name");
            return;
        }

        if (empMname.isEmpty()) {
            Mname.setError("Please enter your middle name");
            return;
        }

        if (empLname.isEmpty()) {
            Lname.setError("Please enter your last name");
            return;
        }

        if (empPass.isEmpty()) {
            Password.setError("Please enter a password");
            return;
        }

        if (empDateHired.isEmpty()) {
            DateHired.setError("Please select a date");
            return;
        }

        Query query = root.orderByChild("FirstName").equalTo(empFname);
        query.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                boolean userExists = false;
                for (DataSnapshot childSnapshot : dataSnapshot.getChildren()) {
                    String firstName = childSnapshot.child("FirstName").getValue(String.class);
                    String middleName = childSnapshot.child("MiddleInitial").getValue(String.class);
                    String lastName = childSnapshot.child("LastName").getValue(String.class);
                    String password = childSnapshot.child("Password").getValue(String.class);
                    String dateHired = childSnapshot.child("DateHired").getValue(String.class);

                    if (empFname.equals(firstName) && empMname.equals(middleName) && empLname.equals(lastName) &&
                            empPass.equals(password) && empDateHired.equals(dateHired)) {
                        userExists = true;
                        break;
                    }
                }

                if (userExists) {
                    // Display an error message to the user
                    Toast.makeText(signup.this, "User already exists", Toast.LENGTH_SHORT).show();
                } else {
                    String capitalizedFname  = empFname.substring(0, 1).toUpperCase() + empFname.substring(1); // Make first letter uppercase
                    String capitalizedMname  = empMname.substring(0, 1).toUpperCase() + empMname.substring(1); // Make first letter uppercase
                    String capitalizedLname  = empLname.substring(0, 1).toUpperCase() + empLname.substring(1); // Make first letter uppercase

                    String empUserType = "User";

                    Random rand = new Random();
                    String empId = capitalizedFname.substring(0, 1).toLowerCase() + capitalizedLname.substring(0, 1).toLowerCase() + capitalizedMname.substring(0, 1).toLowerCase() + String.format("%05d", rand.nextInt(100000));
                    signedEmployeeID = empId;

                    HashMap<String, String> userMap = new HashMap<>();
                    userMap.put("EmployeeID", empId);
                    userMap.put("FirstName", empFname);
                    userMap.put("MiddleInitial", empMname);
                    userMap.put("LastName", empLname);
                    userMap.put("Password", empPass);
                    userMap.put("DateHired", empDateHired);
                    userMap.put("UserType", empUserType);
                    root.push().setValue(userMap);

                    Intent in = new Intent(signup.this, signup_details.class);
                    startActivity(in);
                    finish();
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {
                // Handle database error
                Toast.makeText(signup.this, "Error: " + databaseError.getMessage(), Toast.LENGTH_SHORT).show();
            }
        });
    }

    public static String getRegisteredEmployeeID() {
        return signedEmployeeID;
    }



    public void onClickCalendar(View view) {
        final Calendar currentDate = Calendar.getInstance();
        int year = currentDate.get(Calendar.YEAR);
        int month = currentDate.get(Calendar.MONTH);
        int day = currentDate.get(Calendar.DAY_OF_MONTH);

        DatePickerDialog datePickerDialog = new DatePickerDialog(this, R.style.CustomDatePicker, new DatePickerDialog.OnDateSetListener() {            @Override
            public void onDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth) {
                SimpleDateFormat sdf = new SimpleDateFormat("MM/dd/yyyy", Locale.US);
                currentDate.set(year, monthOfYear, dayOfMonth);
                String selectedDate = sdf.format(currentDate.getTime());
                DateHired.setText(selectedDate);
            }
        }, year, month, day);
        datePickerDialog.show();
    }
}