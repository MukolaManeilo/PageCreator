var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.UseStaticFiles();

app.Map("/", async (context) =>
{
    if (context.Request.Method == "POST")
    {
        var form = context.Request.Form;
        string name = form["login"]!;
        string age = form["password"]!;
        await context.Response.WriteAsync($"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
    }
    else
        context.Response.Redirect("/authorizaton");

});


app.Map("/authorizaton", async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response!.SendFileAsync("html/AuthorizationPage.html");
});

//app.Map("/viewer", () =>
//{

//});

//app.Map("/editor", () =>
//{

//});

app.Run();
