// Number0To100ToText.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number;
	cin >> number;

	if (number >= 0 && number < 20)
	{
		switch (number)
		{
		case 0: cout << "zero" << endl;
			break;
		case 1: cout << "one" << endl;
			break;
		case 2: cout << "two" << endl;
			break;
		case 3: cout << "three" << endl;
			break;
		case 4: cout << "four" << endl;
			break;
		case 5: cout << "fife" << endl;
			break;
		case 6: cout << "six" << endl;
			break;
		case 7: cout << "seven" << endl;
			break;
		case 8: cout << "eight" << endl;
			break;
		case 9: cout << "nine" << endl;
			break;
		case 10: cout << "ten" << endl;
			break;
		case 11: cout << "eleven" << endl;
			break;
		case 12: cout << "twelve" << endl;
			break;
		case 13: cout << "thirteen" << endl;
			break;
		case 14: cout << "fourteen" << endl;
			break;
		case 15: cout << "fifteen" << endl;
			break;
		case 16: cout << "sixteen" << endl;
			break;
		case 17: cout << "seventeen" << endl;
			break;
		case 18: cout << "eighteen" << endl;
			break;
		case 19: cout << "nineteen" << endl;
			break;
		}
	}
	else if (number >= 20 && number < 100)
	{
		int first_digit = number / 10;
		int second_digit = number % 10;

		switch (first_digit)
		{
		case 2: cout << "twenty ";
			break;
		case 3: cout << "thirty ";
			break;
		case 4: cout << "forty ";
			break;
		case 5: cout << "fifty " ;
			break;
		case 6: cout << "sixty ";
			break;
		case 7: cout << "seventy ";
			break;
		case 8: cout << "eighty ";
			break;
		case 9: cout << "ninety ";
			break;
		}
		switch (second_digit)
		{
		case 1: cout << "one" << endl;
			break;
		case 2: cout << "two" << endl;
			break;
		case 3: cout << "three" << endl;
			break;
		case 4: cout << "four" << endl;
			break;
		case 5: cout << "five" << endl;
			break;
		case 6: cout << "six" << endl;
			break;
		case 7: cout << "seven" << endl;
			break;
		case 8: cout << "eight" << endl;
			break;
		case 9: cout << "nine" << endl;
			break;
		}
	}
	else if (number == 100)
	{
		cout << "one hundred" << endl;
	}
	else if (number < 0 || number > 100)
	{
		cout << "invalid number" << endl;
	}
return 0;
}

