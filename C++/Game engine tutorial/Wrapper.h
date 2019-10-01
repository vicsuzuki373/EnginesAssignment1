#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Put functions here
	PLUGIN_API void SaveWall(float x, float y, float z, float degrees);
	PLUGIN_API void SavePlayer(float x, float y, float z);
	PLUGIN_API void SaveObjective(float x, float y, float z);
	PLUGIN_API void SaveToFile();
	PLUGIN_API void LoadFile();
	PLUGIN_API float getPX();
	PLUGIN_API float getPY();
	PLUGIN_API float getPZ();
	PLUGIN_API float getOX();
	PLUGIN_API float getOY();
	PLUGIN_API float getOZ();
	PLUGIN_API float getX(int n);
	PLUGIN_API float getY(int n);
	PLUGIN_API float getZ(int n);
	PLUGIN_API float getAngle(int n);

#ifdef __cplusplus
}
#endif
