// p06.TwoNumbersSum.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int start;
	int end;
	int magic_num;

	int counter = 0;
	int sum = 0;

	for (int i = start; i >= end; i--)
	{
		for (int j = start; j >= end; j--)
		{
			counter++;
			sum = i + j;

			if (sum == magic_num)
			{
				cout << "Combination N:" 
					<< counter 
					<< " (" 
					<< i 
					<< " + " 
					<< j 
					<< " = " 
					<< sum 
					<< ")" 
					<< endl;
				break;
			}
		}

		if (sum == magic_num)
		{
			break;
		}
	}

	if (sum != magic_num)
	{
		cout << counter 
			<< " combinations - neither equals " 
			<< magic_num 
			<< endl;
	}

    return 0;
}

