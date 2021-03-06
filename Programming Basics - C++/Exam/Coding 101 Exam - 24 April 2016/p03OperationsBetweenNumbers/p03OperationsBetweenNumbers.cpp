// p03OperationsBetweenNumbers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int num_1;
	int num_2;
	string math_operator;
	cin >> num_1 >> num_2 >> math_operator;

	int result = 0;
	string odd_even = "";

	if (math_operator == "+")
	{
		result = num_1 + num_2;

		if (result % 2 == 0)
		{
			odd_even = "even";
		}
		else
		{
			odd_even = "odd";
		}

		cout << num_1 << " " 
			<< math_operator << " " 
			<< num_2 << " = " 
			<< result << " - " 
			<< odd_even << endl;
	}
	else if (math_operator == "-")
	{
		result = num_1 - num_2;

		if (result % 2 == 0)
		{
			odd_even = "even";
		}
		else
		{
			odd_even = "odd";
		}

		cout << num_1 << " " 
			<< math_operator << " " 
			<< num_2 << " = " 
			<< result << " - " 
			<< odd_even << endl;
	}
	else if (math_operator == "*")
	{
		result = num_1 * num_2;

		if (result % 2 == 0)
		{
			odd_even = "even";
		}
		else
		{
			odd_even = "odd";
		}

		cout << num_1 << " " 
			<< math_operator << " " 
			<< num_2 << " = " 
			<< result << " - " 
			<< odd_even << endl;
	}
	else if (math_operator == "/")
	{
		result = num_1 / num_2;

		if (num_2 == 0)
		{
			cout << "Cannot divide " 
				<< num_1 << "by zero" 
				<< endl;
		}
		else
		{
			cout << num_1 << " " 
				<< math_operator << " " 
				<< num_2 << " = " 
				<< fixed << setprecision(2) << result 
				<< endl;
		}
	}
	else if (math_operator == "%")
	{
		result = num_1 % num_2;

		if (num_2 == 0)
		{
			cout << "Cannot divide " << num_1 << " by zero" << endl;
		}
		else
		{
			cout << num_1 << " " 
				<< math_operator << " " 
				<< num_2 << " = " 
				<< result 
				<< endl;
		}
	}

    return 0;
}

