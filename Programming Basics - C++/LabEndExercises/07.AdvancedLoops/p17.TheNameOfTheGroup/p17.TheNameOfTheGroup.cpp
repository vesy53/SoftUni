// p17.TheNameOfTheGroup.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	char upper_letter;
	char small_letter1;
	char small_letter2;
	char small_letter3;
	int number;
	cin >> upper_letter >> small_letter1 >> small_letter2 >> small_letter3 >> number;
	int counter = 0;

	for (char i = 'A'; i <= upper_letter; i++)
	{
		for (char j = 'a'; j <= small_letter1; j++)
		{
			for (char k = 'a'; k <= small_letter2; k++)
			{
				for (char l = 'a'; l <= small_letter3; l++)
				{
					for (int m = 0; m <= number; m++)
					{
						counter++;
					}
				}
			}
		}
	}

	cout << counter - 1 << endl;

    return 0;
}

