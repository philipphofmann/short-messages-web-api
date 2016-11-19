# Welcome to the Short Messages Web Api

This simple web API is designed for the course "Sicherheit von Netwerken und mobilen Applikationen"
on the University of Applied Sciences Technikum Wien.

You can reach the API at: [https://simple-web-api.azurewebsites.net/](https://simple-web-api.azurewebsites.net/)

Or you can view the API with Swagger: [https://simple-web-api.azurewebsites.net/swagger/ui/index.html#/ShortMessages](https://simple-web-api.azurewebsites.net/swagger/ui/index.html#/ShortMessages)

## The API
The Web API provides two methods, get and post. A client can post one or 
several ShortMessages via POST. Via GET he can access all his posted ShortMessages. 
The API supports multiple clients with the consumer key.
When a client first posts a ShortMessage with a customer key and a customer secret, a single
list of ShortMessages is assigned to this client. Following ShortMessages with the same 
combination of key and secret are added to the same list.


You can run sample request with postman: 

[![Run in Postman](https://run.pstmn.io/button.svg)](https://app.getpostman.com/run-collection/0a26a4bf47d3c7eaa934)

In folder [/java](./java/)  You can find Java example classes for the use of this API with Retrofit and GSON.

### Get short messages for the consumer key
Returns [ShortMessages](./Models/ShortMessages.cs) for the passed `String consumerKey`

The url schema: `// GET api/ShortMessages/{consumerkey}`


### Post a new short message
You can post new short messages via this method. It expects a 
[IncomingShortMessageModel](./Models/IncomingShortMessageModel.cs).
It returns the currently saved [ShortMessageModel](./Models/ShortMessageModel.cs).


The url schema: `// POST api/ShortMessages`





