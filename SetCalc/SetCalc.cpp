// This is the main DLL file.

#include "stdafx.h"

#include "SetCalc.h"

float SetCalc::MandelSet::DoesBelong(double x, double y, int maxiter)
{
	if (BelongToCardioid(x, y)) return maxiter;
	__asm {
		mov EAX, x

	}
	return maxiter;
}

bool SetCalc::MandelSet::BelongToCardioid(double x, double y)
{
	x -= 0.25; y *= y;
	double q = x * x + y + x;
	return (q - x) * q * 4 < y;
}

float * SetCalc::MapsWork::GetDepthMap(int width, int height, double scale, double a, double b, int iter_max)
{
	__asm
	{
		push eax
		push ebx
			mov ax, width  // width = width / 2
			shr ax, 1
			push eax

			mov ax, height // height = height / 2
			shr ax, 1
			push eax

			mov ax, 0   // x
			:xmark
			mov bx, 0   // y
			: ymark
			// тело цикла
			inc bx
			pop ecx
			cmp bx, cx
			jnz ymark  // while y < height
			inc ax
			pop ecx
			cmp ax, cx // while x < width
			jnz xmark
			pop ebx
			pop eax
	}
}