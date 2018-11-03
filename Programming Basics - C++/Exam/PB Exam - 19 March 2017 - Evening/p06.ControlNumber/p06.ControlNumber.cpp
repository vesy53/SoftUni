// p06.ControlNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num_1;
	int num_2;
	int control_num;
	cin >> num_1 >> num_2 >> control_num;

	int sum = 0;
	int counter = 0;

	for (int i = 1; i <= num_1; i++)
	{
		for (int j = num_2; j >= 1; j--)
		{
			counter++;
			sum += i * 2 + j * 3;

			if (sum >= control_num)
			{
				cout << counter << " moves" << endl;
				cout << "Score: " << sum << " >= " << control_num << endl;
				break;
			}
		}

		if (sum >= control_num)
		{
			break;
		}
	}

	if (sum < control_num)
	{
		cout << counter << " moves" << endl;
	}

    return 0;
}

