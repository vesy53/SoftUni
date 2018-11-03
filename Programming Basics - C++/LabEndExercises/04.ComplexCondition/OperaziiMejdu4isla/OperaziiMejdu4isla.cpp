// OperaziiMejdu4isla.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	int number_one, number_two, sum;
	string math_operator;
	cin >> number_one >> number_two >> math_operator;

	if (math_operator == "+")
	{
		sum = number_one + number_two;
		if (sum % 2 == 0)
		{
			cout << number_one << " + " << number_two << " = " 
				 << sum << " - " << "even" << endl;
		}
		else
		{
			cout << number_one << " + " << number_two << " = " 
				 << sum << " - " << "odd" << endl;
		}
	}
	else if (math_operator == "-")
	{
		sum = number_one - number_two;
		if (sum % 2 == 0)
		{
			cout << number_one << " - " << number_two << " = "
				 << sum << " - " << "even" << endl;
		}
		else
		{
			cout << number_one << " - " << number_two << " = "
				 << sum << " - " << "odd" << endl;
		}
	}
	else if (math_operator == "*")
	{
		sum = number_one * number_two;
		if (sum % 2 == 0 )
		{
			cout << number_one << " * " << number_two << " = "
				 << sum << " - " << "even" << endl;
		}
		else
		{
			cout << number_one << " * " << number_two << " = "
				 << sum << " - " << "odd" << endl;
		}
	}
	else if (math_operator == "/")
	{  
		if (number_two != 0)
		{
		    double results = number_one * 1.0 / number_two;
			cout << number_one << " / " << number_two << " = "
			     << fixed << setprecision(2) << results << endl;
		}
		else
		{
			cout << "Cannot divide " << number_one << " by zero" << endl;
		}
	}
	else if (math_operator == "%")
	{
		if (number_two != 0)
		{
			double results = number_one % number_two;
			cout << number_one << " % " << number_two
				<< " = " << results << endl;
		}
		else
		{
			cout << "Cannot divide " << number_one << " by zero" << endl;
		}
	}

    return 0;
}

