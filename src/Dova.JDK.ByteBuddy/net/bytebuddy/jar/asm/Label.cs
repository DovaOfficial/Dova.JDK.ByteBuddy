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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "public")]
public partial class Label
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Label()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Label;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_DEBUG_ONLY", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_JUMP_TARGET", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_RESOLVED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_REACHABLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_SUBROUTINE_CALLER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_SUBROUTINE_START", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAG_SUBROUTINE_END", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINE_NUMBERS_CAPACITY_INCREMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORWARD_REFERENCES_CAPACITY_INCREMENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORWARD_REFERENCE_TYPE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORWARD_REFERENCE_TYPE_SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORWARD_REFERENCE_TYPE_WIDE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORWARD_REFERENCE_HANDLE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_LIST", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "info", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineNumber", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "otherLineNumbers", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bytecodeOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forwardReferences", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputStackSize", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputStackSize", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputStackMax", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subroutineId", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frame", "Lnet/bytebuddy/jar/asm/Frame;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextBasicBlock", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outgoingEdges", "Lnet/bytebuddy/jar/asm/Edge;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextListElement", "Lnet/bytebuddy/jar/asm/Label;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "put", "(Lnet/bytebuddy/jar/asm/ByteVector;IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "([BI)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLineNumber", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addForwardReference", "(III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushSuccessors", "(Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Label;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCanonicalInstance", "()Lnet/bytebuddy/jar/asm/Label;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markSubroutine", "(S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSubroutineRetSuccessors", "(Lnet/bytebuddy/jar/asm/Label;)V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FLAG_DEBUG_ONLY_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FLAG_JUMP_TARGET_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FLAG_RESOLVED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FLAG_REACHABLE_Property
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
	public static int FLAG_SUBROUTINE_CALLER_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FLAG_SUBROUTINE_START_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FLAG_SUBROUTINE_END_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int LINE_NUMBERS_CAPACITY_INCREMENT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FORWARD_REFERENCES_CAPACITY_INCREMENT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FORWARD_REFERENCE_TYPE_MASK_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FORWARD_REFERENCE_TYPE_SHORT_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FORWARD_REFERENCE_TYPE_WIDE_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int FORWARD_REFERENCE_HANDLE_MASK_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "static final")]
	public static Dova.JDK.net.bytebuddy.jar.asm.Label EMPTY_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object info_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("S", "")]
	public short flags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short lineNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> otherLineNumbers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int bytecodeOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> forwardReferences_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("S", "")]
	public short inputStackSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("S", "")]
	public short outputStackSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("S", "")]
	public short outputStackMax_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("S", "")]
	public short subroutineId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Frame;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Frame frame_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Frame>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label nextBasicBlock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Edge;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Edge outgoingEdges_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Edge>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label nextListElement_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Label(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Label() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Label;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ByteVector;IZ)V", "final")]
	public void put(Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg0, int arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([BI)Z", "final")]
	public bool resolve(JavaArray<byte> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Z)V", "final")]
	public void accept(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "final")]
	public void addLineNumber(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(III)V", "private")]
	public void addForwardReference(int arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Label;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label pushSuccessors(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/Label;", "final")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label getCanonicalInstance()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
	}

	[JniSignatureAttribute("(S)V", "final")]
	public void markSubroutine(short arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "final")]
	public void addSubroutineRetSuccessors(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}
}
