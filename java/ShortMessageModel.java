package muffls.android.shortmessageswebapi.provider.models;

/**
* Model for GSON
*/
public class ShortMessageModel {

    String created;

    String text;

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
