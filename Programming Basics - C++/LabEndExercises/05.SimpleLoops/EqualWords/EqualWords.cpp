// EqualWords.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
	string first_sentence, second_sentence;
	cin >> first_sentence >> second_sentence;
	string first_sentence_lower = first_sentence;
	string second_sentence_lower = second_sentence;

	for (int i = 0; i < first_sentence_lower.length(); i++)
	{
		first_sentence_lower[i] = tolower(first_sentence[i]);
	}
	for (int i = 0; i < second_sentence_lower.length(); i++)
	{
		second_sentence_lower[i] = tolower(second_sentence[i]);
	}if (first_sentence_lower == second_sentence_lower)
	{
		cout << "yes" << endl;
	}
	else
	{
		cout << "no" << endl;
	}

    return 0;
}

