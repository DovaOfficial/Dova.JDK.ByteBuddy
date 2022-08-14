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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/SymbolTable;", "final")]
public partial class SymbolTable
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SymbolTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/SymbolTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classWriter", "Lnet/bytebuddy/jar/asm/ClassWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceClassReader", "Lnet/bytebuddy/jar/asm/ClassReader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "majorVersion", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "className", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entryCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "[Lnet/bytebuddy/jar/asm/SymbolTable$Entry;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantPoolCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constantPool", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootstrapMethodCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootstrapMethods", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeTable", "[Lnet/bytebuddy/jar/asm/SymbolTable$Entry;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassWriter;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassWriter;Lnet/bytebuddy/jar/asm/ClassReader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lnet/bytebuddy/jar/asm/SymbolTable$Entry;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(I)Lnet/bytebuddy/jar/asm/SymbolTable$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Lnet/bytebuddy/jar/asm/SymbolTable$Entry;)Lnet/bytebuddy/jar/asm/SymbolTable$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(ILjava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(IJ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(ILjava/lang/String;Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(ILjava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hash", "(ILjava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(I)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMajorVersion", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantUtf8", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantUtf8", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantInteger", "(I)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantLong", "(J)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantFloat", "(F)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantDouble", "(D)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstant", "(Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMajorVersionAndClassName", "(ILjava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantClass", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantModule", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantNameAndType", "(ILjava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantNameAndType", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeBootstrapMethodsSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstantPoolLength", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstantPoolCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putConstantPool", "(Lnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putBootstrapMethods", "(Lnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantMethodType", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantPackage", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantMethodHandle", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantMethodHandle", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantDynamic", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantInvokeDynamic", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantFieldref", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantMethodref", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addUninitializedType", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addType", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMergedType", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource", "()Lnet/bytebuddy/jar/asm/ClassReader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantMemberReference", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantMemberReference", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/SymbolTable$Entry;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantIntegerOrFloat", "(II)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantIntegerOrFloat", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantLongOrDouble", "(IIJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantLongOrDouble", "(IJ)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantDynamicOrInvokeDynamicReference", "(IILjava/lang/String;Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantDynamicOrInvokeDynamicReference", "(ILjava/lang/String;Ljava/lang/String;I)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantUtf8Reference", "(ILjava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantUtf8Reference", "(IILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyBootstrapMethods", "(Lnet/bytebuddy/jar/asm/ClassReader;[C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addConstantString", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBootstrapMethod", "(III)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addBootstrapMethod", "(Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTypeInternal", "(Lnet/bytebuddy/jar/asm/SymbolTable$Entry;)I"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ClassWriter;", "final")]
	public Dova.JDK.net.bytebuddy.jar.asm.ClassWriter classWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ClassReader;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.ClassReader sourceClassReader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassReader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int majorVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String className_Property
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

	[JniSignatureAttribute("I", "private")]
	public int entryCount_Property
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

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "private")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry> entries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int constantPoolCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector constantPool_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int bootstrapMethodCount_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector bootstrapMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int typeCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "private")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry> typeTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SymbolTable(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassWriter;)V", "")]
	public SymbolTable(Dova.JDK.net.bytebuddy.jar.asm.ClassWriter arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassWriter;Lnet/bytebuddy/jar/asm/ClassReader;)V", "")]
	public SymbolTable(Dova.JDK.net.bytebuddy.jar.asm.ClassWriter arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/SymbolTable;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable$Entry;)V", "private")]
	public void add(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry get(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable$Entry;)Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry put(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry>(ret);
	}

	[JniSignatureAttribute("(II)I", "private static")]
	public static int hash(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;)I", "private static")]
	public static int hash(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IJ)I", "private static")]
	public static int hash(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;I)I", "private static")]
	public static int hash(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "private static")]
	public static int hash(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;I)I", "private static")]
	public static int hash(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;)I", "private static")]
	public static int hash(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;I)I", "private static")]
	public static int hash(int arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol getType(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getClassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int getMajorVersion()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
	public int addConstantUtf8(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "private")]
	public void addConstantUtf8(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantInteger(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(J)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(F)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantFloat(float arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(D)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantDouble(double arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstant(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)I", "")]
	public int setMajorVersionAndClassName(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantModule(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;)V", "private")]
	public void addConstantNameAndType(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "")]
	public int addConstantNameAndType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int computeBootstrapMethodsSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int getConstantPoolLength()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()I", "")]
	public int getConstantPoolCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ByteVector;)V", "")]
	public void putConstantPool(Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ByteVector;)V", "")]
	public void putBootstrapMethods(Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantMethodType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantPackage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void addConstantMethodHandle(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantMethodHandle(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;", "transient")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantDynamic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;", "transient")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantInvokeDynamic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantFieldref(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantMethodref(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "")]
	public int addUninitializedType(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
	public int addType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "")]
	public int addMergedType(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/ClassReader;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.ClassReader getSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassReader>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void addConstantMemberReference(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry addConstantMemberReference(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry>(ret);
	}

	[JniSignatureAttribute("(II)Lnet/bytebuddy/jar/asm/Symbol;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantIntegerOrFloat(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(III)V", "private")]
	public void addConstantIntegerOrFloat(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIJ)V", "private")]
	public void addConstantLongOrDouble(int arg0, int arg1, long arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IJ)Lnet/bytebuddy/jar/asm/Symbol;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantLongOrDouble(int arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;I)V", "private")]
	public void addConstantDynamicOrInvokeDynamicReference(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;I)Lnet/bytebuddy/jar/asm/Symbol;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantDynamicOrInvokeDynamicReference(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantUtf8Reference(int arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(IILjava/lang/String;)V", "private")]
	public void addConstantUtf8Reference(int arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassReader;[C)V", "private")]
	public void copyBootstrapMethods(Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg0, JavaArray<char> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/Symbol;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addConstantString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(III)Lnet/bytebuddy/jar/asm/Symbol;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addBootstrapMethod(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/Symbol;", "transient")]
	public Dova.JDK.net.bytebuddy.jar.asm.Symbol addBootstrapMethod(Dova.JDK.net.bytebuddy.jar.asm.Handle arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable$Entry;)I", "private")]
	public int addTypeInternal(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "private static")]
	public partial class Entry
		: Dova.JDK.net.bytebuddy.jar.asm.Symbol
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Entry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/SymbolTable$Entry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lnet/bytebuddy/jar/asm/SymbolTable$Entry;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIJI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/lang/String;Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/lang/String;JI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;JI)V"));
		}

		[JniSignatureAttribute("I", "final")]
		public int hashCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/SymbolTable$Entry;", "")]
		public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable.Entry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IIJI)V", "")]
		public Entry(int arg0, int arg1, long arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;I)V", "")]
		public Entry(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(IILjava/lang/String;JI)V", "")]
		public Entry(int arg0, int arg1, Dova.JDK.java.lang.String arg2, long arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(IILjava/lang/String;I)V", "")]
		public Entry(int arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;JI)V", "")]
		public Entry(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, long arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/SymbolTable$Entry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
