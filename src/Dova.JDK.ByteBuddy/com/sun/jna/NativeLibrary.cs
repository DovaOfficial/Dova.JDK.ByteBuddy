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

namespace Dova.JDK.com.sun.jna;

[JniSignatureAttribute("Lcom/sun/jna/NativeLibrary;", "public")]
public partial class NativeLibrary
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NativeLibrary()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/NativeLibrary;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Ljava/util/logging/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG_LOAD_LEVEL", "Ljava/util/logging/Level;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanable", "Lcom/sun/jna/internal/Cleaner$Cleanable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handle", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "libraryName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "libraryPath", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "functions", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoding", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "libraries", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "searchPaths", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "librarySearchPath", "Ljava/util/LinkedHashSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_OPEN_OPTIONS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "addSuppressedMethod", "Ljava/lang/reflect/Method;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;JLjava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;)Lcom/sun/jna/NativeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Lcom/sun/jna/NativeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "(Ljava/lang/String;Ljava/util/Map;)Lcom/sun/jna/NativeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadLibrary", "(Ljava/lang/String;Ljava/util/Map;)Lcom/sun/jna/NativeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;Ljava/lang/reflect/Method;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;I)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;ILjava/lang/String;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFile", "()Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLibraryName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getProcess", "(Ljava/util/Map;)Lcom/sun/jna/NativeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getProcess", "()Lcom/sun/jna/NativeLibrary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addSearchPath", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOptions", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlobalVariableAddress", "(Ljava/lang/String;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbolAddress", "(Ljava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disposeAll", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapSharedLibraryName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initPaths", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findLibraryPath", "(Ljava/lang/String;Ljava/util/Collection;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVersionedName", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "matchLibrary", "(Ljava/lang/String;Ljava/util/Collection;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseVersion", "(Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMultiArchPath", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLinuxLdPaths", "()Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "functionKey", "(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "openFlags", "(Ljava/util/Map;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addSuppressedReflected", "(Ljava/lang/Throwable;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "matchFramework", "(Ljava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljava/lang/String;)Z"));
	}

	[JniSignatureAttribute("Ljava/util/logging/Logger;", "private static final")]
	public static Dova.JDK.java.util.logging.Logger LOG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.logging.Logger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/logging/Level;", "private static final")]
	public static Dova.JDK.java.util.logging.Level DEBUG_LOAD_LEVEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.logging.Level>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$Cleanable;", "private")]
	public Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable cleanable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private")]
	public long handle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String libraryName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String libraryPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map functions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int callFlags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "final")]
	public Dova.JDK.java.util.Map options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map libraries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map searchPaths_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/LinkedHashSet;", "private static final")]
	public static Dova.JDK.java.util.LinkedHashSet librarySearchPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DEFAULT_OPEN_OPTIONS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method addSuppressedMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NativeLibrary(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;JLjava/util/Map;)V", "private")]
	public NativeLibrary(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, long arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/NativeLibrary;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jna/NativeLibrary;", "public static final")]
	public static Dova.JDK.com.sun.jna.NativeLibrary getInstance(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Lcom/sun/jna/NativeLibrary;", "public static final")]
	public static Dova.JDK.com.sun.jna.NativeLibrary getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Lcom/sun/jna/NativeLibrary;", "public static final")]
	public static Dova.JDK.com.sun.jna.NativeLibrary getInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Lcom/sun/jna/NativeLibrary;", "private static")]
	public static Dova.JDK.com.sun.jna.NativeLibrary loadLibrary(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Method;)Lcom/sun/jna/Function;", "")]
	public Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Method arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Lcom/sun/jna/Function;", "public")]
	public Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jna/Function;", "public")]
	public Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)Lcom/sun/jna/Function;", "public")]
	public Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("()Ljava/io/File;", "public")]
	public Dova.JDK.java.io.File getFile()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getLibraryName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Lcom/sun/jna/NativeLibrary;", "public static final synchronized")]
	public static Dova.JDK.com.sun.jna.NativeLibrary getProcess(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/NativeLibrary;", "public static final synchronized")]
	public static Dova.JDK.com.sun.jna.NativeLibrary getProcess()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public static final")]
	public static void addSearchPath(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getOptions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer getGlobalVariableAddress(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)J", "")]
	public long getSymbolAddress(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "static")]
	public static void disposeAll()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String mapSharedLibraryName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "private static")]
	public static Dova.JDK.java.util.List initPaths(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String findLibraryPath(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
	public static bool isVersionedName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String matchLibrary(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)D", "static")]
	public static double parseVersion(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String getMultiArchPath()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/ArrayList;", "private static")]
	public static Dova.JDK.java.util.ArrayList getLinuxLdPaths()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String functionKey(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)I", "private static")]
	public static int openFlags(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Throwable;Ljava/lang/Throwable;)V", "private static")]
	public static void addSuppressedReflected(Dova.JDK.java.lang.Throwable arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/lang/String;", "static")]
	public static JavaArray<Dova.JDK.java.lang.String> matchFramework(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool access_000(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/jna/NativeLibrary$NativeLibraryDisposer;", "private static final")]
	public partial class NativeLibraryDisposer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NativeLibraryDisposer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/NativeLibrary$NativeLibraryDisposer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handle", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("J", "private")]
		public long handle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NativeLibraryDisposer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "public")]
		public NativeLibraryDisposer(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/NativeLibrary$NativeLibraryDisposer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
