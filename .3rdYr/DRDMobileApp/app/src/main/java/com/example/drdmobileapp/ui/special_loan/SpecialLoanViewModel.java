package com.example.drdmobileapp.ui.special_loan;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class SpecialLoanViewModel extends ViewModel {

    private final MutableLiveData<String> mText;

    public SpecialLoanViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is slideshow fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}