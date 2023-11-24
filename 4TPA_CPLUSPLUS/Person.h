#pragma once
#include <iostream>
#include <string>
#include "Ada.h"

using namespace std;


class Person
{
public:
	Ada* f;
	string firstName;
	string lastName;

	Person(){}
	Person(string fN, string lN) {
		this->firstName = fN;
		this->lastName = lN;
	}

	void show() {
		cout << this->firstName << " " << this->lastName << "\n";
	}



};

