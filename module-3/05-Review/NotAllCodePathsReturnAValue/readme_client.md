Now on to the client!

Thankfully, the client is mostly complete and just needs to be hooked up to your server. 
However, you should know that the client was written by an actor doing extra work for Diet Doctor Pepper funds and may have room
for improvement or may not accurately match your API.

In order to run this successfully, you will need to right click on the solution and change the solution's startup project. 
From there, set the startup project to multiple projects and choose to start both the client and the server project.

# Step One: Implement the CostumeApi.cs class

You will need to add methods here to communicate with your server. You will need a `RestClient` and will need to give it the URL of 
your server application. Take a look at the URL in the Swagger browser page and drop "index.html" in order to figure out your base URL.

Once all 5 API methods are implemented, you should be able to run the application and see how it responds.

There are likely to be a few bugs in properties not getting values after listing items or creating items. Get these resolved.

# Step Two: Handle bad responses gracefully

Next, make sure each API method responds appropriately to either non-success responses or errors communicating with the server.

You can test handling failures by typing in inputs the server doesn't allow (see your valdiation logic from the server).

You can test communication errors by setting the startup project as ONLY the client and running. If run in this manner, the server will not be online.

You may also encounter some string parsing weaknesses in the client's code while testing this.
You are welcome and encouraged to fix them, but your main focus should be the API.

# If you have extra time...

Add extra properties to the items on the server, then add support for them on the client-side.

Try to improve the client-side code further.