//////////////////////////////////////////////////////////////////////////////
//
//  --- LoadShaders.h ---
//
//////////////////////////////////////////////////////////////////////////////

#ifndef __LOAD_SHADERS_H__
#define __LOAD_SHADERS_H__

#include "Gl/freeglut.h"
#ifdef __cplusplus
extern "C" {
#endif  // __cplusplus

	GLuint LoadShaders(const char* vertex_file_path, const char * fragment_file_path);

//----------------------------------------------------------------------------

#ifdef __cplusplus
};
#endif // __cplusplus

#endif // __LOAD_SHADERS_H__
