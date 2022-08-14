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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public abstract interface")]
public partial interface MethodRegistry
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodRegistry()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry append(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg2, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg3, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry prepend(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default;", "public static")]
	public partial class Default
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List entries_Property
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
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Default() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
		public Default(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry append(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg2, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg3, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry prepend(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Compiled;", "protected static")]
		public partial class Compiled
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Compiled
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compiled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Compiled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypeInitializer", "Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInitializer", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Lnet/bytebuddy/description/method/MethodList;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementations", "Ljava/util/LinkedHashMap;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportsBridges", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/description/method/MethodList;Ljava/util/LinkedHashMap;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer loadedTypeInitializer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer typeInitializer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodList;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList methods_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
			public Dova.JDK.java.util.LinkedHashMap implementations_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool supportsBridges_Property
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
			public Compiled(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/description/method/MethodList;Ljava/util/LinkedHashMap;Z)V", "protected")]
			public Compiled(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.description.method.MethodList arg3, Dova.JDK.java.util.LinkedHashMap arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Compiled;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record target(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getInstrumentedMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Compiled$Entry;", "protected static")]
			public partial class Entry
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Entry()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Compiled$Entry;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeTypes", "Ljava/util/Set;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeMethod", "Z"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/description/modifier/Visibility;Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Z)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled handler_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender attributeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Set;", "private final")]
				public Dova.JDK.java.util.Set bridgeTypes_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
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
				public bool bridgeMethod_Property
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
				public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/description/modifier/Visibility;Z)V", "protected")]
				public Entry(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Compiled$Entry;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Z)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "protected")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, bool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared;", "protected static")]
		public partial class Prepared
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Prepared
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Prepared()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementations", "Ljava/util/LinkedHashMap;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypeInitializer", "Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInitializer", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraph", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Lnet/bytebuddy/description/method/MethodList;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/LinkedHashMap;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/description/method/MethodList;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/implementation/Implementation$Target$Factory;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			}

			[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
			public Dova.JDK.java.util.LinkedHashMap implementations_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer loadedTypeInitializer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer typeInitializer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked methodGraph_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodList;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList methods_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Prepared(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/LinkedHashMap;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/description/method/MethodList;)V", "protected")]
			public Prepared(Dova.JDK.java.util.LinkedHashMap arg0, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target$Factory;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Compiled compile(Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Compiled>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getInstrumentedMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;", "protected static")]
			public partial class Entry
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Entry()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeTokens", "Ljava/util/Set;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bridgeMethod", "Z"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/description/modifier/Visibility;Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "()Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodDescription", "()Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forVisibilityBridge", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppenderFactory", "()Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveBridgeTypes", "()Ljava/util/Set;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBridgeMethod", "()Z"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler handler_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory attributeAppenderFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Set;", "private final")]
				public Dova.JDK.java.util.Set typeTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
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
				public bool bridgeMethod_Property
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
				public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/description/modifier/Visibility;Z)V", "protected")]
				public Entry(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;", "protected")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler getHandler()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "protected")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethodDescription()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "protected")]
				public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;", "protected static")]
				public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry forVisibilityBridge(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory getAppenderFactory()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Set;", "protected")]
				public Dova.JDK.java.util.Set resolveBridgeTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}

				[JniSignatureAttribute("()Z", "protected")]
				public bool isBridgeMethod()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Entry;", "protected static")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/LatentMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandler", "()Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPreparedEntry", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPreparedEntry", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asSupplementaryEntry", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.LatentMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler handler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory attributeAppenderFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
			public Entry(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Entry;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;", "public")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler getHandler()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Set;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry asPreparedEntry(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry asPreparedEntry(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Default$Prepared$Entry;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry asSupplementaryEntry(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Default.Prepared.Entry>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;", "public abstract static interface")]
	public partial interface Compiled
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compiled()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodList getMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodList getInstrumentedMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;", "public abstract static interface")]
	public partial interface Prepared
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Prepared()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Prepared;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/implementation/Implementation$Target$Factory;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target$Factory;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Compiled;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Compiled compile(Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Compiled>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodList getMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodList getInstrumentedMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;", "public abstract static interface")]
	public partial interface Handler
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Handler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled compile(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAnnotationValue;", "public static")]
		public partial class ForAnnotationValue
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForAnnotationValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAnnotationValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValue", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assemble", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private final")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue annotationValue_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForAnnotationValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "public")]
			public ForAnnotationValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAnnotationValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled compile(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record assemble(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation;", "public static")]
		public partial class ForImplementation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForImplementation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementation", "Lnet/bytebuddy/implementation/Implementation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/Implementation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile_0", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile_1", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation implementation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForImplementation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)V", "public")]
			public ForImplementation(Dova.JDK.net.bytebuddy.implementation.Implementation arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForImplementation.Compiled compile_0(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForImplementation.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "public volatile")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled compile_1(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation$Compiled;", "protected static")]
			public partial class Compiled
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Compiled()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation$Compiled;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteCodeAppender", "Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assemble", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender byteCodeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Compiled(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V", "protected")]
				public Compiled(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForImplementation$Compiled;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record assemble(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "public abstract static interface")]
		public partial interface Compiled
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compiled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assemble", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record assemble(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;", "public static final")]
		public partial class ForVisibilityBridge
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForVisibilityBridge()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile_0", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile_1", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForVisibilityBridge(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForVisibilityBridge(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "public volatile")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled compile_0(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge.Compiled compile_1(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForVisibilityBridge.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge$Compiled;", "protected static")]
			public partial class Compiled
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Compiled()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge$Compiled;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assemble", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Compiled(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public Compiled(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForVisibilityBridge$Compiled;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record assemble(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;", "public static final")]
		public partial class ForAbstractMethod
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForAbstractMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assemble", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForAbstractMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForAbstractMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$ForAbstractMethod;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.ForAbstractMethod>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled compile(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/description/modifier/Visibility;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record assemble(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
			}
		}
	}
}
