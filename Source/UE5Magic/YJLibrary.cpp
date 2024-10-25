// Fill out your copyright notice in the Description page of Project Settings.


#include "YJLibrary.h"
#include "YJMagic.h"

float UYJLibrary::AddFloats(float A, float B)
{
	// Create a pointer to the class YJMagic
	YJMagic::YJMagic* PointerToYJMagic;

	// Create an object of type YJMagic and link the pointer to it
	PointerToYJMagic = new YJMagic::YJMagic();

	// Call the function inside YJMagic via -> 
	return PointerToYJMagic->Add(A, B);
	
}
