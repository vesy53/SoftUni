// EvenOrOdd.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;
int main()
{
	int number;
	cin >> number;
	if (number % 2 == 0)
	{
		cout << "even" << endl;
	}
	else
	{
		cout << "odd" << endl;
	}
    return 0;
}

