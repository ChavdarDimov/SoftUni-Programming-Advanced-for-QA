using System;
using NUnit.Framework;
using TestApp.Todo;

namespace TestApp.Tests
{
    [TestFixture]
    public class ToDoListTests
    {
        private ToDoList _toDoList = null!;

        [SetUp]
        public void SetUp()
        {
            this._toDoList = new ToDoList();
        }

        [Test]
        public void Test_AddTask_TaskAddedToToDoList()
        {
            // Arrange
            const string taskTitle = "Task 1";
            DateTime dueDate = DateTime.Now.AddDays(3);

            // Act
            this._toDoList.AddTask(taskTitle, dueDate);

            // Assert
            string displayResult = this._toDoList.DisplayTasks();
            Assert.IsTrue(displayResult.Contains(taskTitle));
        }

        [Test]
        public void Test_CompleteTask_TaskMarkedAsCompleted()
        {
            // Arrange
            const string taskTitle = "Task 2";
            DateTime dueDate = DateTime.Now.AddDays(5);
            this._toDoList.AddTask(taskTitle, dueDate);

            // Act
            this._toDoList.CompleteTask(taskTitle);

            // Assert
            string displayResult = this._toDoList.DisplayTasks();
            Assert.IsTrue(displayResult.Contains("[✓]")); // Check if the completed task is marked with [✓]
        }

        [Test]
        public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
        {
            // Arrange
            const string nonExistingTaskTitle = "Non-Existing Task";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => this._toDoList.CompleteTask(nonExistingTaskTitle));
        }

        [Test]
        public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
        {
            // Act
            string displayResult = this._toDoList.DisplayTasks();

            // Assert
            Assert.AreEqual(displayResult, "To-Do List:");
        }

        [Test]
        public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
        {
            // Arrange
            this._toDoList.AddTask("Task A", DateTime.Now.AddDays(1));
            this._toDoList.AddTask("Task B", DateTime.Now.AddDays(2));
            this._toDoList.AddTask("Task C", DateTime.Now.AddDays(3));

            // Act
            string displayResult = this._toDoList.DisplayTasks();

            // Assert
            Assert.IsNotEmpty(displayResult);
            Assert.IsTrue(displayResult.Contains("To-Do List:"));
            Assert.IsTrue(displayResult.Contains("[ ] Task A - Due:"));
            Assert.IsTrue(displayResult.Contains("[ ] Task B - Due:"));
            Assert.IsTrue(displayResult.Contains("[ ] Task C - Due:"));
        }
    }
}
