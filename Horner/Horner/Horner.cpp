// Horner.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include "conio.h"


using namespace std;

int horner(int wspolczynnik[], int stopien, int argument)
{
	if (stopien == 0)
		return wspolczynnik[0];

	return argument * horner(wspolczynnik, stopien - 1, argument) + wspolczynnik[stopien];
}

int main()
{
	int *wspolczynniki;
	int stopien, argument;

	cout << "Podaj stopien wielomianu: ";
	cin >> stopien;

	wspolczynniki = new int[stopien + 1];

	for (int i = 0; i <= stopien; i++)
	{
		cout << "Podaj wspolczynnik wielomianu " << stopien - i << ": ";
		cin >> wspolczynniki[i];
	}

	do
	{
		cout << "Podaj argument: ";
		cin >> argument;
		
			cout << "W( " << argument << " ) = " << horner(wspolczynniki, stopien, argument) << endl;
		
	} while (true);

	_getch();
			
	return 0;
}

