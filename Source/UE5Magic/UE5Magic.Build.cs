// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;


public class UE5Magic : ModuleRules
{

   
    public UE5Magic(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });


        LoadYJMagicLib(Target);

    }

	public bool LoadYJMagicLib(ReadOnlyTargetRules Target)
	{

        bool isLibrarySupported = false;

        if ((Target.Platform == UnrealTargetPlatform.Win64))
        {
            isLibrarySupported = true;

            PublicAdditionalLibraries.Add("D:\\UE5Magic\\ThirdParty\\YJMagicLib\\Libraries\\YJMagicLib.lib");
            PublicIncludePaths.Add("D:\\UE5Magic\\ThirdParty\\YJMagicLib\\Includes");
        }

        PublicDefinitions.Add(string.Format("WITH_YJ_MAGIC_LIB_BINDING={0}", isLibrarySupported ? 1 : 0));
        return isLibrarySupported; ;

    }
}
