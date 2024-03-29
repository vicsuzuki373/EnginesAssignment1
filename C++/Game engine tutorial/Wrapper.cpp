#include "Wrapper.h"

SimpleClass simpleClass;

void SaveWall(float x, float y, float z, float qx, float qy, float qz, float qw)
{
	simpleClass.SaveWall(x, y, z, qx, qy, qz, qw);
}

void SavePlayer(float x, float y, float z)
{
	simpleClass.SavePlayer(x, y, z);
}

void SaveObjective(float x, float y, float z)
{
	simpleClass.SaveObjective(x, y, z);
}

void SaveToFile()
{
	simpleClass.SaveToFile();
}

void LoadFile()
{
	simpleClass.LoadFile();
}

float getPX()
{
	return simpleClass.getPX();
}

float getPY()
{
	return simpleClass.getPY();
}

float getPZ()
{
	return simpleClass.getPZ();
}

float getOX()
{
	return simpleClass.getOX();
}

float getOY()
{
	return simpleClass.getOY();
}

float getOZ()
{
	return simpleClass.getOZ();
}

float getX(int n)
{
	return simpleClass.getX(n);
}

float getY(int n)
{
	return simpleClass.getY(n);
}

float getZ(int n)
{
	return simpleClass.getZ(n);
}

float getQuatX(int n)
{
	return simpleClass.getQuatX(n);
}

float getQuatY(int n)
{
	return simpleClass.getQuatY(n);
}

float getQuatZ(int n)
{
	return simpleClass.getQuatZ(n);
}

float getQuatW(int n)
{
	return simpleClass.getQuatW(n);
}

int getSize()
{
	return simpleClass.getSize();
}