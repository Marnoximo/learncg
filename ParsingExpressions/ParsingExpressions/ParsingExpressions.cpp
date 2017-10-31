// ParsingExpressions.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include "UDStack.h"
#include <stack>
#include "Expression.h"
#include <math.h>
#include "PStack.h"

using namespace std;

int main()
{
	PostfixExpression *pe = new PostfixExpression("(10.1*3+7/8)*(5-1)");
	cout << pe->to_string() << endl;
	cout << "Result= " << pe->evaluate() << "$" << endl;

	PrefixExpression *pre = new PrefixExpression("(10.1*3+7/8)*(5-1)");
	cout << pre->to_string() << "$" << endl;
	cout << "Result= " << pre->evaluate() << endl;
	cout << "(10.1*3+7/8)*(5-1)" << endl;
	//format_string("(10.1*3+7/8)*(5-1)");
	//cout << endl;
	//int len =  0;
	//double num = parseDouble("760.1290+160.160", len);
	//cout << endl << num << " " << len << endl;
	//len++;
	//cout << parseDouble("760.1290+160.162", len) << " " << len << endl;

	cout << "====================================\n";

	string exp = "(10.1*-3^3+7^2/8)*(5.121-1.2321^4)";
	Postfix *pf = new Postfix(exp.c_str());
	cout << exp << endl;
	pf->show();

	pf->showStack();
	

	cin.get();
    return 0;
}
