package muffls.android.shortmessageswebapi;

import com.google.gson.annotations.SerializedName;

public class ShortMessageModel {

    @SerializedName("created")
    private String created;

    @SerializedName("text")
    private String text;

    public ShortMessageModel() {
        //Required for GSON
    }

    //region Getters and Setters

    public String getCreated() {
        return created;
    }

    public void setCreated(String created) {
        this.created = created;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }


    //endregion
}
