#ifndef _SHADER_H
#define _SHADER_H

#include <GL/glew.h>
#include <GL/glfw3.h>
#include <iostream>
#include <fstream>
#include <sstream>
#include <string>

class shader
{
public:
	unsigned int ID;

	shader(const char * vShaderPath, const char* fShaderPath);
	~shader();
	void use();
	void setBool(const std::string &name, bool value) const;
	void setInt(const std::string &name, int value) const;
	void setFloat(const std::string &name, float value) const;
};

#endif