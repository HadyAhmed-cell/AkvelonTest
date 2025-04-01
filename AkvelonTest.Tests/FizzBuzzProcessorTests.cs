using AkvelonTest;

public class FizzBuzzProcessorTests
{
	private readonly FizzBuzzDetector _detector = new FizzBuzzDetector();

	[Fact]
	public void ProcessText_EmptyInput_ReturnsEmptyResult()
	{
		// Arrange
		var input = "";

		// Act
		var result = _detector.GetOverlappings(input);

		// Assert
		Assert.Equal("", result.OutputString);
		Assert.Equal(0, result.Count);
	}

	[Fact]
	public void ProcessText_NullInput_ReturnsEmptyResult()
	{
		// Arrange
		string input = null;

		// Act
		var result = _detector.GetOverlappings(input);

		// Assert
		Assert.Equal("", result.OutputString);
		Assert.Equal(0, result.Count);
	}

	[Fact]
	public void ProcessText_FizzBuzz_ReplacesCorrectWords()
	{
		// Arrange
		var input = string.Join(" ", new string[30].Select((_, i) => $"Word{i + 1}"));

		// Act
		var result = _detector.GetOverlappings(input);

		// Assert
		Assert.Contains("FizzBuzz", result.OutputString);
		Assert.Contains("Fizz", result.OutputString);
		Assert.Contains("Buzz", result.OutputString);
		Assert.Equal(14, result.Count);
	}

	[Fact]
	public void ProcessText_MultiLineInput_HandlesCorrectly()
	{
		// Arrange
		var input = "First Second Third\nFourth Fifth Sixth\nSeventh Eighth Ninth Tenth";

		// Act
		var result = _detector.GetOverlappings(input);

		// Assert
		Assert.Equal("First Second Fizz Fourth Buzz Fizz Seventh Eighth Fizz Buzz", result.OutputString);
		Assert.Equal(5, result.Count);
	}

	[Fact]
	public void ProcessText_ExtraWhitespace_HandlesCorrectly()
	{
		// Arrange
		var input = "  One   Two  Three  Four  Five  ";

		// Act
		var result = _detector.GetOverlappings(input);

		// Assert
		Assert.Equal("One Two Fizz Four Buzz", result.OutputString);
		Assert.Equal(2, result.Count);
	}

	[Fact]
	public void ProcessText_MixedCaseWords_PreservesOriginalCase()
	{
		// Arrange
		var input = "ONE two ThReE four FIVE";

		// Act
		var result = _detector.GetOverlappings(input);

		// Assert
		Assert.Equal("ONE two Fizz four Buzz", result.OutputString);
		Assert.Equal(2, result.Count);
	}
}