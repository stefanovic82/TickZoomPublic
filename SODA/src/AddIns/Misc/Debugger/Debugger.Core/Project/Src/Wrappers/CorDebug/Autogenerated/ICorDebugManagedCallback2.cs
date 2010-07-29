// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision: 2201 $</version>
// </file>

// This file is automatically generated - any changes will be lost

#pragma warning disable 1591

namespace Debugger.Wrappers.CorDebug
{
	using System;
	
	
	public partial class ICorDebugManagedCallback2
	{
		
		private Debugger.Interop.CorDebug.ICorDebugManagedCallback2 wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugManagedCallback2 WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugManagedCallback2(Debugger.Interop.CorDebug.ICorDebugManagedCallback2 wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugManagedCallback2));
		}
		
		public static ICorDebugManagedCallback2 Wrap(Debugger.Interop.CorDebug.ICorDebugManagedCallback2 objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugManagedCallback2(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugManagedCallback2()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugManagedCallback2));
		}
		
		public bool Is<T>() where T: class
		{
			System.Reflection.ConstructorInfo ctor = typeof(T).GetConstructors()[0];
			System.Type paramType = ctor.GetParameters()[0].ParameterType;
			return paramType.IsInstanceOfType(this.WrappedObject);
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(ICorDebugManagedCallback2 o1, ICorDebugManagedCallback2 o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugManagedCallback2 o1, ICorDebugManagedCallback2 o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugManagedCallback2 casted = o as ICorDebugManagedCallback2;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public void FunctionRemapOpportunity(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pOldFunction, System.IntPtr pNewFunction, uint oldILOffset)
		{
			this.WrappedObject.FunctionRemapOpportunity(pAppDomain, pThread, pOldFunction, pNewFunction, oldILOffset);
		}
		
		public void CreateConnection(System.IntPtr pProcess, uint dwConnectionId, System.IntPtr pConnName)
		{
			this.WrappedObject.CreateConnection(pProcess, dwConnectionId, pConnName);
		}
		
		public void ChangeConnection(System.IntPtr pProcess, uint dwConnectionId)
		{
			this.WrappedObject.ChangeConnection(pProcess, dwConnectionId);
		}
		
		public void DestroyConnection(System.IntPtr pProcess, uint dwConnectionId)
		{
			this.WrappedObject.DestroyConnection(pProcess, dwConnectionId);
		}
		
		public void Exception(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pFrame, uint nOffset, Debugger.Wrappers.CorDebug.CorDebugExceptionCallbackType dwEventType, uint dwFlags)
		{
			this.WrappedObject.Exception(pAppDomain, pThread, pFrame, nOffset, dwEventType, dwFlags);
		}
		
		public void ExceptionUnwind(System.IntPtr pAppDomain, System.IntPtr pThread, Debugger.Wrappers.CorDebug.CorDebugExceptionUnwindCallbackType dwEventType, uint dwFlags)
		{
			this.WrappedObject.ExceptionUnwind(pAppDomain, pThread, dwEventType, dwFlags);
		}
		
		public void FunctionRemapComplete(System.IntPtr pAppDomain, System.IntPtr pThread, System.IntPtr pFunction)
		{
			this.WrappedObject.FunctionRemapComplete(pAppDomain, pThread, pFunction);
		}
		
		public void MDANotification(System.IntPtr pController, System.IntPtr pThread, System.IntPtr pMDA)
		{
			this.WrappedObject.MDANotification(pController, pThread, pMDA);
		}
	}
}

#pragma warning restore 1591