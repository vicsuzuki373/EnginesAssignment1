#pragma once

#include "PluginSettings.h"
#include <vector>
#include <string>
using namespace std;

class PLUGIN_API SimpleClass
{
public:
	void SaveWall(float x, float y, float z, float degrees);
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
	float getAngle(int n);
	int getSize();
private:
	vector<float> X;
	vector<float> Y;
	vector<float> Z;
	vector<float> Angle;
	float PX, PY, PZ, OX, OY, OZ;
};