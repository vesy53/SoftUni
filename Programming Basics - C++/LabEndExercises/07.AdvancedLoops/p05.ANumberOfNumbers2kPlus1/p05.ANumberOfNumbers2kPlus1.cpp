// p05.ANumberOfNumbers2kPlus1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int current_num = 1;

	while (current_num <= num)
	{
		cout << current_num << endl;
		current_num = current_num * 2 + 1;
	}

    return 0;
}

