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

namespace Dova.JDK.net.bytebuddy.description.modifier;

[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/EnumerationState;", "public final")]
public partial class EnumerationState
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType
	, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EnumerationState()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/EnumerationState;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLAIN", "Lnet/bytebuddy/description/modifier/EnumerationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUMERATION", "Lnet/bytebuddy/description/modifier/EnumerationState;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mask", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/modifier/EnumerationState;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/modifier/EnumerationState;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/modifier/EnumerationState;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefault", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMask", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRange", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnumeration", "()Z"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/EnumerationState;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.modifier.EnumerationState PLAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/EnumerationState;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.modifier.EnumerationState ENUMERATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int mask_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/description/modifier/EnumerationState;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EnumerationState(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
	public EnumerationState(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/modifier/EnumerationState;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/description/modifier/EnumerationState;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/modifier/EnumerationState;", "public static")]
	public static Dova.JDK.net.bytebuddy.description.modifier.EnumerationState valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDefault()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMask()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRange()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEnumeration()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}
}
