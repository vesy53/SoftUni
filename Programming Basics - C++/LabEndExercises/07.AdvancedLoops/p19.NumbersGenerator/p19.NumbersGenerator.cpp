// p19.NumbersGenerator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num1;
	int num2;
	int num3;
	int special_num;
	int control_num;
	cin >> num1 >> num2 >> num3 >> special_num >> control_num;

	for (int i = num1; i >= 1; i--)
	{
		for (int j = num2; j >= 1; j--)
		{
			for (int k = num3; k >= 1; k--)
			{
				int total = i * 100 + j * 10 + k;

				if (total % 3 == 0)
				{
					special_num += 5;
				}
				else if (total % 10 == 5)
				{
					special_num -= 2;
				}
				else if (total % 2 == 0)
				{
					special_num *= 2;
				}

				if (special_num >= control_num)
				{
					break;
				}
			}

			if (special_num >= control_num)
			{
				break;
			}
		}

		if (special_num >= control_num)
		{
			break;
		}
	}

	if (special_num < control_num)
	{
		cout << "No! " 
			<< special_num 
			<< " is the last reached special number." 
			<< endl;
	}
	else if (special_num >= control_num)
	{
		cout << 
			"Yes! Control number was reached! Current special number is " 
			<< special_num 
			<< "." 
			<< endl;
	}

    return 0;
}

