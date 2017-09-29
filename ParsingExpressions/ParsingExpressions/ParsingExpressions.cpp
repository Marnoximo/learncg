// ParsingExpressions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include "UDStack.h"
#include <stack>
using namespace std;

int main()
{
	const char *p = "xyz";
	
	UDStack *stack3 = new UDStack("cbcd");
	UDStack *stack1 = new UDStack("abcd");
	cout << stack1->size() << endl;
	UDStack *stack2 = new UDStack(*stack1);
	
	while (stack2->isEmpty() == NULL)
	{
		cout << stack2->pop() << endl;
	}
	char ch[] = { 'a','a','b','d' };
	string str = ch;
	//cout << str;
	cout << sizeof(p);
	cin.get();
    return 0;
}

