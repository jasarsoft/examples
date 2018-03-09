#include <iostream>
using namespace std;

/*

*/

int main()
{
	enum Logicki {
		NEISTINA, 
		ISTINA, 
		DRUGAISTINA = 124
	};

	Logicki a = NEISTINA;
	Logicki b = ISTINA;
	Logicki c = DRUGAISTINA;

	cout << "a = " << a << ", b = " << b << ", c = " << c << endl;

	cout << "Suprotno od a = " << !a << endl;
	cout << "Suprotno od b = " << !b << endl;
	cout << "Suprotno od c = " << !c << endl;

	cout << "a i b = " << (a && b) << endl;
	cout << "a ili b = " << (a || b) << endl;

	system("pause");
	return 0;
}