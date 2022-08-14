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

namespace Dova.JDK.net.bytebuddy.jar.asm;

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public final")]
public partial class Type
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Type()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Type;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERNAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMITIVE_DESCRIPTORS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE_TYPE", "Lnet/bytebuddy/jar/asm/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sort", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueBuffer", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueBegin", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueEnd", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDescriptor", "(Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReturnType", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReturnType", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getType", "(Ljava/lang/Class;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getType", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getType", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getType", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodType", "(Lnet/bytebuddy/jar/asm/Type;[Lnet/bytebuddy/jar/asm/Type;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodType", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodDescriptor", "(Lnet/bytebuddy/jar/asm/Type;[Lnet/bytebuddy/jar/asm/Type;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodDescriptor", "(Ljava/lang/reflect/Method;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInternalName", "(Ljava/lang/Class;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getObjectType", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getArgumentTypes", "(Ljava/lang/String;)[Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getArgumentTypes", "(Ljava/lang/reflect/Method;)[Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgumentTypes", "()[Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getReturnTypeOffset", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getArgumentsAndReturnSizes", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgumentsAndReturnSizes", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTypeInternal", "(Ljava/lang/String;II)Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConstructorDescriptor", "(Ljava/lang/reflect/Constructor;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimensions", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementType", "()Lnet/bytebuddy/jar/asm/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appendDescriptor", "(Ljava/lang/Class;Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendDescriptor", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpcode", "(I)I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int VOID_Property
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
	public static int BOOLEAN_Property
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
	public static int CHAR_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int BYTE_Property
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
	public static int SHORT_Property
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
	public static int INT_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int OBJECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INTERNAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PRIMITIVE_DESCRIPTORS_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type VOID_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type BOOLEAN_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type CHAR_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type BYTE_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type SHORT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type INT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type FLOAT_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type LONG_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Type;", "public static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type DOUBLE_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int sort_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String valueBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int valueBegin_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int valueEnd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Type(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/lang/String;II)V", "private")]
	public Type(int arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Type;";
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

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getDescriptor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/Type;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.Type getReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getReturnType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getReturnType(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getType(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getType(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Type;[Lnet/bytebuddy/jar/asm/Type;)Lnet/bytebuddy/jar/asm/Type;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getMethodType(Dova.JDK.net.bytebuddy.jar.asm.Type arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getMethodType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Type;[Lnet/bytebuddy/jar/asm/Type;)Ljava/lang/String;", "public static transient")]
	public static Dova.JDK.java.lang.String getMethodDescriptor(Dova.JDK.net.bytebuddy.jar.asm.Type arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getMethodDescriptor(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getClassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getInternalName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getInternalName(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSort()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getObjectType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> getArgumentTypes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)[Lnet/bytebuddy/jar/asm/Type;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> getArgumentTypes(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type>>(ret);
	}

	[JniSignatureAttribute("()[Lnet/bytebuddy/jar/asm/Type;", "public")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> getArgumentTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "static")]
	public static int getReturnTypeOffset(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public static")]
	public static int getArgumentsAndReturnSizes(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getArgumentsAndReturnSizes()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)Lnet/bytebuddy/jar/asm/Type;", "private static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Type getTypeInternal(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getConstructorDescriptor(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDimensions()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/Type;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.Type getElementType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/StringBuilder;)V", "private static")]
	public static void appendDescriptor(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.StringBuilder arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "private")]
	public void appendDescriptor(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getOpcode(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}
}
