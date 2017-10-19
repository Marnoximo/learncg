// ParsingExpressions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include "UDStack.h"
#include <stack>
#include "Expression.h"
using namespace std;

int main()
{
	PostfixExpression *pe = new PostfixExpression("(10.1*3+7/8)*(5-1)");
	cout << pe->to_string() << endl;
	cout << "Result= " << pe->evaluate() << "$" << endl;

	PrefixExpression *pre = new PrefixExpression("(10.1*3+7/8)*(5-1)");
	cout << pre->to_string() << "$" << endl;
	cout << "Result= " << pre->evaluate() << endl;

	cin.get();
    return 0;
}

