// SetCalc.h

#pragma once

using namespace System;

namespace SetCalc {

	static public class MandelSet
	{
		static float DoesBelong(double x, double y, int maxiter);
		static bool BelongToCardioid(double x, double y);
	};
	public ref class MapsWork
	{
		static float* GetDepthMap(int width, int height, double scale, double a, double b, int iter_max);
	};
	public ref class ColorWork
	{
		// TODO: Add your methods for this class here.
	};
}
