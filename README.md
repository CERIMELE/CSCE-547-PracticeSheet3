# Practice Sets — Overview

This repository contains **two parts** of beginner-friendly C# collection practice. Use them independently or in sequence.

---

## Part 1 — Lists, Stacks, & Queues (Beginner)

**What’s inside**

* Guided questions (**Q1–Q5**) covering:

  * `List<T>` basics and modifications (add/insert/remove, search, sort/reverse)
  * `Stack<T>` (LIFO): `Push`, `Pop`, `Peek`, `Count`
  * `Queue<T>` (FIFO): `Enqueue`, `Dequeue`, `Peek`, `Count`
* Independent practice (**Q6–Q10**) using the same concepts with provided inputs and expected outputs (no solution code).

**Learning goals**

* Understand linear collections and their typical operations and order semantics.
* Practice reading/writing elements and producing the *exact* expected output.

---

## Part 2 — LinkedList, HashSet, SortedList & SortedSet (Beginner)

**What’s inside**

* Guided questions (**Q1–Q5**) covering:

  * `LinkedList<T>`: `AddFirst`/`AddLast`, `AddBefore`/`AddAfter`, `RemoveFirst`/`RemoveLast`, iterating forward/backward
  * `HashSet<T>`: uniqueness, `Add`, `Remove`, `Contains`, basic set operations
  * `SortedList<TKey,TValue>`: auto-sorted by key, `Keys`/`Values`, lookups
  * `SortedSet<T>`: ordered set semantics, `Min`/`Max`, `Reverse()`
* Independent practice (**Q6–Q10**) using the same concepts with inputs and expected outputs (no solution code).

**Learning goals**

* Work with node-based lists, sets, and sorted collections.
* Compare behavior around ordering, uniqueness, and typical operations.

---


## Requirements

* .NET SDK (tested with .NET 8)
* Any C#-friendly editor (VS Code, Visual Studio, Rider, etc.)

**Run** (example for a console project):

```bash
dotnet build
dotnet run
```

---

## Notes

* Part 1 focuses on **Lists, Stacks, Queues**.
* Part 2 focuses on **LinkedList, HashSet, SortedList, SortedSet**.
