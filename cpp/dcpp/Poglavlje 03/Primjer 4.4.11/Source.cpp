#include <iostream>
using namespace std;

/*

*/

int main()
{
	unsigned char a = 0x25; // 00100101 u heksadec.prikazu
	unsigned char b = ~a; // pridruzi bitovni komplement
	cout << hex << (int)a << endl;// ispisuje a u hex-formatu
	cout << (int)b << endl; // ispisuje b u hex-formatu

	system("pause");
	return 0;
}