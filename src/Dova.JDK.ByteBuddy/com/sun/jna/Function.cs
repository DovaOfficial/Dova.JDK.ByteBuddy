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

[JniSignatureAttribute("Lcom/sun/jna/Function;", "public")]
public partial class Function
	: Dova.JDK.com.sun.jna.Pointer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Function()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Function;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_NARGS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "C_CONVENTION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT_CONVENTION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK_CC", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROW_LAST_ERROR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USE_VARARGS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER_TRUE", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER_FALSE", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "library", "Lcom/sun/jna/NativeLibrary;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "functionName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encoding", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "callFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "options", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTION_INVOKING_METHOD", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_VARARGS", "Lcom/sun/jna/VarArgsChecker;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/NativeLibrary;Ljava/lang/String;ILjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Pointer;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;Ljava/lang/Class;ZI)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Class;[Ljava/lang/Object;Ljava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;Ljava/lang/Class;Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/reflect/Method;[Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Object;Ljava/util/Map;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Z)Ljava/lang/Boolean;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVarArgs", "(Ljava/lang/reflect/Method;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(Lcom/sun/jna/Pointer;I)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;Ljava/lang/String;I)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(Lcom/sun/jna/Pointer;ILjava/lang/String;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(Lcom/sun/jna/Pointer;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFunction", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Lcom/sun/jna/Function;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "concatenateVarArgs", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertArgument", "([Ljava/lang/Object;ILjava/lang/reflect/Method;Lcom/sun/jna/TypeMapper;ZLjava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCallingConvention", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCallingConvention", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fixedArgs", "(Ljava/lang/reflect/Method;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokePointer", "([Ljava/lang/Object;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokePointer", "(I[Ljava/lang/Object;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimitiveArray", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeString", "(I[Ljava/lang/Object;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeString", "([Ljava/lang/Object;Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeObject", "([Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeInt", "([Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeLong", "([Ljava/lang/Object;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeFloat", "([Ljava/lang/Object;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDouble", "([Ljava/lang/Object;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeVoid", "([Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MAX_NARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int C_CONVENTION_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int ALT_CONVENTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MASK_CC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int THROW_LAST_ERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int USE_VARARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "static final")]
	public static Dova.JDK.java.lang.Integer INTEGER_TRUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "static final")]
	public static Dova.JDK.java.lang.Integer INTEGER_FALSE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/NativeLibrary;", "private")]
	public Dova.JDK.com.sun.jna.NativeLibrary library_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLibrary>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String functionName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String encoding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "final")]
	public int callFlags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "final")]
	public Dova.JDK.java.util.Map options_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String OPTION_INVOKING_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/VarArgsChecker;", "private static final")]
	public static Dova.JDK.com.sun.jna.VarArgsChecker IS_VARARGS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.VarArgsChecker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Function(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/NativeLibrary;Ljava/lang/String;ILjava/lang/String;)V", "")]
	public Function(Dova.JDK.com.sun.jna.NativeLibrary arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;ILjava/lang/String;)V", "")]
	public Function(Dova.JDK.com.sun.jna.Pointer arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/Function;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Class;ZI)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Class arg1, bool arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Object;Ljava/util/Map;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Ljava/lang/Class;Z)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0, Dova.JDK.java.lang.Class arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;[Ljava/lang/Class;Ljava/lang/Class;[Ljava/lang/Object;Ljava/util/Map;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.reflect.Method arg0, JavaArray<Dova.JDK.java.lang.Class> arg1, Dova.JDK.java.lang.Class arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, Dova.JDK.java.util.Map arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public void invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Z)Ljava/lang/Boolean;", "static")]
	public static Dova.JDK.java.lang.Boolean valueOf(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Z", "static")]
	public static bool isVarArgs(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/jna/Function;", "public static")]
	public static Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;I)Lcom/sun/jna/Function;", "public static")]
	public static Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.com.sun.jna.Pointer arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I)Lcom/sun/jna/Function;", "public static")]
	public static Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;ILjava/lang/String;)Lcom/sun/jna/Function;", "public static")]
	public static Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.com.sun.jna.Pointer arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)Lcom/sun/jna/Function;", "public static")]
	public static Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.com.sun.jna.Pointer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Lcom/sun/jna/Function;", "public static")]
	public static Dova.JDK.com.sun.jna.Function getFunction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Function>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "static")]
	public static JavaArray<Dova.JDK.java.lang.Object> concatenateVarArgs(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;ILjava/lang/reflect/Method;Lcom/sun/jna/TypeMapper;ZLjava/lang/Class;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object convertArgument(JavaArray<Dova.JDK.java.lang.Object> arg0, int arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.com.sun.jna.TypeMapper arg3, bool arg4, Dova.JDK.java.lang.Class arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void checkCallingConvention(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getCallingConvention()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)I", "static")]
	public static int fixedArgs(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer invokePointer(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/Object;)Lcom/sun/jna/Pointer;", "private")]
	public Dova.JDK.com.sun.jna.Pointer invokePointer(int arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private")]
	public bool isPrimitiveArray(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I[Ljava/lang/Object;Z)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String invokeString(int arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String invokeString(JavaArray<Dova.JDK.java.lang.Object> arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invokeObject(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)I", "public")]
	public int invokeInt(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)J", "public")]
	public long invokeLong(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)F", "public")]
	public float invokeFloat(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)D", "public")]
	public double invokeDouble(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public void invokeVoid(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/jna/Function$PointerArray;", "private static")]
	public partial class PointerArray
		: Dova.JDK.com.sun.jna.Memory
		, Dova.JDK.com.sun.jna.Function.PostCallRead
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PointerArray()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Function$PointerArray;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "original", "[Lcom/sun/jna/Pointer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/jna/Pointer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()V"));
		}

		[JniSignatureAttribute("[Lcom/sun/jna/Pointer;", "private final")]
		public JavaArray<Dova.JDK.com.sun.jna.Pointer> original_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Pointer>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PointerArray(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lcom/sun/jna/Pointer;)V", "public")]
		public PointerArray(JavaArray<Dova.JDK.com.sun.jna.Pointer> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Function$PointerArray;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void read()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Function$NativeMappedArray;", "private static")]
	public partial class NativeMappedArray
		: Dova.JDK.com.sun.jna.Memory
		, Dova.JDK.com.sun.jna.Function.PostCallRead
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NativeMappedArray()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Function$NativeMappedArray;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "original", "[Lcom/sun/jna/NativeMapped;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lcom/sun/jna/NativeMapped;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()V"));
		}

		[JniSignatureAttribute("[Lcom/sun/jna/NativeMapped;", "private final")]
		public JavaArray<Dova.JDK.com.sun.jna.NativeMapped> original_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.NativeMapped>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NativeMappedArray(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lcom/sun/jna/NativeMapped;)V", "public")]
		public NativeMappedArray(JavaArray<Dova.JDK.com.sun.jna.NativeMapped> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Function$NativeMappedArray;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void read()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Function$PostCallRead;", "public abstract static interface")]
	public partial interface PostCallRead
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PostCallRead()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Function$PostCallRead;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void read()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}
}
