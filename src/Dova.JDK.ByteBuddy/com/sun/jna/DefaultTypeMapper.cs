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

[JniSignatureAttribute("Lcom/sun/jna/DefaultTypeMapper;", "public")]
public partial class DefaultTypeMapper
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.jna.TypeMapper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultTypeMapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/DefaultTypeMapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toNativeConverters", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fromNativeConverters", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFromNativeConverter", "(Ljava/lang/Class;Lcom/sun/jna/FromNativeConverter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAltClass", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addToNativeConverter", "(Ljava/lang/Class;Lcom/sun/jna/ToNativeConverter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTypeConverter", "(Ljava/lang/Class;Lcom/sun/jna/TypeConverter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupConverter", "(Ljava/lang/Class;Ljava/util/Collection;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFromNativeConverter", "(Ljava/lang/Class;)Lcom/sun/jna/FromNativeConverter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToNativeConverter", "(Ljava/lang/Class;)Lcom/sun/jna/ToNativeConverter;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List toNativeConverters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List fromNativeConverters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultTypeMapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultTypeMapper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/DefaultTypeMapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/FromNativeConverter;)V", "public")]
	public void addFromNativeConverter(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.FromNativeConverter arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class getAltClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/ToNativeConverter;)V", "public")]
	public void addToNativeConverter(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.ToNativeConverter arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/TypeConverter;)V", "public")]
	public void addTypeConverter(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.TypeConverter arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Collection;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object lookupConverter(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/FromNativeConverter;", "public")]
	public Dova.JDK.com.sun.jna.FromNativeConverter getFromNativeConverter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.FromNativeConverter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/ToNativeConverter;", "public")]
	public Dova.JDK.com.sun.jna.ToNativeConverter getToNativeConverter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ToNativeConverter>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jna/DefaultTypeMapper$Entry;", "private static")]
	public partial class Entry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Entry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/DefaultTypeMapper$Entry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "converter", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object converter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)V", "public")]
		public Entry(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/DefaultTypeMapper$Entry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
