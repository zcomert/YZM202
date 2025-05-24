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

## 7. Algorithm Analysis Techniques

### 1. Time Complexity
- Time complexity describes how the runtime of an algorithm increases with the size of the input.
- Helps evaluate the efficiency of algorithms.
- Common complexities:
  - **O(1)** – Constant time
  - **O(log n)** – Logarithmic time
  - **O(n)** – Linear time
  - **O(n log n)** – Linearithmic time
  - **O(n²)** – Quadratic time
  - **O(2ⁿ), O(n!)** – Exponential time

### 2. Asymptotic Notation
- Used to describe the upper, lower, or tight bound behavior of an algorithm:
  - **Big O (O)** – Worst-case upper bound  
    Example: O(n²) means the runtime grows at most as n².
  - **Big Omega (Ω)** – Best-case lower bound  
    Example: Ω(n) means the algorithm takes at least linear time.
  - **Big Theta (Θ)** – Tight bound (both upper and lower)  
    Example: Θ(n log n) means the runtime grows exactly at that rate.

### 3. Substitution Method
- A method to solve recurrence relations by guessing the form of the solution and proving it using mathematical induction.
- **Example:**
  - T(n) = 2T(n/2) + n  
  - Guess: T(n) = O(n log n)  
  - Prove the guess using induction.

### 4. Iteration Method
- Solves recurrence relations by expanding them step by step until a pattern is observed.
- **Example:**
  - T(n) = T(n/2) + n  
  - T(n/2) = T(n/4) + n/2  
  - …
  - Total = n + n/2 + n/4 + … = O(n)

### 5. Master Theorem
- Provides a direct way to analyze the time complexity of divide-and-conquer algorithms.
- Applies to recurrences of the form:  
  **T(n) = aT(n/b) + f(n)**  
- **Cases:**
  1. If f(n) = O(n^log_b(a - ε)) → T(n) = Θ(n^log_b(a))
  2. If f(n) = Θ(n^log_b(a)) → T(n) = Θ(n^log_b(a) * log n)
  3. If f(n) = Ω(n^log_b(a + ε)) and regularity condition holds → T(n) = Θ(f(n))
- **Example:**
  - Merge Sort: T(n) = 2T(n/2) + n → Case 2 → Θ(n log n)


  ## 8. Tree, Binary Tree, Binary Search Tree

### 1. Tree
- A **tree** is a hierarchical data structure consisting of nodes.
- The top node is called the **root**; nodes without children are called **leaves**.
- Each node (except the root) has exactly one parent.
- Trees are used in many applications like file systems, databases, and parsing expressions.
- **Terminology:**
  - **Parent, Child, Sibling**
  - **Subtree**: A tree formed by a node and its descendants.
  - **Depth**: Number of edges from root to node.
  - **Height**: Number of edges on the longest path from node to a leaf.

### 2. Binary Tree
- A **binary tree** is a tree where each node has at most two children: **left** and **right**.
- Types of binary trees:
  - **Full Binary Tree**: Every node has 0 or 2 children.
  - **Complete Binary Tree**: All levels are filled except possibly the last, which is filled from left to right.
  - **Perfect Binary Tree**: All internal nodes have two children and all leaves are at the same level.
- Common traversals:
  - **Inorder (Left, Root, Right)**
  - **Preorder (Root, Left, Right)**
  - **Postorder (Left, Right, Root)**
  - **Level-order (Breadth-First Search)**

### 3. Binary Search Tree (BST)
- A **Binary Search Tree** is a binary tree with the property:
  - For any node `n`:  
    - All values in the left subtree < `n.value`  
    - All values in the right subtree > `n.value`
- Operations:
  - **Search**: O(h) time complexity (h = tree height)
  - **Insert**: O(h)
  - **Delete**: O(h)
- Best case: **Balanced BST** → O(log n)  
- Worst case: **Unbalanced BST** (like a linked list) → O(n)
- BSTs are used in:
  - Dynamic sets
  - Searching and sorting
  - Dictionary implementations


## 9. Heap, Binary Heap, Min Heap, Max Heap

### 1. Heap
- A **heap** is a special **tree-based** data structure that satisfies the **heap property**.
- It is usually implemented as a **complete binary tree**.
- **Heap property**:
  - In a **Max Heap**: Parent node ≥ Children
  - In a **Min Heap**: Parent node ≤ Children
- Common uses:
  - **Priority queues**
  - **Heap Sort**
  - **Task scheduling**

### 2. Binary Heap
- A **binary heap** is a **complete binary tree** that satisfies the **heap property**.
- Typically implemented using an **array**:
  - For a node at index `i`:
    - Left child → `2i + 1`
    - Right child → `2i + 2`
    - Parent → `(i - 1) / 2`

### 3. Min Heap
- A **Min Heap** is a binary heap where:
  - The **root** contains the **smallest** element.
  - Each parent node ≤ its children.
- Operations:
  - **Insert**: O(log n)
  - **Extract-Min**: O(log n)
  - **Peek-Min**: O(1)
- Applications:
  - **Dijkstra’s algorithm**
  - **Minimum spanning tree (Prim’s algorithm)**
  - **Event simulation**

### 4. Max Heap
- A **Max Heap** is a binary heap where:
  - The **root** contains the **largest** element.
  - Each parent node ≥ its children.
- Operations:
  - **Insert**: O(log n)
  - **Extract-Max**: O(log n)
  - **Peek-Max**: O(1)
- Applications:
  - **Heap Sort**
  - **Priority queues**
  - **Finding the k largest elements**

## 9. Disjoint Set (Union-Find)

### 1. Disjoint Set
- A **Disjoint Set** (also known as **Union-Find**) is a data structure that keeps track of a partition of elements into **disjoint (non-overlapping) subsets**.
- It provides efficient support for the following operations:
  - **MakeSet(x)**: Creates a set containing a single element `x`.
  - **FindSet(x)**: Returns the representative (or "leader") of the set that contains `x`.
  - **Union(x, y)**: Merges the sets containing elements `x` and `y`.

### 2. Disjoint Set Representation
- Internally, each set is represented as a **tree**, with each node pointing to its **parent**.
- The **representative** of a set is the **root** of its tree.
- Optimizations:
  - **Path Compression**: Flattens the structure of the tree whenever `FindSet` is called, speeding up future queries.
  - **Union by Rank / Size**: Always attach the smaller tree to the root of the larger one to keep trees shallow.

### 3. Operations and Complexity

| Operation      | Description                                | Time Complexity |
|----------------|--------------------------------------------|-----------------|
| `MakeSet(x)`   | Initializes a new set with element `x`     | O(1)            |
| `FindSet(x)`   | Returns the root of the set containing `x` | O(α(n))         |
| `Union(x, y)`  | Merges the sets containing `x` and `y`     | O(α(n))         |

> 🔹 Here, `α(n)` is the **inverse Ackermann function**, which grows extremely slowly. For all practical values of `n`, it is ≤ 5.

### 4. Applications
- **Kruskal’s algorithm** for finding the **Minimum Spanning Tree**
- **Connected component detection** in graphs
- **Image segmentation** in computer vision
- **Network connectivity** checking
- **Cycle detection** in undirected graphs

## 10. Graph (Graf)

### 1. Graph Nedir?
- Bir **Graph (Graf)**, **düğümler (nodes / vertices)** ve bu düğümler arasındaki **kenarlardan (edges)** oluşan bir veri yapısıdır.
- Temel graf türleri:
  - **Directed Graph (Yönlü Graf)**: Kenarlar yönlüdür. Örnek: `A → B`
  - **Undirected Graph (Yönsüz Graf)**: Kenarlar çift yönlüdür. Örnek: `A — B`
  - **Weighted Graph (Ağırlıklı Graf)**: Kenarlara sayısal ağırlıklar atanır. Örnek: `A —(3)— B`

### 2. Graph Temsili

| Temsil Şekli         | Açıklama                                                                 | Bellek Karmaşıklığı |
|----------------------|--------------------------------------------------------------------------|----------------------|
| **Adjacency Matrix** | NxN matris, `matrix[i][j] = 1` ise `i`'den `j`'ye kenar vardır            | O(V²)                |
| **Adjacency List**   | Her düğüm için bir liste, sadece bağlı düğümler tutulur                   | O(V + E)             |
| **Edge List**        | Tüm kenarlar (ve gerekirse ağırlıkları) `(u, v)` ya da `(u, v, w)` şeklinde tutulur | O(E)       |

> 🔹 `V`: Düğüm sayısı (vertex), `E`: Kenar sayısı (edge)

### 3. Temel İşlemler ve Karmaşıklıklar

| İşlem                   | Açıklama                                                   | Liste (Adj. List) | Matris (Adj. Matrix) |
|------------------------|------------------------------------------------------------|-------------------|----------------------|
| `AddVertex(v)`         | Yeni bir düğüm ekler                                       | O(1)              | O(V²) (yeniden yapılandırma) |
| `AddEdge(u, v)`        | İki düğüm arasında kenar oluşturur                         | O(1)              | O(1)                 |
| `RemoveEdge(u, v)`     | Kenarı siler                                               | O(E)              | O(1)                 |
| `HasEdge(u, v)`        | Kenar olup olmadığını kontrol eder                         | O(E) / O(1)       | O(1)                 |
| `Neighbors(v)`         | Komşu düğümleri döner                                      | O(degree(v))      | O(V)                 |
| `DFS / BFS`            | Derinlik veya genişlik öncelikli arama                     | O(V + E)          | O(V²)                |

### 4. Graf Türleri

| Tür                   | Özellikler                                                                 |
|-----------------------|----------------------------------------------------------------------------|
| **Directed Graph**     | Kenarların yönü vardır (`u → v`)                                           |
| **Undirected Graph**   | Kenarlar çift yönlüdür (`u — v`)                                           |
| **Weighted Graph**     | Kenarlar ağırlıklıdır (`u —[w]→ v`)                                        |
| **Cyclic / Acyclic**   | Döngü içeren veya içermeyen grafikler                                     |
| **Connected / Disconnected** | Tüm düğümler birbirine bağlıysa bağlı (connected) olarak adlandırılır   |

### 5. Uygulamalar

- **Yol bulma algoritmaları** (Dijkstra, A*, Bellman-Ford)
- **Minimum Spanning Tree** (Kruskal, Prim)
- **Topolojik sıralama**
- **Sosyal ağ analizleri**
- **İletişim ağları**
- **Görüntü işleme** (bölge etiketleme, segmentasyon)
- **Veri akışı ve planlama sistemleri**

### 6. Önemli Grafik Algoritmaları

| Algoritma             | Kullanım Alanı                               |
|-----------------------|----------------------------------------------|
| **DFS / BFS**         | Bağlı bileşen bulma, yol kontrolü            |
| **Dijkstra**          | Tek kaynaklı en kısa yol                     |
| **Bellman-Ford**      | Negatif ağırlık destekli en kısa yol         |
| **Floyd-Warshall**    | Tüm çiftler arasında en kısa yollar          |
| **Kruskal / Prim**    | Minimum Spanning Tree (MST)                 |
| **Topological Sort**  | Bağımlı görev planlaması (DAG yapıları)      |
| **Tarjan / Kosaraju** | Strongly Connected Components (SCC) tespiti  |

