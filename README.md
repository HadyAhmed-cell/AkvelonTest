# AkvelonTest

first of all i allow the user the enter multiple lines as input by providing for loop using while the input line is not empty it will add the input line to string input with the new line separator

The FizzBuzz Detector : 

 - i am checking at first if the string is null or empty it should return the default values for the output
 - if the input is not empty , it will separate every word in the input by using the delimeters to acquire array of string of words
 - then i am using for loop on the words lengh but with 1-index based "wordNum" so that so avoid counting the first word as fizz
 - the app checks if the word number is divisible by 3 then it's a Fizz , if it's divisible by 5 then it's a Buzz and if it's divisible by 15 ( which is divisble by 3 and 5 ) then it's both fizz and buzz
 - otherwise it shall add the word normally
