﻿using System;

namespace TechTalk.SpecFlow.Analytics
{
    public class SpecFlowProjectRunningEvent : SpecFlowAnalyticsEventBase
    {
        public SpecFlowProjectRunningEvent(DateTime utcDate, string userId, string platform, string platformDescription, string specFlowVersion, string unitTestProvider, bool isBuildServer, string hashedAssemblyName, string targetFrameworks, string targetFramework, bool isDockerContainer) : base(utcDate, userId, platform, platformDescription, specFlowVersion, unitTestProvider, isBuildServer, hashedAssemblyName, targetFrameworks, targetFramework, isDockerContainer)
        {
        }

        public override string EventName => "Running SpecFlow project";
    }
}