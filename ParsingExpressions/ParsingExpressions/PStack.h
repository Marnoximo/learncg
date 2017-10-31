#pragma once
#include <string>

enum unit_type {NON, UNARY, BINARY, DIGIT, OPNPAREN, CLSPAREN, DELIMIT, OPER};

class Unit
{
private:
	std::string str;
	unit_type type;
	//int priority;

public:
	Unit();
	Unit(char ch, unit_type type);
	Unit(const char *str, unit_type);
	Unit(const std::string &str, unit_type type);
	Unit(const Unit &u);
	virtual ~Unit();
	void setValue(char ch, unit_type type);
	void setValue(const char *str, unit_type type);
	void setValue(const std::string &str, unit_type type);
	void setType(unit_type type);
	Unit& operator=(const Unit &unit);
	unit_type getType() const;
	std::string getString() const;
};

class UnaryOperator : public Unit
{
private:

public:
	UnaryOperator(const char *str);
	UnaryOperator(const UnaryOperator &op);
	virtual ~UnaryOperator();
};

class BinaryOperator : public Unit
{
private:
public:
	BinaryOperator(const char *str);
	BinaryOperator(const BinaryOperator &op);
	virtual ~BinaryOperator();
};


class PStack
{
private:
	struct Node
	{
		Unit unit;
		Node *prev;
	} *top;
	int size;

public:
	PStack();
	PStack(const PStack &stack);
	~PStack();

	void push(const Unit &p);
	void pop();
	Unit& peekTop();
	int getSize() const;
	bool isEmpty() const;

};

