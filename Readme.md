# Data Structures

## 1. Introduction
1. **Data Types** - Explanation of different types of data in programming.
2. **Reference Type** - Understanding objects stored by reference.
3. **Value Type** - How value types store data directly in memory.
4. **Storing Data in Computer Memory** - Overview of how data is managed in memory.

## 2. Array
1. **Introduction and Basic Concepts** - Fundamentals of arrays and their importance.
2. **Static Array** - Arrays with fixed size and their characteristics.
3. **Dynamic Array** - Resizable arrays and how they manage memory.
4. **Array Operations** - Common operations like insertion, deletion, searching, and sorting.
5. **Application Areas of Arrays** - Practical applications of arrays in real-world scenarios.


## 3. Singly Linked List  
1. **Introduction and Basic Concepts** - Understanding singly linked lists and their significance in data structures.  
2. **Node Structure** - Explanation of the `SinglyLinkedListNode` class, which stores data and a pointer to the next node.  
3. **Singly Linked List Operations**  
   - **Insertion** - Adding elements at the beginning, end, or a specific position.  
   - **Deletion** - Removing the first, last, or a specific node.  
   - **Traversal** - Iterating through the linked list using an enumerator.  
   - **Searching** - Finding a specific node in the list.  
4. **Memory Management in Singly Linked Lists** - How nodes are dynamically allocated and deallocated.  
5. **Application Areas of Singly Linked Lists** - Practical uses in software development, such as queue implementations, undo features, and memory-efficient data storage.  

## 4. Stack  
1. **Introduction and Basic Concepts**  
   - Understanding the LIFO (Last-In, First-Out) principle that defines a stack.  
   - Real-world analogies like a stack of plates or books.  
   - Importance in algorithm design and memory management.

2. **Stack Structure**  
   - Explanation of the internal structure of a stack.  
   - Common implementations using arrays and linked lists.  
   - Core components: `push`, `pop`, `peek`, and `isEmpty` operations.

3. **Stack Operations**  
   - **Push** - Adding an element to the top of the stack.  
   - **Pop** - Removing the top element from the stack.  
   - **Peek (or Top)** - Viewing the top element without removing it.  
   - **IsEmpty** - Checking if the stack is empty.  
   - **Size** - Getting the number of elements in the stack.

4. **Memory Management in Stack**  
   - Stack memory allocation and deallocation.  
   - Call stack usage during function execution.  
   - Stack overflow issues and limitations in memory-constrained environments.

5. **Application Areas of Stacks**  
   - Function call management in programming languages (call stack).  
   - Expression evaluation and syntax parsing.  
   - Backtracking algorithms (e.g., maze solving, undo operations).  
   - Depth-First Search (DFS) in graph traversal.  

## 5. Queue

### 1. Introduction and Basic Concepts
- Understanding the FIFO (First-In, First-Out) principle that defines a queue.
- Real-world analogies such as queues in supermarkets or print job scheduling.
- Importance in algorithm design, scheduling, and resource management.

### 2. Queue Structure
- Explanation of the internal structure of a queue.
- Common implementations using arrays, linked lists, and circular buffers.
- Core components: `enqueue`, `dequeue`, `peek`, and `isEmpty` operations.

### 3. Queue Operations
- **Enqueue** - Adding an element to the rear (end) of the queue.
- **Dequeue** - Removing an element from the front of the queue.
- **Peek (or Front)** - Viewing the front element without removing it.
- **IsEmpty** - Checking if the queue is empty.
- **Size** - Getting the number of elements currently stored in the queue.

### 4. Memory Management in Queue
- Dynamic vs. static memory allocation for queues.
- Circular queue implementations to optimize space utilization.
- Buffer overflow/underflow issues and preventive mechanisms.

### 5. Application Areas of Queues
- Scheduling processes in operating systems (CPU scheduling, IO queues).
- Managing print jobs in printers (print spooling).
- Breadth-First Search (BFS) in graph traversal.
- Simulation systems (e.g., customer service systems, traffic flow models).
- Message queues in distributed systems and asynchronous programming.

## 6. Sorting Algorithms

### 1. Introduction to Sorting Algorithms
- Importance of sorting in computer science.
- Comparison of different sorting techniques based on time complexity, space complexity, and stability.

### 2. Bubble Sort
- Simple comparison-based algorithm.
- Repeatedly swaps adjacent elements if they are in the wrong order.
- **Best case**: O(n), **Worst case**: O(n²), **Space**: O(1).

### 3. Insertion Sort
- Builds the final sorted array one element at a time.
- Good for small or nearly sorted datasets.
- **Best case**: O(n), **Worst case**: O(n²), **Space**: O(1).

### 4. Selection Sort
- Repeatedly finds the minimum element and moves it to the sorted portion.
- Always O(n²) time complexity.
- Not stable but simple to implement.

### 5. Merge Sort
- Divide-and-conquer algorithm that divides the list into halves, sorts them, and merges.
- **Time complexity**: O(n log n) in all cases.
- **Space complexity**: O(n).

### 6. Quick Sort
- Divide-and-conquer algorithm that picks a pivot and partitions the array.
- **Best/Average case**: O(n log n), **Worst case**: O(n²) (can be improved with randomized pivot).
- **Space**: O(log n) due to recursion stack.

### 7. `Sorting.cs` - Main Controller
- Central entry point to call and compare different sorting methods.
- Useful for benchmarking or switching between algorithms dynamically.

