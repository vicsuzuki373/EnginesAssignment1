#define _CRT_SECURE_NO_WARNINGS
#include "SimpleClass.h"
#include <iostream>
#include <fstream>
#include <string>
using namespace std;
#define CHAR_BUFFER_SIZE 128


void SimpleClass::SaveWall(float x, float y, float z, float qx, float qy, float qz, float qw)
{
	X.push_back(x);
	Y.push_back(y);
	Z.push_back(z);
	QuatX.push_back(qx);
	QuatY.push_back(qy);
	QuatZ.push_back(qz);
	QuatW.push_back(qw);
}

void SimpleClass::SavePlayer(float x, float y, float z)
{
	PX = x;
	PY = y;
	PZ = z;
}

void SimpleClass::SaveObjective(float x, float y, float z)
{
	OX = x;
	OY = y;
	OZ = z;
}

void SimpleClass::SaveToFile()
{
	
	ofstream myfile;
	myfile.open("data.txt", ofstream::out | ofstream::trunc);
	if (myfile.is_open())
	{
		myfile << "Player " << PX << " " << PY << " " << PZ << endl;
		myfile << "Objective " << OX << " " << OY << " " << OZ << endl;
		for (int i = 0; i < X.size(); i++) {
			myfile << "Wall " << X[i] << " " << Y[i] << " " << Z[i] << " " << QuatX[i] << " " << QuatY[i] << " " << QuatZ[i] << " " << QuatW[i] << endl;
		}
		myfile.close();
	}
	X.clear();
	Y.clear();
	Z.clear();
	QuatX.clear();
	QuatY.clear();
	QuatZ.clear();
	QuatW.clear();
}

void SimpleClass::LoadFile()
{
	ifstream input("data.txt");
	char inputString[CHAR_BUFFER_SIZE];

	X.clear();
	Y.clear();
	Z.clear();
	QuatX.clear();
	QuatY.clear();
	QuatZ.clear();
	QuatW.clear();

	while (!input.eof())
	{
		input.getline(inputString, CHAR_BUFFER_SIZE);
		if (strstr(inputString, "Player") != nullptr)
		{
			float temp1;
			float temp2;
			float temp3;
			sscanf(inputString, "Player %f %f %f", &temp1, &temp2, &temp3);
			PX = temp1;
			PY = temp2;
			PZ = temp3;
		}
		else if (strstr(inputString, "Objective") != nullptr)
		{
			float temp1;
			float temp2;
			float temp3;
			sscanf(inputString, "Objective %f %f %f", &temp1, &temp2, &temp3);
			OX = temp1;
			OY = temp2;
			OZ = temp3;
		}
		else if (strstr(inputString, "Wall") != nullptr)
		{
			float temp1;
			float temp2;
			float temp3;
			float temp4;
			float temp5;
			float temp6;
			float temp7;
			sscanf(inputString, "Wall %f %f %f %f %f %f %f", &temp1, &temp2, &temp3, &temp4, &temp5, &temp6, &temp7);
			X.push_back(temp1);
			Y.push_back(temp2);
			Z.push_back(temp3);
			QuatX.push_back(temp4);
			QuatY.push_back(temp5);
			QuatZ.push_back(temp6);
			QuatW.push_back(temp7);
		}
	}
	input.close();
}

float SimpleClass::getPX()
{
	return PX;
}

float SimpleClass::getPY()
{
	return PY;
}

float SimpleClass::getPZ()
{
	return PZ;
}

float SimpleClass::getOX()
{
	return OX;
}

float SimpleClass::getOY()
{
	return OY;
}

float SimpleClass::getOZ()
{
	return OZ;
}

float SimpleClass::getX(int n)
{
	return X[n];
}

float SimpleClass::getY(int n)
{
	return Y[n];
}

float SimpleClass::getZ(int n)
{
	return Z[n];
}

float SimpleClass::getQuatX(int n)
{
	return QuatX[n];
}

float SimpleClass::getQuatY(int n)
{
	return QuatY[n];
}

float SimpleClass::getQuatZ(int n)
{
	return QuatZ[n];
}

float SimpleClass::getQuatW(int n)
{
	return QuatW[n];
}

int SimpleClass::getSize()
{
	return X.size();
}
