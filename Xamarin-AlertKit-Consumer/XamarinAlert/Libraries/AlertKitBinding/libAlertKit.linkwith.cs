using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libAlertKit.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true)]
