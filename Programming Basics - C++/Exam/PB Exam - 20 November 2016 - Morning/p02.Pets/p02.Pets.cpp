// p02.Pets.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	double num_days;
	double kg_food;
	double dog_food_kg;
	double cat_food_kg;
	double turtle_gr;
	cin >> num_days >> kg_food >> dog_food_kg >> cat_food_kg >> turtle_gr;

	dog_food_kg *= num_days;
	cat_food_kg *= num_days;
	turtle_gr *= num_days;
	double turtle_kg = turtle_gr / 1000;
	double total = dog_food_kg + cat_food_kg + turtle_kg;

	if (total <= kg_food)
	{
		kg_food -= total;

		cout << floor(kg_food) << " kilos of food left." << endl;
	}
	else if (total  > kg_food)
	{
		total -= kg_food;

		cout << ceil(total) << " more kilos of food are needed." << endl;
	}

    return 0;
}

