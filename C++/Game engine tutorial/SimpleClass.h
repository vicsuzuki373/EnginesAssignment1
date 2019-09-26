#pragma once

#include "PluginSettings.h"

class PLUGIN_API SimpleClass
{
public:
	int SimpleFunction();
	int SaveObject(float x, float y, float z);
	void LoadFile();
	float getX();
	float getY();
	float getZ();
private:
	float X = 0.0f;
	float Y = 0.0f;
	float Z = 0.0f;
};