/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.14-03:38)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.net.bytebuddy.agent.builder;

[JniSignatureAttribute("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;", "public abstract interface")]
public partial interface ResettableClassFileTransformer
	: IJavaObject
	, Dova.JDK.java.lang.instrument.ClassFileTransformer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ResettableClassFileTransformer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;Lnet/bytebuddy/utility/JavaModule;Ljava/lang/Class;Ljava/security/ProtectionDomain;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;Lnet/bytebuddy/utility/JavaModule;Ljava/lang/Class;Ljava/security/ProtectionDomain;)Ljava/util/Iterator;", "public abstract")]
	Dova.JDK.java.util.Iterator iterator(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.net.bytebuddy.utility.JavaModule arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.security.ProtectionDomain arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg3, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg3, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg4, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z", "public abstract")]
	bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer$WithDelegation;", "public abstract static")]
	public partial class WithDelegation
		: Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithDelegation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer$WithDelegation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileTransformer", "Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;Lnet/bytebuddy/utility/JavaModule;Ljava/lang/Class;Ljava/security/ProtectionDomain;)Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;", "protected final")]
		public Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer classFileTransformer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithDelegation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;)V", "protected")]
		public WithDelegation(Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer$WithDelegation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;Lnet/bytebuddy/utility/JavaModule;Ljava/lang/Class;Ljava/security/ProtectionDomain;)Ljava/util/Iterator;", "public")]
		public Dova.JDK.java.util.Iterator iterator(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.net.bytebuddy.utility.JavaModule arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.java.security.ProtectionDomain arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg3, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg4, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg5)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.agent.builder.ResettableClassFileTransformer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;)Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/agent/builder/ResettableClassFileTransformer$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$Listener;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg2, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg3, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.Listener arg4)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$DiscoveryStrategy;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.DiscoveryStrategy arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy$BatchAllocator;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy.BatchAllocator arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/agent/builder/AgentBuilder$RedefinitionStrategy;)Z", "public")]
		public bool reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.agent.builder.AgentBuilder.RedefinitionStrategy arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}
	}
}
