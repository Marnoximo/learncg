#include "stdafx.h"
#include "PStack.h"
#include <string.h>
#include <string>

using namespace std;


//========UNIT===========//
Unit::Unit()
{
	this->str = "";
	this->type = NON;
}
Unit::Unit(char ch, unit_type type)
{
	this->str = ch;
}
Unit::Unit(const char *str, unit_type type)
{
	this->str = str;
	this->type = type;
}
Unit::Unit(const string &str, unit_type type)
{
	this->str = str;
	this->type = type;
}
Unit::Unit(const Unit &u)
{
	this->type = u.getType();
	this->str = u.getString();
}
Unit::~Unit()
{
}
void Unit::setValue(const char *str, unit_type type)
{
	this->str = str;
	this->type = type;
}
void Unit::setValue(const string &str, unit_type type)
{
	this->str = str;
	this->type = type;
}
void Unit::setValue(char ch, unit_type type)
{
	this->str = ch;
	this->type = type;
}
void Unit::setType(unit_type type)
{
	this->type = type;
}
unit_type Unit::getType() const
{
	return this->type;
}
string Unit::getString() const
{
	return this->str;
}

Unit & Unit::operator=(const Unit &unit)
{
	this->str = unit.getString();
	this->type = unit.getType();
	return *this;
}


//===============STACK=================//

PStack::PStack()
{
	this->top = NULL;
	this->size = 0;
}

PStack::PStack(const PStack &stack)
{
	/*
	Node *cur = stack.top;
	this->size = stack.size;
	Node **allNode = new Node*[this->size];
	int i = size - 1;
	while (cur != NULL)
	{
		allNode[i] = cur;
		cur = cur->prev;
		i--;
	}

	for (i = 0; i < size; i++)
	{
		push(allNode[i]->unit);
	}
	delete allNode;
	*/
	Node *cur = stack.top;
	PStack *temp = new PStack();
	int i = stack.size;
	while (i > 0)
	{
		temp->push(cur->unit);
		cur = cur->prev;
		i--;
	}
	while (temp->isEmpty() == false)
	{
		this->push(temp->peekTop());
		temp->pop();
	}
	delete temp;
}

PStack::~PStack()
{
	while (this->top != NULL)
	{
		Node *toDelete = this->top;
		this->top = this->top->prev;
		delete toDelete;
	}
}

void PStack::push(const Unit &p)
{
	Node *node = new Node{ p, this->top };
	this->top = node;
	this->size++;
}

Unit& PStack::peekTop()
{
	return this->top->unit;
}

void PStack::pop()
{
	Node *toDelete = this->top;
	this->top = this->top->prev;
	delete toDelete;
	this->size--;
}

int PStack::getSize() const
{
	return this->size;
}

bool PStack::isEmpty() const
{
	if (this->size == 0)
		return true;
	return false;
}