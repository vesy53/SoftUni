// p12.NumbersOfFibonacci.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int previous_fib = 0;
	int current_fib = 1;

	if (num < 2)
	{
		cout << 1 << endl;
	}
	else
	{
		for (int i = 0; i < num; i++)
		{
			int temp = previous_fib + current_fib;
			previous_fib = current_fib;
			current_fib = temp;
		}

		cout << current_fib << endl;
	}

    return 0;
}

