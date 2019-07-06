// zamianaMiejscami.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include "conio.h"

void zamiana(int &a, double &b) {
	int w = a;
	a = b;
	b = w;
}

int main(int argc, char* argv[]) {
	double a;
	int b;

	printf_s("Podaj liczbe z przecinkiem  a: ");
	scanf_s("%lf", &a);

	printf_s("Podaj liczbe calkowita b: ");
	scanf_s("%d", &b);

	int ra = a;
	double rb = b;

	zamiana(ra, rb);
	printf_s("Po zamianie a = %d b = %lf", ra, rb);

	_getch();
}