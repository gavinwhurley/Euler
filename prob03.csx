/*
	https://projecteuler.net/problem=3
	The prime primeFactors of 13195 are 5, 7, 13 and 29.
	What is the largest prime factor of the number 600851475143 ?
*/

var factorMe = 600851475143;
// every number can be divided by one and itself
var primeFactors = new List<long>();

Console.WriteLine("Factoring {0}", factorMe);

// fill in the list
for(long i=1; i<factorMe; i++)
{
	if (factorMe % i == 0 && IsPrime(i))
		primeFactors.Add(i);
}

// find the greatest one
Console.WriteLine("Greatest prime factor of {0}: {1}", factorMe, primeFactors.Last());

// next problem: find the greatest prime factor
//  and we have to use long integers

private Boolean IsPrime(long number)
{
	if (number == 1) return true;

	for(long l = 2; l < number; l++)
	{
		if (number % l == 0)
		{
			return false;
		}
	} 
	return true;
}

