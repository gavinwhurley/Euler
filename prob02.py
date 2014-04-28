#/usr/bin/python
# https://projecteuler.net/problem=2

def fib(n, m):
	if (m > 400000):
		return

	print(m)

	c = n
	m = n + m
	n = c

	fib(n, m)

def Countdown(n):
	print(n)
	if n == 0: 
		return
	Countdown(n-1)

def GetFib(n):

	if n == 1 or n ==2:
		return 1
	return GetFib(n-1) + GetFib(n-2)

def main():
	a, b, c = 0, 1, 0
	
	#fib(a,b)

	print(GetFib(10))

#	This works great, but I want to go recursive
#	for x in xrange(1,20):
#		print(b)
#
#		c = b
#		b = a + b
#		a = c

if __name__ == '__main__':
	main()

