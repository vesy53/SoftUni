// 3EqualNumbers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int first_number, second_number, third_number;
	cin >> first_number >> second_number >> third_number;

	if (first_number == second_number && first_number == third_number && second_number == third_number)
	{
		cout << "yes" << endl;
	}
	else
	{
		cout << "no" << endl;
	}

return 0;
}
