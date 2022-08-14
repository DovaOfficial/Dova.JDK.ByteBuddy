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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ClassReader;", "public")]
public partial class ClassReader
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassReader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/ClassReader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP_CODE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP_DEBUG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP_FRAMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPAND_FRAMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPAND_ASM_INSNS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_BUFFER_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INPUT_STREAM_DATA_CHUNK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "b", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "header", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileBuffer", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cpInfoOffsets", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantUtf8Values", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantDynamicValues", "[Lnet/bytebuddy/jar/asm/ConstantDynamic;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootstrapMethodOffsets", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxStringLength", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/InputStream;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BIZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([BII)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/jar/asm/ClassVisitor;[Lnet/bytebuddy/jar/asm/Attribute;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/jar/asm/ClassVisitor;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readInt", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readByte", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readShort", "(I)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUnsignedShort", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLong", "(I)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxStringLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readConst", "(I[C)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readModule", "(I[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readBootstrapMethodsAttribute", "(I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readStream", "(Ljava/io/InputStream;Z)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readClass", "(I[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstAttributeOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUTF8", "(I[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUtf", "(I[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readUtf", "(II[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttribute", "([Lnet/bytebuddy/jar/asm/Attribute;Ljava/lang/String;II[CI[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readModuleAttributes", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;IILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readElementValues", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;IZ[C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTypeAnnotationTarget", "(Lnet/bytebuddy/jar/asm/Context;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readRecordComponent", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readField", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readMethod", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readPackage", "(I[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readElementValue", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;ILjava/lang/String;[C)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readParameterAnnotations", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/jar/asm/Context;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/jar/asm/Context;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLabel", "(I[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Label;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDebugLabel", "(I[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readTypeAnnotations", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/jar/asm/Context;IZ)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeImplicitFrame", "(Lnet/bytebuddy/jar/asm/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeAnnotationBytecodeOffset", "([II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readStackMapFrame", "(IZZLnet/bytebuddy/jar/asm/Context;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readLabel", "(I[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Label;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readVerificationTypeInfo", "(I[Ljava/lang/Object;I[C[Lnet/bytebuddy/jar/asm/Label;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readStringish", "(I[C)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readConstantDynamic", "(I[C)Lnet/bytebuddy/jar/asm/ConstantDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccess", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItemCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItem", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeBufferSize", "(Ljava/io/InputStream;)I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int SKIP_CODE_Property
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
	public static int SKIP_DEBUG_Property
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
	public static int SKIP_FRAMES_Property
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
	public static int EXPAND_FRAMES_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int EXPAND_ASM_INSNS_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_BUFFER_SIZE_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int INPUT_STREAM_DATA_CHUNK_SIZE_Property
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

	[JniSignatureAttribute("[B", "public final")]
	public JavaArray<byte> b_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "public final")]
	public int header_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[B", "final")]
	public JavaArray<byte> classFileBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private final")]
	public JavaArray<int> cpInfoOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> constantUtf8Values_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/ConstantDynamic;", "private final")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic> constantDynamicValues_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private final")]
	public JavaArray<int> bootstrapMethodOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int maxStringLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassReader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public ClassReader(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)V", "public")]
	public ClassReader(Dova.JDK.java.io.InputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("([BIZ)V", "")]
	public ClassReader(JavaArray<byte> arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("([BII)V", "public")]
	public ClassReader(JavaArray<byte> arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("([B)V", "public")]
	public ClassReader(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/ClassReader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;[Lnet/bytebuddy/jar/asm/Attribute;I)V", "public")]
	public void accept(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute> arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;I)V", "public")]
	public void accept(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int readInt(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getClassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int readByte(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)S", "public")]
	public short readShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int readUnsignedShort(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "public")]
	public long readLong(int arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxStringLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object readConst(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readModule(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)[I", "private")]
	public JavaArray<int> readBootstrapMethodsAttribute(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;Z)[B", "private static")]
	public static JavaArray<byte> readStream(Dova.JDK.java.io.InputStream arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readClass(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "final")]
	public int getFirstAttributeOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readUTF8(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String readUtf(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(II[C)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String readUtf(int arg0, int arg1, JavaArray<char> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/jar/asm/Attribute;Ljava/lang/String;II[CI[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Attribute;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute readAttribute(JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute> arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3, JavaArray<char> arg4, int arg5, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;IILjava/lang/String;)V", "private")]
	public void readModuleAttributes(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2, int arg3, Dova.JDK.java.lang.String arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;IZ[C)I", "private")]
	public int readElementValues(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0, int arg1, bool arg2, JavaArray<char> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Context;I)I", "private")]
	public int readTypeAnnotationTarget(Dova.JDK.net.bytebuddy.jar.asm.Context arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;I)I", "private")]
	public int readRecordComponent(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;I)I", "private")]
	public int readField(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/jar/asm/Context;I)I", "private")]
	public int readMethod(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String readPackage(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;ILjava/lang/String;[C)I", "private")]
	public int readElementValue(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0, int arg1, Dova.JDK.java.lang.String arg2, JavaArray<char> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/jar/asm/Context;IZ)V", "private")]
	public void readParameterAnnotations(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/jar/asm/Context;I)V", "private")]
	public void readCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Label;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label createLabel(int arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
	}

	[JniSignatureAttribute("(I[Lnet/bytebuddy/jar/asm/Label;)V", "private")]
	public void createDebugLabel(int arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/jar/asm/Context;IZ)[I", "private")]
	public JavaArray<int> readTypeAnnotations(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.Context arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Context;)V", "private")]
	public void computeImplicitFrame(Dova.JDK.net.bytebuddy.jar.asm.Context arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("([II)I", "private")]
	public int getTypeAnnotationBytecodeOffset(JavaArray<int> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IZZLnet/bytebuddy/jar/asm/Context;)I", "private")]
	public int readStackMapFrame(int arg0, bool arg1, bool arg2, Dova.JDK.net.bytebuddy.jar.asm.Context arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(I[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Label;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label readLabel(int arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
	}

	[JniSignatureAttribute("(I[Ljava/lang/Object;I[C[Lnet/bytebuddy/jar/asm/Label;)I", "private")]
	public int readVerificationTypeInfo(int arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, int arg2, JavaArray<char> arg3, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(I[C)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String readStringish(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I[C)Lnet/bytebuddy/jar/asm/ConstantDynamic;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic readConstantDynamic(int arg0, JavaArray<char> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAccess()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSuperName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getItemCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getItem(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/InputStream;)I", "private static")]
	public static int computeBufferSize(Dova.JDK.java.io.InputStream arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return ret;
	}
}
