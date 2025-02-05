package com.example.drdmobileapp.ui.login;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.drdmobileapp.MainActivity;
import com.example.drdmobileapp.R;
import com.example.drdmobileapp.signup;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.Objects;

public class LoginActivity extends AppCompatActivity {

    private EditText employeeIDEditText, passwordEditText;

    private View loginButton;
    private FirebaseAuth mAuth;
    private DatabaseReference mDatabase;

    private static String loggedInEmployeeID, loggedInUserType, loggedFname, loggedMname, loggedLname, loggedInDateHired, loggedInTableName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);
        Objects.requireNonNull(getSupportActionBar()).setTitle("");


        employeeIDEditText = findViewById(R.id.nav_employeeid);
        passwordEditText = findViewById(R.id.password);
        loginButton = findViewById(R.id.login);

        mAuth = FirebaseAuth.getInstance();
        mDatabase = FirebaseDatabase.getInstance().getReference();

        loginButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String employeeId = employeeIDEditText.getText().toString();
                String password = passwordEditText.getText().toString();
                loginUser(employeeId, password);
            }
        });
    }

    private void loginUser(String employeeId, String password) {
        if (employeeId.isEmpty()) {
            employeeIDEditText.setError("Please enter your Employee ID");
            employeeIDEditText.requestFocus();
            return;
        }

        if (password.isEmpty()) {
            passwordEditText.setError("Please enter your password");
            passwordEditText.requestFocus();
            return;
        }

        mDatabase.child("Users").orderByChild("EmployeeID").equalTo(employeeId)
                .addListenerForSingleValueEvent(new ValueEventListener() {
                    @Override
                    public void onDataChange(@NonNull DataSnapshot snapshot) {
                        if (snapshot.exists()) {
                            for (DataSnapshot userSnapshot : snapshot.getChildren()) {
                                String storedPassword = userSnapshot.child("Password").getValue(String.class);
                                if (storedPassword.equals(password)) {
                                    // Login successful
                                    Toast.makeText(LoginActivity.this, "Login successful", Toast.LENGTH_SHORT).show();
                                    loggedInEmployeeID = employeeId;

                                    // Check the UserType and start the appropriate activity
                                    String userType = userSnapshot.child("UserType").getValue(String.class);
                                    loggedInUserType = userType;

                                    String firstname = userSnapshot.child("FirstName").getValue(String.class) + " ";
                                    loggedFname = firstname;

                                    String middleinitial = userSnapshot.child("MiddleInitial").getValue(String.class) + ". ";
                                    loggedMname = middleinitial;

                                    String lastname = userSnapshot.child("LastName").getValue(String.class);
                                    loggedLname = lastname;

                                    String datehired = userSnapshot.child("DateHired").getValue(String.class);
                                    loggedInDateHired = datehired;

                                    String tablename = userSnapshot.getKey();
                                    loggedInTableName = tablename;

                                    if (userType.equals("User")) {
                                        updateUI(true, MainActivity.class);
                                    } else if (userType.equals("Admin")) {
                                        updateUI(true, MainActivity.class);
                                    }
                                    return;
                                }
                            }
                        }
                        // Login failed
                        Toast.makeText(LoginActivity.this, "The login information you entered is incorrect", Toast.LENGTH_SHORT).show();
                    }

                    @Override
                    public void onCancelled(@NonNull DatabaseError error) {
                        // Error occurred while accessing the database
                        Toast.makeText(LoginActivity.this, "Error: " + error.getMessage(), Toast.LENGTH_SHORT).show();
                    }
                });
    }

    private void updateUI(boolean isSuccess, Class activityClass) {
        if (isSuccess) {
            Intent intent = new Intent(LoginActivity.this, activityClass);
            startActivity(intent);
            finish();
        }
    }

    public void btnSignup(View view) {
        Intent in = new Intent(this, signup.class);
        startActivity(in);
    }

    public static String getLoggedInEmployeeID() {
        return loggedInEmployeeID;
    }

    public static String getLoggedInName(String type) {
        if (type != null){
            switch (type) {
                case "firstName":
                    return loggedFname;
                case "middleName":
                    return loggedMname;
                case "lastName":
                    return loggedLname;
                case "fullName":
                    return loggedFname + loggedMname + loggedLname;
            }
        }
        return null;
    }

    public static String getLoggedInDateHired() {
        return loggedInDateHired;
    }

    public static String getLoggedInTableName() {
        return loggedInTableName;
    }

    public static String getLoggedInUserType() {
        return loggedInUserType;
    }
}