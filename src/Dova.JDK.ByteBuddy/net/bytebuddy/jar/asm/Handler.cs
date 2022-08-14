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

namespace Dova.JDK.net.bytebuddy.jar.asm;

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Handler;", "final")]
public partial class Handler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Handler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Handler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startPc", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endPc", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handlerPc", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "catchType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "catchTypeDescriptor", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextHandler", "Lnet/bytebuddy/jar/asm/Handler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;ILjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/Handler;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeRange", "(Lnet/bytebuddy/jar/asm/Handler;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Handler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getExceptionTableLength", "(Lnet/bytebuddy/jar/asm/Handler;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getExceptionTableSize", "(Lnet/bytebuddy/jar/asm/Handler;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putExceptionTable", "(Lnet/bytebuddy/jar/asm/Handler;Lnet/bytebuddy/jar/asm/ByteVector;)V"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "final")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label startPc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "final")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label endPc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "final")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label handlerPc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int catchType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String catchTypeDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Handler;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Handler nextHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Handler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;ILjava/lang/String;)V", "")]
	public Handler(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, int arg3, Dova.JDK.java.lang.String arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handler;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;)V", "")]
	public Handler(Dova.JDK.net.bytebuddy.jar.asm.Handler arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Handler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handler;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Handler;", "static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Handler removeRange(Dova.JDK.net.bytebuddy.jar.asm.Handler arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Handler>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handler;)I", "static")]
	public static int getExceptionTableLength(Dova.JDK.net.bytebuddy.jar.asm.Handler arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handler;)I", "static")]
	public static int getExceptionTableSize(Dova.JDK.net.bytebuddy.jar.asm.Handler arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handler;Lnet/bytebuddy/jar/asm/ByteVector;)V", "static")]
	public static void putExceptionTable(Dova.JDK.net.bytebuddy.jar.asm.Handler arg0, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}
}
