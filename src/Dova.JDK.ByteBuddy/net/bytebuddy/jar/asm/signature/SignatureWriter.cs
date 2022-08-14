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

namespace Dova.JDK.net.bytebuddy.jar.asm.signature;

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/signature/SignatureWriter;", "public")]
public partial class SignatureWriter
	: Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SignatureWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/signature/SignatureWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringBuilder", "Ljava/lang/StringBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasFormals", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasParameters", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentStack", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endArguments", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBaseType", "(C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVariable", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClassType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endFormals", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterface", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSuperclass", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturnType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptionType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFormalTypeParameter", "(Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
	public Dova.JDK.java.lang.StringBuilder stringBuilder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasFormals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasParameters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int argumentStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SignatureWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SignatureWriter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/signature/SignatureWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void endArguments()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(C)V", "public")]
	public void visitBaseType(char arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitTypeVariable(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitArrayType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitInnerClassType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitTypeArgument(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitTypeArgument()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void endFormals()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterfaceBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitClassBound()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitSuperclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitParameterType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitExceptionType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void visitFormalTypeParameter(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}
}
