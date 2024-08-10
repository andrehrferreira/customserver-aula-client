// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MMORPGDoZero : ModuleRules
{
	public MMORPGDoZero(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "WebSockets" });

		PrivateDependencyModuleNames.AddRange(new string[] { "Engine",
                "Slate",
                "SlateCore" });

        PublicDefinitions.Add("WITH_WEBSOCKETS=1");

        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
