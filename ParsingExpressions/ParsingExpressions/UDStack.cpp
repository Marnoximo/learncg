#include "stdafx.h"
#include "UDStack.h"
#include <string>
#include <iostream>

UDStack::UDStack()
{
	this->top = NULL;
	this->num = 0;
}

UDStack::UDStack(const UDStack &stack)
{
	// Create an array to save values of elements in original stack
	char *charArray = new char[stack.size()];
	// A pointer points to the top element of stack
	Node *p = stack.topElement();
	// Save values when traverse throughout the stack
	for (int i = stack.size() - 1; i >= 0; i--)
	{
		charArray[i] = p->ch;
		p = p->previous;
	}
	// Push values into new stack
	for (int i = 0; i < stack.size(); i++)
	{
		this->push(charArray[i]);
	}
	delete[] charArray;
}

UDStack::UDStack(const char *p)
{
	num = 0;
	this->push(p);
}

int UDStack::size() const
{
	return num;
}

Node* UDStack::topElement()const
{
	return top;
}
void UDStack::push(char ch)
{
	num++;
	Node *newNode = new Node{ ch, NULL };
	newNode->previous = top;
	top = newNode;
}

void UDStack::push(const char *p)
{
	int i = 0;
	while (p[i] != '\0')
	{
		this->push(p[i]);
		i++;
	}
}
char UDStack::popChar()
{
	if (this->isEmpty() == false)
	{
		num--;
		char topChar = top->ch;
		Node *toDelete = top;
		top = top->previous;
		delete toDelete;
		return topChar;
	}
	else
		throw "STACK IS EMPTY";
}
char UDStack::peekTop() const
{
	if (this->isEmpty() == false)
	{
		char topChar = top->ch;
		return topChar;
	}
	else
		return 0;
}

bool UDStack::isEmpty() const
{
	if (top == NULL)
		return true;
	else
		return false;
}
UDStack::~UDStack()
{
	while (top != NULL)
	{
		Node *toDelete = top;
		top = top->previous;
		delete toDelete;
	}
}

std::string UDStack::popNumberString()
{
	std::string value = "";
	char topChar = this->peekTop();
	if (topChar != '#')
	{
		return value;
	}
	else
	{
		this->popChar();
		topChar = this->peekTop();
		while (this->isEmpty() == false && ((topChar >= '0' && topChar <= '9') || (topChar == '.')))
		{
			value.insert(value.begin(), this->popChar());
			topChar = this->peekTop();
		}
		return value;
	}
}