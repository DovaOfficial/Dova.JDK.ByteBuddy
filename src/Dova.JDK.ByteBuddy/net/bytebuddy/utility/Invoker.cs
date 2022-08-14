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

namespace Dova.JDK.net.bytebuddy.utility;

[JniSignatureAttribute("Lnet/bytebuddy/utility/Invoker;", "public abstract interface")]
public partial interface Invoker
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Invoker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/Invoker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
