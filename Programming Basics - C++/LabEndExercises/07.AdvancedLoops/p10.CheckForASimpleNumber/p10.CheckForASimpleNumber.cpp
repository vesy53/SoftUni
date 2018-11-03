// p10.CheckForASimpleNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int input_num;
	cin >> input_num;

	bool isPrime = true;

	for (int i = 2; i < input_num; i++)
	{
		if (input_num % i == 0)
		{
			isPrime = false;
		}
	}

    if (!isPrime || input_num <= 1)
	{
		cout << "Not prime" << endl;
	}
	else if (isPrime)
	{
		cout << "Prime" << endl;
	}

    return 0;
}

