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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Nexus;", "public")]
public partial class Nexus
	: Dova.JDK.java.lang.@ref.WeakReference
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Nexus()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Nexus;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_QUEUE", "Ljava/lang/ref/ReferenceQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_INITIALIZERS", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoaderHashCode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identification", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/ref/ReferenceQueue;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initialize", "(Ljava/lang/Class;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "register", "(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/ref/ReferenceQueue;ILjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clean", "(Ljava/lang/ref/Reference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nonAnonymous", "(Ljava/lang/String;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PROPERTY_Property
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

	[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "private static final")]
	public static Dova.JDK.java.lang.@ref.ReferenceQueue NO_QUEUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static final")]
	public static Dova.JDK.java.util.concurrent.ConcurrentMap TYPE_INITIALIZERS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
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

	[JniSignatureAttribute("I", "private final")]
	public int classLoaderHashCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int identification_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Nexus(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;I)V", "private")]
	public Nexus(Dova.JDK.java.lang.Class arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/ref/ReferenceQueue;I)V", "private")]
	public Nexus(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.java.lang.@ref.ReferenceQueue arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Nexus;";
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

	[JniSignatureAttribute("(Ljava/lang/Class;I)V", "public static")]
	public static void initialize(Dova.JDK.java.lang.Class arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;Ljava/lang/ref/ReferenceQueue;ILjava/lang/Object;)V", "public static")]
	public static void register(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1, Dova.JDK.java.lang.@ref.ReferenceQueue arg2, int arg3, Dova.JDK.java.lang.Object arg4)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/ref/Reference;)V", "public static")]
	public static void clean(Dova.JDK.java.lang.@ref.Reference arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String nonAnonymous(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
