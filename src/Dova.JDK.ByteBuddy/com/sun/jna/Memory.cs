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

[JniSignatureAttribute("Lcom/sun/jna/Memory;", "public")]
public partial class Memory
	: Dova.JDK.com.sun.jna.Pointer
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Memory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Memory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "allocatedMemory", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "buffers", "Lcom/sun/jna/WeakMemoryHolder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanable", "Lcom/sun/jna/internal/Cleaner$Cleanable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByte", "(J)B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShort", "(J)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChar", "(J)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInt", "(J)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFloat", "(J)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDouble", "(J)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[Lcom/sun/jna/Pointer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(J[JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[CII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[SII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[BII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[Lcom/sun/jna/Pointer;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[DII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[FII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(J[JII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setByte", "(JB)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setChar", "(JC)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShort", "(JS)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInt", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLong", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFloat", "(JF)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDouble", "(JD)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteBuffer", "(JJ)Ljava/nio/ByteBuffer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getString", "(JLjava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "free", "(J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "purge", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disposeAll", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "share", "(JJ)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "share", "(J)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWideString", "(J)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPointer", "(JLcom/sun/jna/Pointer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setWideString", "(JLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setString", "(JLjava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "align", "(I)Lcom/sun/jna/Memory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundsCheck", "(JJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "malloc", "(J)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shareReferenceIfInBounds", "(Lcom/sun/jna/Pointer;)Lcom/sun/jna/Pointer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPointer", "(J)Lcom/sun/jna/Pointer;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map allocatedMemory_Property
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

	[JniSignatureAttribute("Lcom/sun/jna/WeakMemoryHolder;", "private static final")]
	public static Dova.JDK.com.sun.jna.WeakMemoryHolder buffers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.WeakMemoryHolder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$Cleanable;", "private final")]
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

	[JniSignatureAttribute("J", "protected")]
	public long size_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Memory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public Memory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(J)V", "public")]
	public Memory(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/Memory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)B", "public")]
	public byte getByte(long arg0)
	{
		var ret = DovaVM.Runtime.CallByteMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)S", "public")]
	public short getShort(long arg0)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)C", "public")]
	public char getChar(long arg0)
	{
		var ret = DovaVM.Runtime.CallCharMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "public")]
	public int getInt(long arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)J", "public")]
	public long getLong(long arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)F", "public")]
	public float getFloat(long arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)D", "public")]
	public double getDouble(long arg0)
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()J", "public")]
	public long size()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(J[CII)V", "public")]
	public void write(long arg0, JavaArray<char> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[III)V", "public")]
	public void write(long arg0, JavaArray<int> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[SII)V", "public")]
	public void write(long arg0, JavaArray<short> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[BII)V", "public")]
	public void write(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[Lcom/sun/jna/Pointer;II)V", "public")]
	public void write(long arg0, JavaArray<Dova.JDK.com.sun.jna.Pointer> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[DII)V", "public")]
	public void write(long arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[FII)V", "public")]
	public void write(long arg0, JavaArray<float> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[JII)V", "public")]
	public void write(long arg0, JavaArray<long> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[III)V", "public")]
	public void read(long arg0, JavaArray<int> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[CII)V", "public")]
	public void read(long arg0, JavaArray<char> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[SII)V", "public")]
	public void read(long arg0, JavaArray<short> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[BII)V", "public")]
	public void read(long arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[Lcom/sun/jna/Pointer;II)V", "public")]
	public void read(long arg0, JavaArray<Dova.JDK.com.sun.jna.Pointer> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[DII)V", "public")]
	public void read(long arg0, JavaArray<double> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[FII)V", "public")]
	public void read(long arg0, JavaArray<float> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(J[JII)V", "public")]
	public void read(long arg0, JavaArray<long> arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("(JB)V", "public")]
	public void setByte(long arg0, byte arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(JC)V", "public")]
	public void setChar(long arg0, char arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(JS)V", "public")]
	public void setShort(long arg0, short arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(JI)V", "public")]
	public void setInt(long arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "public")]
	public void setLong(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
	}

	[JniSignatureAttribute("(JF)V", "public")]
	public void setFloat(long arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(JD)V", "public")]
	public void setDouble(long arg0, double arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)Ljava/nio/ByteBuffer;", "public")]
	public Dova.JDK.java.nio.ByteBuffer getByteBuffer(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.ByteBuffer>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool valid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getString(long arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)V", "protected static")]
	public static void free(long arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void purge()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[38]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39]);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void disposeAll()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40]);
	}

	[JniSignatureAttribute("(JJ)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer share(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer share(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getWideString(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(JLcom/sun/jna/Pointer;)V", "public")]
	public void setPointer(long arg0, Dova.JDK.com.sun.jna.Pointer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(JLjava/lang/String;)V", "public")]
	public void setWideString(long arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
	}

	[JniSignatureAttribute("(JLjava/lang/String;Ljava/lang/String;)V", "public")]
	public void setString(long arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)Lcom/sun/jna/Memory;", "public")]
	public Dova.JDK.com.sun.jna.Memory align(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Memory>(ret);
	}

	[JniSignatureAttribute("(JJ)V", "protected")]
	public void boundsCheck(long arg0, long arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}

	[JniSignatureAttribute("(J)J", "protected static")]
	public static long malloc(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Pointer;)Lcom/sun/jna/Pointer;", "private")]
	public Dova.JDK.com.sun.jna.Pointer shareReferenceIfInBounds(Dova.JDK.com.sun.jna.Pointer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "static")]
	public static Dova.JDK.java.util.Map access_000()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String dump()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Lcom/sun/jna/Pointer;", "public")]
	public Dova.JDK.com.sun.jna.Pointer getPointer(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Pointer>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jna/Memory$MemoryDisposer;", "private static final")]
	public partial class MemoryDisposer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MemoryDisposer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Memory$MemoryDisposer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peer", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("J", "private")]
		public long peer_Property
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
		public MemoryDisposer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(J)V", "public")]
		public MemoryDisposer(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Memory$MemoryDisposer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/Memory$SharedMemory;", "private")]
	public partial class SharedMemory
		: Dova.JDK.com.sun.jna.Memory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SharedMemory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/Memory$SharedMemory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/jna/Memory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Memory;JJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundsCheck", "(JJ)V"));
		}

		[JniSignatureAttribute("Lcom/sun/jna/Memory;", "final")]
		public Dova.JDK.com.sun.jna.Memory this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Memory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SharedMemory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/Memory;JJ)V", "public")]
		public SharedMemory(Dova.JDK.com.sun.jna.Memory arg0, long arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/Memory$SharedMemory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "protected synchronized")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(JJ)V", "protected")]
		public void boundsCheck(long arg0, long arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}
	}
}
