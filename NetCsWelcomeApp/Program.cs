byte n1;   // 0..255
sbyte n2;  // -128..127

// 2 byte
short n3;  // -32768..32767
ushort n4; // 0..65535

// 4 byte
int n5;    // -2147483648..2147483647
uint n6;   // 0..4294967295

long n7;   // –9223372036854775808 до 9223372036854775807
ulong n8;  //  0 до 18446744073709551615


// 4 byte
float x1; // -3.4*10^38 до 3.4*10^38

// 8 byte
double x2; //  ±5.0*10^-324 до ±1.7*10^308

x2 = 123.904;
x2 = 0.123904e3;
x2 = 0.45e-4;

decimal x3;

int n10 = 123;
long n11 = 123L;

x1 = 1.5F;
x3 = 1.5M;


bool f1;
f1 = true;
f1 = false;


char symbol;
symbol = 'a';

string str = "Hello world";