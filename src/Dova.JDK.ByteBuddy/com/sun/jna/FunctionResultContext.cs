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

[JniSignatureAttribute("Lcom/sun/jna/FunctionResultContext;", "public")]
public partial class FunctionResultContext
	: Dova.JDK.com.sun.jna.FromNativeContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FunctionResultContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/FunctionResultContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "function", "Lcom/sun/jna/Function;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "[Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Lcom/sun/jna/Function;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunction", "()Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments", "()[Ljava/lang/Object;"));
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FunctionResultContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Function;[Ljava/lang/Object;)V", "")]
	public FunctionResultContext(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.Function arg1, JavaArray<Dova.JDK.java.lang.Object> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/FunctionResultContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/jna/Function;", "public")]
	public Dova.JDK.com.sun.jna.Function getFunction()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}
}
