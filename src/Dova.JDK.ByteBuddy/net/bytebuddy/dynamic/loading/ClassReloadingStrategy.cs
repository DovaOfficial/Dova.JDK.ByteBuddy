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

namespace Dova.JDK.net.bytebuddy.dynamic.loading;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public")]
public partial class ClassReloadingStrategy
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassReloadingStrategy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Dispatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentation", "Ljava/lang/instrument/Instrumentation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strategy", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootstrapInjection", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preregisteredTypes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Lnet/bytebuddy/dynamic/ClassFileLocator;[Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolveByteBuddyAgentInstrumentation", "()Ljava/lang/instrument/Instrumentation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromInstalledAgent", "(Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromInstalledAgent", "()Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preregistered", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "enableBootstrapInjection", "(Ljava/io/File;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Dispatcher;", "protected static final")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Dispatcher DISPATCHER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Dispatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/instrument/Instrumentation;", "private final")]
	public Dova.JDK.java.lang.instrument.Instrumentation instrumentation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.Instrumentation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy strategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection bootstrapInjection_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map preregisteredTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool ACCESS_CONTROLLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassReloadingStrategy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;)V", "public")]
	public ClassReloadingStrategy(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection;Ljava/util/Map;)V", "protected")]
	public ClassReloadingStrategy(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;";
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

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map load(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public static")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy of(Dova.JDK.java.lang.instrument.Instrumentation arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public transient")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy reset(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;[Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public transient")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy reset(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/instrument/Instrumentation;", "private static")]
	public static Dova.JDK.java.lang.instrument.Instrumentation resolveByteBuddyAgentInstrumentation()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.Instrumentation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public static")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy fromInstalledAgent(Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public static")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy fromInstalledAgent()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public transient")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy preregistered(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy enableBootstrapInjection(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection;", "protected abstract static interface")]
	public partial interface BootstrapInjection
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BootstrapInjection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector make(Dova.JDK.java.lang.instrument.Instrumentation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Enabled;", "public static")]
		public partial class Enabled
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Enabled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Enabled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/io/File;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			}

			[JniSignatureAttribute("Ljava/io/File;", "private final")]
			public Dova.JDK.java.io.File folder_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Enabled(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/io/File;)V", "protected")]
			public Enabled(Dova.JDK.java.io.File arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Enabled;";
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

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector make(Dova.JDK.java.lang.instrument.Instrumentation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;", "public static final")]
		public partial class Disabled
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Disabled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$BootstrapInjection$Disabled;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.BootstrapInjection.Disabled>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector make(Dova.JDK.java.lang.instrument.Instrumentation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "public abstract static")]
	public partial class Strategy
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Strategy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDEFINITION", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETRANSFORMATION", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_REDEFINITION", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDEFINE_CLASSES", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redefinition", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZLnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/lang/instrument/Instrumentation;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validate", "(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reset", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/ClassFileLocator;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRedefinition", "()Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy REDEFINITION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy RETRANSFORMATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "private static final")]
		public static JavaArray<byte> NO_REDEFINITION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool REDEFINE_CLASSES_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool redefinition_Property
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

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Strategy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
		public Strategy(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZLnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$1;)V", "")]
		public Strategy(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/util/Map;)V", "protected abstract")]
		public void apply(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.util.Map arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy validate(Dova.JDK.java.lang.instrument.Instrumentation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/ClassFileLocator;Ljava/util/List;)V", "public abstract")]
		public void reset(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.java.util.List arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()[B", "static")]
		public static JavaArray<byte> access_100()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRedefinition()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;", "protected static final")]
		public partial class ClassResettingTransformer
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.java.lang.instrument.ClassFileTransformer
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassResettingTransformer()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/Class;Ljava/security/ProtectionDomain;[B)[B"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassResettingTransformer(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ClassResettingTransformer(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassResettingTransformer;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassReloadingStrategy.Strategy.ClassResettingTransformer>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/Class;Ljava/security/ProtectionDomain;[B)[B", "public")]
			public JavaArray<byte> transform(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.security.ProtectionDomain arg3, JavaArray<byte> arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassRedefinitionTransformer;", "protected static")]
		public partial class ClassRedefinitionTransformer
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.lang.instrument.ClassFileTransformer
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassRedefinitionTransformer()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassRedefinitionTransformer;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redefinedClasses", "Ljava/util/Map;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/Class;Ljava/security/ProtectionDomain;[B)[B"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertTransformation", "()V"));
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map redefinedClasses_Property
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
			public ClassRedefinitionTransformer(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/Map;)V", "protected")]
			public ClassRedefinitionTransformer(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Strategy$ClassRedefinitionTransformer;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/Class;Ljava/security/ProtectionDomain;[B)[B", "public")]
			public JavaArray<byte> transform(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.security.ProtectionDomain arg3, JavaArray<byte> arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void assertTransformation()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Dispatcher;", "protected abstract static interface")]
	public partial interface Dispatcher
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dispatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassReloadingStrategy$Dispatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTransformer", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/instrument/ClassFileTransformer;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRetransformClassesSupported", "(Ljava/lang/instrument/Instrumentation;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retransformClasses", "(Ljava/lang/instrument/Instrumentation;[Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModifiableClass", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/Class;)Z"));
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/instrument/ClassFileTransformer;Z)V", "public abstract")]
		void addTransformer(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.instrument.ClassFileTransformer arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Z", "public abstract")]
		bool isRetransformClassesSupported(Dova.JDK.java.lang.instrument.Instrumentation arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;[Ljava/lang/Class;)V", "public abstract")]
		void retransformClasses(Dova.JDK.java.lang.instrument.Instrumentation arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/Class;)Z", "public abstract")]
		bool isModifiableClass(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}
	}
}
