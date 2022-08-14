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

namespace Dova.JDK.net.bytebuddy.utility.visitor;

[JniSignatureAttribute("Lnet/bytebuddy/utility/visitor/LineNumberPrependingMethodVisitor;", "public")]
public partial class LineNumberPrependingMethodVisitor
	: Dova.JDK.net.bytebuddy.utility.visitor.ExceptionTableSensitiveMethodVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LineNumberPrependingMethodVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/visitor/LineNumberPrependingMethodVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startOfMethod", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prependLineNumber", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumber", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterExceptionTable", "()V"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label startOfMethod_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool prependLineNumber_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LineNumberPrependingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
	public LineNumberPrependingMethodVisitor(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/visitor/LineNumberPrependingMethodVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLineNumber(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void onAfterExceptionTable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}
}
