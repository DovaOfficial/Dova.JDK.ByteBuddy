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

[JniSignatureAttribute("Lcom/sun/jna/NativeMappedConverter;", "public")]
public partial class NativeMappedConverter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.jna.TypeConverter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NativeMappedConverter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/NativeMappedConverter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "converters", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeType", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instance", "Lcom/sun/jna/NativeMapped;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/Class;)Lcom/sun/jna/NativeMappedConverter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "()Lcom/sun/jna/NativeMapped;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromNative", "(Ljava/lang/Object;Lcom/sun/jna/FromNativeContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toNative", "(Ljava/lang/Object;Lcom/sun/jna/ToNativeContext;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nativeType", "()Ljava/lang/Class;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map converters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
	public Dova.JDK.java.lang.Class type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
	public Dova.JDK.java.lang.Class nativeType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/NativeMapped;", "private final")]
	public Dova.JDK.com.sun.jna.NativeMapped instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeMapped>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NativeMappedConverter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
	public NativeMappedConverter(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/NativeMappedConverter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/NativeMappedConverter;", "public static")]
	public static Dova.JDK.com.sun.jna.NativeMappedConverter getInstance(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeMappedConverter>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/NativeMapped;", "public")]
	public Dova.JDK.com.sun.jna.NativeMapped defaultValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeMapped>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/jna/FromNativeContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object fromNative(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.jna.FromNativeContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/jna/ToNativeContext;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object toNative(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.jna.ToNativeContext arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class nativeType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}
}
