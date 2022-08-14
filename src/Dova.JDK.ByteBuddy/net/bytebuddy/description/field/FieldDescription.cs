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

namespace Dova.JDK.net.bytebuddy.description.field;

[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "public abstract interface")]
public partial interface FieldDescription
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.ByteCodeElement
	, Dova.JDK.net.bytebuddy.description.DeclaredByType.WithMandatoryDeclaration
	, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForFieldDescription
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithGenericName
	, Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldDescription()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_DEFAULT_VALUE", "Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSignatureToken", "()Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "()I"));
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "public static final")]
	public static Dova.JDK.java.lang.Object NO_DEFAULT_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

	[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken asSignatureToken()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getActualModifiers()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;", "public static")]
	public partial class SignatureToken
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SignatureToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
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
		public SignatureToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
		public SignatureToken(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$Token;", "public static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$Token;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/field/FieldDescription$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSignatureToken", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;"));
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

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Token(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;)V", "public")]
		public Token(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "public")]
		public Token(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$Token;";
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

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token accept_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/field/FieldDescription$Token;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token accept_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken asSignatureToken(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$TypeSubstituting;", "public static")]
	public partial class TypeSubstituting
		: Dova.JDK.net.bytebuddy.description.field.FieldDescription.AbstractBase
		, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InGenericShape
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeSubstituting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$TypeSubstituting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic declaringType_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "public")]
		public TypeSubstituting(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$TypeSubstituting;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape asDefined_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$Latent;", "public static")]
	public partial class Latent
		: Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Latent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$Latent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredAnnotations", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$Token;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int modifiers_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic fieldType_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List declaredAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$Token;)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$Latent;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$ForLoadedField;", "public static")]
	public partial class ForLoadedField
		: Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$ForLoadedField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredAnnotations", "Lnet/bytebuddy/description/annotation/AnnotationList;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Field;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynthetic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationList;", "private transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList declaredAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$ForLoadedField;";
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
		public bool isSynthetic()
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.net.bytebuddy.description.ModifierReviewable.AbstractBase
		, Dova.JDK.net.bytebuddy.description.field.FieldDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSignatureToken", "()Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken_0", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/field/FieldDescription$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken_1", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$AbstractBase;";
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

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toGenericString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getGenericSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getInternalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken asSignatureToken()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/field/FieldDescription$Token;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token asToken_0(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token asToken_1(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getActualName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getActualModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isVisibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool isAccessibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public abstract static interface")]
	public partial interface InDefinedShape
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.field.FieldDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InDefinedShape()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.net.bytebuddy.description.field.FieldDescription.AbstractBase
			, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape asDefined_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$InGenericShape;", "public abstract static interface")]
	public partial interface InGenericShape
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.field.FieldDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InGenericShape()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldDescription$InGenericShape;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getDeclaringType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}
	}
}
