Tasks for the server-side aspect of the review day.

You have a server with some basic things already in place, as well as swagger documentation added in.

# Step 1: Dependency Injection

In startup.cs, below the TODO on line 50, add a dependency injection configuration setting to provide 
an `InMemoryCostumeDao` whenever an `ICostumeDao` is needed.

You should reuse the same ICostumeDao for every request to the system.

The options you will want to choose from for this are:

- AddTransient
- AddScoped
- AddSingleton

Before moving on to the next step, run your server and make a GET request to its `healthcheck` endpoint and ensure you get a 200 OK response.

# Step 2: Controllers

Add a controller to handle requests related to creating, reading, updating, and deleting costumes. 
This controller will need to take in an ICostumeDao in its constructor.
You should use GET, PUT, POST, and DELETE verbs and have at least 2 GET endpoints: a way to get all costumes as well as a way to get an individual costume.

Test each request in Postman and the Swagger UI web page to ensure it works as expected.

# Step 3: Validation

Take a look at the specifics of the `Costume` class.

Looking at the class and your controller methods from step 2, make decisions as to what types of validation you should have 
for each one and if the validation should be on the model using attributes, on the controller method, or some combination of the two.

Also keep in mind what status codes you'd like to return to API callers to help them understand what happened with their request.

# If you have extra time...

Test your code using a variety of requests in Postman. Try to break it, then fix the gaps you find.

Add new properties to the Costume model and validation rules for those properties.

Add XML Comments to your controller and see how the Swagger documentation reacts
Read more about Swagger / Swashbuckle documentation at https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.1&tabs=visual-studio

Look over `InMemoryCostumeDao` and see what new things you can learn from some of the syntax.