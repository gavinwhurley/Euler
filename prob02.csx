
// https://projecteuler.net/problem=2

// declare the variables outside the recursion

// global variables
var sb = new StringBuilder();
var sum = 0;

// passed by reference into the recursive function
var a = 0;
var b = 1;

// kick it off
Fib(ref a, ref b);

// print result
Console.WriteLine(sb.ToString());
Console.WriteLine("Sum of all even numbers below 4 million = {0}",sum);

public void Fib(ref int a, ref int b)
{
	// this is the recursion-breaker; it's called a base case, although
	//  I think that's backwards and this is tail-recursion
	if (b > 4000000) return;

	// print current value
	sb.Append(String.Format("{0}, ",b));
 	if (b % 2 == 0)
 		sum = sum + b;

	// compute
	var c = b;
	b = a + b;
	a = c;	

	// recurse
	Fib(ref a, ref b);
}
