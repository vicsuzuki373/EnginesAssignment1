#define _CRT_SECURE_NO_WARNINGS
#include "SimpleClass.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
#define CHAR_BUFFER_SIZE 128

int SimpleClass::SimpleFunction()
{
	return 1;
}

int SimpleClass::SaveObject(float x, float y, float z)
{
	ofstream myfile("data.txt");
	if (myfile.is_open())
	{
		myfile << "X " << x << "\n";
		myfile << "Y " << y << "\n";
		myfile << "Z " << z << "\n";
		myfile.close();
		return 1;
	}
	else return 0;
}

void SimpleClass::LoadFile()
{
	ifstream input("data.txt");
	char inputString[CHAR_BUFFER_SIZE];

	while (!input.eof())
	{
		input.getline(inputString, CHAR_BUFFER_SIZE);
		if (strstr(inputString, "X") != nullptr)
		{
			float temp;
			sscanf(inputString, "X %f", &temp);
			X = temp;
		}
		else if (strstr(inputString, "Y") != nullptr)
		{
			float temp;
			sscanf(inputString, "Y %f", &temp);
			Y = temp;
		}
		else if (strstr(inputString, "Z") != nullptr)
		{
			float temp;
			sscanf(inputString, "Z %f", &temp);
			Z = temp;
		}
	}
	input.close();

}

float SimpleClass::getX()
{
	return X;
}

float SimpleClass::getY()
{
	return Y;
}

float SimpleClass::getZ()
{
	return Z;
}