# Lists, Stacks, Queues, LinkedList & HashSet — Practice Sheet (Beginner-Friendly)

We will do **Q1–Q5 in class** (guided), and **Q6–Q10** independently (practice on the same topics).
Topics: **List<T>**, **Stack<T>** (LIFO), **Queue<T>** (FIFO), **LinkedList<T>**, **HashSet<T>**.


---

## Theme A (Q1–Q5): Guided

### 1) List Basics **+ Modifications** (strings)

Create a shopping list with `List<string>`. Add items, then **insert**, **remove by index**, and **remove by value**. Finally, print count and all items with their index.

```csharp
using System;
using System.Collections.Generic;

List<string> shopping = new List<string>();
shopping.Add("Milk");
shopping.Add("Eggs");
shopping.Add("Bread");

shopping.Insert(1, "Butter");                 // Milk, Butter, Eggs, Bread
shopping.RemoveAt(shopping.Count - 1);          // remove last (Bread)
bool removed = shopping.Remove("Eggs");        // remove by value
Console.WriteLine("Removed Eggs: " + removed);

Console.WriteLine("Count: " + shopping.Count);
for (int i = 0; i < shopping.Count; i++)
{
    Console.WriteLine($"{i}: {shopping[i]}");
}
```

**Expected Output**

```
Removed Eggs: True
Count: 2
0: Milk
1: Butter
```

---

### 2) Stack Basics (LIFO)

Push page names onto a `Stack<string>` as you "visit" them. Show the current page with `Peek()`, then pop all to go back.

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

### 3) Queue Basics (FIFO)

Enqueue ticket IDs, peek the next ticket, then dequeue all while printing.

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

### 4) LinkedList Basics (strings)

Create a `LinkedList<string>` for a simple nav trail. Add pages and print them in order.

```csharp
using System;
using System.Collections.Generic;

LinkedList<string> nav = new LinkedList<string>();
nav.AddLast("Home");
nav.AddLast("Products");
nav.AddFirst("Login");

foreach (string page in nav)
{
    Console.WriteLine(page);
}
```

**Expected Output**

```
Login
Home
Products
```

---

### 5) HashSet Basics — Unique Items

Create a `HashSet<int>` with duplicates. Show that only unique values remain, and check membership.

```csharp
using System;
using System.Collections.Generic;

HashSet<int> set = new HashSet<int> { 1, 2, 2, 3 };
Console.WriteLine("Count: " + set.Count);
Console.WriteLine("Contains 2: " + set.Contains(2));
foreach (int n in set)
{
    Console.WriteLine(n);
}
```

**Expected Output** *(order may vary)*

```
Count: 3
Contains 2: True
1
2
3
```

---

## Theme B (Q6–Q10): Independent Practice (Same Concepts — *No solution code here*)

> Use only **List**, **Stack**, **Queue**, **LinkedList**, and **HashSet**. Include the exact inputs shown so your output matches. Write your own code to complete the tasks.

### 6) List Practice — Find / Sort / Reverse

**Inputs**
`List<int> nums = new List<int> { 5, 2, 9, 1, 5, 6 };`

**To‑Do**

1. Print whether the list **contains** `5`.
2. Print the index of the **first** `5`.
3. Sort the list ascending and print it.
4. Reverse the list and print it.

**Expected Output**

```
Contains 5: True
First index of 5: 0
Sorted: 1, 2, 5, 5, 6, 9
Reversed: 9, 6, 5, 5, 2, 1
```

---

### 7) Queue Practice — Processing Log in List

**Inputs**
`Queue<int> q = new Queue<int>(new [] { 11, 12, 13 });`

**To‑Do**

1. While the queue is not empty, dequeue the next ID and print `Processed: <id>`.
2. Add each processed ID to a `List<int> processed`.
3. After the loop, print the log as `Log: 11, 12, 13`.

**Expected Output**

```
Processed: 11
Processed: 12
Processed: 13
Log: 11, 12, 13
```

---

### 8) Stack Practice — Reverse Words

**Inputs**
`string sentence = "stacks use last in first out";`

**To‑Do**

1. Split the sentence into words.
2. Push each word onto a `Stack<string>`.
3. Pop all words to build a reversed sentence and print it on one line.

**Expected Output**

```
out first in last use stacks
```

---

### 9) LinkedList Practice — RemoveFirst/RemoveLast

**Inputs**
`LinkedList<int> nums = new LinkedList<int>(new int[] { 10, 20, 30 });`

**To‑Do**

1. Remove the first node.
2. Add `40` to the end.
3. Remove the last node.
4. Print all remaining values on one line separated by comma+space.

**Expected Output**

```
20, 30
```

---

### 10) HashSet Practice — Add / Remove / Contains

**Inputs**
`HashSet<string> colors = new HashSet<string> { "red", "blue" };`

**To‑Do**

1. Try to add duplicate `"red"` and new value `"green"`.
2. Remove `"blue"`.
3. Print the **Count** and then print every item on its own line (order may vary).

**Expected Output** *(example)*

```
Count: 2
red
green
```

---

## Hints (Detailed)

### General Patterns

* **Check before removing**: use `Count > 0` before `Pop()`/`Dequeue()`.
* **Printing**: for lists/linked lists, `string.Join(", ", collection)` is convenient; for sets, order is **not guaranteed**.
* **Searching**: `Contains`, `IndexOf` (first match), `LastIndexOf` (last match) on `List<T>`.
* **Order of structures**: Stack = **LIFO**; Queue = **FIFO**; LinkedList supports fast add/remove at ends; HashSet keeps **unique** items.

### Q6 Hints — List

* Use `nums.Contains(5)` and `nums.IndexOf(5)`.
* `nums.Sort()` sorts ascending; `nums.Reverse()` flips current order.
* Use `string.Join(", ", nums)` for printing sequences.

### Q7 Hints — Queue + List

* Initialize `processed` as an empty list.
* Loop: `while (q.Count > 0)` → `Dequeue()` each item, then `Add` to `processed`.
* After the loop, join with `string.Join(", ", processed)`.

### Q8 Hints — Stack

* `sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries)` gives `string[] words`.
* Push each word with `st.Push(word)`; pop while `st.Count > 0` and add to a `List<string>`.
* Finally join the reversed list with spaces.

### Q9 Hints — LinkedList

* `RemoveFirst()` and `RemoveLast()` work only if the list is non-empty.
* `AddLast(value)` appends at the end.
* `string.Join(", ", nums)` will iterate the linked list in order.

### Q10 Hints — HashSet

* Adding duplicates returns `false` and **does not** change `Count`.
* Removing a value not present returns `false`.
* Iterate with `foreach` and print items; don’t rely on order.

### Starter Template (for your solutions)

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Write your code for Q6–Q10 here.
    }
}
```
