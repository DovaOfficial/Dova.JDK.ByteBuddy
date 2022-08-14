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

namespace Dova.JDK.com.sun.jna.ptr;

[JniSignatureAttribute("Lcom/sun/jna/ptr/NativeLongByReference;", "public")]
public partial class NativeLongByReference
	: Dova.JDK.com.sun.jna.ptr.ByReference
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NativeLongByReference()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ptr/NativeLongByReference;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/NativeLong;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()Lcom/sun/jna/NativeLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Lcom/sun/jna/NativeLong;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NativeLongByReference(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public NativeLongByReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/NativeLong;)V", "public")]
	public NativeLongByReference(Dova.JDK.com.sun.jna.NativeLong arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/ptr/NativeLongByReference;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/NativeLong;", "public")]
	public Dova.JDK.com.sun.jna.NativeLong getValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLong>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/NativeLong;)V", "public")]
	public void setValue(Dova.JDK.com.sun.jna.NativeLong arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
