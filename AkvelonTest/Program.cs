namespace AkvelonTest
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your text (press Enter twice to finish):");

			string input = "";
			string line;

			while ((line = Console.ReadLine()) != "")
			{
				input += line + "\n";
			}

			var detector = new FizzBuzzDetector();
			var result = detector.GetOverlappings(input);

			Console.WriteLine("\nResult:");
			Console.WriteLine(result.OutputString);
			Console.WriteLine($"\ncount: {result.Count}");
		}
	}
}
