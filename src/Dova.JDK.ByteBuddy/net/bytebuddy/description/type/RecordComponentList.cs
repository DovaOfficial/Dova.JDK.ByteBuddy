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

[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList;", "public abstract interface")]
public partial interface RecordComponentList
	: IJavaObject
	, Dova.JDK.net.bytebuddy.matcher.FilterableList
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RecordComponentList()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenList", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.RecordComponentList asDefined()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList$Empty;", "public static")]
	public partial class Empty
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.Empty
		, Dova.JDK.net.bytebuddy.description.type.RecordComponentList
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Empty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList$Empty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentList$Empty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList$TypeSubstituting;", "public static")]
	public partial class TypeSubstituting
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeSubstituting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList$TypeSubstituting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentDescriptions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InGenericShape;"));
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
		public Dova.JDK.java.util.List recordComponentDescriptions_Property
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentList$TypeSubstituting;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InGenericShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InGenericShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InGenericShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList$ForTokens;", "public static")]
	public partial class ForTokens
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForTokens()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList$ForTokens;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokens", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V", "public transient")]
		public ForTokens(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
		public ForTokens(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentList$ForTokens;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList$Explicit;", "public static")]
	public partial class Explicit
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Explicit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList$Explicit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponents", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/description/type/RecordComponentDescription;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/RecordComponentDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List recordComponents_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/RecordComponentDescription;)V", "public transient")]
		public Explicit(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Explicit(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentList$Explicit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/RecordComponentDescription;", "public")]
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

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList$ForLoadedRecordComponents;", "public static")]
	public partial class ForLoadedRecordComponents
		: Dova.JDK.net.bytebuddy.description.type.RecordComponentList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedRecordComponents()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList$ForLoadedRecordComponents;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponents", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List recordComponents_Property
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
		public ForLoadedRecordComponents(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)V", "protected transient")]
		public ForLoadedRecordComponents(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
		public ForLoadedRecordComponents(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentList$ForLoadedRecordComponents;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentList$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.AbstractBase
		, Dova.JDK.net.bytebuddy.description.type.RecordComponentList
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/type/RecordComponentList$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_0", "(Ljava/util/List;)Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_1", "(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/type/RecordComponentList$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/description/type/RecordComponentList;", "protected")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList wrap_0(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;", "protected volatile")]
		public Dova.JDK.net.bytebuddy.matcher.FilterableList wrap_1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.FilterableList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList asDefined()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/description/ByteCodeElement$Token$TokenList;", "public")]
		public Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList asTokenList(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.Token.TokenList>(ret);
		}
	}
}
