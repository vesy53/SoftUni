// p04.Hospital.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int period;
	cin >> period;

	int doctors = 7;
	int treated_patients = 0;
	int untreated_patients = 0;

	for (int i = 1; i <= period; i++)
	{
		int patients;
		cin >> patients;

		if (i % 3 == 0 && untreated_patients > treated_patients)
		{
			doctors++;
		}

		if (patients <= doctors)
		{
			treated_patients += patients;
		}
		if (patients > doctors)
		{
			treated_patients += doctors;
			untreated_patients += patients - doctors;
		}
	}

	cout << "Treated patients: " << treated_patients << "." << endl;
	cout << "Untreated patients: " << untreated_patients << "." << endl;

    return 0;
}

