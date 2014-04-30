#/usr/bin/python
# https://projecteuler.net/problem=2
# By considering the terms in the Fibonacci sequence whose values do not exceed
# four million, find the sum of the even-valued terms.

def GetFib(n):
	if n == 0 or n ==1:
		return 1
	return GetFib(n-1) + GetFib(n-2)

def main():
	# the problem with this approach is I don't know how to stop when I get to 
	#  four million.  
	answer = 0
	x = 0
	n = 0

	while n < 4000000:
		n = GetFib(x)
		if n % 2 == 0:
			answer += n
		x =  x + 1
	print(answer)

if __name__ == '__main__':
	main()

# this is horribly inefficient because it's computing the whole series for 
# each counter integer.  This version sucks.  