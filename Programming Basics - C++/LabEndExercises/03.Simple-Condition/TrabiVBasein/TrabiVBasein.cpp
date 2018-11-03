// TrabiVBasein.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	double volume, pipe_1, pipe_2;
	double hour;
	cin >> volume >> pipe_1 >> pipe_2 >> hour;

	double first_pipe = pipe_1 * hour;
	double second_pipe = pipe_2 * hour;
	double total = first_pipe + second_pipe;

	if (total <= volume)
	{
		double prozent = total / volume * 100;
		double prozent_first = first_pipe / total * 100;
		double prozent_second = second_pipe / total * 100;
		cout << "The pool is " << floor(prozent) << "% full. Pipe 1: " << floor(prozent_first)
			<< "%. Pipe 2: " << floor(prozent_second) << "%." << endl;
	}
	else if (total > volume)
	{
		double more = total - volume;
		cout << "For " << hour << " hours the pool overflows with " 
			 << fixed << setprecision(1) << more << " liters." << endl;
	}
    return 0;
}

