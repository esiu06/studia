// Data.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.


#include "pch.h"
#include <iostream>
#include <string>


using namespace std;

struct Data
{
	short d, m, r;
};

int Dni[] = { 31,28,31,30,31,30,31,31,30,31,30,31 };



int Test_daty(struct Data D1) {


	int przestepny;

	if (D1.r < 1582 || D1.m < 1 || D1.m>12 || D1.d < 1 || D1.d>31)
	{
		printf_s("Data jest niepoprawna!\n\n");
	}
	else
	{
		przestepny = (D1.r % 400 == 0 || (D1.r % 4 == 0 && D1.r % 100));

		if (przestepny)
		{
			Dni[1] = 29;
			printf("Rok jest przestepny!\n");
		}
		else
		{
			Dni[1] = 28;
			printf("Rok nie jest przestepny!\n");

		}
		if (D1.d > Dni[D1.m - 1])
		{
			return 0;
		}	
	}
	return 0;
}
int wypiszDate(struct Data D1) {

	const char *miesiace[12] = { "Styczen", "Luty", "Marzec", "Kwiecien", "Maj", "Czerwiec", "Lipec", "Sierpien", "Wrzesien", "Pazdziernik", "Listopad", "Grudzien" };

	return printf_s("Data: %d %s %d\n\n", D1.d, miesiace[D1.m - 1], D1.r);
 }


struct Data Zeller(struct Data D1)
{
	if (D1.m < 3)
	{
		D1.r = D1.r--;
		D1.m = D1.m + 10;
	}
	else D1.m = D1.m - 2;
	return D1;
}

int dzienTygodnia(struct Data D1) {

	D1 = Zeller(D1);

	const char *dzienTygodnia[] = { "Niedziela", "Poniedzialek", "Wtorek", "Sroda", "Czwatrek", "Piatek", "Sobota" };

	int index;
	
	index = (D1.d + (((13 * D1.m) - 1) / 5) + ((5 * (D1.r % 100)) / 4) + (D1.r / 400) + (5 * (D1.r / 100))) % 7;

	printf("Dzien tygodnia: %s\n\n", dzienTygodnia[index]);

	return 0;
}

 

int main()
{
	
	struct Data D1;
	{
		fprintf_s(stderr, "Podaj date w postaci dd.mm.rrrr: ");
		scanf_s("%hd%*c%hd%*c%hd", &D1.d, &D1.m, &D1.r);
		printf_s("\n%8.d-%d-%d\n\n", D1.d, D1.m, D1.r);
		wypiszDate(D1);
		dzienTygodnia(D1);
		Test_daty(D1);
	};
	
		

}
