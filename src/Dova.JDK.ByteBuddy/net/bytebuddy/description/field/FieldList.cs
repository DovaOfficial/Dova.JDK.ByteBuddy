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

[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList;", "public abstract interface")]
public partial interface FieldList
	: IJavaObject
	, Dova.JDK.net.bytebuddy.matcher.FilterableList
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldList()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/field/FieldList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenList", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.field.FieldList asDefined()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList$Empty;", "public static")]
	public partial class Empty
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.Empty
		, Dova.JDK.net.bytebuddy.description.field.FieldList
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Empty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList$Empty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenList", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Empty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Empty() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldList$Empty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList$TypeSubstituting;", "public static")]
	public partial class TypeSubstituting
		: Dova.JDK.net.bytebuddy.description.field.FieldList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeSubstituting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList$TypeSubstituting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescriptions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/field/FieldDescription$InGenericShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List fieldDescriptions_Property
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "public")]
		public TypeSubstituting(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldList$TypeSubstituting;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/field/FieldDescription$InGenericShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InGenericShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InGenericShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList$ForTokens;", "public static")]
	public partial class ForTokens
		: Dova.JDK.net.bytebuddy.description.field.FieldList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForTokens()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList$ForTokens;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokens", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/field/FieldDescription$Token;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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
		public Dova.JDK.java.util.List tokens_Property
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
		public ForTokens(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/field/FieldDescription$Token;)V", "public transient")]
		public ForTokens(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
		public ForTokens(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldList$ForTokens;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList$Explicit;", "public static")]
	public partial class Explicit
		: Dova.JDK.net.bytebuddy.description.field.FieldList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Explicit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList$Explicit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescriptions", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/description/field/FieldDescription;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/field/FieldDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List fieldDescriptions_Property
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
		public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/field/FieldDescription;)V", "public transient")]
		public Explicit(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Explicit(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldList$Explicit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
		public Dova.JDK.java.lang.Object get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList$ForLoadedFields;", "public static")]
	public partial class ForLoadedFields
		: Dova.JDK.net.bytebuddy.description.field.FieldList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedFields()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList$ForLoadedFields;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/reflect/Field;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List fields_Property
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
		public ForLoadedFields(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/reflect/Field;)V", "public transient")]
		public ForLoadedFields(JavaArray<Dova.JDK.java.lang.reflect.Field> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public ForLoadedFields(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldList$ForLoadedFields;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldList$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.AbstractBase
		, Dova.JDK.net.bytebuddy.description.field.FieldList
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/field/FieldList$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_0", "(Ljava/util/List;)Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_1", "(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/field/FieldList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenList", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/field/FieldList$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/field/FieldList;", "protected")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList wrap_0(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;", "protected volatile")]
		public Dova.JDK.net.bytebuddy.matcher.FilterableList wrap_1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.FilterableList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
		}
	}
}
