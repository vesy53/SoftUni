// p06.StopNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num_1;
	int num_2;
	int num_3;

	for (int i = num_2; i >= num_1; i--)
	{
		if (i % 2 == 0 && i % 3 == 0)
		{
			if (i == num_3)
			{
				break;
			}

			cout << i << " " << endl;
		}
	}

    return 0;
}

