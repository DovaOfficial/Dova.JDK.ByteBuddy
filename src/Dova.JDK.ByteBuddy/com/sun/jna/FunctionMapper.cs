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

[JniSignatureAttribute("Lcom/sun/jna/FunctionMapper;", "public abstract interface")]
public partial interface FunctionMapper
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FunctionMapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/FunctionMapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunctionName", "(Lcom/sun/jna/NativeLibrary;Ljava/lang/reflect/Method;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(Lcom/sun/jna/NativeLibrary;Ljava/lang/reflect/Method;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getFunctionName(Dova.JDK.com.sun.jna.NativeLibrary arg0, Dova.JDK.java.lang.reflect.Method arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
