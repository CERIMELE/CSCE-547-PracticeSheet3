# LinkedList, HashSet, SortedList & SortedSet — Practice Sheet

We will do **Q1–Q5 in class** (guided), and **Q6–Q10** independently (practice on the same topics).
**Concepts only in this sheet:** **LinkedList<T>**, **HashSet<T>**, **SortedList\<TKey,TValue>**, **SortedSet<T>**.


---

## Theme A (Q1–Q5): Guided

### 1) LinkedList Basics (strings)

Create a navigation trail with `LinkedList<string>`. Add pages at both ends and print them in order.

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

### 2) LinkedList Modify: AddBefore/AddAfter/Remove

Find a node by value and insert relatives; then remove one.

```csharp
using System;
using System.Collections.Generic;

LinkedList<string> steps = new LinkedList<string>();
steps.AddLast("Start");
steps.AddLast("Middle");
steps.AddLast("End");

LinkedListNode<string>? mid = steps.Find("Middle");
if (mid != null)
{
    steps.AddBefore(mid, "Prep");   // Start, Prep, Middle, End
    steps.AddAfter(mid,  "Post");   // Start, Prep, Middle, Post, End
}

steps.Remove("Prep");               // Start, Middle, Post, End

foreach (var s in steps) {
    Console.WriteLine(s);
}
```

**Expected Output**

```
Start
Middle
Post
End
```

---

### 3) HashSet Basics — Uniqueness & Contains

Show that duplicates are ignored and membership checks are fast.

```csharp
using System;
using System.Collections.Generic;

HashSet<int> set = new HashSet<int> { 1, 2, 2, 3 };
Console.WriteLine("Count: " + set.Count);
Console.WriteLine("Contains 2: " + set.Contains(2));
foreach (int n in set) {
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

### 4) SortedList\<TKey,TValue> — Auto-Sorted by Key

Add items **out of order** and observe sorted-by-key iteration.

```csharp
using System;
using System.Collections.Generic;

SortedList<int, string> codes = new SortedList<int, string>();
codes.Add(20, "Beta");
codes.Add(10, "Alpha");
codes.Add(30, "Gamma");

Console.WriteLine("By Keys:");
foreach (var k in codes.Keys) {
    Console.WriteLine(k);
}

Console.WriteLine("Key: Value:");
foreach (var kv in codes) {
    Console.WriteLine(kv.Key + ": " + kv.Value);
}
Console.WriteLine("Lookup 20: " + codes[20]);
```

**Expected Output**

```
By Keys:
10
20
30
Key: Value:
10: Alpha
20: Beta
30: Gamma
Lookup 20: Beta
```

---

### 5) SortedSet<T> — Ordered Set Operations

Add items (with a duplicate), then show ascending and descending order, plus Min/Max.

```csharp
using System;
using System.Collections.Generic;

SortedSet<int> nums = new SortedSet<int>();
nums.Add(5);
nums.Add(1);
nums.Add(3);
nums.Add(3); // duplicate ignored

Console.WriteLine("Ascending:");
foreach (int n in nums) {
    Console.Write(n + " ");
}
Console.WriteLine();

Console.WriteLine("Descending:");
foreach (int n in nums.Reverse()) {
    Console.Write(n + " ");
}
Console.WriteLine();

Console.WriteLine("Min: " + nums.Min + ", Max: " + nums.Max);
```

**Expected Output**

```
Ascending:
1 3 5 
Descending:
5 3 1 
Min: 1, Max: 5
```

---

## Theme B (Q6–Q10): Independent Practice

> Use only **LinkedList<T>**, **HashSet<T>**, **SortedList\<TKey,TValue>**, and **SortedSet<T>**. Include the exact inputs shown so your output matches. Write your own code to complete the tasks.

### 6) LinkedList — Ends & Iteration

**Inputs**
`LinkedList<int> ll = new LinkedList<int>(new int[] { 10, 20, 30 });`

**To‑Do**

1. Add `5` to the **front** and `40` to the **back**.
2. Remove the **first** node.
3. Print all values on one line separated by comma+space.

**Expected Output**

```
20, 30, 40
```

---

### 7) LinkedList — Backward Walk

**Inputs**
`LinkedList<string> words = new LinkedList<string>(new[] { "A", "B", "C", "D" });`

**To‑Do**

1. Start from `words.Last` and walk backwards via `.Previous`.
2. Print the items on one line separated by spaces.

**Expected Output**

```
D C B A
```

---

### 8) HashSet — Union & Intersection (Basics)

**Inputs**
`HashSet<int> a = new HashSet<int> { 1, 2, 3 };`
`HashSet<int> b = new HashSet<int> { 3, 4, 5 };`

**To‑Do**

1. Create a **union** of `a` and `b` and print its elements (order may vary).
2. Create an **intersection** of `a` and `b` and print its elements (order may vary).

**Expected Output** *(example)*

```
Union: 1 2 3 4 5
Intersection: 3
```

---

### 9) SortedList — Keys & Values in Order

**Inputs**
`SortedList<string, int> stock = new SortedList<string, int>();` with adds: `("Banana", 8)`, `("Apple", 12)`, `("Cherry", 6)`

**To‑Do**

1. Add the pairs in the order above.
2. Print **Keys** in order on one line.
3. Print `Key: Value` pairs each on its own line.

**Expected Output**

```
Keys: Apple Banana Cherry
Apple: 12
Banana: 8
Cherry: 6
```

---

### 10) SortedSet — Range & Remove

**Inputs**
`SortedSet<int> s = new SortedSet<int> { 2, 4, 6, 8, 10 };`

**To‑Do**

1. Add `1` and `9`.
2. Remove `4`.
3. Print the set in ascending order on one line.
4. Print the set in descending order on one line.

**Expected Output**

```
Ascending: 1 2 6 8 9 10
Descending: 10 9 8 6 2 1
```

---

## Hints (Detailed)

### LinkedList<T>

* **Add/Remove ends**: `AddFirst`, `AddLast`, `RemoveFirst`, `RemoveLast`.
* **Find & insert relative**: `Find(value)` returns a node; then `AddBefore(node, v)` or `AddAfter(node, v)`.
* **Walk backwards**: start at `list.Last`, then follow `.Previous` until `null`.
* **Printing**: `string.Join(", ", list)` iterates in stored order.

### HashSet<T>

* **Uniqueness**: duplicates are ignored; `Add(value)` returns `false` if already present.
* **Membership**: `Contains(value)` is O(1) average.
* **Set ops**: `UnionWith`, `IntersectWith`, `ExceptWith` modify a set in place. For a non‑destructive result, copy first.

### SortedList\<TKey,TValue>

* Maintains **ascending key order**; fast lookups by key: `list[key]`.
* Iterate `Keys` or `Values` collections; enumerating `foreach (var kv in list)` yields items by key order.
* Keys must be **unique**; use `ContainsKey` before `Add` to avoid exceptions.

### SortedSet<T>

* Maintains items in **ascending order** automatically; duplicates are ignored.
* `Min`/`Max` give smallest/largest; `Remove`, `Contains` are O(log n).
* Descending view: iterate `foreach (var x in set.Reverse())`.

### Starter Template (for Q6–Q10 solutions)

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
