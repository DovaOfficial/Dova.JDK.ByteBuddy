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

[JniSignatureAttribute("Lcom/sun/jna/Structure;", "public abstract")]
public partial class Structure
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Structure()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Ljava/util/logging/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIGN_DEFAULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIGN_NONE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIGN_GNUC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIGN_MSVC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CALCULATE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "layoutInfo", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "fieldOrder", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "memory", "Lcom/sun/jna/Pointer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alignType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoding", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actualAlignType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "structAlignment", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "structFields", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nativeStrings", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeMapper", "Lcom/sun/jna/TypeMapper;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInfo", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "autoRead", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "autoWrite", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "array", "[Lcom/sun/jna/Structure;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readCalled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "reads", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "busy", "Ljava/lang/ThreadLocal;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLACEHOLDER_MEMORY", "Lcom/sun/jna/Pointer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILcom/sun/jna/TypeMapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;ILcom/sun/jna/TypeMapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/TypeMapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(IZZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "size", "(Ljava/lang/Class;Lcom/sun/jna/Structure;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "size", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "([Lcom/sun/jna/Structure;)[Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "(I)[Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/lang/Class;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/lang/Class;J)Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newInstance", "(Ljava/lang/Class;)Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "validate", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFields", "(Z)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fields", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sort", "(Ljava/util/Collection;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fieldOffset", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemory", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemory", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allocateMemory", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reading", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "busy", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readField", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readField", "(Lcom/sun/jna/Structure$StructField;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseClass", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updateStructureByReference", "(Ljava/lang/Class;Lcom/sun/jna/Structure;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Structure;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useMemory", "(Lcom/sun/jna/Pointer;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useMemory", "(Lcom/sun/jna/Pointer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useMemory", "(Lcom/sun/jna/Pointer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "conditionalAutoRead", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeSize", "(Ljava/lang/Class;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeSize", "(Ljava/lang/Class;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "autoWrite", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "autoWrite", "([Lcom/sun/jna/Structure;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldOrder", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStringEncoding", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFieldsOrder", "(Ljava/util/List;[Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFieldsOrder", "(Ljava/util/List;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFieldsOrder", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFieldsOrder", "([Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fieldOrder", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "autoRead", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "autoRead", "([Lcom/sun/jna/Structure;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeTypeMapper", "(Lcom/sun/jna/TypeMapper;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAlignType", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "autoAllocate", "(I)Lcom/sun/jna/Memory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureAllocated", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureAllocated", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldValue", "(Ljava/lang/reflect/Field;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFieldValue", "(Ljava/lang/reflect/Field;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFieldValue", "(Ljava/lang/reflect/Field;Ljava/lang/Object;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Lcom/sun/jna/Structure$StructField;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Lcom/sun/jna/Structure$StructField;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeField", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sortFields", "(Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldList", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateSize", "(ZZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateSize", "(Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateField", "(Ljava/lang/String;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateFields", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deriveLayout", "(ZZ)Lcom/sun/jna/Structure$LayoutInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeFields", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeField", "(Ljava/lang/reflect/Field;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPadding", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPadding", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStructAlignment", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeAlignment", "(Ljava/lang/Class;Ljava/lang/Object;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dataEquals", "(Lcom/sun/jna/Structure;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dataEquals", "(Lcom/sun/jna/Structure;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheTypeInfo", "(Lcom/sun/jna/Pointer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldTypeInfo", "(Lcom/sun/jna/Structure$StructField;)Lcom/sun/jna/Structure$FFIType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInfo", "()Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTypeInfo", "(Ljava/lang/Object;)Lcom/sun/jna/Structure$FFIType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutoSynch", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutoRead", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAutoRead", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutoWrite", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAutoWrite", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPointerConstructor", "(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "structureArrayCheck", "([Lcom/sun/jna/Structure;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2300", "(Lcom/sun/jna/Structure;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2400", "()Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeMapper", "()Lcom/sun/jna/TypeMapper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringEncoding", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointer", "()Lcom/sun/jna/Pointer;"));
	}

	[JniSignatureAttribute("Ljava/util/logging/Logger;", "private static final")]
	public static Dova.JDK.java.util.logging.Logger LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.logging.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ALIGN_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ALIGN_NONE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ALIGN_GNUC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ALIGN_MSVC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int CALCULATE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map layoutInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map fieldOrder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private")]
	public Dova.JDK.com.sun.jna.Pointer memory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int size_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int alignType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int actualAlignType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int structAlignment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map structFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map nativeStrings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/TypeMapper;", "private")]
	public Dova.JDK.com.sun.jna.TypeMapper typeMapper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.TypeMapper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long typeInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool autoRead_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool autoWrite_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/jna/Structure;", "private")]
	public JavaArray<Dova.JDK.com.sun.jna.Structure> array_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Structure>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool readCalled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static final")]
	public static Dova.JDK.java.lang.ThreadLocal reads_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ThreadLocal;", "private static final")]
	public static Dova.JDK.java.lang.ThreadLocal busy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadLocal>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static final")]
	public static Dova.JDK.com.sun.jna.Pointer PLACEHOLDER_MEMORY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Structure(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILcom/sun/jna/TypeMapper;)V", "protected")]
	public Structure(int arg0, Dova.JDK.com.sun.jna.TypeMapper arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "protected")]
	public Structure(Dova.JDK.com.sun.jna.Pointer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;I)V", "protected")]
	public Structure(Dova.JDK.com.sun.jna.Pointer arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;ILcom/sun/jna/TypeMapper;)V", "protected")]
	public Structure(Dova.JDK.com.sun.jna.Pointer arg0, int arg1, Dova.JDK.com.sun.jna.TypeMapper arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Structure() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/TypeMapper;)V", "protected")]
	public Structure(Dova.JDK.com.sun.jna.TypeMapper arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0))
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public Structure(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure;";
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

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(IZZ)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String toString(int arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Structure;)I", "static")]
	public static int size(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "static")]
	public static int size(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int size()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("([Lcom/sun/jna/Structure;)[Lcom/sun/jna/Structure;", "public")]
	public JavaArray<Dova.JDK.com.sun.jna.Structure> toArray(JavaArray<Dova.JDK.com.sun.jna.Structure> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Structure>>(ret);
	}

	[JniSignatureAttribute("(I)[Lcom/sun/jna/Structure;", "public")]
	public JavaArray<Dova.JDK.com.sun.jna.Structure> toArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Structure>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String format(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Structure;", "public static")]
	public static Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.Pointer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;J)Lcom/sun/jna/Structure;", "private static")]
	public static Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.Class arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jna/Structure;", "public static")]
	public static Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void validate(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Z)Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List getFields(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map fields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void write()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void read()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List sort(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "protected")]
	public int fieldOffset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void allocateMemory(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void allocateMemory(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void allocateMemory()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "static")]
	public static Dova.JDK.java.util.Map reading()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "static")]
	public static Dova.JDK.java.util.Set busy()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object readField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure$StructField;)Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object readField(Dova.JDK.com.sun.jna.Structure.StructField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class baseClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Structure;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Structure;", "static")]
	public static Dova.JDK.java.lang.Object updateStructureByReference(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.com.sun.jna.Pointer arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;IZ)V", "")]
	public void useMemory(Dova.JDK.com.sun.jna.Pointer arg0, int arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;I)V", "protected")]
	public void useMemory(Dova.JDK.com.sun.jna.Pointer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "protected")]
	public void useMemory(Dova.JDK.com.sun.jna.Pointer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void conditionalAutoRead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34]);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)I", "protected")]
	public int getNativeSize(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)I", "protected")]
	public int getNativeSize(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void autoWrite()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37]);
	}

	[JniSignatureAttribute("([Lcom/sun/jna/Structure;)V", "public static")]
	public static void autoWrite(JavaArray<Dova.JDK.com.sun.jna.Structure> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List getFieldOrder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void setStringEncoding(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;[Ljava/lang/String;)Ljava/util/List;", "public static transient")]
	public static Dova.JDK.java.util.List createFieldsOrder(Dova.JDK.java.util.List arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List createFieldsOrder(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List createFieldsOrder(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/util/List;", "public static transient")]
	public static Dova.JDK.java.util.List createFieldsOrder(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List fieldOrder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void autoRead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46]);
	}

	[JniSignatureAttribute("([Lcom/sun/jna/Structure;)V", "public static")]
	public static void autoRead(JavaArray<Dova.JDK.com.sun.jna.Structure> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/TypeMapper;)V", "private")]
	public void initializeTypeMapper(Dova.JDK.com.sun.jna.TypeMapper arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void layoutChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setAlignType(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/jna/Memory;", "protected")]
	public Dova.JDK.com.sun.jna.Memory autoAllocate(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Memory>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void ensureAllocated()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52]);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void ensureAllocated(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getFieldValue(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Ljava/lang/Object;)V", "")]
	public void setFieldValue(Dova.JDK.java.lang.reflect.Field arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Ljava/lang/Object;Z)V", "private")]
	public void setFieldValue(Dova.JDK.java.lang.reflect.Field arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure$StructField;Ljava/lang/Object;)V", "private")]
	public void writeField(Dova.JDK.com.sun.jna.Structure.StructField arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void writeField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure$StructField;)V", "protected")]
	public void writeField(Dova.JDK.com.sun.jna.Structure.StructField arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void writeField(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)V", "protected")]
	public void sortFields(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "protected")]
	public Dova.JDK.java.util.List getFieldList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(ZZ)I", "")]
	public int calculateSize(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Z)I", "protected")]
	public int calculateSize(bool arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)V", "private")]
	public void validateField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void validateFields()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66]);
	}

	[JniSignatureAttribute("(ZZ)Lcom/sun/jna/Structure$LayoutInfo;", "private")]
	public Dova.JDK.com.sun.jna.Structure.LayoutInfo deriveLayout(bool arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.LayoutInfo>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initializeFields()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68]);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;Ljava/lang/Class;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object initializeField(Dova.JDK.java.lang.reflect.Field arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int addPadding(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int addPadding(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getStructAlignment()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[72]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;Z)I", "protected")]
	public int getNativeAlignment(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure;)Z", "public")]
	public bool dataEquals(Dova.JDK.com.sun.jna.Structure arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure;Z)Z", "public")]
	public bool dataEquals(Dova.JDK.com.sun.jna.Structure arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "protected")]
	public void cacheTypeInfo(Dova.JDK.com.sun.jna.Pointer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure$StructField;)Lcom/sun/jna/Structure$FFIType;", "")]
	public Dova.JDK.com.sun.jna.Structure.FFIType getFieldTypeInfo(Dova.JDK.com.sun.jna.Structure.StructField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "")]
	public Dova.JDK.com.sun.jna.Pointer getTypeInfo()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/jna/Structure$FFIType;", "static")]
	public static Dova.JDK.com.sun.jna.Structure.FFIType getTypeInfo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAutoSynch(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAutoRead(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAutoRead()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[82]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAutoWrite(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAutoWrite()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[84]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "private static")]
	public static Dova.JDK.java.lang.reflect.Constructor getPointerConstructor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("([Lcom/sun/jna/Structure;)V", "private static")]
	public static void structureArrayCheck(JavaArray<Dova.JDK.com.sun.jna.Structure> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[86], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure;Z)V", "static")]
	public static void access_2300(Dova.JDK.com.sun.jna.Structure arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
	public static Dova.JDK.com.sun.jna.Pointer access_2400()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/TypeMapper;", "")]
	public Dova.JDK.com.sun.jna.TypeMapper getTypeMapper()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.TypeMapper>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getStringEncoding()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer getPointer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$AutoAllocated;", "private static")]
	public partial class AutoAllocated
		: Dova.JDK.com.sun.jna.Memory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AutoAllocated()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$AutoAllocated;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AutoAllocated(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public AutoAllocated(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$AutoAllocated;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$FFIType;", "static")]
	public partial class FFIType
		: Dova.JDK.com.sun.jna.Structure
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FFIType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$FFIType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "typeInfoMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "unionHelper", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffiTypeInfo", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FFI_TYPE_STRUCT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "Lcom/sun/jna/Structure$FFIType$size_t;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alignment", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elements", "Lcom/sun/jna/Pointer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Structure;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Structure$FFIType;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Class;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/Object;Ljava/lang/Class;)Lcom/sun/jna/Structure$FFIType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljava/lang/Object;)Lcom/sun/jna/Structure$FFIType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "([Lcom/sun/jna/Pointer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isIntegerType", "(Lcom/sun/jna/Structure$FFIType;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isFloatType", "(Lcom/sun/jna/Structure$FFIType;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "storeTypeInfo", "(Ljava/lang/Class;Lcom/sun/jna/Structure$FFIType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "storeTypeInfo", "(Ljava/lang/Class;ILcom/sun/jna/Structure$FFIType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTypeInfo", "(Ljava/lang/Class;I)Lcom/sun/jna/Structure$FFIType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$900", "(Ljava/lang/Object;Ljava/lang/Class;)Lcom/sun/jna/Structure$FFIType;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map typeInfoMap_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map unionHelper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map ffiTypeInfo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int FFI_TYPE_STRUCT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/Structure$FFIType$size_t;", "public")]
		public Dova.JDK.com.sun.jna.Structure.FFIType.size_t size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType.size_t>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("S", "public")]
		public short alignment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("S", "public")]
		public short type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "public")]
		public Dova.JDK.com.sun.jna.Pointer elements_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FFIType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure;)V", "public")]
		public FFIType(Dova.JDK.com.sun.jna.Structure arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$FFIType;)V", "public")]
		public FFIType(Dova.JDK.com.sun.jna.Structure.FFIType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)V", "public")]
		public FFIType(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public FFIType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$FFIType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lcom/sun/jna/Structure$FFIType;", "private static")]
		public static Dova.JDK.com.sun.jna.Structure.FFIType get(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lcom/sun/jna/Structure$FFIType;", "static")]
		public static Dova.JDK.com.sun.jna.Structure.FFIType get(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType>(ret);
		}

		[JniSignatureAttribute("([Lcom/sun/jna/Pointer;)V", "private")]
		public void init(JavaArray<Dova.JDK.com.sun.jna.Pointer> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$FFIType;)Z", "private static")]
		public static bool isIntegerType(Dova.JDK.com.sun.jna.Structure.FFIType arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$FFIType;)Z", "private static")]
		public static bool isFloatType(Dova.JDK.com.sun.jna.Structure.FFIType arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Structure$FFIType;)V", "private static")]
		public static void storeTypeInfo(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.Structure.FFIType arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;ILcom/sun/jna/Structure$FFIType;)V", "private static")]
		public static void storeTypeInfo(Dova.JDK.java.lang.Class arg0, int arg1, Dova.JDK.com.sun.jna.Structure.FFIType arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;I)Lcom/sun/jna/Structure$FFIType;", "private static")]
		public static Dova.JDK.com.sun.jna.Structure.FFIType getTypeInfo(Dova.JDK.java.lang.Class arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lcom/sun/jna/Structure$FFIType;", "static")]
		public static Dova.JDK.com.sun.jna.Structure.FFIType access_900(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure.FFIType>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/jna/Structure$FFIType$FFITypes;", "private static")]
		public partial class FFITypes
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FFITypes()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$FFIType$FFITypes;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_void", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_float", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_double", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_longdouble", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_uint8", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_sint8", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_uint16", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_sint16", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_uint32", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_sint32", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_uint64", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_sint64", "Lcom/sun/jna/Pointer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ffi_type_pointer", "Lcom/sun/jna/Pointer;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1500", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1600", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1700", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1800", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1900", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2000", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2100", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2200", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1400", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1300", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1000", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1100", "()Lcom/sun/jna/Pointer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1200", "()Lcom/sun/jna/Pointer;"));
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_void_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_float_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_double_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_longdouble_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_uint8_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_sint8_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_uint16_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_sint16_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_uint32_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_sint32_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_uint64_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_sint64_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private static")]
			public static Dova.JDK.com.sun.jna.Pointer ffi_type_pointer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FFITypes(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "private")]
			public FFITypes() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$FFIType$FFITypes;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1500()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1600()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1700()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1800()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1900()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_2000()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_2100()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_2200()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1400()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1300()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1000()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1100()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}

			[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "static")]
			public static Dova.JDK.com.sun.jna.Pointer access_1200()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/Structure$FFIType$size_t;", "public static")]
		public partial class size_t
			: Dova.JDK.com.sun.jna.IntegerType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static size_t()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$FFIType$size_t;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public size_t(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public size_t() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			[JniSignatureAttribute("(J)V", "public")]
			public size_t(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$FFIType$size_t;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$StructField;", "protected static")]
	public partial class StructField
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StructField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$StructField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isVolatile", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isReadOnly", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readConverter", "Lcom/sun/jna/FromNativeConverter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeConverter", "Lcom/sun/jna/ToNativeConverter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Lcom/sun/jna/FromNativeContext;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "public")]
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

		[JniSignatureAttribute("Ljava/lang/reflect/Field;", "public")]
		public Dova.JDK.java.lang.reflect.Field field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool isVolatile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool isReadOnly_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/FromNativeConverter;", "public")]
		public Dova.JDK.com.sun.jna.FromNativeConverter readConverter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.FromNativeConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ToNativeConverter;", "public")]
		public Dova.JDK.com.sun.jna.ToNativeConverter writeConverter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ToNativeConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/FromNativeContext;", "public")]
		public Dova.JDK.com.sun.jna.FromNativeContext context_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.FromNativeContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StructField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public StructField() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$StructField;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$LayoutInfo;", "private static")]
	public partial class LayoutInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LayoutInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$LayoutInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alignment", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alignType", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeMapper", "Lcom/sun/jna/TypeMapper;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "variable", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Structure$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$502", "(Lcom/sun/jna/Structure$LayoutInfo;Lcom/sun/jna/TypeMapper;)Lcom/sun/jna/TypeMapper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$202", "(Lcom/sun/jna/Structure$LayoutInfo;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$602", "(Lcom/sun/jna/Structure$LayoutInfo;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$302", "(Lcom/sun/jna/Structure$LayoutInfo;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$402", "(Lcom/sun/jna/Structure$LayoutInfo;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lcom/sun/jna/Structure$LayoutInfo;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lcom/sun/jna/Structure$LayoutInfo;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lcom/sun/jna/Structure$LayoutInfo;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Lcom/sun/jna/Structure$LayoutInfo;)Lcom/sun/jna/TypeMapper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "(Lcom/sun/jna/Structure$LayoutInfo;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$700", "(Lcom/sun/jna/Structure$LayoutInfo;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int alignment_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map fields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int alignType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/TypeMapper;", "private")]
		public Dova.JDK.com.sun.jna.TypeMapper typeMapper_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.TypeMapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool variable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LayoutInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public LayoutInfo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$1;)V", "")]
		public LayoutInfo(Dova.JDK.com.sun.jna.Structure arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$LayoutInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;Lcom/sun/jna/TypeMapper;)Lcom/sun/jna/TypeMapper;", "static")]
		public static Dova.JDK.com.sun.jna.TypeMapper access_502(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0, Dova.JDK.com.sun.jna.TypeMapper arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.TypeMapper>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;Z)Z", "static")]
		public static bool access_202(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;I)I", "static")]
		public static int access_602(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;I)I", "static")]
		public static int access_302(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;I)I", "static")]
		public static int access_402(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;)I", "static")]
		public static int access_300(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;)Z", "static")]
		public static bool access_200(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;)I", "static")]
		public static int access_400(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;)Lcom/sun/jna/TypeMapper;", "static")]
		public static Dova.JDK.com.sun.jna.TypeMapper access_500(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.TypeMapper>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;)I", "static")]
		public static int access_600(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$LayoutInfo;)Ljava/util/Map;", "static")]
		public static Dova.JDK.java.util.Map access_700(Dova.JDK.com.sun.jna.Structure.LayoutInfo arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$FieldOrder;", "public abstract static interface")]
	public partial interface FieldOrder
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldOrder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$FieldOrder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()[Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()[Ljava/lang/String;", "public abstract")]
		JavaArray<Dova.JDK.java.lang.String> value()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$StructureSet;", "static")]
	public partial class StructureSet
		: Dova.JDK.java.util.AbstractCollection
		, Dova.JDK.java.util.Set
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StructureSet()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$StructureSet;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elements", "[Lcom/sun/jna/Structure;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/jna/Structure;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(Lcom/sun/jna/Structure;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureCapacity", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElements", "()[Lcom/sun/jna/Structure;"));
		}

		[JniSignatureAttribute("[Lcom/sun/jna/Structure;", "")]
		public JavaArray<Dova.JDK.com.sun.jna.Structure> elements_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Structure>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int count_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StructureSet(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public StructureSet() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$StructureSet;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool add(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure;)Z", "public")]
		public bool add(Dova.JDK.com.sun.jna.Structure arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool remove(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure;)I", "private")]
		public int indexOf(Dova.JDK.com.sun.jna.Structure arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool contains(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void ensureCapacity(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()[Lcom/sun/jna/Structure;", "public")]
		public JavaArray<Dova.JDK.com.sun.jna.Structure> getElements()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Structure>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$NativeStringTracking;", "private static")]
	public partial class NativeStringTracking
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NativeStringTracking()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$NativeStringTracking;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peer", "Lcom/sun/jna/NativeString;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$002", "(Lcom/sun/jna/Structure$NativeStringTracking;Lcom/sun/jna/NativeString;)Lcom/sun/jna/NativeString;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lcom/sun/jna/Structure$NativeStringTracking;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lcom/sun/jna/Structure$NativeStringTracking;)Lcom/sun/jna/NativeString;"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
		public Dova.JDK.java.lang.Object value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/NativeString;", "private")]
		public Dova.JDK.com.sun.jna.NativeString peer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeString>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NativeStringTracking(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "")]
		public NativeStringTracking(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Structure$NativeStringTracking;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$NativeStringTracking;Lcom/sun/jna/NativeString;)Lcom/sun/jna/NativeString;", "static")]
		public static Dova.JDK.com.sun.jna.NativeString access_002(Dova.JDK.com.sun.jna.Structure.NativeStringTracking arg0, Dova.JDK.com.sun.jna.NativeString arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeString>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$NativeStringTracking;)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object access_100(Dova.JDK.com.sun.jna.Structure.NativeStringTracking arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Structure$NativeStringTracking;)Lcom/sun/jna/NativeString;", "static")]
		public static Dova.JDK.com.sun.jna.NativeString access_000(Dova.JDK.com.sun.jna.Structure.NativeStringTracking arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeString>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$ByReference;", "public abstract static interface")]
	public partial interface ByReference
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static ByReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$ByReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure$ByValue;", "public abstract static interface")]
	public partial interface ByValue
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static ByValue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Structure$ByValue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}
}
