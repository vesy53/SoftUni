// p06.Battles.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num_first;
	int num_sec;
	int max_battles;

	int counter = 0;

	for (int i = 1; i <= num_first; i++)
	{
		for (int j = 1; j <= num_sec; j++)
		{
			cout << "(" << i << " <-> " << j << ") ";

			counter++;

			if (counter == max_battles)
			{
				break;
			}

		}

		if (counter == max_battles)
		{
			break;
		}
	}

    return 0;
}

