// p06.LettersCombinations.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	char start;
	char end;
	char miss_letter;
	cin >> start >> end >> miss_letter;

	int counter = 0;

	for (char i = start; i <= end; i++)
	{
		for (char j = start; j <= end; j++)
		{
			for (char k = start; k <= end; k++)
			{
				if (i != miss_letter && j != miss_letter &&
					k != miss_letter)
				{
					counter++;

					cout << i << j << k << " " << endl;
				}
			}
		}
	}

	cout << counter << endl;

    return 0;
}

