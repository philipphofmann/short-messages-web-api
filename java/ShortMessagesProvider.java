package muffls.android.shortmessageswebapi.provider;

import muffls.android.shortmessageswebapi.provider.models.SendShortMessageModel;
import muffls.android.shortmessageswebapi.provider.models.ShortMessageModel;
import muffls.android.shortmessageswebapi.provider.models.ShortMessages;
import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.Path;

/**
* WEB API interface for the use with Retrofit.
*/
public interface ShortMessagesProvider {
    @GET("/api/ShortMessages/{consumerKey}")
    Call<ShortMessages> getShortMessages(@Path("consumerKey") String consumerKey);

    @POST("/api/ShortMessages")
    Call<ShortMessageModel> sendShortMessage(@Body SendShortMessageModel shortMessage);
}
