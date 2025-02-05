package com.example.drdmobileapp.ui.loaninfo;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class UserLoanInfoViewModel extends ViewModel {

    private final MutableLiveData<String> mText;

    public UserLoanInfoViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is home fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}