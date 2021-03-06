// p06.NumberGenerator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num_1;
	int num_2;
	int num_3;
	int special_num;
	int control_num;

	for (int i = num_1; i >= 1; i--)
	{
		for (int j = num_2; j >= 1; j--)
		{
			for (int k = num_3; k >= 1; k--)
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
		cout << "Yes! Control number was reached! "
			<< "Current special number is " 
			<< special_num 
			<< "." 
			<< endl;
	}

    return 0;
}

