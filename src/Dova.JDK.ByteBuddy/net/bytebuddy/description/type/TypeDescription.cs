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

namespace Dova.JDK.net.bytebuddy.description.type;

[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public abstract interface")]
public partial interface TypeDescription
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.type.TypeDefinition
	, Dova.JDK.net.bytebuddy.description.ByteCodeElement
	, Dova.JDK.net.bytebuddy.description.TypeVariableSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeDescription()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWABLE", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_INTERFACES", "Lnet/bytebuddy/description/type/TypeList$Generic;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSamePackage", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInHierarchyWith", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInHierarchyWith", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "(Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongSimpleName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemberType", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitiveWrapper", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationReturnType", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationValue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationValue", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPackageType", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInnerClassCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInnerClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestedClass", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asBoxed", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asUnboxed", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestHost", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestMateOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestMateOf", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompileTimeConstant", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription OBJECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription CLASS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription THROWABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeList$Generic;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeList.Generic ARRAY_INTERFACES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription UNDEFINED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool isAssignableFrom(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool isInstance(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getComponentType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getSimpleName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getCanonicalName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isSealed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getDefaultValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isSamePackage(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isAssignableTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool isAssignableTo(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isInHierarchyWith(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool isInHierarchyWith(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("(Z)I", "public abstract")]
	int getActualModifiers(bool arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getLongSimpleName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isAnonymousType()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isLocalType()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isMemberType()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getInheritedAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isPrimitiveWrapper()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isAnnotationReturnType()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isAnnotationValue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
	bool isAnnotationValue(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isPackageType()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getInnerClassCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isInnerClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isNestedClass()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription asBoxed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription asUnboxed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isNestHost()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isNestMateOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
	bool isNestMateOf(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isCompileTimeConstant()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public abstract")]
	Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading;", "public static")]
	public partial class SuperTypeLoading
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SuperTypeLoading()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoadingDelegate", "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription @delegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader classLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate classLoadingDelegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SuperTypeLoading(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;)V", "public")]
		public SuperTypeLoading(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.ClassLoader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/ClassLoader;Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;)V", "public")]
		public SuperTypeLoading(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isArray()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getComponentType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRecord()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getSimpleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getCanonicalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSealed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
		public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingTypeList;", "protected static")]
		public partial class ClassLoadingTypeList
			: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoadingTypeList()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingTypeList;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeList$Generic;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoadingDelegate", "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeList$Generic;Ljava/lang/ClassLoader;Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeList$Generic;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic @delegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
			public Dova.JDK.java.lang.ClassLoader classLoader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate classLoadingDelegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassLoadingTypeList(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;Ljava/lang/ClassLoader;Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;)V", "protected")]
			public ClassLoadingTypeList(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingTypeList;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int size()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingTypeProjection;", "protected static")]
		public partial class ClassLoadingTypeProjection
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoadingTypeProjection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingTypeProjection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoadingDelegate", "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "erasure", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClass", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "Lnet/bytebuddy/description/type/TypeList$Generic;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/ClassLoader;Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic @delegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
			public Dova.JDK.java.lang.ClassLoader classLoader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate classLoadingDelegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription erasure_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic superClass_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeList$Generic;", "private transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic interfaces_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassLoadingTypeProjection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/ClassLoader;Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;)V", "protected")]
			public ClassLoadingTypeProjection(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingTypeProjection;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
			public Dova.JDK.java.util.Iterator iterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;", "public abstract static interface")]
		public partial interface ClassLoadingDelegate
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoadingDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;"));
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class load(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;", "public static final")]
			public partial class Simple
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Simple()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Simple(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class load(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$SuperTypeLoading$ClassLoadingDelegate$Simple;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.SuperTypeLoading.ClassLoadingDelegate.Simple>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$ForPackageDescription;", "public static")]
	public partial class ForPackageDescription
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForPackageDescription()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$ForPackageDescription;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageDescription", "Lnet/bytebuddy/description/type/PackageDescription;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/PackageDescription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/PackageDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription packageDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForPackageDescription(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/PackageDescription;)V", "public")]
		public ForPackageDescription(Dova.JDK.net.bytebuddy.description.type.PackageDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$ForPackageDescription;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRecord()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Latent;", "public static")]
	public partial class Latent
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Latent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Latent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClass", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;[Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
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

		[JniSignatureAttribute("I", "private final")]
		public int modifiers_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic superClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List interfaces_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;[Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "public transient")]
		public Latent(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "public")]
		public Latent(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Latent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRecord()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$ArrayProjection;", "public static")]
	public partial class ArrayProjection
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArrayProjection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$ArrayProjection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_IMPLIED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_EXCLUDED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arity", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;I)Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemberType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int ARRAY_IMPLIED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int ARRAY_EXCLUDED_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription componentType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int arity_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArrayProjection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;I)V", "protected")]
		public ArrayProjection(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$ArrayProjection;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isArray()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;I)Lnet/bytebuddy/description/type/TypeDescription;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getComponentType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRecord()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getSimpleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getCanonicalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isMemberType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getInheritedAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType;", "public static")]
	public partial class ForLoadedType
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_CACHE", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredFields", "Lnet/bytebuddy/description/field/FieldList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredMethods", "Lnet/bytebuddy/description/method/MethodList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredAnnotations", "Lnet/bytebuddy/description/annotation/AnnotationList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getName", "(Ljava/lang/Class;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotation", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "()Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType$Dispatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asGenericType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInHierarchyWith", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInHierarchyWith", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemberType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestHost", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestMateOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestMateOf", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType$Dispatcher;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.ForLoadedType.Dispatcher DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.ForLoadedType.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map TYPE_CACHE_Property
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

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList;", "private transient")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList declaredFields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodList;", "private transient")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList declaredMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationList;", "private transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList declaredAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "private transient")]
		public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForLoadedType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
		public ForLoadedType(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "public static")]
		public static Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isAssignableFrom(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isArray()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription of(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getComponentType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnnotation()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRecord()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getSimpleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getCanonicalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSealed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType$Dispatcher;", "static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.ForLoadedType.Dispatcher access_300()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.ForLoadedType.Dispatcher>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asGenericType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isAssignableTo(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isAssignableTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isInHierarchyWith(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isInHierarchyWith(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isMemberType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNestHost()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isNestMateOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isNestMateOf(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
		public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
		public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$ForLoadedType$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "(Ljava/lang/Class;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "(Ljava/lang/Class;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubclasses", "(Ljava/lang/Class;)[Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "(Ljava/lang/Class;)[Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedSuperclass", "(Ljava/lang/Class;)Ljava/lang/reflect/AnnotatedElement;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedInterfaces", "(Ljava/lang/Class;)[Ljava/lang/reflect/AnnotatedElement;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestmateOf", "(Ljava/lang/Class;Ljava/lang/Class;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "(Ljava/lang/Class;)[Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "(Ljava/lang/Class;)Z"));
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
			bool isRecord(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class getNestHost(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/Class;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Class> getPermittedSubclasses(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/Object;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Object> getRecordComponents(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
			Dova.JDK.java.lang.reflect.AnnotatedElement getAnnotatedSuperclass(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedInterfaces(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Z", "public abstract")]
			bool isNestmateOf(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/lang/Class;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Class> getNestMembers(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public abstract")]
			bool isSealed(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.net.bytebuddy.description.TypeVariableSource.AbstractBase
		, Dova.JDK.net.bytebuddy.description.type.TypeDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RAW_TYPES", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/TypeVariableSource$Visitor;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSamePackage", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asGenericType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInHierarchyWith", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInHierarchyWith", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "(Z)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongSimpleName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMemberType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInheritedAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitiveWrapper", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationReturnType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationValue", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationValue", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPackageType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInnerClassCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInnerClass", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestedClass", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asBoxed", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asUnboxed", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestHost", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestMateOf", "(Ljava/lang/Class;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNestMateOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompileTimeConstant", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInferrable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isGenerified", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAssignable", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		}

		[JniSignatureAttribute("Z", "public static final")]
		public static bool RAW_TYPES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
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

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$AbstractBase;";
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

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isAssignableFrom(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool isInstance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
		public Dova.JDK.java.util.Iterator iterator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTypeName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSealed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/TypeVariableSource$Visitor;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.TypeVariableSource.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getGenericSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getDefaultValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isSamePackage(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getInternalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asGenericType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isAssignableTo(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isAssignableTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isInHierarchyWith(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isInHierarchyWith(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getActualName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Z)I", "public")]
		public int getActualModifiers(bool arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getLongSimpleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isMemberType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getInheritedAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrimitiveWrapper()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnnotationReturnType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool isAnnotationValue(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnnotationValue()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPackageType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getInnerClassCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInnerClass()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNestedClass()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription asBoxed()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription asUnboxed()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNestHost()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
		public bool isNestMateOf(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isNestMateOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isCompileTimeConstant()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
		public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isVisibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isAccessibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
		public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
		public Dova.JDK.net.bytebuddy.description.TypeVariableSource getEnclosingSource()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInferrable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[46]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isGenerified()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[47]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Z", "private static")]
		public static bool isAssignable(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[48], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$AbstractBase$OfSimpleType;", "public abstract static")]
		public partial class OfSimpleType
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfSimpleType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$AbstractBase$OfSimpleType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfSimpleType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public OfSimpleType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$AbstractBase$OfSimpleType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getComponentType_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getDescriptor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSimpleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getCanonicalName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$AbstractBase$OfSimpleType$WithDelegation;", "public abstract static")]
			public partial class WithDelegation
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithDelegation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$AbstractBase$OfSimpleType$WithDelegation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegate", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "(Z)I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithDelegation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public WithDelegation() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$AbstractBase$OfSimpleType$WithDelegation;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()I", "public")]
				public int getModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isRecord()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isSealed()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getGenericSignature()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription @delegate()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Z)I", "public")]
				public int getActualModifiers(bool arg0)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAnonymousType()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
					return ret;
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isLocalType()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
				public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract static interface")]
	public partial interface Generic
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.type.TypeDefinition
		, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Generic()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asRawType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic OBJECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic VOID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic UNDEFINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getSymbol()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asRawType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public abstract static")]
		public partial class Builder
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Builder()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "Ljava/lang/reflect/Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rawType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rawType", "(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rawType", "(Ljava/lang/Class;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "rawType", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asArray", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAnnotate", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardLowerBound", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardLowerBound", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardLowerBound", "(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardLowerBound", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardLowerBound", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardUpperBound", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardUpperBound", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardUpperBound", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardUpperBound", "(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asWildcardUpperBound", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unboundWildcard", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unboundWildcard", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unboundWildcard", "(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unboundWildcard", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unboundWildcard", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parameterizedType", "(Ljava/lang/Class;Ljava/lang/reflect/Type;Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parameterizedType", "(Ljava/lang/Class;Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parameterizedType", "(Ljava/lang/Class;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
			}

			[JniSignatureAttribute("Ljava/lang/reflect/Type;", "private static final")]
			public static Dova.JDK.java.lang.reflect.Type UNDEFINED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "protected final")]
			public Dova.JDK.java.util.List annotations_Property
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
			public Builder(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
			public Builder(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder of(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder of(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic build(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic build(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic build(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic build(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic build()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder rawType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder rawType(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder rawType(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder rawType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder asArray(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder asArray()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder annotate(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder annotate(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder annotate(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder annotate(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder doAnnotate(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic doBuild()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardLowerBound(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardLowerBound(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardLowerBound(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardLowerBound(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardLowerBound()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardUpperBound()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardUpperBound(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardUpperBound(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardUpperBound(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asWildcardUpperBound(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic unboundWildcard()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static transient")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic unboundWildcard(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic unboundWildcard(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic unboundWildcard(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static transient")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic unboundWildcard(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder typeVariable(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/reflect/Type;Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder parameterizedType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder parameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.Collection arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Collection;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder parameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.Collection arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static transient")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder parameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder parameterizedType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public static transient")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder parameterizedType(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.reflect.Type> arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfTypeVariable;", "protected static")]
			public partial class OfTypeVariable
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfTypeVariable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfTypeVariable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAnnotate", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String symbol_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public OfTypeVariable(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)V", "protected")]
				public OfTypeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfTypeVariable;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder doAnnotate(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic doBuild()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfGenericArrayType;", "protected static")]
			public partial class OfGenericArrayType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfGenericArrayType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfGenericArrayType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAnnotate", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic componentType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfGenericArrayType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
				public OfGenericArrayType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "protected")]
				public OfGenericArrayType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfGenericArrayType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder doAnnotate(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic doBuild()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfParameterizedType;", "protected static")]
			public partial class OfParameterizedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfParameterizedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfParameterizedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypes", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAnnotate", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription rawType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic ownerType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List parameterTypes_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "protected")]
				public OfParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/util/List;)V", "protected")]
				public OfParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfParameterizedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder doAnnotate(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic doBuild()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfNonGenericType;", "protected static")]
			public partial class OfNonGenericType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfNonGenericType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfNonGenericType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAnnotate", "(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic ownerType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfNonGenericType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "protected")]
				public OfNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
				public OfNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public OfNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public OfNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$OfNonGenericType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder doAnnotate(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic doBuild()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;", "protected static final")]
			public partial class Visitor
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Visitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Visitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Visitor(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder$Visitor;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder.Visitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;", "public abstract static")]
		public partial class LazyProjection
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LazyProjection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			}

			[JniSignatureAttribute("I", "private transient")]
			public int hashCode_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LazyProjection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public LazyProjection() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getTypeName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSymbol()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
			public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getActualName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
			public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithResolvedErasure;", "public static")]
			public partial class WithResolvedErasure
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithResolvedErasure()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithResolvedErasure;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor visitor_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithResolvedErasure(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "public")]
				public WithResolvedErasure(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "public")]
				public WithResolvedErasure(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg1, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithResolvedErasure;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfRecordComponent;", "public static")]
			public partial class OfRecordComponent
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation.OfAnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfRecordComponent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfRecordComponent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponent", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object recordComponent_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
				public OfRecordComponent(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfRecordComponent;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfMethodParameter;", "public static")]
			public partial class OfMethodParameter
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation.OfAnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfMethodParameter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfMethodParameter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "erasure", "[Ljava/lang/Class;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;I[Ljava/lang/Class;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method method_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int index_Property
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

				[JniSignatureAttribute("[Ljava/lang/Class;", "private final")]
				public JavaArray<Dova.JDK.java.lang.Class> erasure_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfMethodParameter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Method;I[Ljava/lang/Class;)V", "public")]
				public OfMethodParameter(Dova.JDK.java.lang.reflect.Method arg0, int arg1, JavaArray<Dova.JDK.java.lang.Class> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfMethodParameter;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfConstructorParameter;", "public static")]
			public partial class OfConstructorParameter
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation.OfAnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfConstructorParameter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfConstructorParameter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "erasure", "[Ljava/lang/Class;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;I[Ljava/lang/Class;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private final")]
				public Dova.JDK.java.lang.reflect.Constructor constructor_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int index_Property
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

				[JniSignatureAttribute("[Ljava/lang/Class;", "private final")]
				public JavaArray<Dova.JDK.java.lang.Class> erasure_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfConstructorParameter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;I[Ljava/lang/Class;)V", "public")]
				public OfConstructorParameter(Dova.JDK.java.lang.reflect.Constructor arg0, int arg1, JavaArray<Dova.JDK.java.lang.Class> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$OfConstructorParameter;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedReturnType;", "public static")]
			public partial class ForLoadedReturnType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation.OfAnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedReturnType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedReturnType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method method_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedReturnType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "public")]
				public ForLoadedReturnType(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedReturnType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedFieldType;", "public static")]
			public partial class ForLoadedFieldType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation.OfAnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedFieldType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedFieldType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Field;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Field;", "private final")]
				public Dova.JDK.java.lang.reflect.Field field_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedFieldType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Field;)V", "public")]
				public ForLoadedFieldType(Dova.JDK.java.lang.reflect.Field arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedFieldType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedSuperClass;", "public static")]
			public partial class ForLoadedSuperClass
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithLazyNavigation.OfAnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedSuperClass()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedSuperClass;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedSuperClass(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)V", "protected")]
				public ForLoadedSuperClass(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$ForLoadedSuperClass;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithEagerNavigation;", "public abstract static")]
			public partial class WithEagerNavigation
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithEagerNavigation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithEagerNavigation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithEagerNavigation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public WithEagerNavigation() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithEagerNavigation;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
				public Dova.JDK.java.util.Iterator iterator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithEagerNavigation$OfAnnotatedElement;", "protected abstract static")]
				public partial class OfAnnotatedElement
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfAnnotatedElement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithEagerNavigation$OfAnnotatedElement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfAnnotatedElement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public OfAnnotatedElement() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithEagerNavigation$OfAnnotatedElement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected abstract")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation;", "public abstract static")]
			public partial class WithLazyNavigation
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithLazyNavigation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithLazyNavigation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public WithLazyNavigation() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
				public Dova.JDK.java.util.Iterator iterator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$OfAnnotatedElement;", "protected abstract static")]
				public partial class OfAnnotatedElement
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithLazyNavigation
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfAnnotatedElement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$OfAnnotatedElement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationReader", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfAnnotatedElement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public OfAnnotatedElement() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$OfAnnotatedElement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected abstract")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader getAnnotationReader()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazyInterfaceList;", "protected static")]
				public partial class LazyInterfaceList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyInterfaceList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazyInterfaceList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawInterfaces", "Lnet/bytebuddy/description/type/TypeList$Generic;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;Lnet/bytebuddy/description/type/TypeList$Generic;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection @delegate_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeList$Generic;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic rawInterfaces_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyInterfaceList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;Lnet/bytebuddy/description/type/TypeList$Generic;)V", "protected")]
					public LazyInterfaceList(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection arg0, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazyInterfaceList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;)Lnet/bytebuddy/description/type/TypeList$Generic;", "protected static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeList.Generic of(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazyInterfaceType;", "protected static")]
				public partial class LazyInterfaceType
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithLazyNavigation
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyInterfaceType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazyInterfaceType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawInterface", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;ILnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection @delegate_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int index_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic rawInterface_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyInterfaceType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;ILnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
					public LazyInterfaceType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazyInterfaceType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazySuperClass;", "protected static")]
				public partial class LazySuperClass
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithLazyNavigation
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazySuperClass()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazySuperClass;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection @delegate_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazySuperClass(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;)V", "protected")]
					public LazySuperClass(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection$WithLazyNavigation$LazySuperClass;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$LazyProjection;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable;", "public abstract static")]
		public partial class OfTypeVariable
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfTypeVariable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			}

			[JniSignatureAttribute("I", "private transient")]
			public int hashCode_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public OfTypeVariable() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
			public Dova.JDK.java.util.Iterator iterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getTypeName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getActualName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
			public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$WithAnnotationOverlay;", "public static")]
			public partial class WithAnnotationOverlay
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithAnnotationOverlay()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$WithAnnotationOverlay;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithAnnotationOverlay(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "public")]
				public WithAnnotationOverlay(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$WithAnnotationOverlay;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getSymbol()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
				public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$ForLoadedType;", "public static")]
			public partial class ForLoadedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$ForLoadedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Ljava/lang/reflect/TypeVariable;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/TypeVariable;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/TypeVariable;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/TypeVariable;", "private final")]
				public Dova.JDK.java.lang.reflect.TypeVariable typeVariable_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/TypeVariable;)V", "public")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.TypeVariable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/TypeVariable;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.TypeVariable arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$ForLoadedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getSymbol()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
				public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
				public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$ForLoadedType$TypeVariableBoundList;", "protected static")]
				public partial class TypeVariableBoundList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static TypeVariableBoundList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$ForLoadedType$TypeVariableBoundList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bound", "[Ljava/lang/reflect/Type;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					}

					[JniSignatureAttribute("[Ljava/lang/reflect/Type;", "private final")]
					public JavaArray<Dova.JDK.java.lang.reflect.Type> bound_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public TypeVariableBoundList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
					public TypeVariableBoundList(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$ForLoadedType$TypeVariableBoundList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$Symbolic;", "public static")]
			public partial class Symbolic
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Symbolic()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$Symbolic;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String symbol_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Symbolic(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "public")]
				public Symbolic(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfTypeVariable$Symbolic;";
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

				[JniSignatureAttribute("()Z", "public")]
				public bool isArray()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isPrimitive()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}

				[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
				public Dova.JDK.java.util.Iterator iterator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isRecord()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getTypeName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getSymbol()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
				public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getActualName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
				public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType;", "public abstract static")]
		public partial class OfParameterizedType
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfParameterizedType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
			}

			[JniSignatureAttribute("I", "private transient")]
			public int hashCode_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public OfParameterizedType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
			public Dova.JDK.java.util.Iterator iterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getTypeName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSymbol()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
			public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getActualName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
			public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
				return ret;
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForGenerifiedErasure;", "public static")]
			public partial class ForGenerifiedErasure
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForGenerifiedErasure()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForGenerifiedErasure;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForGenerifiedErasure(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForGenerifiedErasure(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForGenerifiedErasure;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForReifiedType;", "public static")]
			public partial class ForReifiedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForReifiedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForReifiedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterizedType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic parameterizedType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForReifiedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
				public ForReifiedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForReifiedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$Latent;", "public static")]
			public partial class Latent
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Latent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$Latent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription rawType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic ownerType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List parameters_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "public")]
				public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$Latent;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForLoadedType;", "public static")]
			public partial class ForLoadedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForLoadedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterizedType", "Ljava/lang/reflect/ParameterizedType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/ParameterizedType;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/ParameterizedType;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/ParameterizedType;", "private final")]
				public Dova.JDK.java.lang.reflect.ParameterizedType parameterizedType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.ParameterizedType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/ParameterizedType;)V", "public")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.ParameterizedType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/ParameterizedType;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.ParameterizedType arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForLoadedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
				public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForLoadedType$ParameterArgumentTypeList;", "protected static")]
				public partial class ParameterArgumentTypeList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ParameterArgumentTypeList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForLoadedType$ParameterArgumentTypeList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentType", "[Ljava/lang/reflect/Type;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					}

					[JniSignatureAttribute("[Ljava/lang/reflect/Type;", "private final")]
					public JavaArray<Dova.JDK.java.lang.reflect.Type> argumentType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ParameterArgumentTypeList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
					public ParameterArgumentTypeList(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$ForLoadedType$ParameterArgumentTypeList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "protected abstract static")]
			public partial class RenderingDelegate
				: Dova.JDK.java.lang.Enum
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RenderingDelegate()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_LEGACY_VM", "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_JAVA_8_CAPABLE_VM", "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CURRENT", "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/lang/StringBuilder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate FOR_LEGACY_VM_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate FOR_JAVA_8_CAPABLE_VM_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "protected static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate CURRENT_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public RenderingDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public RenderingDelegate(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$1;)V", "")]
				public RenderingDelegate(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$OfParameterizedType$RenderingDelegate;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType.RenderingDelegate>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/StringBuilder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected abstract")]
				public void apply(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType;", "public abstract static")]
		public partial class OfWildcardType
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfWildcardType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYMBOL", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
			public static Dova.JDK.java.lang.String SYMBOL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private transient")]
			public int hashCode_Property
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
			public OfWildcardType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public OfWildcardType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
			public Dova.JDK.java.util.Iterator iterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getTypeName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSymbol()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
			public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getActualName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
			public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$Latent;", "public static")]
			public partial class Latent
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfWildcardType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Latent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$Latent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upperBounds", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lowerBounds", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unbounded", "(Lnet/bytebuddy/description/annotation/AnnotationSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedAbove", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "boundedBelow", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List upperBounds_Property
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

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List lowerBounds_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "protected")]
				public Latent(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$Latent;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic unbounded(Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic boundedAbove(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic boundedBelow(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType;", "public static")]
			public partial class ForLoadedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfWildcardType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wildcardType", "Ljava/lang/reflect/WildcardType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/WildcardType;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/WildcardType;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/WildcardType;", "private final")]
				public Dova.JDK.java.lang.reflect.WildcardType wildcardType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.WildcardType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/WildcardType;)V", "public")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.WildcardType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/WildcardType;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.WildcardType arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
				public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType$WildcardLowerBoundTypeList;", "protected static")]
				public partial class WildcardLowerBoundTypeList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WildcardLowerBoundTypeList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType$WildcardLowerBoundTypeList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lowerBound", "[Ljava/lang/reflect/Type;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					}

					[JniSignatureAttribute("[Ljava/lang/reflect/Type;", "private final")]
					public JavaArray<Dova.JDK.java.lang.reflect.Type> lowerBound_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WildcardLowerBoundTypeList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
					public WildcardLowerBoundTypeList(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType$WildcardLowerBoundTypeList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType$WildcardUpperBoundTypeList;", "protected static")]
				public partial class WildcardUpperBoundTypeList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WildcardUpperBoundTypeList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType$WildcardUpperBoundTypeList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upperBound", "[Ljava/lang/reflect/Type;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					}

					[JniSignatureAttribute("[Ljava/lang/reflect/Type;", "private final")]
					public JavaArray<Dova.JDK.java.lang.reflect.Type> upperBound_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WildcardUpperBoundTypeList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("([Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
					public WildcardUpperBoundTypeList(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfWildcardType$ForLoadedType$WildcardUpperBoundTypeList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray;", "public abstract static")]
		public partial class OfGenericArray
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfGenericArray()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			}

			[JniSignatureAttribute("I", "private transient")]
			public int hashCode_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfGenericArray(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public OfGenericArray() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
			public Dova.JDK.java.util.Iterator iterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getTypeName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSymbol()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
			public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getActualName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray$Latent;", "public static")]
			public partial class Latent
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfGenericArray
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Latent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray$Latent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic componentType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "public")]
				public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray$Latent;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray$ForLoadedType;", "public static")]
			public partial class ForLoadedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfGenericArray
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray$ForLoadedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericArrayType", "Ljava/lang/reflect/GenericArrayType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/GenericArrayType;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/GenericArrayType;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/GenericArrayType;", "private final")]
				public Dova.JDK.java.lang.reflect.GenericArrayType genericArrayType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.GenericArrayType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/GenericArrayType;)V", "public")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.GenericArrayType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/GenericArrayType;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForLoadedType(Dova.JDK.java.lang.reflect.GenericArrayType arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfGenericArray$ForLoadedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
				public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType;", "public abstract static")]
		public partial class OfNonGenericType
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfNonGenericType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findBindingOf", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			}

			[JniSignatureAttribute("I", "private transient")]
			public int hashCode_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfNonGenericType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public OfNonGenericType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isArray()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isPrimitive()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
			public Dova.JDK.java.util.Iterator iterator()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getTypeName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSymbol()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
			public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic findBindingOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getActualName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
			public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForReifiedErasure;", "public static")]
			public partial class ForReifiedErasure
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForReifiedErasure()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForReifiedErasure;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForReifiedErasure(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForReifiedErasure(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForReifiedErasure;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$Latent;", "public static")]
			public partial class Latent
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Latent()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$Latent;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationSource", "Lnet/bytebuddy/description/annotation/AnnotationSource;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/annotation/AnnotationSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic declaringType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource annotationSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "protected")]
				public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "private")]
				public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/annotation/AnnotationSource;)V", "public")]
				public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$Latent;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForErasure;", "public static")]
			public partial class ForErasure
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForErasure()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForErasure;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForErasure(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public ForErasure(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForErasure;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForLoadedType;", "public static")]
			public partial class ForLoadedType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForLoadedType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_CACHE", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
				public static Dova.JDK.java.util.Map TYPE_CACHE_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
				public ForLoadedType(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForLoadedType(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$OfNonGenericType$ForLoadedType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
				public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.net.bytebuddy.description.ModifierReviewable.AbstractBase
			, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asGenericType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asRawType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int getModifiers()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asGenericType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public")]
			public bool represents(Dova.JDK.java.lang.reflect.Type arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asRawType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract static interface")]
		public partial interface AnnotationReader
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AnnotationReader()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asList", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofOuterClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofComponentType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWildcardUpperBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWildcardLowerBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeVariableBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeArgument", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
			}

			[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
			Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.annotation.AnnotationList asList()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofOuterClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofComponentType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofOwnerType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofWildcardUpperBoundType(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofWildcardLowerBoundType(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeVariableBoundType(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeArgument(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType;", "public static")]
			public partial class ForOwnerType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.Chained
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForOwnerType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_TYPE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType$AnnotatedType;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType$AnnotatedType;", "private static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForOwnerType.AnnotatedType ANNOTATED_TYPE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForOwnerType.AnnotatedType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForOwnerType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForOwnerType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public volatile")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType$AnnotatedType;", "protected abstract static interface")]
				public partial interface AnnotatedType
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotatedType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForOwnerType$AnnotatedType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedOwnerType", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
					Dova.JDK.java.lang.reflect.AnnotatedElement getAnnotatedOwnerType(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType;", "public static")]
			public partial class ForComponentType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.Chained
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForComponentType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_PARAMETERIZED_TYPE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType$AnnotatedParameterizedType;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType$AnnotatedParameterizedType;", "private static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForComponentType.AnnotatedParameterizedType ANNOTATED_PARAMETERIZED_TYPE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForComponentType.AnnotatedParameterizedType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForComponentType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
				public ForComponentType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public volatile")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType$AnnotatedParameterizedType;", "protected abstract static interface")]
				public partial interface AnnotatedParameterizedType
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotatedParameterizedType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForComponentType$AnnotatedParameterizedType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/reflect/AnnotatedElement;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedGenericComponentType", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Z", "public abstract")]
					bool isInstance(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
					Dova.JDK.java.lang.reflect.AnnotatedElement getAnnotatedGenericComponentType(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument;", "public static")]
			public partial class ForTypeArgument
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.Chained
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForTypeArgument()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_PARAMETERIZED_TYPE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument$AnnotatedParameterizedType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument$AnnotatedParameterizedType;", "private static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForTypeArgument.AnnotatedParameterizedType ANNOTATED_PARAMETERIZED_TYPE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForTypeArgument.AnnotatedParameterizedType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int index_Property
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
				public ForTypeArgument(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V", "protected")]
				public ForTypeArgument(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public volatile")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument$AnnotatedParameterizedType;", "protected abstract static interface")]
				public partial interface AnnotatedParameterizedType
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotatedParameterizedType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeArgument$AnnotatedParameterizedType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/reflect/AnnotatedElement;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedActualTypeArguments", "(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Z", "public abstract")]
					bool isInstance(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
					JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedActualTypeArguments(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType;", "public static")]
			public partial class ForTypeVariableBoundType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.Chained
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForTypeVariableBoundType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_TYPE_VARIABLE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$AnnotatedTypeVariable;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$AnnotatedTypeVariable;", "private static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForTypeVariableBoundType.AnnotatedTypeVariable ANNOTATED_TYPE_VARIABLE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForTypeVariableBoundType.AnnotatedTypeVariable>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int index_Property
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
				public ForTypeVariableBoundType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V", "protected")]
				public ForTypeVariableBoundType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public volatile")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable;", "protected static")]
				public partial class OfFormalTypeVariable
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfFormalTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_VARIABLE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable$FormalTypeVariable;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Ljava/lang/reflect/TypeVariable;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/TypeVariable;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable$FormalTypeVariable;", "private static final")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForTypeVariableBoundType.OfFormalTypeVariable.FormalTypeVariable TYPE_VARIABLE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForTypeVariableBoundType.OfFormalTypeVariable.FormalTypeVariable>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/reflect/TypeVariable;", "private final")]
					public Dova.JDK.java.lang.reflect.TypeVariable typeVariable_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int index_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfFormalTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/TypeVariable;I)V", "protected")]
					public OfFormalTypeVariable(Dova.JDK.java.lang.reflect.TypeVariable arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable$FormalTypeVariable;", "protected abstract static interface")]
					public partial interface FormalTypeVariable
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static FormalTypeVariable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$OfFormalTypeVariable$FormalTypeVariable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedBounds", "(Ljava/lang/Object;)[Ljava/lang/reflect/AnnotatedElement;"));
						}

						[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
						JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedBounds(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$AnnotatedTypeVariable;", "protected abstract static interface")]
				public partial interface AnnotatedTypeVariable
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotatedTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForTypeVariableBoundType$AnnotatedTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/reflect/AnnotatedElement;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedBounds", "(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Z", "public abstract")]
					bool isInstance(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
					JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedBounds(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType;", "public static")]
			public partial class ForWildcardLowerBoundType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.Chained
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForWildcardLowerBoundType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_WILDCARD_TYPE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType$AnnotatedWildcardType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType$AnnotatedWildcardType;", "private static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForWildcardLowerBoundType.AnnotatedWildcardType ANNOTATED_WILDCARD_TYPE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForWildcardLowerBoundType.AnnotatedWildcardType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int index_Property
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
				public ForWildcardLowerBoundType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V", "protected")]
				public ForWildcardLowerBoundType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public volatile")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType$AnnotatedWildcardType;", "protected abstract static interface")]
				public partial interface AnnotatedWildcardType
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotatedWildcardType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardLowerBoundType$AnnotatedWildcardType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/reflect/AnnotatedElement;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedLowerBounds", "(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Z", "public abstract")]
					bool isInstance(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
					JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedLowerBounds(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType;", "public static")]
			public partial class ForWildcardUpperBoundType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.Chained
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForWildcardUpperBoundType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_WILDCARD_TYPE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType$AnnotatedWildcardType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType$AnnotatedWildcardType;", "private static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForWildcardUpperBoundType.AnnotatedWildcardType ANNOTATED_WILDCARD_TYPE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.ForWildcardUpperBoundType.AnnotatedWildcardType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int index_Property
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
				public ForWildcardUpperBoundType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;I)V", "protected")]
				public ForWildcardUpperBoundType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public volatile")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType$AnnotatedWildcardType;", "protected abstract static interface")]
				public partial interface AnnotatedWildcardType
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotatedWildcardType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$ForWildcardUpperBoundType$AnnotatedWildcardType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/reflect/AnnotatedElement;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedUpperBounds", "(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Z", "public abstract")]
					bool isInstance(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
					JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedUpperBounds(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator;", "public abstract static")]
			public partial class Delegator
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Delegator()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asList", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofOuterClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofComponentType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWildcardUpperBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWildcardLowerBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeVariableBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeArgument", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				}

				[JniSignatureAttribute("Z", "private static final")]
				public static bool ACCESS_CONTROLLER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Delegator(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public Delegator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "static")]
				public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList asList()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofOuterClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofWildcardUpperBoundType(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofWildcardLowerBoundType(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeVariableBoundType(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeArgument(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedRecordComponent;", "public static")]
				public partial class ForLoadedRecordComponent
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedRecordComponent()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedRecordComponent;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponent", "Ljava/lang/Object;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
					public Dova.JDK.java.lang.Object recordComponent_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
					public ForLoadedRecordComponent(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedRecordComponent;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType;", "public static")]
				public partial class ForLoadedExecutableExceptionType
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedExecutableExceptionType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType$Dispatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executable", "Ljava/lang/reflect/AccessibleObject;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/AccessibleObject;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType$Dispatcher;", "protected static final")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedExecutableExceptionType.Dispatcher DISPATCHER_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedExecutableExceptionType.Dispatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/reflect/AccessibleObject;", "private final")]
					public Dova.JDK.java.lang.reflect.AccessibleObject executable_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AccessibleObject>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int index_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedExecutableExceptionType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AccessibleObject;I)V", "public")]
					public ForLoadedExecutableExceptionType(Dova.JDK.java.lang.reflect.AccessibleObject arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType$Dispatcher;", "protected abstract static interface")]
					public partial interface Dispatcher
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Dispatcher()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableExceptionType$Dispatcher;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedExceptionTypes", "(Ljava/lang/Object;)[Ljava/lang/reflect/AnnotatedElement;"));
						}

						[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
						JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedExceptionTypes(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType;", "public static")]
				public partial class ForLoadedExecutableParameterType
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedExecutableParameterType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType$Dispatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executable", "Ljava/lang/reflect/AccessibleObject;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/AccessibleObject;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType$Dispatcher;", "protected static final")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedExecutableParameterType.Dispatcher DISPATCHER_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedExecutableParameterType.Dispatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/reflect/AccessibleObject;", "private final")]
					public Dova.JDK.java.lang.reflect.AccessibleObject executable_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AccessibleObject>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int index_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedExecutableParameterType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AccessibleObject;I)V", "public")]
					public ForLoadedExecutableParameterType(Dova.JDK.java.lang.reflect.AccessibleObject arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType$Dispatcher;", "protected abstract static interface")]
					public partial interface Dispatcher
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Dispatcher()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedExecutableParameterType$Dispatcher;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedParameterTypes", "(Ljava/lang/Object;)[Ljava/lang/reflect/AnnotatedElement;"));
						}

						[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
						JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement> getAnnotatedParameterTypes(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.AnnotatedElement>>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType;", "public static")]
				public partial class ForLoadedMethodReturnType
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedMethodReturnType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType$Dispatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType$Dispatcher;", "protected static final")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedMethodReturnType.Dispatcher DISPATCHER_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedMethodReturnType.Dispatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
					public Dova.JDK.java.lang.reflect.Method method_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedMethodReturnType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "public")]
					public ForLoadedMethodReturnType(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType$Dispatcher;", "protected abstract static interface")]
					public partial interface Dispatcher
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Dispatcher()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedMethodReturnType$Dispatcher;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedReturnType", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/AnnotatedElement;"));
						}

						[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
						Dova.JDK.java.lang.reflect.AnnotatedElement getAnnotatedReturnType(Dova.JDK.java.lang.reflect.Method arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField;", "public static")]
				public partial class ForLoadedField
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedField()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField$Dispatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Field;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField$Dispatcher;", "protected static final")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedField.Dispatcher DISPATCHER_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator.ForLoadedField.Dispatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Field;", "private final")]
					public Dova.JDK.java.lang.reflect.Field field_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedField(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Field;)V", "public")]
					public ForLoadedField(Dova.JDK.java.lang.reflect.Field arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField$Dispatcher;", "protected abstract static interface")]
					public partial interface Dispatcher
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Dispatcher()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedField$Dispatcher;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedType", "(Ljava/lang/reflect/Field;)Ljava/lang/reflect/AnnotatedElement;"));
						}

						[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
						Dova.JDK.java.lang.reflect.AnnotatedElement getAnnotatedType(Dova.JDK.java.lang.reflect.Field arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedInterface;", "public static")]
				public partial class ForLoadedInterface
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedInterface()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedInterface;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
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

					[JniSignatureAttribute("I", "private final")]
					public int index_Property
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
					public ForLoadedInterface(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/Class;I)V", "public")]
					public ForLoadedInterface(Dova.JDK.java.lang.Class arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedInterface;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedSuperClass;", "public static")]
				public partial class ForLoadedSuperClass
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedSuperClass()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedSuperClass;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedSuperClass(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
					public ForLoadedSuperClass(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedSuperClass;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedTypeVariable;", "public static")]
				public partial class ForLoadedTypeVariable
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLoadedTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Ljava/lang/reflect/TypeVariable;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/TypeVariable;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeVariableBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					}

					[JniSignatureAttribute("Ljava/lang/reflect/TypeVariable;", "private final")]
					public Dova.JDK.java.lang.reflect.TypeVariable typeVariable_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.TypeVariable>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLoadedTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/TypeVariable;)V", "public")]
					public ForLoadedTypeVariable(Dova.JDK.java.lang.reflect.TypeVariable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$ForLoadedTypeVariable;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeVariableBoundType(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$Chained;", "protected abstract static")]
				public partial class Chained
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Chained()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$Chained;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationReader", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "protected final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader annotationReader_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Chained(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)V", "protected")]
					public Chained(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$Chained;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/AnnotatedElement;", "protected abstract")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$Simple;", "public static")]
				public partial class Simple
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.Delegator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotatedElement", "Ljava/lang/reflect/AnnotatedElement;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/AnnotatedElement;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					}

					[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedElement;", "private final")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement annotatedElement_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)V", "public")]
					public Simple(Dova.JDK.java.lang.reflect.AnnotatedElement arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$Delegator$Simple;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
					public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;", "public static final")]
			public partial class NoOp
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader
				, Dova.JDK.java.lang.reflect.AnnotatedElement
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static NoOp()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotationPresent", "(Ljava/lang/Class;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()[Ljava/lang/annotation/Annotation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/reflect/AnnotatedElement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asList", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofOuterClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofComponentType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWildcardUpperBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofWildcardLowerBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeVariableBoundType", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofTypeArgument", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public NoOp(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader$NoOp;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader.NoOp>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)Z", "public")]
				public bool isAnnotationPresent(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "public")]
				public Dova.JDK.java.lang.Object getAnnotation(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public")]
				public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
				}

				[JniSignatureAttribute("()[Ljava/lang/annotation/Annotation;", "public")]
				public JavaArray<Dova.JDK.java.lang.annotation.Annotation> getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/reflect/AnnotatedElement;", "public")]
				public Dova.JDK.java.lang.reflect.AnnotatedElement resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList asList()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofOuterClass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofComponentType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofOwnerType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofWildcardUpperBoundType(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofWildcardLowerBoundType(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeVariableBoundType(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader ofTypeArgument(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public abstract static interface")]
		public partial interface Visitor
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Visitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object onGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object onWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object onParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object onTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object onNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reducing;", "public static")]
			public partial class Reducing
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Reducing()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reducing;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableTokens", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/TypeVariableToken;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription declaringType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List typeVariableTokens_Property
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
				public Reducing(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/TypeVariableToken;)V", "public transient")]
				public Reducing(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeVariableToken> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public Reducing(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reducing;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForRawType;", "public static")]
			public partial class ForRawType
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForRawType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForRawType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription declaringType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForRawType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public ForRawType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForRawType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor;", "public abstract static")]
			public partial class Substitutor
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Substitutor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSimpleType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Substitutor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public Substitutor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForReplacement;", "public static")]
				public partial class ForReplacement
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForReplacement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForReplacement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSimpleType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForReplacement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
					public ForReplacement(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForReplacement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTokenNormalization;", "public static")]
				public partial class ForTokenNormalization
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTokenNormalization()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTokenNormalization;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSimpleType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForTokenNormalization(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
					public ForTokenNormalization(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTokenNormalization;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;", "public static")]
				public partial class ForTypeVariableBinding
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.WithoutTypeSubstitution
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTypeVariableBinding()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterizedType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic parameterizedType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForTypeVariableBinding(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
					public ForTypeVariableBinding(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic access_200(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding$RetainedMethodTypeVariable;", "protected")]
					public partial class RetainedMethodTypeVariable
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static RetainedMethodTypeVariable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding$RetainedMethodTypeVariable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;", "final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public RetainedMethodTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
						public RetainedMethodTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding$RetainedMethodTypeVariable;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Ljava/lang/String;", "public")]
						public Dova.JDK.java.lang.String getSymbol()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding$TypeVariableSubstitutor;", "protected")]
					public partial class TypeVariableSubstitutor
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.description.TypeVariableSource.Visitor
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static TypeVariableSubstitutor()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding$TypeVariableSubstitutor;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethod_0", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethod_1", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;", "final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public TypeVariableSubstitutor(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
						public TypeVariableSubstitutor(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForTypeVariableBinding arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForTypeVariableBinding$TypeVariableSubstitutor;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
						public bool equals(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return ret;
						}

						[JniSignatureAttribute("()I", "public")]
						public int hashCode()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onMethod_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onMethod_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForDetachment;", "public static")]
				public partial class ForDetachment
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForDetachment()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForDetachment;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeMatcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSimpleType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
					public Dova.JDK.net.bytebuddy.matcher.ElementMatcher typeMatcher_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForDetachment(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
					public ForDetachment(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForDetachment;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor of(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;", "public static")]
				public partial class ForAttachment
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForAttachment()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/TypeVariableSource;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/TypeVariableSource;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/ParameterDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSimpleType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription declaringType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
					public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForAttachment(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/TypeVariableSource;)V", "protected")]
					public ForAttachment(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/TypeVariableSource;)V", "protected")]
					public ForAttachment(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment of(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment of(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment of(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$ForAttachment;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment of(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.ForAttachment>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$WithoutTypeSubstitution;", "public abstract static")]
				public partial class WithoutTypeSubstitution
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithoutTypeSubstitution()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$WithoutTypeSubstitution;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSimpleType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithoutTypeSubstitution(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public WithoutTypeSubstitution() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Substitutor$WithoutTypeSubstitution;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForSignatureVisitor;", "public static")]
			public partial class ForSignatureVisitor
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForSignatureVisitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForSignatureVisitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLY_CHARACTER", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureVisitor", "Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onOwnableType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("I", "private static final")]
				public static int ONLY_CHARACTER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "protected final")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor signatureVisitor_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForSignatureVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;)V", "public")]
				public ForSignatureVisitor(Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForSignatureVisitor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "private")]
				public void onOwnableType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForSignatureVisitor$OfTypeArgument;", "protected static")]
				public partial class OfTypeArgument
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.ForSignatureVisitor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfTypeArgument()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForSignatureVisitor$OfTypeArgument;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfTypeArgument(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;)V", "protected")]
					public OfTypeArgument(Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$ForSignatureVisitor$OfTypeArgument;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;", "public abstract static")]
			public partial class Reifying
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Reifying()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INITIATING", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INHERITING", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying INITIATING_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying INHERITING_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Reifying(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Reifying(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$1;)V", "")]
				public Reifying(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Reifying;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Reifying>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static")]
			public partial class Validator
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Validator()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER_CLASS", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_VARIABLE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_RETURN", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_PARAMETER", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCEPTION", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECEIVER", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acceptsArray", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acceptsPrimitive", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acceptsVariable", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "acceptsVoid", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZZZZ)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZZZZLnet/bytebuddy/description/type/TypeDescription$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator SUPER_CLASS_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator INTERFACE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator TYPE_VARIABLE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator FIELD_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator METHOD_RETURN_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator METHOD_PARAMETER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator EXCEPTION_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator RECEIVER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool acceptsArray_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool acceptsPrimitive_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool acceptsVariable_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool acceptsVoid_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Validator(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;IZZZZ)V", "private")]
				public Validator(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, bool arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;IZZZZLnet/bytebuddy/description/type/TypeDescription$1;)V", "")]
				public Validator(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
				public Dova.JDK.java.lang.Boolean onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
				public Dova.JDK.java.lang.Boolean onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
				public Dova.JDK.java.lang.Boolean onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
				public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
				public Dova.JDK.java.lang.Boolean onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;", "public static final")]
				public partial class ForTypeAnnotations
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTypeAnnotations()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_USE", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_PARAMETER", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFormalTypeVariable", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;", "public static final")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
					public static Dova.JDK.java.lang.String TYPE_USE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
					public static Dova.JDK.java.lang.String TYPE_PARAMETER_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForTypeAnnotations(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public ForTypeAnnotations(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Validator$ForTypeAnnotations;", "public static")]
					public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Validator.ForTypeAnnotations>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "private")]
					public bool isValid(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return ret;
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
					public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
					public Dova.JDK.java.lang.Boolean onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
					public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
					public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
					public Dova.JDK.java.lang.Boolean onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "public static")]
					public static bool ofFormalTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0);
						return ret;
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;", "public static final")]
			public partial class Assigner
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Assigner()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Assigner(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Assigner(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public abstract static interface")]
				public partial interface Dispatcher
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Dispatcher()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "public abstract")]
					bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForGenericArray;", "public static")]
					public partial class ForGenericArray
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForGenericArray()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForGenericArray;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericArray", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic genericArray_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForGenericArray(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
						public ForGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForGenericArray;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
						public bool equals(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return ret;
						}

						[JniSignatureAttribute("()I", "public")]
						public int hashCode()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType;", "public static")]
					public partial class ForParameterizedType
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForParameterizedType()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterizedType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic parameterizedType_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
						public ForParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
						public bool equals(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return ret;
						}

						[JniSignatureAttribute("()I", "public")]
						public int hashCode()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;", "protected static final")]
						public partial class ParameterAssigner
							: Dova.JDK.java.lang.Enum
							, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static ParameterAssigner()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;"));
								FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;"));
								MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;", "public static final")]
							public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner INSTANCE_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner>(ret);
								}
								set
								{
									DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;", "private static final")]
							public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner> VALUES_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
									return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner>>(ret);
								}
								set
								{
									DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public ParameterAssigner(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
							public ParameterAssigner(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;", "public static")]
							public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner> values()
							{
								var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
								return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner>>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner;", "public static")]
							public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner valueOf(Dova.JDK.java.lang.String arg0)
							{
								var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.ForParameterizedType.ParameterAssigner>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
							public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
							public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
							public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
							public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
							public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$ContravariantBinding;", "protected static")]
							public partial class ContravariantBinding
								: Dova.JDK.java.lang.Object
								, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static ContravariantBinding()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$ContravariantBinding;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lowerBound", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
								public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic lowerBound_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public ContravariantBinding(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
								public ContravariantBinding(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$ContravariantBinding;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
								public bool equals(Dova.JDK.java.lang.Object arg0)
								{
									var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
									return ret;
								}

								[JniSignatureAttribute("()I", "public")]
								public int hashCode()
								{
									var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
									return ret;
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "public")]
								public bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
								{
									var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
									return ret;
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$CovariantBinding;", "protected static")]
							public partial class CovariantBinding
								: Dova.JDK.java.lang.Object
								, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static CovariantBinding()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$CovariantBinding;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upperBound", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
								public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic upperBound_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public CovariantBinding(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
								public CovariantBinding(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$CovariantBinding;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
								public bool equals(Dova.JDK.java.lang.Object arg0)
								{
									var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
									return ret;
								}

								[JniSignatureAttribute("()I", "public")]
								public int hashCode()
								{
									var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
									return ret;
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "public")]
								public bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
								{
									var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
									return ret;
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$InvariantBinding;", "protected static")]
							public partial class InvariantBinding
								: Dova.JDK.java.lang.Object
								, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static InvariantBinding()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$InvariantBinding;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
								public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeDescription_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public InvariantBinding(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
								public InvariantBinding(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForParameterizedType$ParameterAssigner$InvariantBinding;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
								public bool equals(Dova.JDK.java.lang.Object arg0)
								{
									var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
									return ret;
								}

								[JniSignatureAttribute("()I", "public")]
								public int hashCode()
								{
									var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
									return ret;
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "public")]
								public bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
								{
									var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
									return ret;
								}
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForTypeVariable;", "public static")]
					public partial class ForTypeVariable
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForTypeVariable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForTypeVariable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
						public ForTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForTypeVariable;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
						public bool equals(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return ret;
						}

						[JniSignatureAttribute("()I", "public")]
						public int hashCode()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForNonGenericType;", "public static")]
					public partial class ForNonGenericType
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForNonGenericType()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForNonGenericType;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForNonGenericType(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
						public ForNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$ForNonGenericType;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
						public bool equals(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return ret;
						}

						[JniSignatureAttribute("()I", "public")]
						public int hashCode()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
						public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$AbstractBase;", "public abstract static")]
					public partial class AbstractBase
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Assigner.Dispatcher
						, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AbstractBase()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$AbstractBase;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableFrom", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("()V", "public")]
						public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$Assigner$Dispatcher$AbstractBase;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Z", "public")]
						public bool isAssignableFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return ret;
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;", "public static final")]
			public partial class AnnotationStripper
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AnnotationStripper()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AnnotationStripper(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public AnnotationStripper(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.AnnotationStripper>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper$NonAnnotatedTypeVariable;", "protected static")]
				public partial class NonAnnotatedTypeVariable
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static NonAnnotatedTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper$NonAnnotatedTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public NonAnnotatedTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
					public NonAnnotatedTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$AnnotationStripper$NonAnnotatedTypeVariable;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getSymbol()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
					public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;", "public static final")]
			public partial class TypeErasing
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TypeErasing()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public TypeErasing(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public TypeErasing(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$TypeErasing;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.TypeErasing>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;", "public static final")]
			public partial class NoOp
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static NoOp()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;", "public static final")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public NoOp(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor$NoOp;", "public static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.NoOp>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}
		}
	}
}
