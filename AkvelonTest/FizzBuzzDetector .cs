namespace AkvelonTest
{
	public class FizzBuzzDetector
	{
		public FizzBuzzResult GetOverlappings(string input)
		{
			if (string.IsNullOrEmpty(input))
				return new FizzBuzzResult { OutputString = "", Count = 0 };

			string[] words = input.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
			int count = 0;
			var outputWords = new List<string>();

			for (int i = 0; i < words.Length; i++)
			{
				int wordNum = i + 1;
				string word = words[i];

				if (wordNum % 15 == 0)
				{
					outputWords.Add("FizzBuzz");
					count++;
				}
				else if (wordNum % 3 == 0)
				{
					outputWords.Add("Fizz");
					count++;
				}
				else if (wordNum % 5 == 0)
				{
					outputWords.Add("Buzz");
					count++;
				}
				else
				{
					outputWords.Add(word);
				}
			}

			return new FizzBuzzResult
			{
				OutputString = string.Join(" ", outputWords),
				Count = count
			};
		}
	}
}
