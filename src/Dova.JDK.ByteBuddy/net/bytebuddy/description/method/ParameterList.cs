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

[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList;", "public abstract interface")]
public partial interface ParameterList
	: IJavaObject
	, Dova.JDK.net.bytebuddy.matcher.FilterableList
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParameterList()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/method/ParameterList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasExplicitMetaData", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenList", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.ParameterList asDefined()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool hasExplicitMetaData()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$Empty;", "public static")]
	public partial class Empty
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.Empty
		, Dova.JDK.net.bytebuddy.description.method.ParameterList
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Empty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$Empty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasExplicitMetaData", "()Z"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$Empty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterList asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasExplicitMetaData()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$TypeSubstituting;", "public static")]
	public partial class TypeSubstituting
		: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeSubstituting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$TypeSubstituting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringMethod", "Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterDescriptions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InGenericShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List parameterDescriptions_Property
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InGenericShape;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "public")]
		public TypeSubstituting(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InGenericShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$TypeSubstituting;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InGenericShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InGenericShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InGenericShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForTokens;", "public static")]
	public partial class ForTokens
		: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForTokens()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForTokens;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokens", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)V", "public")]
		public ForTokens(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$ForTokens;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$Explicit;", "public static")]
	public partial class Explicit
		: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Explicit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$Explicit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterDescriptions", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/description/method/ParameterDescription;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List parameterDescriptions_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/description/method/ParameterDescription;)V", "public transient")]
		public Explicit(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Explicit(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$Explicit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription;", "public")]
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$Explicit$ForTypes;", "public static")]
		public partial class ForTypes
			: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForTypes()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$Explicit$ForTypes;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDefinitions", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Lnet/bytebuddy/description/type/TypeDefinition;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape methodDescription_Property
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

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List typeDefinitions_Property
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
			public ForTypes(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Lnet/bytebuddy/description/type/TypeDefinition;)V", "public transient")]
			public ForTypes(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)V", "public")]
			public ForTypes(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$Explicit$ForTypes;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int size()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable;", "public abstract static")]
	public partial class ForLoadedExecutable
		: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedExecutable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXECUTABLE", "Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$Executable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executable", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationSource", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Method;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Constructor;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$Executable;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.description.method.ParameterList.ForLoadedExecutable.Executable EXECUTABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList.ForLoadedExecutable.Executable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "protected final")]
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource parameterAnnotationSource_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForLoadedExecutable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
		public ForLoadedExecutable(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/description/method/ParameterList;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.method.ParameterList of(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/description/method/ParameterList;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.method.ParameterList of(Dova.JDK.java.lang.reflect.Constructor arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)Lnet/bytebuddy/description/method/ParameterList;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.method.ParameterList of(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)Lnet/bytebuddy/description/method/ParameterList;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.method.ParameterList of(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfLegacyVmMethod;", "protected static")]
		public partial class OfLegacyVmMethod
			: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLegacyVmMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfLegacyVmMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "[Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationSource", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

			[JniSignatureAttribute("[Ljava/lang/Class;", "private final")]
			public JavaArray<Dova.JDK.java.lang.Class> parameterType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource parameterAnnotationSource_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLegacyVmMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfLegacyVmMethod(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfLegacyVmMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int size()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfLegacyVmConstructor;", "protected static")]
		public partial class OfLegacyVmConstructor
			: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfLegacyVmConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfLegacyVmConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "[Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationSource", "Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

			[JniSignatureAttribute("[Ljava/lang/Class;", "private final")]
			public JavaArray<Dova.JDK.java.lang.Class> parameterType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource parameterAnnotationSource_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfLegacyVmConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfLegacyVmConstructor(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfLegacyVmConstructor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int size()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfMethod;", "protected static")]
		public partial class OfMethod
			: Dova.JDK.net.bytebuddy.description.method.ParameterList.ForLoadedExecutable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfMethod(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfConstructor;", "protected static")]
		public partial class OfConstructor
			: Dova.JDK.net.bytebuddy.description.method.ParameterList.ForLoadedExecutable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Lnet/bytebuddy/description/method/ParameterDescription$ForLoadedParameter$ParameterAnnotationSource;)V", "protected")]
			public OfConstructor(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.ForLoadedParameter.ParameterAnnotationSource arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$OfConstructor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$Executable;", "protected abstract static interface")]
		public partial interface Executable
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Executable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$ForLoadedExecutable$Executable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterCount", "(Ljava/lang/Object;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "(Ljava/lang/Object;)[Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
			bool isInstance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
			int getParameterCount(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/Object;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Object> getParameters(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.AbstractBase
		, Dova.JDK.net.bytebuddy.description.method.ParameterList
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/method/ParameterList$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_0", "(Ljava/util/List;)Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_1", "(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/method/ParameterList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasExplicitMetaData", "()Z"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/method/ParameterList$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/method/ParameterList;", "protected")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterList wrap_0(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;", "protected volatile")]
		public Dova.JDK.net.bytebuddy.matcher.FilterableList wrap_1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.FilterableList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.ParameterList asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasExplicitMetaData()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
		}
	}
}
