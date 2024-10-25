// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "YJLibrary.generated.h"

/**
 * 
 */
UCLASS()
class UE5MAGIC_API UYJLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()
	UFUNCTION(BlueprintCallable, meta = (DisplayName = "Adds floats", Keywords = "Float Add"), Category = YJLibrary)
	static float AddFloats(float A, float B);
};
