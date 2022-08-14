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

namespace Dova.JDK.com.sun.jna;

[JniSignatureAttribute("Lcom/sun/jna/CallbackThreadInitializer;", "public")]
public partial class CallbackThreadInitializer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CallbackThreadInitializer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/CallbackThreadInitializer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "daemon", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detach", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "group", "Ljava/lang/ThreadGroup;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZLjava/lang/String;Ljava/lang/ThreadGroup;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZLjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Lcom/sun/jna/Callback;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThreadGroup", "(Lcom/sun/jna/Callback;)Ljava/lang/ThreadGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDaemon", "(Lcom/sun/jna/Callback;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "(Lcom/sun/jna/Callback;)Z"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool daemon_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool detach_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadGroup;", "private")]
	public Dova.JDK.java.lang.ThreadGroup group_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CallbackThreadInitializer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ZZLjava/lang/String;Ljava/lang/ThreadGroup;)V", "public")]
	public CallbackThreadInitializer(bool arg0, bool arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.ThreadGroup arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(ZZLjava/lang/String;)V", "public")]
	public CallbackThreadInitializer(bool arg0, bool arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CallbackThreadInitializer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public CallbackThreadInitializer(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(ZZ)V", "public")]
	public CallbackThreadInitializer(bool arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/CallbackThreadInitializer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Ljava/lang/ThreadGroup;", "public")]
	public Dova.JDK.java.lang.ThreadGroup getThreadGroup(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Z", "public")]
	public bool isDaemon(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Z", "public")]
	public bool detach(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}
}
