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

namespace Dova.JDK.net.bytebuddy.implementation.auxiliary;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/TrivialType;", "public final")]
public partial class TrivialType
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TrivialType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/auxiliary/TrivialType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIGNATURE_RELEVANT", "Lnet/bytebuddy/implementation/auxiliary/TrivialType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLAIN", "Lnet/bytebuddy/implementation/auxiliary/TrivialType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "eager", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/auxiliary/TrivialType;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/auxiliary/TrivialType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/auxiliary/TrivialType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuffix", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/TrivialType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType SIGNATURE_RELEVANT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/TrivialType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType PLAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool eager_Property
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

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/auxiliary/TrivialType;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TrivialType(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
	public TrivialType(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/auxiliary/TrivialType;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/auxiliary/TrivialType;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/auxiliary/TrivialType;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.TrivialType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType make(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSuffix()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
