#pragma once
#include <string>
#include "UDStack.h"
#include <list>
#include "PStack.h"


 
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

class Postfix
{
private:
	std::list<Unit*> l;
	std::string str;
	PStack stack;
	void build_stack();
	void refine();
	
	static unit_type recog_char(char ch);
	static double nextDouble(const char *str, int &len);
public:
	static int getPriority(const Unit &unit);
	Postfix(const char* str);
	Postfix(const std::string & str);
	~Postfix();
	void showStack() const;
	void show() const;
};