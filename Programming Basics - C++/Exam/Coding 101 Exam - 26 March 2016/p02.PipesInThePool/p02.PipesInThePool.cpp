// p02.PipesInThePool.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	int pool_volume_in_liters;
	int pipe_1;
	int pipe_2;
	double hour;
	cin >> pool_volume_in_liters >> pipe_1 >> pipe_2 >> hour;

	int result_pipe_1 = pipe_1 * hour;
	int result_pipe_2 = pipe_2 * hour;
	int total = result_pipe_1 + result_pipe_2;

	if (total <= pool_volume_in_liters)
	{
		int total_result = (total * 100 / pool_volume_in_liters);
		int total_pipe_1 = (result_pipe_1 * 100 / total);
		int total_pipe_2 = (result_pipe_2 * 100 / total);

		cout << "The pool is "
			<< total_result
			<< "% full. Pipe 1: "
			<< total_pipe_1
			<< "%. Pipe 2: "
			<< total_pipe_2
			<< "%." 
			<< endl;
	}
	else if (total > pool_volume_in_liters)
	{
		total -= pool_volume_in_liters;

		cout << "For "
			<< hour
			<< " hours the pool overflows with "
			<< fixed << setprecision(1) << total
			<< " liters."
			<< endl;
	}

    return 0;
}

