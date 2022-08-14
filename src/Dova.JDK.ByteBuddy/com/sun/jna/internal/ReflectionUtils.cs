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

namespace Dova.JDK.com.sun.jna.@internal;

[JniSignatureAttribute("Lcom/sun/jna/internal/ReflectionUtils;", "public")]
public partial class ReflectionUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReflectionUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/internal/ReflectionUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOG", "Ljava/util/logging/Logger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_IS_DEFAULT", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP_IN", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_PRIVATE_LOOKUP_IN", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP_UNREFLECT_SPECIAL", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP_FIND_SPECIAL", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_BIND_TO", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_INVOKE_WITH_ARGUMENTS", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_LOOKUP_CLASS", "Ljava/lang/reflect/Constructor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefault", "(Ljava/lang/reflect/Method;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodHandle", "(Ljava/lang/reflect/Method;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeDefaultMethod", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mhViaUnreflectSpecial", "(Ljava/lang/Object;Ljava/lang/reflect/Method;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createPrivateLookupIn", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createLookup", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConstructorLookupClass", "()Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupDeclaredConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mhViaFindSpecial", "(Ljava/lang/Object;Ljava/lang/reflect/Method;)Ljava/lang/Object;"));
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

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_IS_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_LOOKUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_LOOKUP_IN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_PRIVATE_LOOKUP_IN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_LOOKUP_UNREFLECT_SPECIAL_Property
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

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_LOOKUP_FIND_SPECIAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_BIND_TO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_HANDLES_INVOKE_WITH_ARGUMENTS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
	public static Dova.JDK.java.lang.reflect.Method METHOD_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private static")]
	public static Dova.JDK.java.lang.reflect.Constructor CONSTRUCTOR_LOOKUP_CLASS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
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
	public ReflectionUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ReflectionUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/internal/ReflectionUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Z", "public static")]
	public static bool isDefault(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/Object;", "public static")]
	public static Dova.JDK.java.lang.Object getMethodHandle(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class lookupClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public static transient")]
	public static Dova.JDK.java.lang.Object invokeDefaultMethod(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object mhViaUnreflectSpecial(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object createPrivateLookupIn(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object createLookup()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Constructor;", "private static")]
	public static Dova.JDK.java.lang.reflect.Constructor getConstructorLookupClass()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "private static transient")]
	public static Dova.JDK.java.lang.reflect.Constructor lookupDeclaredConstructor(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", "private static transient")]
	public static Dova.JDK.java.lang.reflect.Method lookupMethod(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Class> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object mhViaFindSpecial(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
