// p01.Money.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double bitcoins;
	double num_chinese_yuan;
	double commission;
	cin >> bitcoins >> num_chinese_yuan >> commission;

	bitcoins *= 1168;
	num_chinese_yuan *= 0.15;
	num_chinese_yuan *= 1.76;
	double total = (bitcoins + num_chinese_yuan) / 1.95;
	commission *= total / 100;
	double total_commission = total - commission;

	cout << fixed << setprecision(2) << total_commission << endl;

    return 0;
}

