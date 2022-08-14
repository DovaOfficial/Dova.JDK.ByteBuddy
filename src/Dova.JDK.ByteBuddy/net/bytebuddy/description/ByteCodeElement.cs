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

namespace Dova.JDK.net.bytebuddy.description;

[JniSignatureAttribute("Lnet/bytebuddy/description/ByteCodeElement;", "public abstract interface")]
public partial interface ByteCodeElement
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithRuntimeName
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithDescriptor
	, Dova.JDK.net.bytebuddy.description.ModifierReviewable
	, Dova.JDK.net.bytebuddy.description.DeclaredByType
	, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ByteCodeElement()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ByteCodeElement;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isVisibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public abstract")]
	bool isAccessibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ByteCodeElement$Token;", "public abstract static interface")]
	public partial interface Token
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Token()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ByteCodeElement$Token;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public abstract")]
		Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public static")]
		public partial class TokenList
			: Dova.JDK.net.bytebuddy.matcher.FilterableList.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TokenList()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokens", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/description/ByteCodeElement$Token;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_0", "(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_1", "(Ljava/util/List;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List tokens_Property
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
			public TokenList(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/ByteCodeElement$Token;)V", "public transient")]
			public TokenList(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
			public TokenList(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public")]
			public Dova.JDK.java.lang.Object get_0(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object get_1(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;", "protected volatile")]
			public Dova.JDK.net.bytebuddy.matcher.FilterableList wrap_0(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.FilterableList>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "protected")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList wrap_1(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int size()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList accept(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public abstract static interface")]
	public partial interface TypeDependant
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeDependant()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asToken", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public abstract")]
		Dova.JDK.java.lang.Object asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token;", "public abstract")]
		Dova.JDK.java.lang.Object asToken(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
