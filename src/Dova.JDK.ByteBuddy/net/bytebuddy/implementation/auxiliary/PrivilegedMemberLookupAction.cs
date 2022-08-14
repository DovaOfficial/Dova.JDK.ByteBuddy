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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public final")]
public partial class PrivilegedMemberLookupAction
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrivilegedMemberLookupAction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_PUBLIC_METHOD", "Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_DECLARED_METHOD", "Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_PUBLIC_CONSTRUCTOR", "Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_DECLARED_CONSTRUCTOR", "Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_FIELD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_CONSTRUCTOR", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuffix", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction FOR_PUBLIC_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction FOR_DECLARED_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction FOR_PUBLIC_CONSTRUCTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction FOR_DECLARED_CONSTRUCTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String TYPE_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape DEFAULT_CONSTRUCTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
	public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape methodDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map fields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrivilegedMemberLookupAction(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Class;)V", "private")]
	public PrivilegedMemberLookupAction(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Class arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.Class arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/Class;)V", "private")]
	public PrivilegedMemberLookupAction(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Class arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/auxiliary/PrivilegedMemberLookupAction;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.PrivilegedMemberLookupAction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType of(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType make(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSuffix()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
