// USD-to-BGN.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include<cmath>
#include<iomanip>
using namespace std;

int main()
{
	double dollar = 1;
	double bulgarian_lev = 1.79549;

	cin >> dollar;

	double result = dollar * bulgarian_lev;

	cout << fixed << setprecision(2) << result << endl;

    return 0;
}

