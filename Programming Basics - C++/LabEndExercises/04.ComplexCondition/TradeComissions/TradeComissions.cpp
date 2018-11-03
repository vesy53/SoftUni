// TradeComissions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main()
{
	double sales_count;
	string town_name;

	cin >> town_name >> sales_count;

	double comission = 0;
	if (town_name != "Sofia" && town_name != "Varna" && 
		town_name != "Plovdiv" || sales_count < 0) 
	{
		cout << "error" << endl;
	}
	else if (town_name == "Sofia")
	{
		if (sales_count > 10000 )
		{
			comission = sales_count * 12 / 100;
		}
		else if (sales_count > 1000)
		{
			comission = sales_count * 8 / 100;
		}
		else if (sales_count > 500)
		{
			comission = sales_count * 7 / 100;
		}
		else if (sales_count >= 0)
		{
			comission = sales_count * 5 / 100;
		}

	cout << fixed << setprecision(2) << comission << endl;
	}
	else if (town_name == "Varna")
	{
		if (sales_count > 10000)
		{
			comission = sales_count * 13 / 100;
		}
		else if (sales_count > 1000)
		{
			comission = sales_count * 10 / 100;
		}
		else if (sales_count > 500)
		{
			comission = sales_count * 7.5 / 100;
		}
		else if (sales_count >= 0)
		{
			comission = sales_count * 4.5 / 100;
		}

	cout << fixed << setprecision(2) << comission << endl;
	}
	else if (town_name == "Plovdiv")
	{
		if (sales_count > 10000)
		{
			comission = sales_count * 14.5 / 100;
		}
		else if (sales_count > 1000)
		{
			comission = sales_count * 12 / 100;
		}
		else if (sales_count > 500)
		{
			comission = sales_count * 8 / 100;
		}
		else if (sales_count >= 0)
		{
			comission = sales_count * 5.5 / 100;
		}

	cout << fixed << setprecision(2) << comission << endl;
	}

    return 0;
}

