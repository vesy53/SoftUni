// VowelsSum.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	string sentence;
	getline(cin, sentence);
	int sum = 0;

	for (int i = 0; i < sentence.length(); i++)
	{
		char current_letter = sentence[i];
		if (current_letter == 'a')
		{
			sum += 1;
		}
		else if (current_letter == 'e')
		{
			sum += 2;
		}
		else if (current_letter == 'i')
		{
			sum += 3;
		}
		else if (current_letter == 'o')
		{
			sum += 4;
		}
		else if (current_letter == 'u')
		{
			sum += 5;
		}
	}
	cout << sum << endl;

    return 0;
}

