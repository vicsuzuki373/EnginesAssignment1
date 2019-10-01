#pragma once

#include "PluginSettings.h"
#include <vector>
#include <string>
using namespace std;

class PLUGIN_API SimpleClass
{
public:
	void SaveWall(float x, float y, float z, float qx, float qy, float qz, float qw);
	void SavePlayer(float x, float y, float z);
	void SaveObjective(float x, float y, float z);
	void SaveToFile();
	void LoadFile();
	float getPX();
	float getPY();
	float getPZ();
	float getOX();
	float getOY();
	float getOZ();
	float getX(int n);
	float getY(int n);
	float getZ(int n);
	float getQuatX(int n);
	float getQuatY(int n);
	float getQuatZ(int n);
	float getQuatW(int n);
	int getSize();
private:
	vector<float> X;
	vector<float> Y;
	vector<float> Z;
	vector<float> QuatX;
	vector<float> QuatY;
	vector<float> QuatZ;
	vector<float> QuatW;
	float PX, PY, PZ, OX, OY, OZ;
};