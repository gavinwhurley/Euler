/*
	https://projecteuler.net/problem=3
	The prime factors of 13195 are 5, 7, 13 and 29.
	What is the largest prime factor of the number 600851475143 ?
*/

var factorMe = 12;
var factors = new List<int>();
Console.WriteLine("Factoring {0}", factorMe);

AddFactor(factorMe, ref factors);

foreach(var factor in factors)
{
	Console.WriteLine(factor);
}

public void AddFactor(int FactorMe, ref List<int> FactorList)
{
	var divisor = 2;
	do
	{
		var remainder = FactorMe % divisor;
		Console.WriteLine("{0} = {1} % {2}", remainder, FactorMe, divisor);
		
		if (divisor == FactorMe / 2)
		{
			break;
		}
		if (remainder == 0)
		{
			FactorList.Add(divisor);
			AddFactor(FactorMe/divisor, ref FactorList);
			break;
		}
		divisor++;
	} while (1 == 1);

}

