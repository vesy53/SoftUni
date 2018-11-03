// SumSeconds.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int first_second, second_seconds, thirs_seconds;
	cin >> first_second >> second_seconds >> thirs_seconds;

	int total_seconds = first_second + second_seconds + thirs_seconds;
	int final_minutes = total_seconds / 60;
	int final_seconds = total_seconds % 60;

	cout << final_minutes << ":";

	if (final_seconds  < 10)
	{
		cout << "0" << final_seconds;
	}
	else 
	{
		cout << final_seconds;
	}
	cout << endl;

    return 0;
}

