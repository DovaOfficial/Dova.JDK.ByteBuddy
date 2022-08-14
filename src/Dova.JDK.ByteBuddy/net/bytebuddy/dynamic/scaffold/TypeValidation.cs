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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "public final")]
public partial class TypeValidation
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeValidation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENABLED", "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISABLED", "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Z)Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "public static final")]
	public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation ENABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "public static final")]
	public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation DISABLED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool enabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeValidation(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
	public TypeValidation(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "public static")]
	public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
	}

	[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "public static")]
	public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation of(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}
}
