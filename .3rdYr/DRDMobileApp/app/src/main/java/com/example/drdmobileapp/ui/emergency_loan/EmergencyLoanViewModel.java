package com.example.drdmobileapp.ui.emergency_loan;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class EmergencyLoanViewModel extends ViewModel {

    private final MutableLiveData<String> mText;

    public EmergencyLoanViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is gallery fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}