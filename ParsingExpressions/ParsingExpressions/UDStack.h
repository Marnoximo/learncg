#pragma once
#include <string>
struct Node {
	char ch;			// Character hold
	Node *previous;		// Pointer to the lower/previous element
};
class UDStack
{
private:
	Node *top;		// Pointer to the top element
	int num;		// Number of elements in stack
	
public:
	// Constructors
	UDStack();							// Default constructor
	UDStack(const char *p);				// Constructor with a parameter of a string literal
	UDStack(const UDStack &stack);		// Copy constructor

	// Const methods
	Node* topElement() const;	// Return a pointer to the top element
	int size() const;			// Return size of a stack
	char peekTop() const;		// Return the value of the top element, not pop it
	bool isEmpty() const;		// Check if stack is empty or not

	// Non-const methods
	void push(char ch);					// Push a char into stack
	void push(const char *p);			// Push all characters of a string literal into stack
	char popChar();						// Pop one character
	std::string popNumberString();					// Pop one number
	//const char* popAll();				// Pop all

	// Destructors
	~UDStack();							// Default destructor
};

