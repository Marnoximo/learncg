#pragma once
#include <string>

class PrefixExpression
{
private:
	char *ch;
	static bool isNumber(const char &p);
	static double calculate(const char &o, const char &n1, const char &n2);
public:
	PrefixExpression();
	PrefixExpression(const char *p);
	PrefixExpression(const std::string &str);
	virtual ~PrefixExpression();
	virtual std::string getString() const;
	virtual double evaluate() const;

};

class InfixExpression
{
private:
	char *ch;
public:
	InfixExpression();
	InfixExpression(const char *p);
	InfixExpression(const std::string &string);
	virtual ~InfixExpression();
	virtual void display() const;
};

class PostfixExpression
{
private:
	char *ch;
public:
	PostfixExpression();
	PostfixExpression(const char *p);
	virtual ~PostfixExpression();
	virtual void display() const;
	virtual double evaluate() const;
};