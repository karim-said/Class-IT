#include"Header1.h"
#include<string>
#include<iostream>

using namespace std;

MyClass::MyClass()
{
	cout << "I'm a counctructor" << endl;
}

MyClass::~MyClass()
{
	cout << "I'm a Decounctructor" << endl;
}



std::string MyClass::Foo()
{
	// Function code goes here
	return "Hello, world!"; // Replace this with your actual implementation
}