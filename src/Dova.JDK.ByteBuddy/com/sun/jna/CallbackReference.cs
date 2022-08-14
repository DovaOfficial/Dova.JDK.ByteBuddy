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

[JniSignatureAttribute("Lcom/sun/jna/CallbackReference;", "public")]
public partial class CallbackReference
	: Dova.JDK.java.lang.@ref.WeakReference
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CallbackReference()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/CallbackReference;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "callbackMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "directCallbackMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pointerCallbackMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allocations", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allocatedMemory", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROXY_CALLBACK_METHOD", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DLL_CALLBACK_CLASS", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "initializers", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanable", "Lcom/sun/jna/internal/Cleaner$Cleanable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbstruct", "Lcom/sun/jna/Pointer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trampoline", "Lcom/sun/jna/Pointer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "Lcom/sun/jna/CallbackProxy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callingConvention", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Callback;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMethod", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disposeAll", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Ljava/lang/Object;Z)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lcom/sun/jna/CallbackReference;)Lcom/sun/jna/Callback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setCallbackThreadInitializer", "(Lcom/sun/jna/Callback;Lcom/sun/jna/CallbackThreadInitializer;)Lcom/sun/jna/CallbackThreadInitializer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initializeThread", "(Lcom/sun/jna/Callback;Lcom/sun/jna/CallbackReference$AttachOptions;)Ljava/lang/ThreadGroup;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCallback", "()Lcom/sun/jna/Callback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallback", "(Ljava/lang/Class;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Callback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallback", "(Ljava/lang/Class;Lcom/sun/jna/Pointer;Z)Lcom/sun/jna/Callback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTypeAssignableCallback", "(Ljava/lang/Class;[Ljava/lang/ref/Reference;)Lcom/sun/jna/Callback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addCallbackToArray", "(Lcom/sun/jna/Callback;[Ljava/lang/ref/Reference;)[Ljava/lang/ref/Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createCallback", "(Ljava/lang/Class;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Callback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeType", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findCallbackClass", "(Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallbackMethod", "(Lcom/sun/jna/Callback;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCallbackMethod", "(Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCallbackOptions", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrampoline", "()Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNativeFunctionPointer", "(Lcom/sun/jna/Callback;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunctionPointer", "(Lcom/sun/jna/Callback;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunctionPointer", "(Lcom/sun/jna/Callback;Z)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAllowableNativeType", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNativeString", "(Ljava/lang/Object;Z)Lcom/sun/jna/Pointer;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map callbackMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map directCallbackMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map pointerCallbackMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "static final")]
	public static Dova.JDK.java.util.Map allocations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map allocatedMemory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method PROXY_CALLBACK_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private static final")]
	public static Dova.JDK.java.lang.Class DLL_CALLBACK_CLASS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map initializers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$Cleanable;", "")]
	public Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable cleanable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "")]
	public Dova.JDK.com.sun.jna.Pointer cbstruct_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "")]
	public Dova.JDK.com.sun.jna.Pointer trampoline_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/CallbackProxy;", "")]
	public Dova.JDK.com.sun.jna.CallbackProxy proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.CallbackProxy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "")]
	public Dova.JDK.java.lang.reflect.Method method_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int callingConvention_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CallbackReference(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;IZ)V", "private")]
	public CallbackReference(Dova.JDK.com.sun.jna.Callback arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/CallbackReference;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method checkMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "static")]
	public static void disposeAll()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Lcom/sun/jna/Pointer;", "static")]
	public static Dova.JDK.com.sun.jna.Pointer access_100(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "static")]
	public static Dova.JDK.java.util.Map access_200()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/CallbackReference;)Lcom/sun/jna/Callback;", "static")]
	public static Dova.JDK.com.sun.jna.Callback access_000(Dova.JDK.com.sun.jna.CallbackReference arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;Lcom/sun/jna/CallbackThreadInitializer;)Lcom/sun/jna/CallbackThreadInitializer;", "static")]
	public static Dova.JDK.com.sun.jna.CallbackThreadInitializer setCallbackThreadInitializer(Dova.JDK.com.sun.jna.Callback arg0, Dova.JDK.com.sun.jna.CallbackThreadInitializer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.CallbackThreadInitializer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;Lcom/sun/jna/CallbackReference$AttachOptions;)Ljava/lang/ThreadGroup;", "private static")]
	public static Dova.JDK.java.lang.ThreadGroup initializeThread(Dova.JDK.com.sun.jna.Callback arg0, Dova.JDK.com.sun.jna.CallbackReference.AttachOptions arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ThreadGroup>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Callback;", "private")]
	public Dova.JDK.com.sun.jna.Callback getCallback()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Callback;", "public static")]
	public static Dova.JDK.com.sun.jna.Callback getCallback(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.Pointer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Pointer;Z)Lcom/sun/jna/Callback;", "private static")]
	public static Dova.JDK.com.sun.jna.Callback getCallback(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.Pointer arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/ref/Reference;)Lcom/sun/jna/Callback;", "private static")]
	public static Dova.JDK.com.sun.jna.Callback getTypeAssignableCallback(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.@ref.Reference> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;[Ljava/lang/ref/Reference;)[Ljava/lang/ref/Reference;", "private static")]
	public static JavaArray<Dova.JDK.java.lang.@ref.Reference> addCallbackToArray(Dova.JDK.com.sun.jna.Callback arg0, JavaArray<Dova.JDK.java.lang.@ref.Reference> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.@ref.Reference>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lcom/sun/jna/Pointer;)Lcom/sun/jna/Callback;", "private static")]
	public static Dova.JDK.com.sun.jna.Callback createCallback(Dova.JDK.java.lang.Class arg0, Dova.JDK.com.sun.jna.Pointer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "private")]
	public Dova.JDK.java.lang.Class getNativeType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class findCallbackClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method getCallbackMethod(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method getCallbackMethod(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void setCallbackOptions(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer getTrampoline()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Lcom/sun/jna/Pointer;", "private static")]
	public static Dova.JDK.com.sun.jna.Pointer getNativeFunctionPointer(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;)Lcom/sun/jna/Pointer;", "public static")]
	public static Dova.JDK.com.sun.jna.Pointer getFunctionPointer(Dova.JDK.com.sun.jna.Callback arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Callback;Z)Lcom/sun/jna/Pointer;", "private static")]
	public static Dova.JDK.com.sun.jna.Pointer getFunctionPointer(Dova.JDK.com.sun.jna.Callback arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private static")]
	public static bool isAllowableNativeType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Z)Lcom/sun/jna/Pointer;", "private static")]
	public static Dova.JDK.com.sun.jna.Pointer getNativeString(Dova.JDK.java.lang.Object arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jna/CallbackReference$CallbackReferenceDisposer;", "private static final")]
	public partial class CallbackReferenceDisposer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CallbackReferenceDisposer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/CallbackReference$CallbackReferenceDisposer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbstruct", "Lcom/sun/jna/Pointer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "private")]
		public Dova.JDK.com.sun.jna.Pointer cbstruct_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CallbackReferenceDisposer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)V", "public")]
		public CallbackReferenceDisposer(Dova.JDK.com.sun.jna.Pointer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/CallbackReference$CallbackReferenceDisposer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/CallbackReference$NativeFunctionHandler;", "private static")]
	public partial class NativeFunctionHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.reflect.InvocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NativeFunctionHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/CallbackReference$NativeFunctionHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "function", "Lcom/sun/jna/Function;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;ILjava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointer", "()Lcom/sun/jna/Pointer;"));
		}

		[JniSignatureAttribute("Lcom/sun/jna/Function;", "private final")]
		public Dova.JDK.com.sun.jna.Function function_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map options_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NativeFunctionHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Pointer;ILjava/util/Map;)V", "public")]
		public NativeFunctionHandler(Dova.JDK.com.sun.jna.Pointer arg0, int arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/CallbackReference$NativeFunctionHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/jna/Pointer;", "public")]
		public Dova.JDK.com.sun.jna.Pointer getPointer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/CallbackReference$DefaultCallbackProxy;", "private")]
	public partial class DefaultCallbackProxy
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.jna.CallbackProxy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultCallbackProxy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/CallbackReference$DefaultCallbackProxy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callbackMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toNative", "Lcom/sun/jna/ToNativeConverter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fromNative", "[Lcom/sun/jna/FromNativeConverter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoding", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jna/CallbackReference;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/CallbackReference;Ljava/lang/reflect/Method;Lcom/sun/jna/TypeMapper;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()[Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeCallback", "([Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertArgument", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertResult", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCallback", "()Lcom/sun/jna/Callback;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "callback", "([Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
		public Dova.JDK.java.lang.reflect.Method callbackMethod_Property
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

		[JniSignatureAttribute("Lcom/sun/jna/ToNativeConverter;", "private")]
		public Dova.JDK.com.sun.jna.ToNativeConverter toNative_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ToNativeConverter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/jna/FromNativeConverter;", "private final")]
		public JavaArray<Dova.JDK.com.sun.jna.FromNativeConverter> fromNative_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.FromNativeConverter>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String encoding_Property
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

		[JniSignatureAttribute("Lcom/sun/jna/CallbackReference;", "final")]
		public Dova.JDK.com.sun.jna.CallbackReference this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.CallbackReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultCallbackProxy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/CallbackReference;Ljava/lang/reflect/Method;Lcom/sun/jna/TypeMapper;Ljava/lang/String;)V", "public")]
		public DefaultCallbackProxy(Dova.JDK.com.sun.jna.CallbackReference arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.com.sun.jna.TypeMapper arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/CallbackReference$DefaultCallbackProxy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class getReturnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()[Ljava/lang/Class;", "public")]
		public JavaArray<Dova.JDK.java.lang.Class> getParameterTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object invokeCallback(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object convertArgument(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object convertResult(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/jna/Callback;", "public")]
		public Dova.JDK.com.sun.jna.Callback getCallback()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Callback>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object callback(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/CallbackReference$AttachOptions;", "static")]
	public partial class AttachOptions
		: Dova.JDK.com.sun.jna.Structure
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttachOptions()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/CallbackReference$AttachOptions;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELDS", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "daemon", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detach", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldOrder", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public static final")]
		public static Dova.JDK.java.util.List FIELDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool daemon_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool detach_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "public")]
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttachOptions(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public AttachOptions() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/CallbackReference$AttachOptions;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "protected")]
		public Dova.JDK.java.util.List getFieldOrder()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}
}
