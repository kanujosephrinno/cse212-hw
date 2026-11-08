using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Testing wether the highest priority item is removed first from the queue.
    // Expected Result: Mry, John, Peter.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("John", 2);
priorityQueue.Enqueue("Mary", 5);
priorityQueue.Enqueue("Peter", 1);

Assert.AreEqual("Mary", priorityQueue.Dequeue());
Assert.AreEqual("John", priorityQueue.Dequeue());
Assert.AreEqual("Peter", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    { 
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alice", 4);
        priorityQueue.Enqueue("Bob", 4);
        priorityQueue.Enqueue("Peter", 2);

        Assert.AreEqual("Alice", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Peter", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
public void TestPriorityQueue_Empty()
{
    var priorityQueue = new PriorityQueue();

    Assert.ThrowsException<InvalidOperationException>(
        () => priorityQueue.Dequeue());
}
}