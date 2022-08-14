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

[JniSignatureAttribute("Lcom/sun/jna/IntegerType;", "public abstract")]
public partial class IntegerType
	: Dova.JDK.java.lang.Number
	, Dova.JDK.com.sun.jna.NativeMapped
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IntegerType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/IntegerType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "number", "Ljava/lang/Number;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unsigned", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IJZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IJ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(JJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Lcom/sun/jna/IntegerType;Lcom/sun/jna/IntegerType;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compare", "(Lcom/sun/jna/IntegerType;J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "longValue", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "floatValue", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doubleValue", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromNative", "(Ljava/lang/Object;Lcom/sun/jna/FromNativeContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toNative", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nativeType", "()Ljava/lang/Class;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int size_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Number;", "private")]
	public Dova.JDK.java.lang.Number number_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Number>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool unsigned_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long value_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IntegerType(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IJZ)V", "public")]
	public IntegerType(int arg0, long arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(IJ)V", "public")]
	public IntegerType(int arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(IZ)V", "public")]
	public IntegerType(int arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public IntegerType(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/IntegerType;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(JJ)I", "public static final")]
	public static int compare(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/IntegerType;Lcom/sun/jna/IntegerType;)I", "public static")]
	public static int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/IntegerType;J)I", "public static")]
	public static int compare(Dova.JDK.com.sun.jna.IntegerType arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int intValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long longValue()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()F", "public")]
	public float floatValue()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()D", "public")]
	public double doubleValue()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void setValue(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/jna/FromNativeContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object fromNative(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.jna.FromNativeContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object toNative()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class nativeType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}
}
