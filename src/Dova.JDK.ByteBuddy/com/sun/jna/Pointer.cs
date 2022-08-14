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

[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "public")]
public partial class Pointer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Pointer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Pointer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL", "Lcom/sun/jna/Pointer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peer", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(JB)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChar", "(J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(JLjava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[Lcom/sun/jna/Pointer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[Lcom/sun/jna/Pointer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(JLjava/lang/Object;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByte", "(JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChar", "(JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShort", "(JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLong", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloat", "(JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDouble", "(JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory", "(JJB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteBuffer", "(JJ)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringArray", "(JLjava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringArray", "(JI)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringArray", "(J)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStringArray", "(JILjava/lang/String;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(JLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createConstant", "(J)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createConstant", "(I)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "share", "(JJ)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "share", "(J)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNativeLong", "(J)Lcom/sun/jna/NativeLong;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWideString", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteArray", "(JI)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharArray", "(JI)[C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortArray", "(JI)[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntArray", "(JI)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLongArray", "(JI)[J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloatArray", "(JI)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleArray", "(JI)[D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointerArray", "(JI)[Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointerArray", "(J)[Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWideStringArray", "(J)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWideStringArray", "(JI)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNativeLong", "(JLcom/sun/jna/NativeLong;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPointer", "(JLcom/sun/jna/Pointer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setWideString", "(JLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(JLjava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(JLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(JLcom/sun/jna/WString;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nativeValue", "(Lcom/sun/jna/Pointer;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nativeValue", "(Lcom/sun/jna/Pointer;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(JI)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointer", "(J)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readArray", "(JLjava/lang/Object;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeArray", "(JLjava/lang/Object;Ljava/lang/Class;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/jna/Pointer;", "public static final")]
	public static Dova.JDK.com.sun.jna.Pointer NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "protected")]
	public long peer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Pointer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Pointer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public Pointer(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/Pointer;";
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

	[JniSignatureAttribute("(JB)J", "public")]
	public long indexOf(long arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)B", "public")]
	public byte getByte(long arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)S", "public")]
	public short getShort(long arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)C", "public")]
	public char getChar(long arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "public")]
	public int getInt(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)F", "public")]
	public float getFloat(long arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)D", "public")]
	public double getDouble(long arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "public")]
	public void clear(long arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(JLjava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getValue(long arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(J[III)V", "public")]
	public void write(long arg0, JavaArray<int> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[JII)V", "public")]
	public void write(long arg0, JavaArray<long> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[FII)V", "public")]
	public void write(long arg0, JavaArray<float> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[DII)V", "public")]
	public void write(long arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[Lcom/sun/jna/Pointer;II)V", "public")]
	public void write(long arg0, JavaArray<Dova.JDK.com.sun.jna.Pointer> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[BII)V", "public")]
	public void write(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[SII)V", "public")]
	public void write(long arg0, JavaArray<short> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[CII)V", "public")]
	public void write(long arg0, JavaArray<char> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[CII)V", "public")]
	public void read(long arg0, JavaArray<char> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[III)V", "public")]
	public void read(long arg0, JavaArray<int> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[JII)V", "public")]
	public void read(long arg0, JavaArray<long> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[SII)V", "public")]
	public void read(long arg0, JavaArray<short> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[BII)V", "public")]
	public void read(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[DII)V", "public")]
	public void read(long arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[FII)V", "public")]
	public void read(long arg0, JavaArray<float> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[Lcom/sun/jna/Pointer;II)V", "public")]
	public void read(long arg0, JavaArray<Dova.JDK.com.sun.jna.Pointer> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JLjava/lang/Object;Ljava/lang/Class;)V", "")]
	public void setValue(long arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JB)V", "public")]
	public void setByte(long arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(JC)V", "public")]
	public void setChar(long arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(JS)V", "public")]
	public void setShort(long arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(JI)V", "public")]
	public void setInt(long arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void setLong(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(JF)V", "public")]
	public void setFloat(long arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("(JD)V", "public")]
	public void setDouble(long arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("(JJB)V", "public")]
	public void setMemory(long arg0, long arg1, byte arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJ)Ljava/nio/ByteBuffer;", "public")]
	public Dova.JDK.java.nio.ByteBuffer getByteBuffer(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/String;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getStringArray(long arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(JI)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getStringArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(J)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getStringArray(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(JILjava/lang/String;)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getStringArray(long arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(long arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "public static final")]
	public static Dova.JDK.com.sun.jna.Pointer createConstant(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/jna/Pointer;", "public static final")]
	public static Dova.JDK.com.sun.jna.Pointer createConstant(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(JJ)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer share(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer share(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/NativeLong;", "public")]
	public Dova.JDK.com.sun.jna.NativeLong getNativeLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.NativeLong>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getWideString(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JI)[B", "public")]
	public JavaArray<byte> getByteArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(JI)[C", "public")]
	public JavaArray<char> getCharArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
	}

	[JniSignatureAttribute("(JI)[S", "public")]
	public JavaArray<short> getShortArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<short>>(ret);
	}

	[JniSignatureAttribute("(JI)[I", "public")]
	public JavaArray<int> getIntArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(JI)[J", "public")]
	public JavaArray<long> getLongArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
	}

	[JniSignatureAttribute("(JI)[F", "public")]
	public JavaArray<float> getFloatArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("(JI)[D", "public")]
	public JavaArray<double> getDoubleArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<double>>(ret);
	}

	[JniSignatureAttribute("(JI)[Lcom/sun/jna/Pointer;", "public")]
	public JavaArray<Dova.JDK.com.sun.jna.Pointer> getPointerArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Pointer>>(ret);
	}

	[JniSignatureAttribute("(J)[Lcom/sun/jna/Pointer;", "public")]
	public JavaArray<Dova.JDK.com.sun.jna.Pointer> getPointerArray(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.Pointer>>(ret);
	}

	[JniSignatureAttribute("(J)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getWideStringArray(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(JI)[Ljava/lang/String;", "public")]
	public JavaArray<Dova.JDK.java.lang.String> getWideStringArray(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(JLcom/sun/jna/NativeLong;)V", "public")]
	public void setNativeLong(long arg0, Dova.JDK.com.sun.jna.NativeLong arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
	}

	[JniSignatureAttribute("(JLcom/sun/jna/Pointer;)V", "public")]
	public void setPointer(long arg0, Dova.JDK.com.sun.jna.Pointer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
	}

	[JniSignatureAttribute("(JLjava/lang/String;)V", "public")]
	public void setWideString(long arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(JLjava/lang/String;Ljava/lang/String;)V", "public")]
	public void setString(long arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLjava/lang/String;)V", "public")]
	public void setString(long arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
	}

	[JniSignatureAttribute("(JLcom/sun/jna/WString;)V", "public")]
	public void setString(long arg0, Dova.JDK.com.sun.jna.WString arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;J)V", "public static")]
	public static void nativeValue(Dova.JDK.com.sun.jna.Pointer arg0, long arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)J", "public static")]
	public static long nativeValue(Dova.JDK.com.sun.jna.Pointer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[69], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String dump(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer getPointer(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/Object;Ljava/lang/Class;)V", "private")]
	public void readArray(long arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLjava/lang/Object;Ljava/lang/Class;)V", "private")]
	public void writeArray(long arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lcom/sun/jna/Pointer$Opaque;", "private static")]
	public partial class Opaque
		: Dova.JDK.com.sun.jna.Pointer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Opaque()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Pointer$Opaque;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "MSG", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLcom/sun/jna/Pointer$1;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "indexOf", "(JB)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(J)B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(J)S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChar", "(J)C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(J)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(J)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(J)D"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[FII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[JII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[DII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[Lcom/sun/jna/Pointer;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[CII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[SII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[BII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[CII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[FII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[DII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[Lcom/sun/jna/Pointer;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[JII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[SII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByte", "(JB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChar", "(JC)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShort", "(JS)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(JI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLong", "(JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloat", "(JF)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDouble", "(JD)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMemory", "(JJB)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteBuffer", "(JJ)Ljava/nio/ByteBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(JLjava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "share", "(JJ)Lcom/sun/jna/Pointer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWideString", "(J)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPointer", "(JLcom/sun/jna/Pointer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setWideString", "(JLjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(JLjava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(JI)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointer", "(J)Lcom/sun/jna/Pointer;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String MSG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Opaque(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLcom/sun/jna/Pointer$1;)V", "")]
		public Opaque(long arg0, Dova.JDK.com.sun.jna.Pointer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(J)V", "private")]
		public Opaque(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Pointer$Opaque;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(JB)J", "public")]
		public long indexOf(long arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(J)B", "public")]
		public byte getByte(long arg0)
		{
			var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)S", "public")]
		public short getShort(long arg0)
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)C", "public")]
		public char getChar(long arg0)
		{
			var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)I", "public")]
		public int getInt(long arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)J", "public")]
		public long getLong(long arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)F", "public")]
		public float getFloat(long arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)D", "public")]
		public double getDouble(long arg0)
		{
			var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)V", "public")]
		public void clear(long arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(J[FII)V", "public")]
		public void write(long arg0, JavaArray<float> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[JII)V", "public")]
		public void write(long arg0, JavaArray<long> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[DII)V", "public")]
		public void write(long arg0, JavaArray<double> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[Lcom/sun/jna/Pointer;II)V", "public")]
		public void write(long arg0, JavaArray<Dova.JDK.com.sun.jna.Pointer> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[BII)V", "public")]
		public void write(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[CII)V", "public")]
		public void write(long arg0, JavaArray<char> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[SII)V", "public")]
		public void write(long arg0, JavaArray<short> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[III)V", "public")]
		public void write(long arg0, JavaArray<int> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[BII)V", "public")]
		public void read(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[CII)V", "public")]
		public void read(long arg0, JavaArray<char> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[III)V", "public")]
		public void read(long arg0, JavaArray<int> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[FII)V", "public")]
		public void read(long arg0, JavaArray<float> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[DII)V", "public")]
		public void read(long arg0, JavaArray<double> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[Lcom/sun/jna/Pointer;II)V", "public")]
		public void read(long arg0, JavaArray<Dova.JDK.com.sun.jna.Pointer> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[JII)V", "public")]
		public void read(long arg0, JavaArray<long> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(J[SII)V", "public")]
		public void read(long arg0, JavaArray<short> arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(JB)V", "public")]
		public void setByte(long arg0, byte arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		}

		[JniSignatureAttribute("(JC)V", "public")]
		public void setChar(long arg0, char arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(JS)V", "public")]
		public void setShort(long arg0, short arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		}

		[JniSignatureAttribute("(JI)V", "public")]
		public void setInt(long arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		}

		[JniSignatureAttribute("(JJ)V", "public")]
		public void setLong(long arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		}

		[JniSignatureAttribute("(JF)V", "public")]
		public void setFloat(long arg0, float arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		}

		[JniSignatureAttribute("(JD)V", "public")]
		public void setDouble(long arg0, double arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		}

		[JniSignatureAttribute("(JJB)V", "public")]
		public void setMemory(long arg0, long arg1, byte arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JJ)Ljava/nio/ByteBuffer;", "public")]
		public Dova.JDK.java.nio.ByteBuffer getByteBuffer(long arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
		}

		[JniSignatureAttribute("(JLjava/lang/String;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getString(long arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(JJ)Lcom/sun/jna/Pointer;", "public")]
		public Dova.JDK.com.sun.jna.Pointer share(long arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}

		[JniSignatureAttribute("(J)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getWideString(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(JLcom/sun/jna/Pointer;)V", "public")]
		public void setPointer(long arg0, Dova.JDK.com.sun.jna.Pointer arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		}

		[JniSignatureAttribute("(JLjava/lang/String;)V", "public")]
		public void setWideString(long arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		}

		[JniSignatureAttribute("(JLjava/lang/String;Ljava/lang/String;)V", "public")]
		public void setString(long arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(JI)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String dump(long arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "public")]
		public Dova.JDK.com.sun.jna.Pointer getPointer(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
		}
	}
}
