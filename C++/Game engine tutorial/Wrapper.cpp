#include "Wrapper.h"

SimpleClass simpleClass;

int SimpleFunction()
{
	return simpleClass.SimpleFunction();
}

int SaveObject(float x, float y, float z)
{
	return simpleClass.SaveObject(x, y, z);
}

void LoadFile()
{
	simpleClass.LoadFile();
}

float getX()
{
	return simpleClass.getX();
}

float getY()
{
	return simpleClass.getY();
}

float getZ()
{
	return simpleClass.getZ();
}