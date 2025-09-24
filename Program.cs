using System.Diagnostics;

class Program {
	static void Main(string[] args)
	{
		LinkedList<string> navigation = new LinkedList<string>();
		navigation.AddLast("Home");
		navigation.AddLast("Products");
		navigation.AddBefore(navigation.Find("Products"), "Product Details");
		navigation.AddFirst("Login");

		foreach (var page in navigation)
		{
			System.Console.WriteLine(page);
        }


		//part 3

		HashSet<int> storeSet = new HashSet<int>();

		
        for (int i = 0; i < 10000; i++)
		{
			var newInt = new System.Random().Next(1, 50000);
			storeSet.Add(newInt);
        }
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Contains 100: " + storeSet.Contains(100)); //fast membership test
        stopwatch.Stop();
        Console.WriteLine("Count: " + storeSet.Count);
		Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");

		//SortedSet
		SortedSet<int> numbers = new SortedSet<int>();
		numbers.Add(5);
		numbers.Add(1);
		numbers.Add(3);
		numbers.Add(3); // Duplicate, will be ignored
		numbers.Add(4);
		Debug.WriteLine("Numbers in ascending order:");
		foreach (int n in numbers)
		{
			Debug.WriteLine(n);
		}
		Debug.WriteLine("Numbers in descending order:");
		for (int i = numbers.Count - 1; i >= 0; i--)
		{
			Console.WriteLine(numbers.ElementAt(i));
        }





    }
}