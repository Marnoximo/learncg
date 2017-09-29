#include "stdafx.h"
#include "Expression.h"
#include <string>
#include "UDStack.h"

PrefixExpression::PrefixExpression()
{
	ch = NULL;
}
PrefixExpression::PrefixExpression(const char *p)
{
	ch = new char[sizeof(p)];
	for (int i = 0; i < sizeof(p); i++)
		ch[i] = p[i];
}
PrefixExpression::PrefixExpression(const std::string &str)
{
	ch = new char[str.capacity()];
	for (int i = 0; i < str.capacity(); i++)
		ch[i] = str[i];
}
PrefixExpression::~PrefixExpression()
{
	if (ch != NULL)
		delete[] ch;
}
std::string PrefixExpression::getString() const
{
	std::string str = ch;
	str += "";
	return str;
}
double PrefixExpression::evaluate() const
{
	UDStack *stack = new UDStack();
	char o, n1, n2, r;
	for (int i = sizeof(ch)-1;i>=0;i--)
	{
		if (isNumber(ch[i]))
			stack->push(ch[i]);
		else
		{
			o = ch[i];
			n1 = stack->pop();
			n2 = stack->pop();
			r = calculate(, )
		}
	}
}
bool PrefixExpression::isNumber(const char &p)
{
	if (p >= 48 && p <= 57)
		return true;
	else
		return false;
}
double PrefixExpression::calculate(const char &o, const char &n1, const char &n2)
{
	int num1 = n1 - 48, num2 = n2 - 48;
	switch (o)
	{
	case '+':
		return n1 + n2;
	case '-':
		return n1 - n2;
	case '*':
		return n1 * n2;
	case '/':
		return n1 / n2;
	default:
		throw "WRONG INPUT FORMAT";
	}
}