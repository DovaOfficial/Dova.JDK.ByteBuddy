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

namespace Dova.JDK.net.bytebuddy.dynamic;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy;", "public abstract interface")]
public partial interface TypeResolutionStrategy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeResolutionStrategy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved resolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;", "public static final")]
	public partial class Disabled
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Disabled()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectedInto", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Disabled(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Disabled(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Disabled;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Disabled>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map initialize(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved resolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer injectedInto(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;", "public static final")]
	public partial class Lazy
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Lazy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectedInto", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Lazy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Lazy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Lazy;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Lazy>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map initialize(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved resolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer injectedInto(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Active;", "public static")]
	public partial class Active
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Active()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Active;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nexusAccessor", "Lnet/bytebuddy/dynamic/NexusAccessor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/NexusAccessor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/NexusAccessor;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.NexusAccessor nexusAccessor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.NexusAccessor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Active(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Active() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/NexusAccessor;)V", "public")]
		public Active(Dova.JDK.net.bytebuddy.dynamic.NexusAccessor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Active;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved resolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Active$Resolved;", "protected static")]
		public partial class Resolved
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Resolved()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Active$Resolved;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nexusAccessor", "Lnet/bytebuddy/dynamic/NexusAccessor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identification", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/NexusAccessor;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectedInto", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/NexusAccessor;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.NexusAccessor nexusAccessor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.NexusAccessor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int identification_Property
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
			public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/NexusAccessor;I)V", "protected")]
			public Resolved(Dova.JDK.net.bytebuddy.dynamic.NexusAccessor arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Active$Resolved;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;", "public")]
			public Dova.JDK.java.util.Map initialize(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer injectedInto(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;", "public static final")]
	public partial class Passive
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy
		, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Passive()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectedInto", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Passive(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Passive(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Passive;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Passive>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map initialize(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved resolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer injectedInto(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "public abstract static interface")]
	public partial interface Resolved
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolved()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectedInto", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Ljava/util/Map;", "public abstract")]
		Dova.JDK.java.util.Map initialize(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer injectedInto(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}
	}
}
