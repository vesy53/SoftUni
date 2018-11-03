// BonusScore.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int score;
	double bonus_points;
	cin >> score;

	if (score > 1000)
	{
		bonus_points = score * 0.1;
	}
	else if (score > 100)
	{
		bonus_points = score * 0.2;
	}
	else if (score <= 100)
	{
		bonus_points = 5;
	}
	
	if (score % 2 == 0)
	{
		bonus_points++;
	}
	else if (score % 10 == 5)
	{
		bonus_points += 2;
	}
	cout << bonus_points << endl;
	cout << score + bonus_points << endl;
    return 0;
}

