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

[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition;", "public abstract interface")]
public partial interface TypeDefinition
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.NamedElement
	, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForTypeDefinition
	, Dova.JDK.java.lang.Iterable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeDefinition()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDefinition;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RAW_TYPES_PROPERTY", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArray", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asGenericType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()Lnet/bytebuddy/implementation/bytecode/StackSize;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represents", "(Ljava/lang/reflect/Type;)Z"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String RAW_TYPES_PROPERTY_Property
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

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isArray()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isPrimitive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isRecord()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getTypeName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort getSort()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic asGenericType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackSize;", "public abstract")]
	Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize getStackSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Z", "public abstract")]
	bool represents(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$SuperClassIterator;", "public static")]
	public partial class SuperClassIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SuperClassIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDefinition$SuperClassIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextClass", "Lnet/bytebuddy/description/type/TypeDefinition;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDefinition;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition;", "private")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition nextClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SuperClassIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)V", "public")]
		public SuperClassIterator(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDefinition$SuperClassIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void remove()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasNext()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object next_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition next_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
	public partial class Sort
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Sort()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDefinition$Sort;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NON_GENERIC", "Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERIC_ARRAY", "Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAMETERIZED", "Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WILDCARD", "Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARIABLE", "Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARIABLE_SYMBOLIC", "Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_TYPE", "Lnet/bytebuddy/description/type/TypeDefinition$Sort$AnnotatedType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDefinition$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "describe", "(Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "describe", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNonGeneric", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "describeAnnotated", "(Ljava/lang/reflect/AnnotatedElement;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWildcard", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isGenericArray", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTypeVariable", "()Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort NON_GENERIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort GENERIC_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort PARAMETERIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort VARIABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort VARIABLE_SYMBOLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort$AnnotatedType;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort.AnnotatedType ANNOTATED_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort.AnnotatedType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
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
		public Sort(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Sort(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/TypeDefinition$Sort;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDefinition$Sort;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Type;Lnet/bytebuddy/description/type/TypeDescription$Generic$AnnotationReader;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic describe(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.AnnotationReader arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic describe(Dova.JDK.java.lang.reflect.Type arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNonGeneric()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic describeAnnotated(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isWildcard()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isParameterized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isGenericArray()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTypeVariable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition$Sort$AnnotatedType;", "protected abstract static interface")]
		public partial interface AnnotatedType
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AnnotatedType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/TypeDefinition$Sort$AnnotatedType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/reflect/AnnotatedElement;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/Type;"));
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Z", "public abstract")]
			bool isInstance(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Ljava/lang/reflect/Type;", "public abstract")]
			Dova.JDK.java.lang.reflect.Type getType(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
			}
		}
	}
}
