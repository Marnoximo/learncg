#pragma once
#include <string>
#include "UDStack.h"

class Expression
{

};
class PrefixExpression
{
private:
	std::string *pre_expr;
	static void refine(std::string &str);
	void build_stack(const std::string &str);
	static int opr_priority(const char &ch);
public:
	PrefixExpression(const std::string &str);
	virtual ~PrefixExpression();
	virtual std::string to_string() const;
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
	std::string *pos_expr;
	static void refine(std::string &str);
	void build_stack(const std::string &str);
	static int opr_priority(const char &ch);

public:
	PostfixExpression(const std::string &str);
	virtual ~PostfixExpression();
	virtual std::string to_string() const;
	virtual double evaluate() const;
};