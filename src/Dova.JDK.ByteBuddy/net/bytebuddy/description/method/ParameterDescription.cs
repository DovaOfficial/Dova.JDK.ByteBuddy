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

namespace Dova.JDK.net.bytebuddy.description.method;

[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription;", "public abstract interface")]
public partial interface ParameterDescription
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithRuntimeName
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithOptionalName
	, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForParameterDescription
	, Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParameterDescription()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAME_PREFIX", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NAME_PREFIX_Property
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

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool hasModifiers()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$Token;", "public static")]
	public partial class Token
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Token()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$Token;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_MODIFIERS", "Ljava/lang/Integer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "Ljava/lang/Integer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/lang/String;Ljava/lang/Integer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/String;Ljava/lang/Integer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()Ljava/lang/Integer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/method/ParameterDescription$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
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

		[JniSignatureAttribute("Ljava/lang/Integer;", "public static final")]
		public static Dova.JDK.java.lang.Integer NO_MODIFIERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic type_Property
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
		public Dova.JDK.java.util.List annotations_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Integer;", "private final")]
		public Dova.JDK.java.lang.Integer modifiers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Token(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "public")]
		public Token(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/lang/String;Ljava/lang/Integer;)V", "public")]
		public Token(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.Integer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/String;Ljava/lang/Integer;)V", "public")]
		public Token(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Integer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "public")]
		public Token(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$Token;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Integer;", "public")]
		public Dova.JDK.java.lang.Integer getModifiers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/method/ParameterDescription$Token;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token accept_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token accept_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$Token$TypeList;", "public static")]
		public partial class TypeList
			: Dova.JDK.java.util.AbstractList
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeList()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$Token$TypeList;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescriptions", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription$Token;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List typeDescriptions_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeList(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
			public TypeList(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$Token$TypeList;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$Token;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int size()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$TypeSubstituting;", "public static")]
	public partial class TypeSubstituting
		: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.AbstractBase
		, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InGenericShape
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeSubstituting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$TypeSubstituting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringMethod", "Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterDescription", "Lnet/bytebuddy/description/method/ParameterDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;", "private final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape declaringMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription parameterDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor visitor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeSubstituting(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "public")]
		public TypeSubstituting(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$TypeSubstituting;";
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
		public bool isNamed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasModifiers()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape getDeclaringMethod_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape asDefined_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$Latent;", "public static")]
	public partial class Latent
		: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Latent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$Latent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredAnnotations", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "Ljava/lang/Integer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/ParameterDescription$Token;II)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/lang/String;Ljava/lang/Integer;II)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription$Generic;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape declaringMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic parameterType_Property
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
		public Dova.JDK.java.util.List declaredAnnotations_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Integer;", "private final")]
		public Dova.JDK.java.lang.Integer modifiers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/ParameterDescription$Token;II)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/lang/String;Ljava/lang/Integer;II)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Integer arg4, int arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription$Generic;II)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$Latent;";
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
		public bool isNamed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasModifiers()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter;", "public abstract static")]
	public partial class ForLoadedParameter
		: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedParameter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAMETER", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$Parameter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executable", "Ljava/lang/reflect/AccessibleObject;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationSource", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/AccessibleObject;ILnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$Parameter;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.Parameter PARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.Parameter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/AccessibleObject;", "protected final")]
		public Dova.JDK.java.lang.Object executable_Property
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

		[JniSignatureAttribute("I", "protected final")]
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource parameterAnnotationSource_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForLoadedParameter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/AccessibleObject;ILnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
		public ForLoadedParameter(Dova.JDK.java.lang.Object arg0, int arg1, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter;";
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

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNamed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasModifiers()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfLegacyVmConstructor;", "protected static")]
		public partial class OfLegacyVmConstructor
			: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLegacyVmConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfLegacyVmConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "[Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationSource", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;I[Ljava/lang/Class;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
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
			public JavaArray<Dova.JDK.java.lang.Class> parameterType_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource parameterAnnotationSource_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLegacyVmConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;I[Ljava/lang/Class;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfLegacyVmConstructor(Dova.JDK.java.lang.reflect.Constructor arg0, int arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfLegacyVmConstructor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "public")]
			public bool isNamed()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getIndex()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasModifiers()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfLegacyVmMethod;", "protected static")]
		public partial class OfLegacyVmMethod
			: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLegacyVmMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfLegacyVmMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "[Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationSource", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;I[Ljava/lang/Class;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
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
			public JavaArray<Dova.JDK.java.lang.Class> parameterType_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource parameterAnnotationSource_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLegacyVmMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;I[Ljava/lang/Class;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfLegacyVmMethod(Dova.JDK.java.lang.reflect.Method arg0, int arg1, JavaArray<Dova.JDK.java.lang.Class> arg2, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfLegacyVmMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "public")]
			public bool isNamed()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getIndex()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool hasModifiers()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfConstructor;", "protected static")]
		public partial class OfConstructor
			: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;ILnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;ILnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfConstructor(Dova.JDK.java.lang.reflect.Constructor arg0, int arg1, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfConstructor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfMethod;", "protected static")]
		public partial class OfMethod
			: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;ILnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;ILnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfMethod(Dova.JDK.java.lang.reflect.Method arg0, int arg1, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$OfMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$Parameter;", "protected abstract static interface")]
		public partial interface Parameter
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Parameter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$Parameter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/lang/Object;)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "(Ljava/lang/Object;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamePresent", "(Ljava/lang/Object;)Z"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
			Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
			int getModifiers(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
			bool isNamePresent(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "public abstract static interface")]
		public partial interface ParameterAnnotationSource
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ParameterAnnotationSource()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;"));
			}

			[JniSignatureAttribute("()[[Ljava/lang/annotation/Annotation;", "public abstract")]
			JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>> getParameterAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource$ForLoadedMethod;", "public static")]
			public partial class ForLoadedMethod
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource$ForLoadedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "public")]
				public ForLoadedMethod(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource$ForLoadedMethod;";
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

				[JniSignatureAttribute("()[[Ljava/lang/annotation/Annotation;", "public")]
				public JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>> getParameterAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource$ForLoadedConstructor;", "public static")]
			public partial class ForLoadedConstructor
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLoadedConstructor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource$ForLoadedConstructor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLoadedConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)V", "public")]
				public ForLoadedConstructor(Dova.JDK.java.lang.reflect.Constructor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource$ForLoadedConstructor;";
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

				[JniSignatureAttribute("()[[Ljava/lang/annotation/Annotation;", "public")]
				public JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>> getParameterAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<JavaArray<Dova.JDK.java.lang.annotation.Annotation>>>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.net.bytebuddy.description.ModifierReviewable.AbstractBase
		, Dova.JDK.net.bytebuddy.description.method.ParameterDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken_0", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken_1", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/method/ParameterDescription$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
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
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getInternalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token asToken_0(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/method/ParameterDescription$Token;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token asToken_1(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getActualName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public abstract static interface")]
	public partial interface InDefinedShape
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.method.ParameterDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InDefinedShape()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.AbstractBase
			, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape asDefined_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$InGenericShape;", "public abstract static interface")]
	public partial interface InGenericShape
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.method.ParameterDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InGenericShape()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterDescription$InGenericShape;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape getDeclaringMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape>(ret);
		}
	}
}
