// p04.Cake.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

int main()
{
	int width_cake;
	int height_cake;
	string command;
	cin >> width_cake >> height_cake >> command;

	int total_cake = width_cake * height_cake;
	int take_pieces = 0;

	while (command != "STOP")
	{
		take_pieces = atoi(command.c_str());

		if (take_pieces > total_cake)
		{
			break;
		}
		else
		{
			total_cake -= take_pieces;
		}

		cin >> command;
	}

	if (take_pieces > total_cake)
	{
		take_pieces -= total_cake;

		cout << "No more cake left! You need " 
			<< take_pieces << " pieces more." << endl;
	}
	else
	{
		cout << total_cake << " pieces are left." << endl;
	}

    return 0;
}

