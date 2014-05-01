/*
	https://projecteuler.net/problem=3
	The prime factors of 13195 are 5, 7, 13 and 29.
	What is the largest prime factor of the number 600851475143 ?
*/

var factorMe = 12;
// every number can be divided by one and itself
var factors = new List<long>();

Console.WriteLine("Factoring {0}", factorMe);

// fill in the list
foreach(var increment in Enumerable.Range(2, factorMe/2))
{
	if (factorMe % increment == 0 && IsPrime(increment))
		factors.Add(increment);
}

// print it out
foreach(var factor in factors)
{
	Console.WriteLine(factor);
}

// find the greatest one
Console.WriteLine("Greatest factor: {0}", factors.Last());

// next problem: find the greatest prime factor
//  and we have to use long integers

private Boolean IsPrime(long number)
{
	for(var l = 1; l < number/2; l++)
	{
		if (number % l == 0)
		{
			return true;
		}
	} 
	return false;
}

