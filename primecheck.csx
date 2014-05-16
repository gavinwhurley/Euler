// a prime number is only divisible by one and itself
private Boolean IsPrime(long number)
{
	if (number == 1) return true;

	for(long l = 2; l <= Math.Sqrt(number); l++)
	{
		if (number % l == 0.0)
		{
			return false;
		}
	} 
	return true;
}

var upperRange = 100;

Console.WriteLine("Prime numbers between 1 and {0}", upperRange);

foreach(var checkThis in Enumerable.Range(1, upperRange))
{
	if (IsPrime(checkThis))
	{
		Console.WriteLine(checkThis);
	}
}