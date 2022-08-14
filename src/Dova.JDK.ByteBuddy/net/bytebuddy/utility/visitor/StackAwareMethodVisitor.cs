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

namespace Dova.JDK.net.bytebuddy.utility.visitor;

[JniSignatureAttribute("Lnet/bytebuddy/utility/visitor/StackAwareMethodVisitor;", "public")]
public partial class StackAwareMethodVisitor
	: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StackAwareMethodVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/visitor/StackAwareMethodVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNADJUSTED_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNADJUSTED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZE_CHANGE", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sizes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "freeIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFrame", "(II[Ljava/lang/Object;I[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/jar/asm/Label;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeInsn", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIntInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitJumpInsn", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabel", "(Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTableSwitchInsn", "(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLookupSwitchInsn", "(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMultiANewArrayInsn", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTryCatchBlock", "(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumber", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drainStack", "(IILnet/bytebuddy/implementation/bytecode/StackSize;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drainStack", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustStack", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustStack", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDrain", "(Ljava/util/List;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String UNADJUSTED_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public static final")]
	public static bool UNADJUSTED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> SIZE_CHANGE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List current_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map sizes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int freeIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool ACCESS_CONTROLLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StackAwareMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;)V", "protected")]
	public StackAwareMethodVisitor(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/visitor/StackAwareMethodVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II[Ljava/lang/Object;I[Ljava/lang/Object;)V", "public")]
	public void visitFrame(int arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor of(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;Ljava/util/List;)V", "public")]
	public void register(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void visitFieldInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void visitInsn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitVarInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
	public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void visitTypeInsn(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitIntInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V", "public transient")]
	public void visitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitJumpInsn(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLabel(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V", "public transient")]
	public void visitTableSwitchInsn(int arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLookupSwitchInsn(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void visitMultiANewArrayInsn(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Ljava/lang/String;)V", "public")]
	public void visitTryCatchBlock(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLineNumber(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(IILnet/bytebuddy/implementation/bytecode/StackSize;)I", "public")]
	public int drainStack(int arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void drainStack()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void adjustStack(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void adjustStack(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void doDrain(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}
}
