// Bankomat.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include "pch.h"
#include <iostream>
#include <string>

std::string PIN;


int main()
{
    std::cout << "Witaj w naszym banku" << std::endl;
	std::cout << "Podaj PIN: ";
	std::cin >> PIN;
	if (PIN == "1729")
	{
		std::cout << "PIN poprawny" << std::endl;
	}
	else
	{
		std::cout << "PIN Niepoprawny" << std::endl;
	}
	return 0;
}


