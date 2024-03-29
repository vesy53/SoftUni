// p02.ToyShop.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	double price_excursion;
	int num_puzzles;
	int num_dolls;
	int num_teddy_beers;
	int num_million;
	int num_truck;
	cin >> price_excursion 
		>> num_puzzles 
		>> num_dolls 
		>> num_teddy_beers 
		>> num_million 
		>> num_truck;

	double price_puzzle = 2.6 * num_puzzles;
	double price_dolls = 3 * num_dolls;
	double price_teddy_beers = 4.1 * num_teddy_beers;
	double price_million = 8.2 * num_million;
	double price_truck = 2 * num_truck;
	double total_price =
		price_puzzle + price_dolls + price_teddy_beers + price_truck + price_million;

	double total_num_toys =
		num_puzzles + num_dolls + num_teddy_beers + num_million + num_truck;

	if (total_num_toys >= 50)
	{
		total_price -= total_price * 0.25;
	}

	total_price -= total_price * 0.1;

	if (total_price < price_excursion)
	{
		price_excursion -= total_price;

		cout << "Not enough money! " 
			<< fixed << setprecision(2) << price_excursion
			<< " lv needed." 
			<< endl;
	}
	else if (total_price >= price_excursion)
	{
		total_price -= price_excursion;

		cout << "Yes! " 
			<< fixed << setprecision(2) << total_price
			<< " lv left." 
			<< endl;
	}

    return 0;
}

