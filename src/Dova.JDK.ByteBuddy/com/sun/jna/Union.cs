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

[JniSignatureAttribute("Lcom/sun/jna/Union;", "public abstract")]
public partial class Union
	: Dova.JDK.com.sun.jna.Structure
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Union()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Union;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "activeField", "Lcom/sun/jna/Structure$StructField;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;ILcom/sun/jna/TypeMapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/TypeMapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readField", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readField", "(Lcom/sun/jna/Structure$StructField;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldOrder", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Lcom/sun/jna/Structure$StructField;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeAlignment", "(Ljava/lang/Class;Ljava/lang/Object;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypedValue", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTypedValue", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findField", "(Ljava/lang/Class;)Lcom/sun/jna/Structure$StructField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(Ljava/lang/Class;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$StructField;", "private")]
	public Dova.JDK.com.sun.jna.Structure.StructField activeField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.StructField>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Union(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;ILcom/sun/jna/TypeMapper;)V", "protected")]
	public Union(Dova.JDK.com.sun.jna.Pointer arg0, int arg1, Dova.JDK.com.sun.jna.TypeMapper arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/TypeMapper;)V", "protected")]
	public Union(Dova.JDK.com.sun.jna.TypeMapper arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;I)V", "protected")]
	public Union(Dova.JDK.com.sun.jna.Pointer arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "protected")]
	public Union(Dova.JDK.com.sun.jna.Pointer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Union() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/Union;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object readField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure$StructField;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object readField(Dova.JDK.com.sun.jna.Structure.StructField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List getFieldOrder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure$StructField;)V", "protected")]
	public void writeField(Dova.JDK.com.sun.jna.Structure.StructField arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void writeField(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void writeField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Z)I", "protected")]
	public int getNativeAlignment(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getTypedValue(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object setTypedValue(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/Structure$StructField;", "private")]
	public Dova.JDK.com.sun.jna.Structure.StructField findField(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.StructField>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
	public void setType(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}
}
