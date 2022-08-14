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

namespace Dova.JDK.net.bytebuddy.utility;

[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule;", "public")]
public partial class JavaModule
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.description.NamedElement.WithOptionalName
	, Dova.JDK.net.bytebuddy.description.annotation.AnnotationSource
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaModule()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaModule;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNSUPPORTED", "Lnet/bytebuddy/utility/JavaModule;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLVER", "Lnet/bytebuddy/utility/JavaModule$Resolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE", "Lnet/bytebuddy/utility/JavaModule$Module;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "module", "Ljava/lang/reflect/AnnotatedElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/AnnotatedElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaModule;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSupported", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canRead", "(Lnet/bytebuddy/utility/JavaModule;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExported", "(Lnet/bytebuddy/description/type/PackageDescription;Lnet/bytebuddy/utility/JavaModule;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpened", "(Lnet/bytebuddy/description/type/PackageDescription;Lnet/bytebuddy/utility/JavaModule;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofType", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaModule;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaModule UNSUPPORTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaModule>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule$Resolver;", "protected static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaModule.Resolver RESOLVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaModule.Resolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule$Module;", "protected static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaModule.Module MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaModule.Module>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/AnnotatedElement;", "private final")]
	public Dova.JDK.java.lang.reflect.AnnotatedElement module_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.AnnotatedElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool ACCESS_CONTROLLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavaModule(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)V", "protected")]
	public JavaModule(Dova.JDK.java.lang.reflect.AnnotatedElement arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaModule;";
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

	[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaModule;", "public static")]
	public static Dova.JDK.net.bytebuddy.utility.JavaModule of(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaModule>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNamed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public")]
	public Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
	public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isSupported()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaModule;)Z", "public")]
	public bool canRead(Dova.JDK.net.bytebuddy.utility.JavaModule arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/PackageDescription;Lnet/bytebuddy/utility/JavaModule;)Z", "public")]
	public bool isExported(Dova.JDK.net.bytebuddy.description.type.PackageDescription arg0, Dova.JDK.net.bytebuddy.utility.JavaModule arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object unwrap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/PackageDescription;Lnet/bytebuddy/utility/JavaModule;)Z", "public")]
	public bool isOpened(Dova.JDK.net.bytebuddy.description.type.PackageDescription arg0, Dova.JDK.net.bytebuddy.utility.JavaModule arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getActualName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaModule;", "public static")]
	public static Dova.JDK.net.bytebuddy.utility.JavaModule ofType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaModule>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule$Module;", "protected abstract static interface")]
	public partial interface Module
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Module()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaModule$Module;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/lang/Object;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "(Ljava/lang/Object;)Ljava/lang/ClassLoader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResourceAsStream", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/io/InputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpen", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canRead", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExported", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
		bool isInstance(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/ClassLoader;", "public abstract")]
		Dova.JDK.java.lang.ClassLoader getClassLoader(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
		bool isNamed(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)Ljava/io/InputStream;", "public abstract")]
		Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Z", "public abstract")]
		bool isOpen(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "public abstract")]
		bool canRead(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Z", "public abstract")]
		bool isExported(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule$Resolver;", "protected abstract static interface")]
	public partial interface Resolver
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaModule$Resolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModule", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getModule(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
