// PasswordGuess.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{ 
	string input;
	cin >> input;

	string correct_password = "s3cr3t!P@ssw0rd";

	if (input == correct_password)
	{
		cout << "Welcome" << endl;
	}
	else 
	{
		cout << "Wrong password!" << endl;
	}
    return 0;
}

