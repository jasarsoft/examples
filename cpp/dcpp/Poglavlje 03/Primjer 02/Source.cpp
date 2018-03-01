#include <iostream>
using namespace std;

/**********************************************************
Program:	Moj treci i C++ program
Datoteka:	Treci.cpp
Funkcije:	main() - cijeli program je u jednoj datoteci
Opis:	U è itava dva broja i ispisuje njihov zbroj
Autori:		Boris (bm)
			Julijan	(jš)
Okruženje:	Prozori95
			PHP C++ 4.5 prevoditelj
Zabiljeske: Znam Boris da si ti protiv ovakvih komentara,
			ali sam ih morao staviti
Izmjene:	15.07.96. (jš) prva ina è ica
			21.08.96. (bm) svi podaci su iz float
			promijenjeni u int
**********************************************************/

int main() {
	int a, b, c;

	cout << "Upisi prvi broj: ";
	cin >> a;

	cout << "Upisi i drugi broj: ";
	cin >> b;

	c = a + b; //racuna njihov zbroj

	//ispisuje rezultat
	cout << "Njihov zbroj je: " << c << endl;
	return 0;
}