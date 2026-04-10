# Keyfive Coding Assessment

This is the starter solution for the Keyfive React + ASP.NET assessment.

## Requirements

- .NET 8 SDK
- Visual Studio 2022 or later

## Run in Visual Studio

1. Open `K5.Assessment.Starter.csproj`
2. Press F5 or run the project
3. The app will open in your browser

## ... or run from the command line

```bash
dotnet run
```

## What is already implemented

- ASP.NET Core minimal API project
- Static React UI served from `wwwroot`
- In-memory seeded task data
- `GET /api/tasks`
- View/listing of tasks, including tasks that are already completed

## What is intentionally incomplete

- `POST /api/tasks`
- `PUT /api/tasks/{id}`
- Add-task UI functionality
- Edit-task UI functionality

## Notes

This project intentionally avoids Node.js and a frontend build step to keep the assessment easy to run in Visual Studio.


## Expectation

The add and edit UI is already present in the starter, and the related React and C# add/edit methods are intentionally left as empty stubs.
Candidates are expected to implement those methods, wire the UI to the API, and complete the backend behavior.

Let us know if you have any questions. Thank you for your time and look forward to seeing what you come up with.
