// p06.Numbers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int number = num;
	int digit_3 = num % 10;
	num /= 10;
	int digit_2 = num % 10;
	num /= 10;
	int digit_1 = num % 10;

	for (int i = 1; i <= digit_1 + digit_2; i++)
	{
		for (int j = 1; j <= digit_1 + digit_3; j++)
		{
			if (number % 5 == 0)
			{
				number -= digit_1;
			}
			else if (number % 3 == 0)
			{
				number -= digit_2;
			}
			else
			{
				number += digit_3;
			}

			cout << number << " ";
		}

		cout << endl;
	}

    return 0;
}

