// p01.DailyProfit.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int work_days_in_month;
	double money_for_days;
	double exchange_rate;
	cin >> work_days_in_month >> money_for_days >> exchange_rate;

	double monthly_salary = work_days_in_month * money_for_days;
	double annual_income = monthly_salary * 12 + monthly_salary * 2.5;
	double tax = annual_income * 0.25;
	double total_annual_income = (annual_income - tax) * exchange_rate;
	double result = total_annual_income / 365;

	cout << fixed << setprecision(2) << result << endl;

    return 0;
}

