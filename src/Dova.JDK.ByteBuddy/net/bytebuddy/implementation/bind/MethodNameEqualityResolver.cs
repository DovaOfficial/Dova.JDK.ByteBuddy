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

namespace Dova.JDK.net.bytebuddy.implementation.bind;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;", "public final")]
public partial class MethodNameEqualityResolver
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodNameEqualityResolver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodNameEqualityResolver(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public MethodNameEqualityResolver(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodNameEqualityResolver;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodNameEqualityResolver>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
	}
}
