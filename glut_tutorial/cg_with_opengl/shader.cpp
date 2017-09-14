#include "shader.h"
#include <iostream>
#include <fstream>
#include <sstream>
#include <string>

using namespace std;


shader::shader(const char* vShaderPath, const char* fShaderPath)
{
	string vertexCode, fragmentCode;
	ifstream vShaderFile, fShaderFile;

	vShaderFile.exceptions(ifstream::failbit | ifstream::badbit);
	fShaderFile.exceptions(ifstream::failbit | ifstream::badbit);
	try 
	{
		vShaderFile.open(vShaderPath);
		fShaderFile.open(fShaderPath);
		stringstream vShaderStream, fShaderStream;
		vShaderStream << vShaderFile.rdbuf();
		fShaderStream << fShaderFile.rdbuf();
		vShaderFile.close();
		fShaderFile.close();
		vertexCode = vShaderStream.str();
		fragmentCode = fShaderStream.str();
	}
	catch (ifstream::failure e)
	{
		cout << "ERROR::SHADER::FILE_NOT_SUCCESFULLY_READ" << endl;
	}

	const char* vShaderCode = vertexCode.c_str(), * fShaderCode = fragmentCode.c_str();

	unsigned int vShaderID, fShaderID;
	int errorCode;
	char infoLog[512];

	vShaderID = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(vShaderID, 1, &vShaderCode, NULL);
	glCompileShader(vShaderID);
	glGetShaderiv(vShaderID, GL_COMPILE_STATUS, &errorCode);
	if (!errorCode)
	{
		glGetShaderInfoLog(vShaderID, 512, NULL, infoLog);
		cout << "ERROR::SHADER::VERTEX::COMPILATION_FAILED\n" << infoLog << endl;
	}

	fShaderID = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(fShaderID, 1, &fShaderCode, NULL);
	glCompileShader(fShaderID);
	glGetShaderiv(fShaderID, GL_COMPILE_STATUS, &errorCode);
	if (!errorCode)
	{
		glGetShaderInfoLog(fShaderID, 512, NULL, infoLog);
		cout << "ERROR::SHADER::FRAGMENT::COMPILATION_FAILED\n" << infoLog << endl;
	}

	this->ID = glCreateProgram();
	glAttachShader(this->ID, vShaderID);
	glAttachShader(this->ID, fShaderID);
	glLinkProgram(this->ID);
	glGetProgramiv(this->ID, GL_LINK_STATUS, &errorCode);
	if (!errorCode)
	{
		glGetProgramInfoLog(this->ID, 512, NULL, infoLog);
		cout << "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" << infoLog << endl;
	}

	glDeleteShader(vShaderID);
	glDeleteShader(fShaderID);
}

shader::~shader()
{
}

void shader::use()
{
	glUseProgram(this->ID);
}

void shader::setBool(const string &name, bool value) const
{
	glUniform1i(glGetUniformLocation(ID, name.c_str()), (int)value);
}
void shader::setInt(const string &name, int value) const
{
	glUniform1i(glGetUniformLocation(ID, name.c_str()), value);
}
void shader::setFloat(const string &name, float value) const
{
	glUniform1f(glGetUniformLocation(ID, name.c_str()), value);
}
