package muffls.android.shortmessageswebapi.provider.models;

/**
* Model for GSON
*/
public class SendShortMessageModel {

    private String consumerKey;
    private String consumerSecret;
    private String text;

    public SendShortMessageModel() {
        //Required for GSON
    }

    //region Getters and Setters

    public String getConsumerKey() {
        return consumerKey;
    }

    public void setConsumerKey(String consumerKey) {
        this.consumerKey = consumerKey;
    }

    public String getConsumerSecret() {
        return consumerSecret;
    }

    public void setConsumerSecret(String consumerSecret) {
        this.consumerSecret = consumerSecret;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }


    //endregion

}
