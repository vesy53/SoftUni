// p06.GroupName.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	char upper_letter;
	char small_letter_1;
	char small_letter_2;
	char small_letter_3;
	int number;
	cin >> upper_letter 
		>> small_letter_1 
		>> small_letter_2 
		>> small_letter_3 
		>> number;

	int counter = 0;

	for (char i = 'A'; i <= upper_letter; i++)
	{
		for (char j = 'a'; j <= small_letter_1; j++)
		{
			for (char k = 'a'; k <= small_letter_2; k++)
			{
				for (char l = 'a'; l <= small_letter_3; l++)
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

