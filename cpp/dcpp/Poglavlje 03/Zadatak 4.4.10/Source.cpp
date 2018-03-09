#include <iostream>
using namespace std;

/*
	Zadatak.  Razmislite i provjerite ?to ce se ispisati izvodjenjem sljedeceg kôda:
	char a = 'a';
	char b = a;
	int asciiKod = a;
	cout << a << endl;
	cout << b << endl;
	cout << 'b' << endl;
	cout << asciiKod << endl;
*/

int main()
{
	char a = 'a';
	char b = a;
	int asciiKod = a;
	cout << a << endl; //a
	cout << b << endl; //a
	cout << 'b' << endl; // b
	cout << asciiKod << endl; // 97

	system("pause");
	return 0;
}