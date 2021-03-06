// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2077 $</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public enum CorDebugUserState : int
	{
		
		USER_STOP_REQUESTED = 1,
		
		USER_SUSPEND_REQUESTED = 2,
		
		USER_BACKGROUND = 4,
		
		USER_UNSTARTED = 8,
		
		USER_STOPPED = 16,
		
		USER_WAIT_SLEEP_JOIN = 32,
		
		USER_SUSPENDED = 64,
		
		USER_UNSAFE_POINT = 128,
	}
}

#pragma warning restore 1591
