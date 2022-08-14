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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public abstract interface")]
public partial interface MethodGraph
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodGraph()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listNodes", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList listNodes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node locate(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Simple;", "public static")]
	public partial class Simple
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Simple()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Simple;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nodes", "Ljava/util/LinkedHashMap;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/LinkedHashMap;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listNodes", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
		}

		[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
		public Dova.JDK.java.util.LinkedHashMap nodes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
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

		[JniSignatureAttribute("(Ljava/util/LinkedHashMap;)V", "public")]
		public Simple(Dova.JDK.java.util.LinkedHashMap arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Simple;";
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

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph of(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList listNodes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node locate(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "public static")]
	public partial class NodeList
		: Dova.JDK.net.bytebuddy.matcher.FilterableList.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NodeList()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nodes", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_0", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_1", "(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMethodList", "()Lnet/bytebuddy/description/method/MethodList;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List nodes_Property
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
		public NodeList(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public NodeList(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object get_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node get_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "protected")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList wrap_0(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/matcher/FilterableList;", "protected volatile")]
		public Dova.JDK.net.bytebuddy.matcher.FilterableList wrap_1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.FilterableList>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int size()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList asMethodList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "public abstract static interface")]
	public partial interface Compiler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compiler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default;", "public static")]
		public partial class Default
			: Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "harmonizer", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "merger", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitor", "Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forJavaHierarchy", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyze", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Map;Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forJVMHierarchy", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "analyzeNullable", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Map;Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAnalyze", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Map;Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer harmonizer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger merger_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger>(ret);
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
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)V", "protected")]
			public Default(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;Lnet/bytebuddy/description/type/TypeDescription$Generic$Visitor;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler of(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler of(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler forJavaHierarchy()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Map;Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store analyze(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler forJVMHierarchy()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Map;Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store analyzeNullable(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Map;Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store doAnalyze(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key;", "protected abstract static")]
			public partial class Key
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Key()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterCount", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifiers", "()Ljava/util/Set;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
				public Dova.JDK.java.lang.String internalName_Property
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

				[JniSignatureAttribute("I", "protected final")]
				public int parameterCount_Property
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
				public Key(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "protected")]
				public Key(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key;";
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

				[JniSignatureAttribute("()Ljava/util/Set;", "protected abstract")]
				public Dova.JDK.java.util.Set getIdentifiers()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected static")]
				public partial class Store
					: Dova.JDK.java.lang.Object
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Store()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/LinkedHashMap;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/LinkedHashMap;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "combine", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combineWith", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerTopLevel", "(Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asGraph", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
					}

					[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
					public Dova.JDK.java.util.LinkedHashMap entries_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Store(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public Store() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					[JniSignatureAttribute("(Ljava/util/LinkedHashMap;)V", "private")]
					public Store(Dova.JDK.java.util.LinkedHashMap arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "private static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry combine(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry arg1)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store inject(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store combineWith(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store registerTopLevel(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph asGraph(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Graph;", "protected static")]
					public partial class Graph
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Graph()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Graph;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/LinkedHashMap;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/LinkedHashMap;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listNodes", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
						}

						[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
						public Dova.JDK.java.util.LinkedHashMap entries_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Graph(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/util/LinkedHashMap;)V", "protected")]
						public Graph(Dova.JDK.java.util.LinkedHashMap arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Graph;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList listNodes()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node locate(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "protected abstract static interface")]
					public partial interface Entry
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Entry()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidates", "()Ljava/util/Set;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extendBy", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asNode", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized getKey()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry inject(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
						}

						[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
						Dova.JDK.java.util.Set getCandidates()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry extendBy(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node asNode(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Ambiguous;", "public static")]
						public partial class Ambiguous
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Ambiguous()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Ambiguous;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescriptions", "Ljava/util/LinkedHashSet;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Ljava/util/LinkedHashSet;Lnet/bytebuddy/description/modifier/Visibility;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidates", "()Ljava/util/Set;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extendBy", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asNode", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "private final")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized key_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/util/LinkedHashSet;", "private final")]
							public Dova.JDK.java.util.LinkedHashSet methodDescriptions_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
									return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashSet>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
							public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Ambiguous(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Ljava/util/LinkedHashSet;Lnet/bytebuddy/description/modifier/Visibility;)V", "protected")]
							public Ambiguous(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0, Dova.JDK.java.util.LinkedHashSet arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Ambiguous;";
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

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "protected static")]
							public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry of(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg3)
							{
								var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized getKey()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
							public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry inject(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("()Ljava/util/Set;", "public")]
							public Dova.JDK.java.util.Set getCandidates()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry extendBy(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node asNode(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Ambiguous$Node;", "protected static")]
							public partial class Node
								: Dova.JDK.java.lang.Object
								, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static Node()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Ambiguous$Node;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodTypes", "()Ljava/util/Set;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRepresentative", "()Lnet/bytebuddy/description/method/MethodDescription;"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;", "private final")]
								public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached key_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
								public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
								public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public Node(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)V", "protected")]
								public Node(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Ambiguous$Node;";
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

								[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort getSort()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
								public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
								}

								[JniSignatureAttribute("()Ljava/util/Set;", "public")]
								public Dova.JDK.java.util.Set getMethodTypes()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
									return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
								public Dova.JDK.net.bytebuddy.description.method.MethodDescription getRepresentative()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
								}
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Resolved;", "public static")]
						public partial class Resolved
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Resolved()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Resolved;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MADE_VISIBLE", "I"));
								FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_MADE_VISIBLE", "Z"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "madeVisible", "Z"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)V"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;Z)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidates", "()Ljava/util/Set;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extendBy", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asNode", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
							}

							[JniSignatureAttribute("I", "private static final")]
							public static int MADE_VISIBLE_Property
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

							[JniSignatureAttribute("Z", "private static final")]
							public static bool NOT_MADE_VISIBLE_Property
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

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "private final")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized key_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
							public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
							public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Z", "private final")]
							public bool madeVisible_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
									return ret;
								}
								set
								{
									DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)V", "protected")]
							public Resolved(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;Z)V", "protected")]
							public Resolved(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Resolved;";
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

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "private static")]
							public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry of(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg3)
							{
								var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized getKey()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
							public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry inject(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("()Ljava/util/Set;", "public")]
							public Dova.JDK.java.util.Set getCandidates()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry extendBy(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node asNode(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Resolved$Node;", "protected static")]
							public partial class Node
								: Dova.JDK.java.lang.Object
								, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static Node()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Resolved$Node;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visible", "Z"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;Z)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodTypes", "()Ljava/util/Set;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRepresentative", "()Lnet/bytebuddy/description/method/MethodDescription;"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;", "private final")]
								public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached key_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
								public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
								public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Z", "private final")]
								public bool visible_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
										return ret;
									}
									set
									{
										DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
									}
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public Node(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;Z)V", "protected")]
								public Node(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Resolved$Node;";
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

								[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort getSort()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
								public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
								}

								[JniSignatureAttribute("()Ljava/util/Set;", "public")]
								public Dova.JDK.java.util.Set getMethodTypes()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
									return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
								public Dova.JDK.net.bytebuddy.description.method.MethodDescription getRepresentative()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
								}
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Initial;", "public static")]
						public partial class Initial
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Initial()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Initial;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidates", "()Ljava/util/Set;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extendBy", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asNode", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "private final")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized key_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Initial(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;)V", "protected")]
							public Initial(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry$Initial;";
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

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized getKey()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
							public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry inject(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("()Ljava/util/Set;", "public")]
							public Dova.JDK.java.util.Set getCandidates()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Store$Entry;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry extendBy(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Store.Entry>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node asNode(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
							}
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;", "protected static")]
				public partial class Detached
					: Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Detached()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identifiers", "Ljava/util/Set;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/Set;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifiers", "()Ljava/util/Set;"));
					}

					[JniSignatureAttribute("Ljava/util/Set;", "private final")]
					public Dova.JDK.java.util.Set identifiers_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Detached(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Set;)V", "protected")]
					public Detached(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Set arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;", "protected static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached of(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached>(ret);
					}

					[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
					public Dova.JDK.java.util.Set getIdentifiers()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "protected static")]
				public partial class Harmonized
					: Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Harmonized()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identifiers", "Ljava/util/Map;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/Map;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "detach", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "combineWith", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifiers", "()Ljava/util/Set;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extend", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;"));
					}

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map identifiers_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Harmonized(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Map;)V", "protected")]
					public Harmonized(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "protected static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized of(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Detached;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached detach(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Detached>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized combineWith(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
					}

					[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
					public Dova.JDK.java.util.Set getIdentifiers()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Key$Harmonized;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized extend(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Key.Harmonized>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;", "public abstract static interface")]
			public partial interface Merger
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Merger()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.method.MethodDescription merge(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;", "public static final")]
				public partial class Directional
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Directional()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "left", "Z"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional LEFT_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional RIGHT_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "private final")]
					public bool left_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Directional(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
					public Directional(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Merger$Directional;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Merger.Directional>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription merge(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;", "public abstract static interface")]
			public partial interface Harmonizer
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Harmonizer()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "harmonize", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object harmonize(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;", "public static final")]
				public partial class ForJVMMethod
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJVMMethod()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "harmonize_0", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "harmonize_1", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod$Token;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJVMMethod(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public ForJVMMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object harmonize_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod$Token;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod.Token harmonize_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJVMMethod.Token>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod$Token;", "protected static")]
					public partial class Token
						: Dova.JDK.java.lang.Object
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Token()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod$Token;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeToken", "Lnet/bytebuddy/description/method/MethodDescription$TypeToken;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$TypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken typeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("I", "private final")]
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
						public Token(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)V", "public")]
						public Token(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJVMMethod$Token;";
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
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;", "public static final")]
				public partial class ForJavaMethod
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJavaMethod()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "harmonize_0", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "harmonize_1", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod$Token;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJavaMethod(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public ForJavaMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object harmonize_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod$Token;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod.Token harmonize_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.Default.Harmonizer.ForJavaMethod.Token>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod$Token;", "protected static")]
					public partial class Token
						: Dova.JDK.java.lang.Object
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Token()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod$Token;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeToken", "Lnet/bytebuddy/description/method/MethodDescription$TypeToken;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$TypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken typeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("I", "private final")]
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
						public Token(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)V", "protected")]
						public Token(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$Default$Harmonizer$ForJavaMethod$Token;";
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
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;", "public static final")]
		public partial class ForDeclaredMethods
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForDeclaredMethods()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForDeclaredMethods(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForDeclaredMethods(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler$ForDeclaredMethods;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler.ForDeclaredMethods>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public abstract static interface")]
	public partial interface Node
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Node()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodTypes", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRepresentative", "()Lnet/bytebuddy/description/method/MethodDescription;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort getSort()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
		Dova.JDK.java.util.Set getMethodTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription getRepresentative()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodTypes", "()Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRepresentative", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)V", "public")]
			public Simple(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Simple;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
			public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Set;", "public")]
			public Dova.JDK.java.util.Set getMethodTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getRepresentative()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;", "public static final")]
		public partial class Unresolved
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Unresolved()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodTypes", "()Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRepresentative", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Unresolved(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Unresolved(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Unresolved;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Unresolved>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort getSort()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
			public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Set;", "public")]
			public Dova.JDK.java.util.Set getMethodTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getRepresentative()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static final")]
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
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VISIBLE", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLVED", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMBIGUOUS", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRESOLVED", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unique", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "madeVisible", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZZZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMadeVisible", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnique", "()Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort VISIBLE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort RESOLVED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort AMBIGUOUS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort UNRESOLVED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool resolved_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool unique_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool madeVisible_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Sort(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;IZZZ)V", "private")]
			public Sort(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node$Sort;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node.Sort>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isMadeVisible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isUnique()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public abstract static interface")]
	public partial interface Linked
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Linked()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClassGraph", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaceGraph", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph getSuperClassGraph()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph getInterfaceGraph(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked$Delegation;", "public static")]
		public partial class Delegation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Delegation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked$Delegation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraph", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClassGraph", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceGraphs", "Ljava/util/Map;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph;Lnet/bytebuddy/dynamic/scaffold/MethodGraph;Ljava/util/Map;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listNodes", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClassGraph", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaceGraph", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph methodGraph_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph superClassGraph_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map interfaceGraphs_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Delegation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph;Lnet/bytebuddy/dynamic/scaffold/MethodGraph;Ljava/util/Map;)V", "public")]
			public Delegation(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked$Delegation;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList listNodes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node locate(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph getSuperClassGraph()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph getInterfaceGraph(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;", "public static final")]
	public partial class Empty
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Empty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listNodes", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClassGraph", "()Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaceGraph", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Empty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Empty(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Empty;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Empty>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph$NodeList;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList listNodes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.NodeList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node locate(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph getSuperClassGraph()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodGraph;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph getInterfaceGraph(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph>(ret);
		}
	}
}
