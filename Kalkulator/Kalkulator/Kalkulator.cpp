// Kalkulator.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream> 

using namespace std;

int a, b, wynik;
char znak;

int main()
{
	while (true)
	{
		cout << "Podaj pierwsza liczbe: ";
		cin >> a;
		cout << "Podaj znak działania [+ - * / % ]: ";
		cin >> znak;
		cout << "Podaj druga liczbe: ";
		cin >> b;

		if (znak == '+')
		{
			wynik = a + b;
			cout << "Wynik dzialania to: " << wynik<<endl;
		}
		else if (znak =='-')
		{
			wynik = a - b;
			cout << "Wynik dzialania to: " << wynik<<endl;
		}
		else if (znak == '*')
		{
			wynik = a * b;
			cout << "Wynik dzialania to: " << wynik<<endl;
		}
		else if (znak == '/')
		{
			wynik = a / b;
			cout << "Wynik dzialania to: " << wynik<<endl;
		}
		else if (znak == '%')
		{
			wynik = a % b;
			cout << "Wynik dzialania to: " << wynik << endl;
		}
		else
		{
			cout << "Nieprawidlowe dzialanie"<<endl;
		}
		cout << endl;
	}
	return 0;
}

