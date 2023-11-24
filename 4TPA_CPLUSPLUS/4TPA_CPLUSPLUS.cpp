#include <iostream>
#include "Person.h"
#include <string>

using namespace std;

int main()
{
   


	// int, float, char, string, double, bool


	//deklaracja 

	int firstValue, secondValue;


	cout << "podaj pierwsza wartosc" <<endl;
	cin >> firstValue;
	cout << "podaj druga wartosc" <<endl;
	cin >> secondValue;
	
	for (int i = firstValue; i < secondValue; i++) {
		if (i % 2 == 0) {
			cout << "Zmienne to;" << i << "\n";
		}
	}


	Person antek;
	antek.firstName = "saasd";
	antek.lastName = "saasd";
	antek.show();

	
}

