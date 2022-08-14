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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;", "public")]
public partial class ByteArrayClassLoader
	: Dova.JDK.net.bytebuddy.dynamic.loading.InjectionClassLoader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ByteArrayClassLoader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "URL_SCHEMA", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FROM_BEGINNING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_URL", "Ljava/net/URL;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_LOOKUP_STRATEGY", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNCHRONIZATION_STRATEGY", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$Initializable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDefinitions", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "persistenceHandler", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageDefinitionStrategy", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFilePostProcessor", "Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessControlContext", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;ZZ)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findResource", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findResources", "(Ljava/lang/String;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getContext", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "methodHandle", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$700", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "()Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDefineClasses", "(Ljava/util/Map;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doRegisterAsParallelCapable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doGetPackage", "(Ljava/lang/String;)Ljava/lang/Package;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String URL_SCHEMA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FROM_BEGINNING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/net/URL;", "private static final")]
	public static Dova.JDK.java.net.URL NO_URL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;", "private static final")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy PACKAGE_LOOKUP_STRATEGY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$Initializable;", "protected static final")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable SYNCHRONIZATION_STRATEGY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "protected final")]
	public Dova.JDK.java.util.concurrent.ConcurrentMap typeDefinitions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler persistenceHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "protected final")]
	public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy packageDefinitionStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor classFilePostProcessor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "protected final")]
	public Dova.JDK.java.lang.Object accessControlContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool ACCESS_CONTROLLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ByteArrayClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.security.ProtectionDomain arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg4, Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.security.ProtectionDomain arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.security.ProtectionDomain arg3, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg4, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.security.ProtectionDomain arg3, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg4, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg5, Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;)V", "public")]
	public ByteArrayClassLoader(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;ZZ)Ljava/util/Map;", "public static")]
	public static Dova.JDK.java.util.Map load(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.security.ProtectionDomain arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg4, bool arg5, bool arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;", "public static")]
	public static Dova.JDK.java.util.Map load(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;Ljava/lang/Object;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "protected")]
	public Dova.JDK.java.net.URL findResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "protected")]
	public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Enumeration;", "protected")]
	public Dova.JDK.java.util.Enumeration findResources(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object getContext()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "static")]
	public static Dova.JDK.java.lang.Package access_400(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object access_000()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object methodHandle()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object access_700(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URL;", "static")]
	public static Dova.JDK.java.net.URL access_600()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;", "static")]
	public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy access_100()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "static")]
	public static Dova.JDK.java.lang.Package access_200(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;[BIILjava/security/ProtectionDomain;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class access_300(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, int arg3, int arg4, Dova.JDK.java.security.ProtectionDomain arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map doDefineClasses(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void doRegisterAsParallelCapable()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Package;", "private")]
	public Dova.JDK.java.lang.Package doGetPackage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SingletonEnumeration;", "protected static")]
	public partial class SingletonEnumeration
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Enumeration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SingletonEnumeration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SingletonEnumeration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Ljava/net/URL;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMoreElements", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_1", "()Ljava/net/URL;"));
		}

		[JniSignatureAttribute("Ljava/net/URL;", "private")]
		public Dova.JDK.java.net.URL element_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SingletonEnumeration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/net/URL;)V", "protected")]
		public SingletonEnumeration(Dova.JDK.java.net.URL arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SingletonEnumeration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool hasMoreElements()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object nextElement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/URL;", "public")]
		public Dova.JDK.java.net.URL nextElement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;", "protected static final")]
	public partial class EmptyEnumeration
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.java.util.Enumeration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EmptyEnumeration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMoreElements", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_0", "()Ljava/net/URL;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_1", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EmptyEnumeration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public EmptyEnumeration(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$EmptyEnumeration;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.EmptyEnumeration>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasMoreElements()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/net/URL;", "public")]
		public Dova.JDK.java.net.URL nextElement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object nextElement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ChildFirst;", "public static")]
	public partial class ChildFirst
		: Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChildFirst()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ChildFirst;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_SUFFIX", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;ZLjava/util/Map;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;ZZ)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResource", "(Ljava/lang/String;)Ljava/net/URL;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShadowed", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doRegisterAsParallelCapable", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String CLASS_FILE_SUFFIX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChildFirst(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.security.ProtectionDomain arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.security.ProtectionDomain arg3, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg4, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.security.ProtectionDomain arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg4, Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.security.ProtectionDomain arg3, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg4, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg5, Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;ZLjava/util/Map;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, bool arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;)V", "public")]
		public ChildFirst(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ChildFirst;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/Class;", "protected")]
		public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;)Ljava/util/Map;", "public static")]
		public static Dova.JDK.java.util.Map load(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Map;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;ZZ)Ljava/util/Map;", "public static")]
		public static Dova.JDK.java.util.Map load(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.security.ProtectionDomain arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler arg3, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg4, bool arg5, bool arg6)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "public")]
		public Dova.JDK.java.net.URL getResource(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Enumeration;", "public")]
		public Dova.JDK.java.util.Enumeration getResources(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
		public bool isShadowed(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "private static")]
		public static void doRegisterAsParallelCapable()
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ChildFirst$PrependingEnumeration;", "protected static")]
		public partial class PrependingEnumeration
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.util.Enumeration
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PrependingEnumeration()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ChildFirst$PrependingEnumeration;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextElement", "Ljava/net/URL;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumeration", "Ljava/util/Enumeration;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;Ljava/util/Enumeration;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMoreElements", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_1", "()Ljava/net/URL;"));
			}

			[JniSignatureAttribute("Ljava/net/URL;", "private")]
			public Dova.JDK.java.net.URL nextElement_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Enumeration;", "private final")]
			public Dova.JDK.java.util.Enumeration enumeration_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PrependingEnumeration(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/net/URL;Ljava/util/Enumeration;)V", "protected")]
			public PrependingEnumeration(Dova.JDK.java.net.URL arg0, Dova.JDK.java.util.Enumeration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ChildFirst$PrependingEnumeration;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Z", "public")]
			public bool hasMoreElements()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object nextElement_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/net/URL;", "public")]
			public Dova.JDK.java.net.URL nextElement_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "public abstract static")]
	public partial class PersistenceHandler
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PersistenceHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MANIFEST", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LATENT", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_SUFFIX", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifest", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZLnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;Ljava/util/concurrent/ConcurrentMap;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "url", "(Ljava/lang/String;Ljava/util/concurrent/ConcurrentMap;)Ljava/net/URL;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "release", "(Ljava/lang/String;Ljava/util/concurrent/ConcurrentMap;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isManifest", "()Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler MANIFEST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler LATENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String CLASS_FILE_SUFFIX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool manifest_Property
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

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PersistenceHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
		public PersistenceHandler(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZLnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$1;)V", "")]
		public PersistenceHandler(Dova.JDK.java.lang.String arg0, int arg1, bool arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PersistenceHandler>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/concurrent/ConcurrentMap;)[B", "protected abstract")]
		public JavaArray<byte> lookup(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.concurrent.ConcurrentMap arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/concurrent/ConcurrentMap;)Ljava/net/URL;", "protected abstract")]
		public Dova.JDK.java.net.URL url(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.concurrent.ConcurrentMap arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/concurrent/ConcurrentMap;)V", "protected abstract")]
		public void release(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.concurrent.ConcurrentMap arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isManifest()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction;", "protected static")]
		public partial class UrlDefinitionAction
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.security.PrivilegedAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UrlDefinitionAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENCODING", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_PORT", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_FILE", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[B)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/net/URL;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String ENCODING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int NO_PORT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String NO_FILE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String typeName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> binaryRepresentation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UrlDefinitionAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;[B)V", "protected")]
			public UrlDefinitionAction(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object run_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/net/URL;", "public")]
			public Dova.JDK.java.net.URL run_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction$ByteArrayUrlStreamHandler;", "protected static")]
			public partial class ByteArrayUrlStreamHandler
				: Dova.JDK.java.net.URLStreamHandler
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ByteArrayUrlStreamHandler()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction$ByteArrayUrlStreamHandler;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;"));
				}

				[JniSignatureAttribute("[B", "private final")]
				public JavaArray<byte> binaryRepresentation_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ByteArrayUrlStreamHandler(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("([B)V", "protected")]
				public ByteArrayUrlStreamHandler(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction$ByteArrayUrlStreamHandler;";
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

				[JniSignatureAttribute("(Ljava/net/URL;)Ljava/net/URLConnection;", "protected")]
				public Dova.JDK.java.net.URLConnection openConnection(Dova.JDK.java.net.URL arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLConnection>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction$ByteArrayUrlStreamHandler$ByteArrayUrlConnection;", "protected static")]
				public partial class ByteArrayUrlConnection
					: Dova.JDK.java.net.URLConnection
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ByteArrayUrlConnection()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction$ByteArrayUrlStreamHandler$ByteArrayUrlConnection;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputStream", "Ljava/io/InputStream;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;Ljava/io/InputStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "connect", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/InputStream;"));
					}

					[JniSignatureAttribute("Ljava/io/InputStream;", "private final")]
					public Dova.JDK.java.io.InputStream inputStream_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ByteArrayUrlConnection(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/net/URL;Ljava/io/InputStream;)V", "protected")]
					public ByteArrayUrlConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.java.io.InputStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PersistenceHandler$UrlDefinitionAction$ByteArrayUrlStreamHandler$ByteArrayUrlConnection;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()V", "public")]
					public void connect()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
					}

					[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
					public Dova.JDK.java.io.InputStream getInputStream()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
					}
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;", "protected abstract static interface")]
	public partial interface PackageLookupStrategy
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PackageLookupStrategy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public abstract")]
		Dova.JDK.java.lang.Package apply(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForJava9CapableVm;", "public static")]
		public partial class ForJava9CapableVm
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForJava9CapableVm()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForJava9CapableVm;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getDefinedPackage", "Ljava/lang/reflect/Method;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
			}

			[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
			public Dova.JDK.java.lang.reflect.Method getDefinedPackage_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForJava9CapableVm(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "protected")]
			public ForJava9CapableVm(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForJava9CapableVm;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
			public Dova.JDK.java.lang.Package apply(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;", "public static final")]
		public partial class ForLegacyVm
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForLegacyVm()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForLegacyVm(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForLegacyVm(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$ForLegacyVm;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.ForLegacyVm>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
			public Dova.JDK.java.lang.Package apply(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;", "public static final")]
		public partial class CreationAction
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.java.security.PrivilegedAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CreationAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public CreationAction(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object run_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy run_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$PackageLookupStrategy$CreationAction;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.PackageLookupStrategy.CreationAction>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ClassDefinitionAction;", "protected")]
	public partial class ClassDefinitionAction
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.security.PrivilegedAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassDefinitionAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ClassDefinitionAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;[B)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
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

		[JniSignatureAttribute("[B", "private final")]
		public JavaArray<byte> binaryRepresentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;", "final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassDefinitionAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;[B)V", "protected")]
		public ClassDefinitionAction(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$ClassDefinitionAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object run_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class run_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;", "protected abstract static interface")]
	public partial interface SynchronizationStrategy
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SynchronizationStrategy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForJava8CapableVm;", "public static")]
		public partial class ForJava8CapableVm
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForJava8CapableVm()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForJava8CapableVm;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodHandle", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindTo", "Ljava/lang/reflect/Method;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invokeWithArguments", "Ljava/lang/reflect/Method;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object methodHandle_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
			public Dova.JDK.java.lang.reflect.Method bindTo_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
			public Dova.JDK.java.lang.reflect.Method invokeWithArguments_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForJava8CapableVm(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
			public ForJava8CapableVm(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForJava8CapableVm;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy initialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForJava7CapableVm;", "public static")]
		public partial class ForJava7CapableVm
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForJava7CapableVm()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForJava7CapableVm;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForJava7CapableVm(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "protected")]
			public ForJava7CapableVm(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForJava7CapableVm;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy initialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;", "public static final")]
		public partial class ForLegacyVm
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy
			, Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForLegacyVm()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForLegacyVm(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForLegacyVm(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$ForLegacyVm;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.ForLegacyVm>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy initialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;", "public static final")]
		public partial class CreationAction
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.java.security.PrivilegedAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CreationAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$Initializable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public CreationAction(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object run_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$Initializable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable run_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.Initializable>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$CreationAction;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy.CreationAction>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$Initializable;", "public abstract static interface")]
		public partial interface Initializable
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Initializable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy$Initializable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;"));
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ByteArrayClassLoader$SynchronizationStrategy;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy initialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ByteArrayClassLoader.SynchronizationStrategy>(ret);
			}
		}
	}
}
