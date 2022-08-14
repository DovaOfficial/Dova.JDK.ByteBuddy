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

[JniSignatureAttribute("Lnet/bytebuddy/utility/FieldComparator;", "public final")]
public partial class FieldComparator
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.java.util.Comparator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldComparator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FieldComparator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/utility/FieldComparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/FieldComparator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/FieldComparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/reflect/Field;Ljava/lang/reflect/Field;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/FieldComparator;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/FieldComparator;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.FieldComparator INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FieldComparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/utility/FieldComparator;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.utility.FieldComparator> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.FieldComparator>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FieldComparator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public FieldComparator(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/FieldComparator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/utility/FieldComparator;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.utility.FieldComparator> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.FieldComparator>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public volatile")]
	public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Ljava/lang/reflect/Field;)I", "public")]
	public int compare(Dova.JDK.java.lang.reflect.Field arg0, Dova.JDK.java.lang.reflect.Field arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/FieldComparator;", "public static")]
	public static Dova.JDK.net.bytebuddy.utility.FieldComparator valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FieldComparator>(ret);
	}
}
