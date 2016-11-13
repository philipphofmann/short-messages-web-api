package muffls.android.shortmessageswebapi.provider.models;

import java.util.ArrayList;
import java.util.List;

/**
* Model for GSON
*/
public class ShortMessages {
    List<ShortMessageModel> messages = new ArrayList<>();

    public ShortMessages() {
        //required for GSON
    }

    //region Getters and Setters

    public List<ShortMessageModel> getMessages() {
        return messages;
    }

    public void setMessages(List<ShortMessageModel> messages) {
        this.messages = messages;
    }


    //endregion
}
