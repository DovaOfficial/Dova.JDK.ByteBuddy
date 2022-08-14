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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/TypeReference;", "public")]
public partial class TypeReference
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeReference()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/TypeReference;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_TYPE_PARAMETER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE_PARAMETER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_EXTENDS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_TYPE_PARAMETER_BOUND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE_PARAMETER_BOUND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_RETURN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_RECEIVER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_FORMAL_PARAMETER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_VARIABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOURCE_VARIABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCEPTION_PARAMETER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCEOF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_REFERENCE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_REFERENCE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAST", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_INVOCATION_TYPE_ARGUMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_INVOCATION_TYPE_ARGUMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_REFERENCE_TYPE_ARGUMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_REFERENCE_TYPE_ARGUMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetTypeAndInfo", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putTarget", "(ILnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperTypeIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameterIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameterBoundIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFormalParameterReference", "(I)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newExceptionReference", "(I)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newSuperTypeReference", "(I)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTypeParameterReference", "(II)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTypeParameterBoundReference", "(III)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTypeReference", "(I)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTypeArgumentReference", "(II)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArgumentIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTryCatchReference", "(I)Lnet/bytebuddy/jar/asm/TypeReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTryCatchBlockIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFormalParameterIndex", "()I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CLASS_TYPE_PARAMETER_Property
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
	public static int METHOD_TYPE_PARAMETER_Property
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
	public static int CLASS_EXTENDS_Property
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
	public static int CLASS_TYPE_PARAMETER_BOUND_Property
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
	public static int METHOD_TYPE_PARAMETER_BOUND_Property
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
	public static int FIELD_Property
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
	public static int METHOD_RETURN_Property
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
	public static int METHOD_RECEIVER_Property
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
	public static int METHOD_FORMAL_PARAMETER_Property
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
	public static int THROWS_Property
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
	public static int LOCAL_VARIABLE_Property
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
	public static int RESOURCE_VARIABLE_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int EXCEPTION_PARAMETER_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int INSTANCEOF_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int NEW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTRUCTOR_REFERENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int METHOD_REFERENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CAST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTRUCTOR_INVOCATION_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int METHOD_INVOCATION_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CONSTRUCTOR_REFERENCE_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int METHOD_REFERENCE_TYPE_ARGUMENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int targetTypeAndInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeReference(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public TypeReference(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/TypeReference;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int getValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSort()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/ByteVector;)V", "static")]
	public static void putTarget(int arg0, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSuperTypeIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTypeParameterIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTypeParameterBoundIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newFormalParameterReference(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newExceptionReference(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newSuperTypeReference(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("(II)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newTypeParameterReference(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("(III)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newTypeParameterBoundReference(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newTypeReference(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getExceptionIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(II)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newTypeArgumentReference(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTypeArgumentIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/TypeReference;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.TypeReference newTryCatchReference(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypeReference>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTryCatchBlockIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getFormalParameterIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}
}
