using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCode
{
    internal class FinalCode
    {
        // Define an enumeration for task importance levels
        public enum ImportanceLevel
        {
            Low,
            Medium,
            High
        }

        // Define a Task class with properties representing a task
        public class Task
        {
            public string Name { get; set; }
            public DateTime DueDate { get; set; }
            public bool IsCompleted { get; set; }
            public ImportanceLevel Importance { get; set; }
        }

        // Define a Category class with properties representing a category of tasks
        public class Category
        {
            public string Name { get; set; }
            public List<Task> Tasks { get; set; } = new List<Task>();
        }

        // Define a TaskManager class to manage tasks and categories
        public class TaskManager
        {
            // List to store categories
            public List<Category> Categories { get; set; } = new List<Category>();

            // Display a menu with available options
            public void ShowMenu()
            {
                Console.WriteLine("1.  Add Category");
                Console.WriteLine("2.  Add Task");
                Console.WriteLine("3.  Complete Task");
                Console.WriteLine("4.  Change Importance");
                Console.WriteLine("5.  Set Due Date");
                Console.WriteLine("6.  Change Position");
                Console.WriteLine("7.  Move Task to another Category");
                Console.WriteLine("8.  Display Tasks");
                Console.WriteLine("9.  Delete Task");
                Console.WriteLine("10. Delete Category");
                Console.WriteLine("0.  Exit");
            }



            // Add a new category
            public void AddCategory(string categoryName)
            {
                // Create a new Category instance and add it to the Categories list.
                Categories.Add(new Category { Name = categoryName });
            }



            // Delete a category
            public void DeleteCategory(string categoryName)
            {
                // Find the category to remove based on the provided category name (case-insensitive).
                var categoryToRemove = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before attempting to remove it.
                if (categoryToRemove != null)
                {
                    Categories.Remove(categoryToRemove); // Remove the found category.
                }
            }



            // Add a new task to a specific category
            public void AddTask(string categoryName, string taskName, DateTime dueDate)
            {
                // Find the category based on the provided category name (case-insensitive).
                var category = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before adding the task.
                if (category != null)
                {
                    // Create a new Task instance and add it to the Tasks list of the found category.
                    category.Tasks.Add(new Task { Name = taskName, DueDate = dueDate });
                }
                else
                {
                    // Display an error message if the specified category is not found.
                    Console.WriteLine($"Category '{categoryName}' not found.");
                }
            }



            // Delete a task from a specific category
            public void DeleteTask(string categoryName, string taskName)
            {
                // Find the category based on the provided category name (case-insensitive).
                var category = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before attempting to delete the task.
                if (category != null)
                {
                    // Find the task to remove based on the provided task name (case-insensitive).
                    var taskToRemove = category.Tasks.FirstOrDefault(t => t.Name.ToLower() == taskName.ToLower());

                    // Check if the task exists before attempting to remove it.
                    if (taskToRemove != null)
                    {
                        category.Tasks.Remove(taskToRemove);// Remove the found task.
                    }
                    else
                    {
                        // Display an error message
                        Console.WriteLine($"Task '{taskName}' not found in category '{categoryName}'.");
                    }
                }
                else
                {
                    // Display an error message
                    Console.WriteLine($"Category '{categoryName}' not found.");
                }
            }



            // Mark a task as completed
            public void CompleteTask(string categoryName, string taskName)
            {
                // Find the category based on the provided category name (case-insensitive).
                var category = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before attempting to complete the task.
                if (category != null)
                {
                    // Find the task based on the provided task name (case-insensitive).
                    var task = category.Tasks.FirstOrDefault(t => t.Name.ToLower() == taskName.ToLower());

                    // Check if the task exists before marking it as completed.
                    if (task != null)
                    {
                        task.IsCompleted = true; // Mark the task as completed.

                        // Change text color for completed tasks
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Task '{taskName}' in category '{categoryName}' marked as completed.");
                        Console.ResetColor();
                    }
                    else
                    {
                        // Display an error message 
                        Console.WriteLine($"Task '{taskName}' not found in category '{categoryName}'.");
                    }
                }
                else
                {
                    // Display an error message 
                    Console.WriteLine($"Category '{categoryName}' not found.");
                }
            }



            // Change the importance level of a task
            public void ChangeImportance(string categoryName, string taskName, ImportanceLevel importanceLevel)
            {
                // Find the category based on the provided category name (case-insensitive).
                var category = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before attempting to change the importance level.
                if (category != null)
                {
                    // Find the task based on the provided task name (case-insensitive).
                    var task = category.Tasks.FirstOrDefault(t => t.Name.ToLower() == taskName.ToLower());

                    // Check if the task exists before changing its importance level.
                    if (task != null)
                    {
                        task.Importance = importanceLevel; // Change the importance level of the task.

                        // Change text color based on importance level
                        Console.ForegroundColor = GetColorForImportance(importanceLevel);
                        Console.WriteLine($"Importance of task '{taskName}' in category '{categoryName}' changed to {importanceLevel}.");
                        Console.ResetColor();
                    }
                    else
                    {
                        // Display an error message
                        Console.WriteLine($"Task '{taskName}' not found in category '{categoryName}'.");
                    }
                }
                else
                {
                    // Display an error message
                    Console.WriteLine($"Category '{categoryName}' not found.");
                }
            }



            // GetColorForImportance method returns a ConsoleColor based on the provided ImportanceLevel.
            // It helps visualize the importance level with different colors.
            private ConsoleColor GetColorForImportance(ImportanceLevel importanceLevel)
            {
                switch (importanceLevel)
                {
                    case ImportanceLevel.Low:
                        return ConsoleColor.Gray; // - Low importance: Gray
                    case ImportanceLevel.Medium:
                        return ConsoleColor.Yellow; // - Medium importance: Yellow
                    case ImportanceLevel.High:
                        return ConsoleColor.Red; // - High importance: Red
                    default:
                        return ConsoleColor.White; // - Default (if importance level is undefined): White
                }
            }



            // Set a new due date for a task
            public void SetDueDate(string categoryName, string taskName, DateTime dueDate)
            {
                // Find the category based on the provided category name (case-insensitive).
                var category = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before attempting to set the due date.
                if (category != null)
                {
                    // Find the task based on the provided task name (case-insensitive).
                    var task = category.Tasks.FirstOrDefault(t => t.Name.ToLower() == taskName.ToLower());

                    // Check if the task exists before setting its due date.
                    if (task != null)
                    {
                        task.DueDate = dueDate; // Set the due date of the task.

                        // Display a message confirming the change in due date.
                        Console.WriteLine($"Due date of task '{taskName}' in category '{categoryName}' set to {dueDate.ToShortDateString()}.");
                    }
                    else
                    {
                        // Display an error message
                        Console.WriteLine($"Task '{taskName}' not found in category '{categoryName}'.");
                    }
                }
                else
                {
                    // Display an error message
                    Console.WriteLine($"Category '{categoryName}' not found.");
                }
            }



            // Change the position of a task within a category
            public void ChangePosition(string categoryName, string taskName, int newPosition)
            {
                // Find the category based on the provided category name (case-insensitive).
                var category = Categories.FirstOrDefault(c => c.Name.ToLower() == categoryName.ToLower());

                // Check if the category exists before attempting to change the task position.
                if (category != null)
                {
                    // Find the task based on the provided task name (case-insensitive).
                    var task = category.Tasks.FirstOrDefault(t => t.Name.ToLower() == taskName.ToLower());

                    // Check if the task exists before changing its position.
                    if (task != null)
                    {
                        // Check if the new position is within a valid range.
                        if (newPosition >= 1 && newPosition <= category.Tasks.Count)
                        {
                            category.Tasks.Remove(task);
                            category.Tasks.Insert(newPosition - 1, task); // Change the position of the task.
                            Console.WriteLine($"Position of task '{taskName}' in category '{categoryName}' changed to {newPosition}.");
                        }
                        else
                        {
                            // Display an error message
                            Console.WriteLine($"Invalid position for task '{taskName}' in category '{categoryName}'.");
                        }
                    }
                    else
                    {
                        // Display an error message
                        Console.WriteLine($"Task '{taskName}' not found in category '{categoryName}'.");
                    }
                }
                else
                {
                    // Display an error message
                    Console.WriteLine($"Category '{categoryName}' not found.");
                }
            }



            // Move a task from one category to another
            public void MoveTask(string currentCategoryName, string newCategoryName, string taskName)
            {
                // Find the current category based on the provided current category name (case-insensitive).
                var currentCategory = Categories.FirstOrDefault(c => c.Name.ToLower() == currentCategoryName.ToLower());

                // Find the new category based on the provided new category name (case-insensitive).
                var newCategory = Categories.FirstOrDefault(c => c.Name.ToLower() == newCategoryName.ToLower());

                // Check if both the current and new categories exist before attempting to move the task.
                if (currentCategory != null && newCategory != null)
                {
                    // Find the task based on the provided task name (case-insensitive) within the current category.
                    var task = currentCategory.Tasks.FirstOrDefault(t => t.Name.ToLower() == taskName.ToLower());

                    // Check if the task exists in the current category before attempting to move it.
                    if (task != null)
                    {
                        currentCategory.Tasks.Remove(task);
                        newCategory.Tasks.Add(task); // Move the task from the current category to the new category.
                        Console.WriteLine($"Task '{taskName}' moved from '{currentCategoryName}' to '{newCategoryName}'.");
                    }
                    else
                    {
                        // Display an error message
                        Console.WriteLine($"Task '{taskName}' not found in category '{currentCategoryName}'.");
                    }
                }
                else
                {
                    // Display an error message
                    Console.WriteLine($"Category not found. Ensure both '{currentCategoryName}' and '{newCategoryName}' exist.");
                }
            }



            // Display all tasks and their details
            public void DisplayTasks()
            {
                foreach (var category in Categories)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(new string(' ', 10) + new string('-', 94));
                    Console.WriteLine(new string(' ', 10) + $"Category: {category.Name}");
                    Console.WriteLine(new string(' ', 10) + new string('-', 14));
                    Console.ResetColor();

                    foreach (var taskName in category.Tasks)
                    {
                        ConsoleColor taskColor = GetColorForTask(taskName);
                        Console.ForegroundColor = taskColor;

                        Console.WriteLine(new string(' ', 10)+$"Task for : {taskName.Name}, Due Date: {taskName.DueDate.ToShortDateString()}, Importance: {taskName.Importance}, Completed: {taskName.IsCompleted}");
                        Console.WriteLine();
                    }
                }
                Console.ResetColor();
            }



            // Get the color for a task based on completion and importance
            private ConsoleColor GetColorForTask(Task task)
            {
                if (task.IsCompleted)
                {
                    return ConsoleColor.Green; // Completed tasks are displayed in green
                }
               
                else
                {
                    // Use GetColorForImportance to determine color based on the task's importance level
                    return GetColorForImportance(task.Importance); 
                }
            }



            // Run the main application loop
            public void Run()
            {
                while (true)
                {
                    Console.Clear();   
                    ShowMenu();

                    Console.WriteLine();
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1": // Add Category
                            Console.Write("Enter category name: ");
                            string categoryName = Console.ReadLine();
                            AddCategory(categoryName);
                            break;

                        case "2": // Add Task
                            Console.Write("Enter category name: ");
                            string categoryForTask = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string taskName = Console.ReadLine();
                            Console.Write("Enter due date (yyyy-MM-dd): ");
                            DateTime dueDate = DateTime.Parse(Console.ReadLine());
                            AddTask(categoryForTask, taskName, dueDate);
                            break;

                        case "3": // Complete Task
                            Console.Write("Enter category name: ");
                            string completeCategory = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string completeTaskName = Console.ReadLine();
                            CompleteTask(completeCategory, completeTaskName);
                            break;

                        case "4": // Change Importance
                            Console.Write("Enter category name: ");
                            string importanceCategory = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string importanceTaskName = Console.ReadLine();
                            Console.Write("Enter importance level (Low/Medium/High): ");
                            ImportanceLevel importanceLevel;
                            Enum.TryParse(Console.ReadLine(), out importanceLevel);
                            ChangeImportance(importanceCategory, importanceTaskName, importanceLevel);
                            break;

                        case "5": // Set Due Date
                            Console.Write("Enter category name: ");
                            string dueDateCategory = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string dueDateTaskName = Console.ReadLine();
                            Console.Write("Enter new due date (yyyy-MM-dd): ");
                            DateTime newDueDate = DateTime.Parse(Console.ReadLine());
                            SetDueDate(dueDateCategory, dueDateTaskName, newDueDate);
                            break;

                        case "6": // Change Position
                            Console.Write("Enter category name: ");
                            string positionCategory = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string positionTaskName = Console.ReadLine();
                            Console.Write("Enter new position: ");
                            int newPosition = int.Parse(Console.ReadLine());
                            ChangePosition(positionCategory, positionTaskName, newPosition);
                            break;

                        case "7": // Move Task
                            Console.Write("Enter current category name: ");
                            string moveCurrentCategory = Console.ReadLine();
                            Console.Write("Enter new category name: ");
                            string moveNewCategory = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string moveTaskName = Console.ReadLine();
                            MoveTask(moveCurrentCategory, moveNewCategory, moveTaskName);
                            break;

                       case "8": // Display Tasks
                            DisplayTasks(); 
                            break;

                        case "9": // Delete tasks
                            Console.Write("Enter category name: ");
                            string deleteTaskCategory = Console.ReadLine();
                            Console.Write("Enter task name: ");
                            string deleteTaskName = Console.ReadLine();
                            DeleteTask(deleteTaskCategory, deleteTaskName);
                            break;

                        case "10": // Delete Category
                            Console.Write("Enter category name: ");
                            string deleteCategoryName = Console.ReadLine();
                            DeleteCategory(deleteCategoryName);
                            break;

                        case "0": // Exit program
                            Environment.Exit(0);
                            break;
                        default: // Statement prints when an invalid input is given.
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }

                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }



            // Main program entry point
            class Program
            {
                static void Main(string[] args)
                {
                    TaskManager taskManager = new TaskManager();
                    taskManager.Run();
                }
            }
        }
    }
}