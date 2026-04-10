using K5.Assessment.Starter.Models;

namespace K5.Assessment.Starter.Services;

public class TaskStore
{
    readonly List<TaskItem> tasks =
    [
        new TaskItem(1,"Review quarterly report", "High", false),
        new TaskItem(2,"Send follow-up email", "Normal", true),
        new TaskItem(3,"Schedule demo call", "Low", false)
    ];

    int nextId = 4;

    public IReadOnlyList<TaskItem> GetAll()
    {
        return tasks
            .OrderByDescending(x => PriorityRank(x.Priority))
            .ThenBy(x => x.Title)
            .ToList();
    }

    public TaskItem? Add(string title, string priority)
    {
        // TODO:
        // Create a new task record, add it to the in-memory list,
        // increment nextId, and return the created task.

        return null;
    }

    public TaskItem? Update(int id, string title, string priority)
    {
        // TODO:
        // Find the matching task, replace it with an updated record,
        // and return the updated task.

        return null;
    }

    public static bool IsValidPriority(string? value)
    {
        return value is "Low" or "Normal" or "High";
    }

    static int PriorityRank(string priority)
    {
        return priority switch
        {
            "High" => 3,
            "Normal" => 2,
            "Low" => 1,
            _ => 0
        };
    }
}
