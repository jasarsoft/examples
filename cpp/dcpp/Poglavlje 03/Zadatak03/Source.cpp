#include <iostream>
using namespace std;

/*
	Zadatak.  Odredite koje æe od navedenih naredbi za ispis:
	int a = 10000;
	int b = 10;
	long c = a * b;
	cout << c << endl;
	cout << (a * b) << endl;
	cout << ((float)a * b) << endl;
	cout << (long)(a * b) << endl;
	cout << (a * (long)b) << endl;
	dati ispravan umno?ak, tj. 100000.

	Dat ce sve!!!
*/

int main()
{
	int a = 10000;
	int b = 10;
	long c = a * b;
	cout << c << endl;					//100 000
	cout << (a * b) << endl;			//100 000
	cout << ((float)a * b) << endl;		//...
	cout << (long)(a * b) << endl;
	cout << (a * (long)b) << endl;

	system("pause");
	return 0;
}