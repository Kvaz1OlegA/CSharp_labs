#ifndef TaskDllH
#define TaskDllH

extern "C" int __declspec(dllexport) __stdcall BinPow(int a, int n);

extern "C" int __declspec(dllexport) __cdecl Sum(int a, int b);

#endif
