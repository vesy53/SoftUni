// p06.MaxCombination.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int start;
	int end;
	int max_combination;

	int counter = 0;

	for (int i = start; i <= end; i++)
	{
		for (int j = start; j <= end; j++)
		{
			counter++;
			cout << "<" << i << "-" << j << ">" << endl;

			if (counter == max_combination)
			{
				break;
			}

		}

		if (counter == max_combination)
		{
			break;
		}
	}

    return 0;
}

