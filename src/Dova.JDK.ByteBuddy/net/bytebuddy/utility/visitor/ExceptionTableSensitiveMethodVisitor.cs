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

[JniSignatureAttribute("Lnet/bytebuddy/utility/visitor/ExceptionTableSensitiveMethodVisitor;", "public abstract")]
public partial class ExceptionTableSensitiveMethodVisitor
	: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExceptionTableSensitiveMethodVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/visitor/ExceptionTableSensitiveMethodVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trigger", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/jar/asm/MethodVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFrame", "(II[Ljava/lang/Object;I[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeInsn", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIntInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitJumpInsn", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabel", "(Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIincInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTableSwitchInsn", "(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLookupSwitchInsn", "(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMultiANewArrayInsn", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "considerEndOfExceptionTable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterExceptionTable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitFrame", "(II[Ljava/lang/Object;I[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitLabel", "(Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitIntInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitVarInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitTypeInsn", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitJumpInsn", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitLdcInsn", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitIincInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitTableSwitchInsn", "(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitLookupSwitchInsn", "(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitMultiANewArrayInsn", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitInsn", "(I)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool trigger_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExceptionTableSensitiveMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/MethodVisitor;)V", "protected")]
	public ExceptionTableSensitiveMethodVisitor(int arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/visitor/ExceptionTableSensitiveMethodVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II[Ljava/lang/Object;I[Ljava/lang/Object;)V", "public final")]
	public void visitFrame(int arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public final")]
	public void visitFieldInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)V", "public final")]
	public void visitInsn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(II)V", "public final")]
	public void visitVarInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public final")]
	public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public final")]
	public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public final")]
	public void visitTypeInsn(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public final")]
	public void visitIntInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public final")]
	public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V", "public final transient")]
	public void visitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public final")]
	public void visitJumpInsn(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "public final")]
	public void visitLabel(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(II)V", "public final")]
	public void visitIincInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V", "public final transient")]
	public void visitTableSwitchInsn(int arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V", "public final")]
	public void visitLookupSwitchInsn(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public final")]
	public void visitMultiANewArrayInsn(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void considerEndOfExceptionTable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()V", "protected abstract")]
	public void onAfterExceptionTable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(II[Ljava/lang/Object;I[Ljava/lang/Object;)V", "protected")]
	public void onVisitFrame(int arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "protected")]
	public void onVisitLabel(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void onVisitIntInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void onVisitVarInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "protected")]
	public void onVisitTypeInsn(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void onVisitFieldInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "protected")]
	public void onVisitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void onVisitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V", "protected transient")]
	public void onVisitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "protected")]
	public void onVisitJumpInsn(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void onVisitLdcInsn(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(II)V", "protected")]
	public void onVisitIincInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
	}

	[JniSignatureAttribute("(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V", "protected transient")]
	public void onVisitTableSwitchInsn(int arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V", "protected")]
	public void onVisitLookupSwitchInsn(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "protected")]
	public void onVisitMultiANewArrayInsn(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void onVisitInsn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}
}
