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

[JniSignatureAttribute("Lcom/sun/jna/ptr/PointerByReference;", "public")]
public partial class PointerByReference
	: Dova.JDK.com.sun.jna.ptr.ByReference
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PointerByReference()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ptr/PointerByReference;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Lcom/sun/jna/Pointer;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PointerByReference(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PointerByReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "public")]
	public PointerByReference(Dova.JDK.com.sun.jna.Pointer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/ptr/PointerByReference;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer getValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "public")]
	public void setValue(Dova.JDK.com.sun.jna.Pointer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
