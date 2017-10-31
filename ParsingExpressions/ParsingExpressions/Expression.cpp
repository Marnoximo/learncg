#include "stdafx.h"
#include "Expression.h"
#include <string>
#include <iostream>
#include "UDStack.h"
#include <list>

using namespace std;

const char *STR_DIGIT = "0123456789.";
const char *STR_PAREN = "()";
const char *STR_UNARY = "-";
const char *STR_BINARY = "+-*/^";
const char *STR_ALLOPER = "-+-*/^";
const char *STR_DELIMITER = "# ";
const char *STR_ALLCHAR = "()-+-*/^0123456789.";

PostfixExpression::PostfixExpression(const std::string &str)
{
	pos_expr = new std::string();
	std::string expression = str;
	refine(expression);
	this->build_stack(expression);
}

PostfixExpression::~PostfixExpression()
{
	delete pos_expr;
}
void PostfixExpression::refine(std::string &str)
{

}

void PostfixExpression::build_stack(const std::string &str)
{
	UDStack *operator_stack = new UDStack();
	for (unsigned int i = 0; i < str.length(); i++)
	{
		switch (str[i])
		{
			case '(':
			{
				operator_stack->push(str[i]);
				break;
			}

			case ')':
			{
				char top_el = 0;
				while (top_el != '(')
				{
					top_el = operator_stack->popChar();
					if (top_el != '(')
						this->pos_expr->push_back(top_el);
				}
				break;
			}

			case '+': case '-': case '*': case '/':
			{
				while (operator_stack->isEmpty() == false && (opr_priority(str[i]) <= opr_priority(operator_stack->peekTop())))
					this->pos_expr->push_back(operator_stack->popChar());
				operator_stack->push(str[i]);
				break;
			}

			default:
			{
				this->pos_expr->push_back(str[i]);
				if (!((str[i + 1] >= '0' && str[i + 1] <= '9') || str[i + 1] == '.'))
					this->pos_expr->push_back('#');
			}
				
		}
	}
	while(operator_stack->isEmpty()==false)
		this->pos_expr->push_back(operator_stack->popChar());

	delete operator_stack;
}

int PostfixExpression::opr_priority(const char &ch)
{
	switch (ch)
	{
	case '*':
	case '/':
		return 2;
	case '+':
	case '-':
		return 1;
	case '(':
		return 0;
	default:
		return 0;
	}
}

std::string PostfixExpression::to_string()const
{
	return *pos_expr;
}

double PostfixExpression::evaluate() const
{
	UDStack *eval_stack = new UDStack();
	double a, b, r;
	for (unsigned int i = 0; i < pos_expr->length(); i++)
	{
		if (opr_priority((*pos_expr)[i]) == 0)
		{
			eval_stack->push((*pos_expr)[i]);
		}
		else
		{
			b = std::stod(eval_stack->popNumberString());
			a = std::stod(eval_stack->popNumberString());
			switch ((*pos_expr)[i])
			{
			case '+':
			{
				r = a + b;
				break;
			}
			case '-':
			{
				r = a - b;
				break;
			}
			case '*':
			{
				r = a * b;
				break;
			}
			case '/':
			{
				r = a / b;
				break;
			}
			default:
				break;
			}
			//std::cout << "a= " << a << " b= " << b << " r= " << r << std::endl;
			//std::cin.get();
			eval_stack->push((std::to_string(r) + "#").c_str());
		}
	}
	/*
	UDStack copy(*eval_stack);
	while (copy.isEmpty() == false)
		std::cout << copy.popChar();
	std::cin.get();
	*/
	r = std::stod(eval_stack->popNumberString());
	return r;
}

/////////////////////////////////////////////////////////////////////
//////////////////// PREFIX EXPRESSIONS /////////////////////////////
/////////////////////////////////////////////////////////////////////

PrefixExpression::PrefixExpression(const std::string &str)
{
	pre_expr = new std::string();
	std::string expression = str;
	refine(expression);
	this->build_stack(expression);
}

void PrefixExpression::refine(std::string &str)
{

}

void PrefixExpression::build_stack(const std::string &str)
{
	UDStack *operator_stack = new UDStack();
	bool seperate = true;
	for (int i = str.length() - 1; i >= 0; i--)
	{
		switch (str[i])
		{
		case ')':
		{
			operator_stack->push(str[i]);
			break;
		}

		case '(':
		{
			char top_el = 0;
			while (top_el != ')')
			{
				top_el = operator_stack->popChar();
				if (top_el != ')')
					this->pre_expr->insert(pre_expr->begin(), top_el);
			}
			break;
		}

		case '+': case '-': case '*': case '/':
		{
			while (operator_stack->isEmpty() == false && (opr_priority(str[i]) <= opr_priority(operator_stack->peekTop())))
				this->pre_expr->insert(pre_expr->begin(), operator_stack->popChar());
			operator_stack->push(str[i]);
			seperate = true;
			break;
		}

		default:
		{
			if (seperate)
			{
				this->pre_expr->insert(pre_expr->begin(), '#');
				seperate = false;
			}
			this->pre_expr->insert(pre_expr->begin(), str[i]);
			//if (!((str[i - 1] >= '0' && str[i - 1] <= '9') || str[i - 1] == '.'))
			//	this->pre_expr->insert(pre_expr->begin(), '#');
		}

		}
	}
	while (operator_stack->isEmpty() == false)
		this->pre_expr->insert(pre_expr->begin(), operator_stack->popChar());

	delete operator_stack;
}

PrefixExpression::~PrefixExpression()
{
	delete pre_expr;
}

int PrefixExpression::opr_priority(const char &ch)
{
	switch (ch)
	{
	case '*':
	case '/':
		return 2;
	case '+':
	case '-':
		return 1;
	case '(':
		return 0;
	default:
		return 0;
	}
}

std::string PrefixExpression::to_string() const
{
	return *pre_expr;
}

double PrefixExpression::evaluate() const
{
	UDStack *eval_stack = new UDStack();
	UDStack *temp = new UDStack();
	
	double a, b, r;
	for (int i = pre_expr->length() - 1
		; i >= 0; i--)
	{
		if (opr_priority((*pre_expr)[i]) == 0)
		{
			//eval_stack->push((*pre_expr)[i]);

			while(opr_priority((*pre_expr)[i]) == 0)
			{
				temp->push((*pre_expr)[i]);
				i--;
			}
			i++;
			//std::cout << temp->size() << std::endl;
			while (temp->isEmpty() == false)
			{
				eval_stack->push(temp->popChar());
			}

			/*
			UDStack copy(*eval_stack);
			std::cout << "$";
			while (copy.isEmpty() == false)
				std::cout << copy.popCha
				r();
			std::cin.get();
			*/
		}
		else
		{
			b = std::stod(eval_stack->popNumberString());
			a = std::stod(eval_stack->popNumberString());
			switch ((*pre_expr)[i])
			{
			case '+':
			{
				r = a + b;
				break;
			}
			case '-':
			{
				r = a - b;
				break;
			}
			case '*':
			{
				r = a * b;
				break;
			}
			case '/':
			{
				r = a / b;
				break;
			}
			default:
				break;
			}
			/*
			std::cout << "a= " << a << " b= " << b << " r= " << r << std::endl;
			std::cin.get();
			*/
			eval_stack->push((std::to_string(r) + "#").c_str());
		}
	}
	/*
	UDStack copy(*eval_stack);
	while (copy.isEmpty() == false)
	std::cout << copy.popChar();
	std::cin.get();
	*/
	
	r = std::stod(eval_stack->popNumberString());
	return r;
}

//=========================================================//
//=========================================================//
//=========================================================//

Postfix::Postfix(const char *str)
{
	this->str = str;
	this->refine();
	this->build_stack();
}

Postfix::~Postfix()
{
	for each (Unit* var in l)
	{
		delete var;
	}
}
void Postfix::refine()
{
	int len = str.length();
	for (int i = 0; i < len; i++)
	{
		Unit *unit = new Unit();
		int numLen = 0;
		string num;
		
		unit_type type = NON;
		switch (recog_char(str.at(i)))
		{
		case NON:
			break;
		case DIGIT:
			nextDouble(str.c_str() + i, numLen);
			num.assign(str.c_str() + i, numLen);
			unit->setValue(num, DIGIT);
			l.push_back(unit);
			i = i + numLen - 1;
			break;
		case OPER:
			unit->setValue(str.at(i), OPER);
			type = l.back()->getType();
			if ((type == OPNPAREN || type == CLSPAREN || type == BINARY || l.size() == 0) && strstr(STR_UNARY, unit->getString().c_str()) != NULL)
				unit->setType(UNARY);
			else
				unit->setType(BINARY);
			l.push_back(unit);
			break;
		case CLSPAREN:
			unit->setValue(str.at(i), CLSPAREN);
			l.push_back(unit);
			break;
		case OPNPAREN:
			unit->setValue(str.at(i), OPNPAREN);
			l.push_back(unit);
			break;
		case DELIMIT:
			unit->setValue(str.at(i), DELIMIT);
			l.push_back(unit);
			break;
		default:
			break;
		}
	}
}

void Postfix::build_stack()
{
	PStack *oper_stack = new PStack();
	unit_type type;
	for each (Unit* unit in l)
	{
		type = unit->getType();
		switch (type)
		{
		case OPNPAREN:
			oper_stack->push(*unit);
			//cout << "OPNPAREN ";
			break;
		case CLSPAREN:
			while (oper_stack->peekTop().getType() != OPNPAREN)
			{
				stack.push(oper_stack->peekTop());
				oper_stack->pop();
			}
			oper_stack->pop();
			//cout << "CLSPAREN ";
			break;
		case BINARY:
			while (oper_stack->isEmpty() == false && getPriority(*unit) <= getPriority(oper_stack->peekTop()))
			{
				//cout << unit->getString() << "->" << getPriority(*unit) << " - " << oper_stack->peekTop().getString() << "->" << getPriority(oper_stack->peekTop()) << " ";
				stack.push(oper_stack->peekTop());
				oper_stack->pop();
			}
			oper_stack->push(*unit);
			//cout << "BINARY ";
			break;
		case UNARY:
			oper_stack->push(*unit);
			//cout << "UNARY ";
			break;
		default:
			stack.push(*unit);
			//cout << "DEFAULT ";
			break;
		}
		//showStack();
	}
	while (oper_stack->isEmpty() == false)
	{
		stack.push(oper_stack->peekTop());
		oper_stack->pop();
	}
	delete oper_stack;
}

unit_type Postfix::recog_char(char ch)
{
	if (ch == ' ')
		return DELIMIT;							// is a space
	if (ch >= '0' && ch <= '9')
		return DIGIT;							// is a digit
	if (strchr(STR_ALLOPER, ch) != NULL)
		return OPER;							// is a operator
	if (ch == '(')
		return OPNPAREN;							// is a parenthese
	if (ch == ')')
		return CLSPAREN;
	return NON;								// wrong format
}

//void Postfix::

double Postfix::nextDouble(const char *str, int &len)
{
	double num = 0, temp;
	bool dot = false;
	char ch;

	int iNum = 0, charLen = 0, strLen = strlen(str);
	for (int i = len; i < strLen; i++)
	{
		ch = str[i];
		if (ch >= '0' && ch <= '9')
		{
			if (dot)
			{
				temp = ch - 48;
				temp /= pow(10, iNum);
				num += temp;
				iNum++;
				charLen++;
			}
			else
			{
				temp = ch - 48;
				num *= 10;
				num += temp;
				charLen++;
			}
		}
		else
		{
			if (ch == '.')
			{
				if (dot == false)
				{
					dot = true;
					iNum = 1;
					charLen++;
				}
				else
				{
					throw "Wrong number format";
				}
				
			}
			else {
				break;
			}
		}
	}
	len = charLen;
	return num;
}

void Postfix::show() const
{
	for each (Unit* var in l)
	{
		cout << var->getString() << " type=" << var->getType() << endl;
	}
}

int Postfix::getPriority(const Unit &unit)
{
	unit_type type = unit.getType();
	string s, oper;
	int pos;

	switch (type)
	{
	case NON:
	case CLSPAREN:
	case OPNPAREN:
	case DIGIT:
	case DELIMIT:
		return 0;
	case BINARY:
		oper = unit.getString();
		s = "-+*/^";
		pos = s.find(oper);
		if (pos == 0 || pos == 1)
			return 1;
		if (pos == 2 || pos == 3)
			return 2;
		if (pos == 4)
			return 3;
		break;
	case UNARY:
		return 4;
		break;
	default:
		return 0;
		break;
	}
	return 0;
}

void Postfix::showStack() const
{
	PStack showStk = stack;
	list<Unit> lu;
	while (showStk.isEmpty() == false)
	{
		lu.insert(lu.begin(), showStk.peekTop());
		showStk.pop();
	}

	for each (Unit var in lu)
	{
		cout << var.getString() << "$";
	}
	cout << endl;
}