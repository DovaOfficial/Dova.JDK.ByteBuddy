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

[JniSignatureAttribute("Lcom/sun/jna/TypeMapper;", "public abstract interface")]
public partial interface TypeMapper
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeMapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/TypeMapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFromNativeConverter", "(Ljava/lang/Class;)Lcom/sun/jna/FromNativeConverter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToNativeConverter", "(Ljava/lang/Class;)Lcom/sun/jna/ToNativeConverter;"));
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/FromNativeConverter;", "public abstract")]
	Dova.JDK.com.sun.jna.FromNativeConverter getFromNativeConverter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.FromNativeConverter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/ToNativeConverter;", "public abstract")]
	Dova.JDK.com.sun.jna.ToNativeConverter getToNativeConverter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ToNativeConverter>(ret);
	}
}
