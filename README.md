# Lists, Stacks, & Queues — Practice Sheet (Beginner-Friendly)

We will do **Q1–Q5 in class** (guided), and **Q6–Q10** independently (practice on the same topics).
Topics: **List<T>**, **Stack<T>** (LIFO), **Queue<T>** (FIFO).

---

## Theme A (Q1–Q5): Guided

### 1) List Basics (strings)

Create a shopping list with `List<string>`. Add three items and print the count and each item with its index.

```csharp
using System;
using System.Collections.Generic;

List<string> shopping = new List<string>();
shopping.Add("Milk");
shopping.Add("Eggs");
shopping.Add("Bread");

Console.WriteLine("Count: " + shopping.Count);
for (int i = 0; i < shopping.Count; i++)
{
    Console.WriteLine($"{i}: {shopping[i]}");
}
```

**Expected Output**

```
Count: 3
0: Milk
1: Eggs
2: Bread
```

---

### 2) List Modify: Insert, RemoveAt, Remove

- Insert `"Butter"` at index `1`. 
- Remove the last item by index. 
- Remove `"Eggs"` by value. Print the final list.

```csharp
using System;
using System.Collections.Generic;

List<string> shopping = new List<string> { "Milk", "Eggs", "Bread" };
shopping.Insert(1, "Butter");
shopping.RemoveAt(shopping.Count - 1); // remove last (Bread)
bool removed = shopping.Remove("Eggs"); // remove by value

Console.WriteLine("Removed Eggs: " + removed);
foreach (string item in shopping)
{
    Console.WriteLine(item);
}
```

**Expected Output**

```
Removed Eggs: True
Milk
Butter
```

---

### 3) Stack Basics (LIFO)

- Push page names onto a `Stack<string>` as you “visit” them. 
- Show the current page with `Peek()`.
- Pop all to go back.

```csharp
using System;
using System.Collections.Generic;

string[] pages = { "Home", "Products", "Cart", "Checkout" };
Stack<string> history = new Stack<string>();

foreach (string p in pages)
{
    history.Push(p);
    Console.WriteLine("Visited: " + p);
}

Console.WriteLine("Current (peek): " + history.Peek());

while (history.Count > 0)
{
    string last = history.Pop();
    Console.WriteLine("Back to: " + last);
}
```

**Expected Output**

```
Visited: Home
Visited: Products
Visited: Cart
Visited: Checkout
Current (peek): Checkout
Back to: Checkout
Back to: Cart
Back to: Products
Back to: Home
```

---

### 4) Queue Basics (FIFO) — Ticket Line

Enqueue tickets, peek the next ticket, then dequeue all while printing.

```csharp
using System;
using System.Collections.Generic;

int[] ticketIds = { 101, 102, 103, 104 };
Queue<int> tickets = new Queue<int>();

foreach (int id in ticketIds)
{
    tickets.Enqueue(id);
    Console.WriteLine("Enqueued: " + id);
}

Console.WriteLine("Next (peek): " + tickets.Peek());

while (tickets.Count > 0)
{
    int id = tickets.Dequeue();
    Console.WriteLine("Handled: " + id);
}
```

**Expected Output**

```
Enqueued: 101
Enqueued: 102
Enqueued: 103
Enqueued: 104
Next (peek): 101
Handled: 101
Handled: 102
Handled: 103
Handled: 104
```

---

### 5) Queue Processing + Log in List

Use a `Queue<int>` to process ticket IDs and keep a log of processed IDs in a `List<int>`.

```csharp
using System;
using System.Collections.Generic;

Queue<int> q = new Queue<int>(new [] { 11, 12, 13 });
List<int> processed = new List<int>();

while (q.Count > 0)
{
    int next = q.Dequeue();
    processed.Add(next);
    Console.WriteLine("Processed: " + next);
}

Console.WriteLine("Log: " + string.Join(", ", processed));
```

**Expected Output**

```
Processed: 11
Processed: 12
Processed: 13
Log: 11, 12, 13
```

---

## Theme B (Q6–Q10): Independent Practice

> Keep the inputs exactly as shown so your output matches.

### 6) List Practice — Add/Remove/Print

**Input**
`List<string> fruits = new() { "Apple", "Banana" };`
Tasks:

1. Add `"Cherry"`.
2. Insert `"Apricot"` at index `1`.
3. Remove `"Banana"`.
4. Print count and each item on its own line.
   **Expected Output**

```
Count: 3
Apple
Apricot
Cherry
```

---

### 7) List Practice — Find/Sort/Reverse

**Input**
`List<int> nums = new() { 5, 2, 9, 1, 5, 6 };`
Tasks:

1. Print whether the list **contains** `5`.
2. Print the index of the **first** `5`.
3. Sort the list and print it.
4. Reverse the list and print it.
   **Expected Output**

```
Contains 5: True
First index of 5: 0
Sorted: 1, 2, 5, 5, 6, 9
Reversed: 9, 6, 5, 5, 2, 1
```

---

### 8) Stack Practice — Reverse Words

**Input**
`string sentence = "stacks use last in first out";`
Tasks:

1. Split into words.
2. Push each word onto a `Stack<string>`.
3. Pop all words to build a reversed sentence and print it.
   **Expected Output**

```
out first in last use stacks
```

---

### 9) Queue Practice — Remaining Count

**Input**
`Queue<int> q = new(new [] { 7, 8, 9 });`
Tasks:

1. Before each `Dequeue`, print `"Remaining: X"`.
2. Dequeue and print `"Processing: <id>"`.
3. After the loop, print `"Remaining: 0"`.
   **Expected Output**

```
Remaining: 3
Processing: 7
Remaining: 2
Processing: 8
Remaining: 1
Processing: 9
Remaining: 0
```

---

### 10) Priorities to Front 

**Input**

```csharp
var tasks = new List<(string Name, int Priority)>
{
    ("T1", 1),
    ("T2", 3),
    ("T3", 2),
    ("T4", 3)
};
```

Tasks:

1. Create a **new** list where higher `Priority` comes first (3, then 2, then 1).
2. Build a `Queue<(string,int)>` from that sorted list.
3. Dequeue and print `"Serving: <Name> (<Priority>)"` for all.
   **Expected Output**

```
Serving: T2 (3)
Serving: T4 (3)
Serving: T3 (2)
Serving: T1 (1)
```

---

## Hints

* **List<T>**

  * Add/Insert: `Add(item)`, `Insert(index, item)`
  * Remove: `Remove(value)`, `RemoveAt(index)`
  * Search: `Contains`, `IndexOf`, `LastIndexOf`
  * Output helpers: `string.Join(", ", list)`, `list.ToArray()`
  * Sorting: `list.Sort()`, `list.Reverse()` (works on value types and reference types by comparer)
* **Stack<T>** (LIFO)

  * `Push(item)`, `Pop()`, `Peek()`, `Count`
  * Typical pattern: **push while reading**, then **pop while writing** to reverse order.
* **Queue<T>** (FIFO)

  * `Enqueue(item)`, `Dequeue()`, `Peek()`, `Count`
  * Typical pattern: **enqueue tasks**, then **process until Count == 0**.
* **Common pitfalls**

  * Don’t `Pop()`/`Dequeue()` on empty collections (check `Count > 0`).
  * After `RemoveAt`, indices shift; iterate carefully.
  * `ToList()` creates a **shallow** copy for reference types (inner objects are shared).
* **Printing tips**

  * For lists of primitives: `Console.WriteLine(string.Join(", ", list));`
  * For custom types, override `ToString()` or project to strings before joining.
* **Starter template**

  ```csharp
  using System;
  using System.Collections.Generic;
  using System.Linq;

  class Program
  {
      static void Main()
      {
          // Paste one question's code here and run.
      }
  }
  ```
