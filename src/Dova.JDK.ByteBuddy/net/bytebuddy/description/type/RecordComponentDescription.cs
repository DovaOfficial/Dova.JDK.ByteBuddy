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

[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription;", "public abstract interface")]
public partial interface RecordComponentDescription
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.DeclaredByType.WithMandatoryDeclaration
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithDescriptor
	, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource
	, Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RecordComponentDescription()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor", "()Lnet/bytebuddy/description/method/MethodDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/type/RecordComponentDescription$Token;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodDescription getAccessor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/type/RecordComponentDescription$Token;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token asToken(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$Token;", "public static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$Token;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/type/RecordComponentDescription$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic type_Property
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
		public Dova.JDK.java.util.List annotations_Property
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

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
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
		public Token(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "public")]
		public Token(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "public")]
		public Token(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentDescription$Token;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token accept_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/type/RecordComponentDescription$Token;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token accept_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$TypeSubstituting;", "public static")]
	public partial class TypeSubstituting
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.AbstractBase
		, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InGenericShape
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeSubstituting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$TypeSubstituting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentDescription", "Lnet/bytebuddy/description/type/RecordComponentDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor_1", "()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription recordComponentDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "public")]
		public TypeSubstituting(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentDescription$TypeSubstituting;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription getAccessor_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape getAccessor_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape asDefined_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getActualName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$Latent;", "public static")]
	public partial class Latent
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Latent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$Latent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "public")]
		public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentDescription$Latent;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getActualName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent;", "public static")]
	public partial class ForLoadedRecordComponent
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedRecordComponent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD_COMPONENT", "Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent$RecordComponent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponent", "Ljava/lang/reflect/AnnotatedElement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/AnnotatedElement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/description/type/RecordComponentDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor_1", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent$RecordComponent;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.ForLoadedRecordComponent.RecordComponent RECORD_COMPONENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.ForLoadedRecordComponent.RecordComponent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedElement;", "private final")]
		public Dova.JDK.java.lang.reflect.AnnotatedElement recordComponent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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
		public ForLoadedRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)V", "protected")]
		public ForLoadedRecordComponent(Dova.JDK.java.lang.reflect.AnnotatedElement arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/description/type/RecordComponentDescription;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription of(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getGenericSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription getAccessor_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getAccessor_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getActualName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent$RecordComponent;", "protected abstract static interface")]
		public partial interface RecordComponent
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RecordComponent()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$ForLoadedRecordComponent$RecordComponent;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/lang/Object;)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "(Ljava/lang/Object;)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericType", "(Ljava/lang/Object;)Ljava/lang/reflect/Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Ljava/lang/Object;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotatedType", "(Ljava/lang/Object;)Ljava/lang/reflect/AnnotatedElement;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringRecord", "(Ljava/lang/Object;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor", "(Ljava/lang/Object;)Ljava/lang/reflect/Method;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
			Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
			bool isInstance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
			Dova.JDK.java.lang.String getGenericSignature(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/reflect/Type;", "public abstract")]
			Dova.JDK.java.lang.reflect.Type getGenericType(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class getType(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/reflect/AnnotatedElement;", "public abstract")]
			Dova.JDK.java.lang.reflect.AnnotatedElement getAnnotatedType(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class getDeclaringRecord(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/reflect/Method;", "public abstract")]
			Dova.JDK.java.lang.reflect.Method getAccessor(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken_0", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken_1", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/type/RecordComponentDescription$Token;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentDescription$AbstractBase;";
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
		public Dova.JDK.java.lang.String getGenericSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token asToken_0(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/type/RecordComponentDescription$Token;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token asToken_1(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "public abstract static interface")]
	public partial interface InDefinedShape
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InDefinedShape()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getAccessor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.AbstractBase
			, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor_0", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor_1", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getAccessor_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getAccessor_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape asDefined_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$InGenericShape;", "public abstract static interface")]
	public partial interface InGenericShape
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InGenericShape()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentDescription$InGenericShape;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessor", "()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape getAccessor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape>(ret);
		}
	}
}
