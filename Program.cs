using K5.Assessment.Starter.Models;
using K5.Assessment.Starter.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TaskStore>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Using .NET Minimal APIs

app.MapGet("/api/tasks", (TaskStore store) =>
{
    return Results.Ok(store.GetAll());
});

app.MapPost("/api/tasks", CreateTask);
app.MapPut("/api/tasks/{id:int}", UpdateTask);

app.MapFallbackToFile("index.html");

app.Run();

static IResult CreateTask(CreateTaskRequest request, TaskStore store)
{
    // TODO:
    // Validate the request, add the task, and return the created task.
    // Suggested responses:
    // - 400 for validation errors
    // - 201 with the created task on success

    return Results.StatusCode(StatusCodes.Status501NotImplemented);
}

static IResult UpdateTask(int id, UpdateTaskRequest request, TaskStore store)
{
    // TODO:
    // Update title and priority for the given task.
    // Suggested responses:
    // - 400 for validation errors
    // - 404 if the task does not exist
    // - 200 with the updated task on success

    return Results.StatusCode(StatusCodes.Status501NotImplemented);
}
