// PospalivataKotkaTom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int repose_day;
	cin >> repose_day;

	int play, work_play, repose_play, total_play;
	work_play = (365 - repose_day) * 63;
	repose_play = repose_day * 127;
	play = work_play + repose_play;
	total_play = 30000 - play;

	if (play > 30000)
	{
		total_play = abs(total_play);
		int hour = total_play / 60;
		int minutes = total_play % 60;
		cout << "Tom will run away" << endl;
		cout << hour << " hours and " << minutes << " minutes more for play" << endl;
	}
	else
	{
		int hour = total_play / 60;
		int minutes = total_play % 60;
		cout << "Tom sleeps well" << endl;
		cout << hour << " hours and " << minutes << " minutes less for play" << endl;
	}

    return 0;
}

