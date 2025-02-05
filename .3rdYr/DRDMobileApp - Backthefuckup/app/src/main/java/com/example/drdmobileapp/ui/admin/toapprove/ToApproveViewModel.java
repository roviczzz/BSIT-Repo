package com.example.drdmobileapp.ui.admin.toapprove;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class ToApproveViewModel extends ViewModel {

    private final MutableLiveData<String> mText;

    public ToApproveViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is home fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}