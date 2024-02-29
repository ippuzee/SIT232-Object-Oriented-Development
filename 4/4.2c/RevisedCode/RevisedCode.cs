using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedCode
{
    internal class RevisedCode
    {
        static void Main(string[] args)
        {
            // Arrays to store tasks for different categories
            string[] tasksIndividual = new string[0];
            string[] tasksWork = new string[0];
            string[] tasksFamily = new string[0];

            while (true)
            {
                // Clears the console screen at the beginning of each iteration to create a cleaner display.
                Console.Clear();

                // Calculate the maximum length of any category's task array
                int max = Math.Max(tasksIndividual.Length, Math.Max(tasksWork.Length, tasksFamily.Length));

                // Display Header for task categories
                DisplayCategoriesHeader();

                // Display tasks for each category
                for (int i = 0; i < max; i++)
                {
                    DisplayTaskInfo(i, tasksIndividual, tasksWork, tasksFamily);
                }

                // Resets the console color to the default.
                Console.ResetColor();

                Console.WriteLine("\nWhich category do you want to place a new task? Type 'Personal', 'Work', or 'Family'");
                Console.Write(">> ");

                // Converts the characters given as input into lowercase
                // The null conditional operator(?) is used to ensue that when a null vlaue is entered, the operation won't throw a NullReferenceException, instead, the entire expression evaluates to null.
                string listName = Console.ReadLine()?.ToLower();         

                Console.WriteLine("Describe your task below (max. 30 symbols).");
                Console.Write(">> ");

                // Reads and truncates(shortens) user input for the task description
                string task = Console.ReadLine();
                if (task != null)
                {
                    task = task.Substring(0, Math.Min(30, Math.Min(task.Length, Console.WindowWidth - 1)));
                }

                // Add the task to the appropriate category
                AddTask(listName, task, ref tasksIndividual, ref tasksWork, ref tasksFamily);
            }
        }

        // The method that displays the header for task categories
        private static void DisplayCategoriesHeader()
        {
            // Sets the console text color to blue.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 12) + "CATEGORIES");
            Console.WriteLine(new string(' ', 10) + new string('-', 94));
            Console.WriteLine("{0,10}|{1,30}|{2,30}|{3,30}|", "item #", "Personal", "Work", "Family");
            Console.WriteLine(new string(' ', 10) + new string('-', 94));
        }

        // The Method to display tasks for each category
        private static void DisplayTaskInfo(int index, params string[][] tasksArrays)
        {
            Console.Write($"{index,10}|");

            foreach (var tasks in tasksArrays)
            {
                if (tasks.Length > index)
                {
                    Console.Write($"{tasks[index],30}|");
                }
                else
                {
                    Console.Write($"{"N/A",30}|");
                }
            }
            Console.WriteLine();
        }


        // The method to add a task to the specified category
        private static void AddTask(string listName, string task, ref string[] tasksIndividual, ref string[] tasksWork, ref string[] tasksFamily)
        { 
            switch (listName)
            {
                case "personal":
                    AddTaskToCategory(task, ref tasksIndividual);
                    break;
                case "work":
                    AddTaskToCategory(task, ref tasksWork);
                    break;
                case "family":
                    AddTaskToCategory(task, ref tasksFamily);
                    break;
                default:
                    Console.WriteLine("Invalid category. Please choose 'Personal', 'Work', or 'Family'.");
                    break;
            }
        }

        // Extend the specified category's task array to accommodate the new task
        private static void AddTaskToCategory(string task, ref string[] categoryTasks)
        {
            // Create a new array with increased length to hold the tasks
            string[] updatedCategoryTasks = new string[categoryTasks.Length + 1];

            // Copy existing tasks to the new array
            for (int j = 0; j < categoryTasks.Length; j++)
            {
                updatedCategoryTasks[j] = categoryTasks[j];
            }

            // Add the new task to the end of the array
            updatedCategoryTasks[updatedCategoryTasks.Length - 1] = task;
            // Update the reference to the original array with the new one
            categoryTasks = updatedCategoryTasks;
        }
    }
}
