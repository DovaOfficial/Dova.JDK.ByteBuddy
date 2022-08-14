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

[JniSignatureAttribute("Lnet/bytebuddy/utility/ConstructorComparator;", "public final")]
public partial class ConstructorComparator
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.util.Comparator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstructorComparator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/ConstructorComparator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/utility/ConstructorComparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/ConstructorComparator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/ConstructorComparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/reflect/Constructor;Ljava/lang/reflect/Constructor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/ConstructorComparator;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/ConstructorComparator;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.ConstructorComparator INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.ConstructorComparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/utility/ConstructorComparator;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.utility.ConstructorComparator> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.ConstructorComparator>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConstructorComparator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public ConstructorComparator(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/ConstructorComparator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/utility/ConstructorComparator;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.utility.ConstructorComparator> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.ConstructorComparator>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public volatile")]
	public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljava/lang/reflect/Constructor;)I", "public")]
	public int compare(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.java.lang.reflect.Constructor arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/ConstructorComparator;", "public static")]
	public static Dova.JDK.net.bytebuddy.utility.ConstructorComparator valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.ConstructorComparator>(ret);
	}
}
