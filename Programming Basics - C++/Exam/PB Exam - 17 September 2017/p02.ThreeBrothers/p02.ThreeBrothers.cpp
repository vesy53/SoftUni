// p02.ThreeBrothers.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;


int main()
{
	double first_brother;
	double second_brother;
	double third_brother;
	double time_father;
	cin >> first_brother >> second_brother >> third_brother;

	double total =
		1 / (1 / first_brother + 1 / second_brother + 1 / third_brother);
	double result = total * 0.15;
	total += result;

	cout << "Cleaning time: "
		<< fixed << setprecision(2) << total
		<< endl;

	double diff = time_father - total;

	if (diff >= 0)
	{
		cout << "Yes, there is a surprise - time left -> "
			<< floor(diff)
			<< " hours."
			<< endl;
	}
	else
	{
		cout << "No, there isn't a surprise - shortage of time -> "
			<< ceil(abs(diff))
			<< " hours."
			<< endl;
	}

    return 0;
}

