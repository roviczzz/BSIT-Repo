package com.example.drdmobileapp.ui.regular_loan;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class RegularLoanViewModel extends ViewModel {

    private final MutableLiveData<String> mText;

    public RegularLoanViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is slideshow fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}