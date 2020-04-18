#pragma hdrstop
#pragma argsused

extern "C" int _libmain(unsigned long reason)
{
	return 1;
}

extern "C" int __declspec(dllexport) __stdcall BinPow(int a, int n)
{
	if (n == 0)
		return 1;
	if (n % 2 == 1)
		return BinPow (a, n-1) * a;
	else {
		int b = BinPow (a, n/2);
		return b * b;
	}
}

extern "C" int __declspec(dllexport) __cdecl Sum(int a, int b)
{
	return a+b;
}

