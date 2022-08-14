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

[JniSignatureAttribute("Lcom/sun/jna/FunctionParameterContext;", "public")]
public partial class FunctionParameterContext
	: Dova.JDK.com.sun.jna.ToNativeContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FunctionParameterContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/FunctionParameterContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "function", "Lcom/sun/jna/Function;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Function;[Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunction", "()Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterIndex", "()I"));
	}

	[JniSignatureAttribute("Lcom/sun/jna/Function;", "private")]
	public Dova.JDK.com.sun.jna.Function function_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> args_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FunctionParameterContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Function;[Ljava/lang/Object;I)V", "")]
	public FunctionParameterContext(Dova.JDK.com.sun.jna.Function arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/FunctionParameterContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Function;", "public")]
	public Dova.JDK.com.sun.jna.Function getFunction()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getParameterIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}
}
