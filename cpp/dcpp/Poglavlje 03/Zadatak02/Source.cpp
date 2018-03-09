#include <iostream>
using namespace std;

/*
	Zadatak.   Da li ce postojati razlika pri ispisu u donjim naredbama (varijable a i b
	deklarirane su u prethodnom zadatku):

	float c = a / 3;
	cout << c * b << endl;
	c = a / 3.;
	cout << c * b << endl;
	c = b * a;
	cout << c / 3 << endl;

	DA
*/

int main()
{
	int a = 10;
	float b = 10;

	float c = a / 3;
	cout << c * b << endl; //30
	c = a / 3.;
	cout << c * b << endl; //33.33
	c = b * a;
	cout << c / 3 << endl; //33.33

	system("pause");
	return 0;
}