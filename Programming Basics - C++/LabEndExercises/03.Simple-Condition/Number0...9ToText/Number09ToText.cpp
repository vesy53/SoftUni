// Number09ToText.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int input_number;
	cin >> input_number;
	if (input_number == 1)
	{
		cout << "one" << endl;
	}
	else if (input_number == 2)
	{
		cout << "two" << endl;
	}
	else if (input_number == 3)
	{
		cout << "three" << endl;
	}
	else if (input_number == 4)
	{
		cout << "four" << endl;
	}
	else if (input_number == 5)
	{
		cout << "five" << endl;
	}
	else if (input_number == 6)
	{
		cout << "six" << endl;
	}
	else if (input_number == 7)
	{
		cout << "seven" << endl;
	}
	else if (input_number == 8)
	{
		cout << "eight" << endl;
	}
	else if (input_number ==9)
	{
		cout << "nine" << endl;
	}
	else if (input_number > 9)
	{
		cout << "number too big" << endl;
	}
    return 0;
}

