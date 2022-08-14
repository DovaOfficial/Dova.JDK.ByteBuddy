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

namespace Dova.JDK.net.bytebuddy.jar.asm.commons;

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/commons/SignatureRemapper;", "public")]
public partial class SignatureRemapper
	: Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureRemapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/commons/SignatureRemapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureVisitor", "Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remapper", "Lnet/bytebuddy/jar/asm/commons/Remapper;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classNames", "Ljava/util/ArrayList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/jar/asm/signature/SignatureVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBaseType", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVariable", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterface", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSuperclass", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturnType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptionType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFormalTypeParameter", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor signatureVisitor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/commons/Remapper;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper remapper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList classNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureRemapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "public")]
	public SignatureRemapper(Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/signature/SignatureVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "protected")]
	public SignatureRemapper(int arg0, Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor arg1, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/commons/SignatureRemapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void visitBaseType(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitTypeVariable(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitArrayType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitInnerClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitTypeArgument()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitTypeArgument(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterfaceBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitClassBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitSuperclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitParameterType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitExceptionType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitFormalTypeParameter(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}
}
