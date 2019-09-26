#pragma once
#include "PluginSettings.h"
#include "SimpleClass.h"

#ifdef __cplusplus
extern "C"
{
#endif

	//Put functions here
	PLUGIN_API int SimpleFunction();
	PLUGIN_API int SaveObject(float x, float y, float z);
	PLUGIN_API void LoadFile();
	PLUGIN_API float getX();
	PLUGIN_API float getY();
	PLUGIN_API float getZ();

#ifdef __cplusplus
}
#endif
