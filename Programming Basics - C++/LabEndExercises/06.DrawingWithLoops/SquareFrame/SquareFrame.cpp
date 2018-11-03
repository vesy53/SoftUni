// SquareFrame.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int size;
	cin >> size;

	cout << "+ ";
	for (int i = 0; i < size -2; i++)
	{
		cout << "- ";
	}
	cout << "+" << endl;
	for (int row = 0; row < size - 2; row++)
	{
		cout << "| ";
		for (int col = 0; col < size - 2; col++)
		{
			cout << "- ";
		}
		cout << "|" << endl;
	}
	cout << "+ ";
	for (int i = 0; i < size - 2; i++)
	{
		cout << "- ";
	}
	cout << "+" << endl;

    return 0;
}

