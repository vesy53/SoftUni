// p04.TrainersSalary.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	int lectures;
	double boudget;
	cin >> lectures >> boudget;

	double jelev_count = 0;
	double royal_count = 0;
	double roli_count = 0;
	double trofon_count = 0;
	double sino_count = 0;
	double other_count = 0;

	for (int i = 0; i < lectures; i++)
	{
		string name_lecturer;
		cin >> name_lecturer;

		if (name_lecturer == "Jelev")
		{
			jelev_count++;
		}
		else if (name_lecturer == "RoYaL")
		{
			royal_count++;
		}
		else if (name_lecturer == "Roli")
		{
			roli_count++;
		}
		else if (name_lecturer == "Trofon")
		{
			trofon_count++;
		}
		else if (name_lecturer == "Sino")
		{
			sino_count++;
		}
		else
		{
			other_count++;
		}
	}

	double everyLecture = boudget / lectures;

	cout << "Jelev salary: " 
		<< fixed << setprecision (2) << everyLecture * jelev_count 
		<< " lv" 
		<< endl;
	cout << "RoYaL salary: " 
		<< fixed << setprecision(2) << everyLecture * royal_count
		<< " lv"
		<< endl;
	cout << "Roli salary: "
		<< fixed << setprecision(2) << everyLecture * roli_count
		<< " lv"
		<< endl;
	cout << "Trofon salary: "
		<< fixed << setprecision(2) << everyLecture * trofon_count
		<< " lv"
		<< endl;
	cout << "Sino salary: "
		<< fixed << setprecision(2) << everyLecture * sino_count
		<< " lv"
		<< endl;
	cout << "Others salary: "
		<< fixed << setprecision(2) << everyLecture * other_count
		<< " lv"
		<< endl;

    return 0;
}

