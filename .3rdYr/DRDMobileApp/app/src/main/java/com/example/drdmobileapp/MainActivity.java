package com.example.drdmobileapp;

import static com.example.drdmobileapp.ui.login.LoginActivity.getLoggedInEmployeeID;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

import com.google.android.material.navigation.NavigationView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.navigation.NavController;
import androidx.navigation.NavDestination;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.appcompat.app.AppCompatActivity;

import com.example.drdmobileapp.databinding.ActivityMainBinding;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.Objects;

public class MainActivity extends AppCompatActivity {

    private AppBarConfiguration mAppBarConfiguration;
    private ActivityMainBinding binding;

    private TextView TextViewName, TextViewID;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        setSupportActionBar(binding.appBarMain.toolbar);

        DrawerLayout drawer = binding.drawerLayout;
        NavigationView navigationView = binding.navView;

        DatabaseReference usersRef = FirebaseDatabase.getInstance().getReference("Users");
        usersRef.orderByChild("EmployeeID").equalTo(getLoggedInEmployeeID()).addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {
                for (DataSnapshot userSnapshot : dataSnapshot.getChildren()) {
                    String userType = userSnapshot.child("UserType").getValue(String.class);
                    if (userType != null) {
                        navigationView.getMenu().clear(); // Clear existing menu items

                        if (userType.equals("User")) {
                            mAppBarConfiguration = new AppBarConfiguration.Builder(
                                    R.id.nav_home, R.id.nav_emergency_loan, R.id.nav_special_loan, R.id.nav_regular_loan, R.id.nav_user_Loan_info)
                                    .setOpenableLayout(drawer)
                                    .build();
                            navigationView.inflateMenu(R.menu.activity_main_drawer);

                            Navigation.findNavController(MainActivity.this, R.id.nav_host_fragment_content_main)
                                    .navigate(R.id.nav_home);
                            updateNavigationViewSelection(navigationView, R.id.nav_home);
                        } else if (userType.equals("Admin")) {
                            mAppBarConfiguration = new AppBarConfiguration.Builder(
                                    R.id.nav_home_admin, R.id.nav_loan_status, R.id.nav_loan_records)
                                    .setOpenableLayout(drawer)
                                    .build();
                            navigationView.inflateMenu(R.menu.activity_admin_drawer);

                            Navigation.findNavController(MainActivity.this, R.id.nav_host_fragment_content_main)
                                    .navigate(R.id.nav_home_admin);
                            updateNavigationViewSelection(navigationView, R.id.nav_home_admin);
                        }
                    } else {
                        finish();
                    }

                    NavController navController = Navigation.findNavController(MainActivity.this, R.id.nav_host_fragment_content_main);
                    NavigationUI.setupActionBarWithNavController(MainActivity.this, navController, mAppBarConfiguration);
                    NavigationUI.setupWithNavController(navigationView, navController);

                    navigationView.setNavigationItemSelectedListener(new NavigationView.OnNavigationItemSelectedListener() {
                        @Override
                        public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                            int itemId = item.getItemId();
                            navController.navigate(itemId);
                            drawer.closeDrawers();
                            return true;
                        }
                    });

                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {
                // Handle any errors
            }

        });

        Objects.requireNonNull(getSupportActionBar()).setDisplayShowTitleEnabled(false);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        String employeeID = getLoggedInEmployeeID();

        TextViewName = findViewById(R.id.nav_employeeid);
        TextViewID = findViewById(R.id.nav_fullname);

        // Get the FirebaseDatabase reference
        FirebaseDatabase database = FirebaseDatabase.getInstance();
        DatabaseReference usersRef = database.getReference("Users");

        usersRef.orderByChild("EmployeeID").equalTo(employeeID)
                .addListenerForSingleValueEvent(new ValueEventListener() {
                    @Override
                    public void onDataChange(@NonNull DataSnapshot snapshot) {
                        if (snapshot.exists()) {
                            for (DataSnapshot userSnapshot : snapshot.getChildren()) {

                                String firstName = userSnapshot.child("FirstName").getValue(String.class);
                                String middleInitial = userSnapshot.child("MiddleInitial").getValue(String.class);
                                String lastName = userSnapshot.child("LastName").getValue(String.class);
                                String employeeId = userSnapshot.child("EmployeeID").getValue(String.class);

                                TextViewName.setText(firstName + " " + middleInitial + "." + " " + lastName);
                                TextViewID.setText(employeeId);
                                break; // Exit the loop after finding the first matching user
                            }
                        } else {
                            // Handle the case when the user's information is not found
                            TextViewName.setText("User not found");
                        }
                    }

                    @Override
                    public void onCancelled(@NonNull DatabaseError error) {
                        // Handle any errors that occur during the retrieval
                        TextViewName.setText("Error retrieving user information");
                    }
                });

        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onSupportNavigateUp() {
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment_content_main);
        return NavigationUI.navigateUp(navController, mAppBarConfiguration)
                || super.onSupportNavigateUp();
    }

    private void updateNavigationViewSelection(NavigationView navigationView, int itemId) {
        Menu menu = navigationView.getMenu();
        for (int i = 0; i < menu.size(); i++) {
            MenuItem item = menu.getItem(i);
            item.setChecked(item.getItemId() == itemId);
        }
    }
}