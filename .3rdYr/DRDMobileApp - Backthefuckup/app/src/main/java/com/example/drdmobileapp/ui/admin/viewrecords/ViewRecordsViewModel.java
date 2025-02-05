package com.example.drdmobileapp.ui.admin.viewrecords;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class ViewRecordsViewModel extends ViewModel {

    private final MutableLiveData<String> mText;

    public ViewRecordsViewModel() {
        mText = new MutableLiveData<>();
        mText.setValue("This is home fragment");
    }

    public LiveData<String> getText() {
        return mText;
    }
}