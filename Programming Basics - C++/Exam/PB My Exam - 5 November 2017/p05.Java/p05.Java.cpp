// p05.Java.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int num;
	cin >> num;

	int width = num * 3 + 6;
	int height = num * 3 + 1;

	for (int i = 0; i < num; i++)
	{
		cout << string(num, ' ')
			<< "~ ~ ~"
			<< endl;
	}

	cout << string(width - 1, '=') 
		<< endl;

	for (int i = 1; i <= num - 2; i++)
	{
		if (i == num / 2)
		{
			cout << "|"
				<< string(num, '~')
				<< "JAVA"
				<< string(num, '~')
				<< "|"
				<< string(num - 1, ' ')
				<< "|"
				<< endl;
		}
		else
		{
			cout << "|"
				<< string(num * 2 + 4, '~')
				<< "|"
				<< string(num - 1, ' ')
				<< "|"
				<< endl;
		}
	}

	cout << string(width - 1, '=') 
		<< endl;

	int aMonky = num * 2 + 4;

	for (int i = 0; i < num; i++)
	{
		cout << string(i, ' ')
			<< "\\"
			<< string(aMonky, '@')
			<< "/"
			<< endl;

		aMonky -= 2;
	}

	cout << string(num * 2 + 6, '=') 
		<< endl;

    return 0;
}

