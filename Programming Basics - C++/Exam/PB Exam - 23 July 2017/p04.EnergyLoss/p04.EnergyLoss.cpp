// p04.EnergyLoss.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int training_days;
	int num_dancers;

	double loss_energy = 0;

	for (int i = 1; i <= training_days; i++)
	{
		int hours;
		cin >> hours;

		if (i % 2 == 0 && hours % 2 == 0)
		{
			loss_energy += num_dancers * 68;
		}
		else if (i % 2 == 1 && hours % 2 == 0)
		{
			loss_energy += num_dancers * 49;
		}
		else if (i % 2 == 0 && hours % 2 == 1)
		{
			loss_energy += num_dancers * 65;
		}
		else if (i % 2 == 1 && hours % 2 == 1)
		{
			loss_energy += num_dancers * 30;
		}
	}

	double total_energy = 100 * num_dancers * training_days;
	double unloss_energy = total_energy - loss_energy;
	double unloss_energy_dancer =
		unloss_energy / num_dancers / training_days;

	if (unloss_energy_dancer <= 50)
	{
		cout << "They are wasted! Energy left: " 
			<< fixed << setprecision(2) << unloss_energy_dancer 
			<< endl;
	}
	else if (unloss_energy_dancer > 50)
	{
		cout << "They feel good! Energy left: " 
			<< fixed << setprecision(2) << unloss_energy_dancer
			<< endl;
	}

    return 0;
}

