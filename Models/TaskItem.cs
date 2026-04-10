namespace K5.Assessment.Starter.Models;

public record TaskItem(int Id, string Title = "", string Priority = "Normal", bool IsComplete = false);