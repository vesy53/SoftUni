// p11.EvenNumber.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int number;

	do
	{
		cout << "Enter even number: ";
		cin >> number;

		if (number % 2 != 0)
		{
			cout << "The number is not even." << endl;

		}
	} while (number % 2 != 0);

	cout << "Even number entered: "<< number << endl;

    return 0;
}

