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
	
	
	public partial class ICorDebugChain
	{
		
		private Debugger.Interop.CorDebug.ICorDebugChain wrappedObject;
		
		internal Debugger.Interop.CorDebug.ICorDebugChain WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public ICorDebugChain(Debugger.Interop.CorDebug.ICorDebugChain wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(ICorDebugChain));
		}
		
		public static ICorDebugChain Wrap(Debugger.Interop.CorDebug.ICorDebugChain objectToWrap)
		{
			if ((objectToWrap != null))
			{
				return new ICorDebugChain(objectToWrap);
			} else
			{
				return null;
			}
		}
		
		~ICorDebugChain()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(ICorDebugChain));
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
		
		public static bool operator ==(ICorDebugChain o1, ICorDebugChain o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(ICorDebugChain o1, ICorDebugChain o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			ICorDebugChain casted = o as ICorDebugChain;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public ICorDebugThread Thread
		{
			get
			{
				ICorDebugThread ppThread;
				Debugger.Interop.CorDebug.ICorDebugThread out_ppThread;
				this.WrappedObject.GetThread(out out_ppThread);
				ppThread = ICorDebugThread.Wrap(out_ppThread);
				return ppThread;
			}
		}
		
		public ulong GetStackRange(out ulong pStart)
		{
			ulong pEnd;
			this.WrappedObject.GetStackRange(out pStart, out pEnd);
			return pEnd;
		}
		
		public ICorDebugContext Context
		{
			get
			{
				ICorDebugContext ppContext;
				Debugger.Interop.CorDebug.ICorDebugContext out_ppContext;
				this.WrappedObject.GetContext(out out_ppContext);
				ppContext = ICorDebugContext.Wrap(out_ppContext);
				return ppContext;
			}
		}
		
		public ICorDebugChain Caller
		{
			get
			{
				ICorDebugChain ppChain;
				Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
				this.WrappedObject.GetCaller(out out_ppChain);
				ppChain = ICorDebugChain.Wrap(out_ppChain);
				return ppChain;
			}
		}
		
		public ICorDebugChain Callee
		{
			get
			{
				ICorDebugChain ppChain;
				Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
				this.WrappedObject.GetCallee(out out_ppChain);
				ppChain = ICorDebugChain.Wrap(out_ppChain);
				return ppChain;
			}
		}
		
		public ICorDebugChain Previous
		{
			get
			{
				ICorDebugChain ppChain;
				Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
				this.WrappedObject.GetPrevious(out out_ppChain);
				ppChain = ICorDebugChain.Wrap(out_ppChain);
				return ppChain;
			}
		}
		
		public ICorDebugChain Next
		{
			get
			{
				ICorDebugChain ppChain;
				Debugger.Interop.CorDebug.ICorDebugChain out_ppChain;
				this.WrappedObject.GetNext(out out_ppChain);
				ppChain = ICorDebugChain.Wrap(out_ppChain);
				return ppChain;
			}
		}
		
		public int IsManaged
		{
			get
			{
				int pManaged;
				this.WrappedObject.IsManaged(out pManaged);
				return pManaged;
			}
		}
		
		public ICorDebugFrameEnum EnumerateFrames()
		{
			ICorDebugFrameEnum ppFrames;
			Debugger.Interop.CorDebug.ICorDebugFrameEnum out_ppFrames;
			this.WrappedObject.EnumerateFrames(out out_ppFrames);
			ppFrames = ICorDebugFrameEnum.Wrap(out_ppFrames);
			return ppFrames;
		}
		
		public ICorDebugFrame ActiveFrame
		{
			get
			{
				ICorDebugFrame ppFrame;
				Debugger.Interop.CorDebug.ICorDebugFrame out_ppFrame;
				this.WrappedObject.GetActiveFrame(out out_ppFrame);
				ppFrame = ICorDebugFrame.Wrap(out_ppFrame);
				return ppFrame;
			}
		}
		
		public ICorDebugRegisterSet RegisterSet
		{
			get
			{
				ICorDebugRegisterSet ppRegisters;
				Debugger.Interop.CorDebug.ICorDebugRegisterSet out_ppRegisters;
				this.WrappedObject.GetRegisterSet(out out_ppRegisters);
				ppRegisters = ICorDebugRegisterSet.Wrap(out_ppRegisters);
				return ppRegisters;
			}
		}
		
		public CorDebugChainReason Reason
		{
			get
			{
				CorDebugChainReason pReason;
				Debugger.Interop.CorDebug.CorDebugChainReason out_pReason;
				this.WrappedObject.GetReason(out out_pReason);
				pReason = ((CorDebugChainReason)(out_pReason));
				return pReason;
			}
		}
	}
}

#pragma warning restore 1591
