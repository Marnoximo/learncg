#include "stdafx.h"
#include "Expression.h"
#include <string>
#include <iostream>
#include "UDStack.h"

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
	for (int i = 0; i < str.length(); i++)
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
	for (int i = 0; i < pos_expr->length(); i++)
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