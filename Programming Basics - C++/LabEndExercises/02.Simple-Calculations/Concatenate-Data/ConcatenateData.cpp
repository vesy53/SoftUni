// ConcatenateData.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{    
	string first_name;
	string last_name;
	string town;
	int age;
	cin >> first_name >> last_name >> age >> town;
	cout << "You are" << " " << first_name << " "
		<< last_name << ", a" << " " << age 
		<< "-years old person from" << " " 
		<< town << "." << endl;
	
	return 0;
}

