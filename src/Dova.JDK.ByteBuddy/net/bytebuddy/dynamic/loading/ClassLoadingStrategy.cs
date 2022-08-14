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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;", "public abstract interface")]
public partial interface ClassLoadingStrategy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassLoadingStrategy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOTSTRAP_LOADER", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_PROTECTION_DOMAIN", "Ljava/security/ProtectionDomain;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
	}

	[JniSignatureAttribute("Ljava/lang/ClassLoader;", "public static final")]
	public static Dova.JDK.java.lang.ClassLoader BOOTSTRAP_LOADER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "public static final")]
	public static Dova.JDK.java.security.ProtectionDomain NO_PROTECTION_DOMAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map load(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForJnaInjection;", "public static")]
	public partial class ForJnaInjection
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForJnaInjection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForJnaInjection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/ProtectionDomain;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
		public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForJnaInjection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForJnaInjection() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)V", "public")]
		public ForJnaInjection(Dova.JDK.java.security.ProtectionDomain arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForJnaInjection;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForUnsafeInjection;", "public static")]
	public partial class ForUnsafeInjection
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForUnsafeInjection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForUnsafeInjection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/ProtectionDomain;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
		public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForUnsafeInjection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForUnsafeInjection() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)V", "public")]
		public ForUnsafeInjection(Dova.JDK.java.security.ProtectionDomain arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForUnsafeInjection;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForBootstrapInjection;", "public static")]
	public partial class ForBootstrapInjection
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForBootstrapInjection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForBootstrapInjection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentation", "Ljava/lang/instrument/Instrumentation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/io/File;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/instrument/Instrumentation;Ljava/io/File;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Ljava/lang/instrument/Instrumentation;", "private final")]
		public Dova.JDK.java.lang.instrument.Instrumentation instrumentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.Instrumentation>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/io/File;", "private final")]
		public Dova.JDK.java.io.File folder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForBootstrapInjection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/io/File;)V", "public")]
		public ForBootstrapInjection(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.io.File arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$ForBootstrapInjection;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$UsingLookup;", "public static")]
	public partial class UsingLookup
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UsingLookup()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$UsingLookup;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classInjector", "Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/ClassInjector;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withFallback", "(Ljava/util/concurrent/Callable;Z)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withFallback", "(Ljava/util/concurrent/Callable;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector classInjector_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UsingLookup(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ClassInjector;)V", "protected")]
		public UsingLookup(Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$UsingLookup;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy of(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Callable;Z)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy withFallback(Dova.JDK.java.util.concurrent.Callable arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy withFallback(Dova.JDK.java.util.concurrent.Callable arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public abstract static interface")]
	public partial interface Configurable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Configurable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allowExistingTypes", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opened", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
		}

		[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.java.security.ProtectionDomain arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable allowExistingTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable opened()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static final")]
	public partial class Default
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRAPPER", "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRAPPER_PERSISTENT", "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHILD_FIRST", "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHILD_FIRST_PERSISTENT", "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INJECTION", "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_FORBID_EXISTING", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dispatcher", "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allowExistingTypes", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opened", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default WRAPPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default WRAPPER_PERSISTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default CHILD_FIRST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default CHILD_FIRST_PERSISTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default INJECTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool DEFAULT_FORBID_EXISTING_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable dispatcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;)V", "private")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map load(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Default>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.java.security.ProtectionDomain arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable allowExistingTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable opened()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default$WrappingDispatcher;", "protected static")]
		public partial class WrappingDispatcher
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WrappingDispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default$WrappingDispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHILD_FIRST", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARENT_FIRST", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "persistenceHandler", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageDefinitionStrategy", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "childFirst", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forbidExisting", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sealed", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Z)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;ZZZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allowExistingTypes", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opened", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			}

			[JniSignatureAttribute("Z", "private static final")]
			public static bool CHILD_FIRST_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("Z", "private static final")]
			public static bool PARENT_FIRST_Property
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

			[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
			public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler persistenceHandler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy packageDefinitionStrategy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool childFirst_Property
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
			public bool forbidExisting_Property
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

			[JniSignatureAttribute("Z", "private final")]
			public bool @sealed_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public WrappingDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Z)V", "protected")]
			public WrappingDispatcher(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;ZZZ)V", "private")]
			public WrappingDispatcher(Dova.JDK.java.security.ProtectionDomain arg0, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg2, bool arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default$WrappingDispatcher;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}

			[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.java.security.ProtectionDomain arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable allowExistingTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable opened()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default$InjectionDispatcher;", "protected static")]
		public partial class InjectionDispatcher
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InjectionDispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default$InjectionDispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageDefinitionStrategy", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forbidExisting", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allowExistingTypes", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "opened", "()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;"));
			}

			[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
			public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy packageDefinitionStrategy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool forbidExisting_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InjectionDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "protected")]
			public InjectionDispatcher() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			[JniSignatureAttribute("(Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Z)V", "private")]
			public InjectionDispatcher(Dova.JDK.java.security.ProtectionDomain arg0, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Default$InjectionDispatcher;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}

			[JniSignatureAttribute("(Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable with(Dova.JDK.java.security.ProtectionDomain arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable allowExistingTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy$Configurable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable opened()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy.Configurable>(ret);
			}
		}
	}
}
