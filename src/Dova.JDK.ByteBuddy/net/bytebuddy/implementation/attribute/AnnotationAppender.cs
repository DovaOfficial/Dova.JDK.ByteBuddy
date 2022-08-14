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

namespace Dova.JDK.net.bytebuddy.implementation.attribute;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public abstract interface")]
public partial interface AnnotationAppender
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationAppender()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NAME", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NO_NAME_Property
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public abstract")]
	Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender append(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, int arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public abstract")]
	Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender append(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$ForTypeAnnotations;", "public static")]
	public partial class ForTypeAnnotations
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForTypeAnnotations()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$ForTypeAnnotations;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARIABLE_ON_TYPE", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARIABLE_ON_INVOKEABLE", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_TYPE_PATH", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPONENT_TYPE_PATH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WILDCARD_TYPE_PATH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INNER_CLASS_PATH", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEXED_TYPE_DELIMITER", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER_CLASS_INDEX", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationAppender", "Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilter", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeReference", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;Lnet/bytebuddy/jar/asm/TypeReference;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSuperClass", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofTypeVariable", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ZLjava/util/List;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofTypeVariable", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ZILjava/util/List;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInterfaceType", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofReceiverType", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofFieldType", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofMethodReturnType", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofExceptionType", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofMethodParameterType", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
		}

		[JniSignatureAttribute("Z", "public static final")]
		public static bool VARIABLE_ON_TYPE_Property
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

		[JniSignatureAttribute("Z", "public static final")]
		public static bool VARIABLE_ON_INVOKEABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String EMPTY_TYPE_PATH_Property
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

		[JniSignatureAttribute("C", "private static final")]
		public static char COMPONENT_TYPE_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("C", "private static final")]
		public static char WILDCARD_TYPE_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("C", "private static final")]
		public static char INNER_CLASS_PATH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("C", "private static final")]
		public static char INDEXED_TYPE_DELIMITER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int SUPER_CLASS_INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender annotationAppender_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter annotationValueFilter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int typeReference_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String typePath_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForTypeAnnotations(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;Lnet/bytebuddy/jar/asm/TypeReference;)V", "protected")]
		public ForTypeAnnotations(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, Dova.JDK.net.bytebuddy.jar.asm.TypeReference arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)V", "protected")]
		public ForTypeAnnotations(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$ForTypeAnnotations;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "private")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender apply(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofSuperClass(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ZLjava/util/List;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender ofTypeVariable(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, bool arg2, Dova.JDK.java.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ZILjava/util/List;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender ofTypeVariable(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, bool arg2, int arg3, Dova.JDK.java.util.List arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofInterfaceType(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofReceiverType(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofFieldType(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofMethodReturnType(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofExceptionType(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;I)Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor ofMethodParameterType(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Default;", "public static")]
	public partial class Default
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "handle", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAppend", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;ZLnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAppend", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;ZLnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target;)V", "public")]
		public Default(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender append(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender append(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg1, int arg2, Dova.JDK.java.lang.String arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Ljava/lang/Object;)V", "public static")]
		public static void apply(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Object arg3)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "private static")]
		public static void handle(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;ZLnet/bytebuddy/implementation/attribute/AnnotationValueFilter;ILjava/lang/String;)V", "private")]
		public void doAppend(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, bool arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2, int arg3, Dova.JDK.java.lang.String arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;ZLnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "private")]
		public void doAppend(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, bool arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target;", "public abstract static interface")]
	public partial interface Target
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Target()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public abstract")]
		Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public abstract")]
		Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnRecordComponent;", "public static")]
		public partial class OnRecordComponent
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OnRecordComponent()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnRecordComponent;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentVisitor", "Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "private final")]
			public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor recordComponentVisitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OnRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;)V", "public")]
			public OnRecordComponent(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnRecordComponent;";
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

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnMethodParameter;", "public static")]
		public partial class OnMethodParameter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OnMethodParameter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnMethodParameter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodVisitor", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterIndex", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private final")]
			public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor methodVisitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int parameterIndex_Property
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
			public OnMethodParameter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;I)V", "public")]
			public OnMethodParameter(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnMethodParameter;";
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

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnMethod;", "public static")]
		public partial class OnMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OnMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodVisitor", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private final")]
			public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor methodVisitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OnMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
			public OnMethod(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnMethod;";
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

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnField;", "public static")]
		public partial class OnField
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OnField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldVisitor", "Lnet/bytebuddy/jar/asm/FieldVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/FieldVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldVisitor;", "private final")]
			public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor fieldVisitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OnField(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;)V", "public")]
			public OnField(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnField;";
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

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnType;", "public static")]
		public partial class OnType
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationAppender.Target
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OnType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classVisitor", "Lnet/bytebuddy/jar/asm/ClassVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ClassVisitor;", "private final")]
			public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor classVisitor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OnType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;)V", "public")]
			public OnType(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationAppender$Target$OnType;";
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

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;ZILjava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visit(Dova.JDK.java.lang.String arg0, bool arg1, int arg2, Dova.JDK.java.lang.String arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}
	}
}
