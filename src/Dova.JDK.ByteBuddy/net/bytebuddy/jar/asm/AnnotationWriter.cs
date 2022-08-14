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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "final")]
public partial class AnnotationWriter
	: Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/AnnotationWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbolTable", "Lnet/bytebuddy/jar/asm/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "useNamedValues", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotation", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numElementValuePairsOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numElementValuePairs", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/SymbolTable;ZLnet/bytebuddy/jar/asm/ByteVector;Lnet/bytebuddy/jar/asm/AnnotationWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lnet/bytebuddy/jar/asm/SymbolTable;ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationWriter;)Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationWriter;)Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArray", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeAnnotationsSize", "(Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeAnnotationsSize", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putAnnotations", "(Lnet/bytebuddy/jar/asm/SymbolTable;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAnnotations", "(ILnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeParameterAnnotationsSize", "(Ljava/lang/String;[Lnet/bytebuddy/jar/asm/AnnotationWriter;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putParameterAnnotations", "(I[Lnet/bytebuddy/jar/asm/AnnotationWriter;ILnet/bytebuddy/jar/asm/ByteVector;)V"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/SymbolTable;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable symbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool useNamedValues_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector annotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int numElementValuePairsOffset_Property
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

	[JniSignatureAttribute("I", "private")]
	public int numElementValuePairs_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter previousAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter nextAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotationWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;ZLnet/bytebuddy/jar/asm/ByteVector;Lnet/bytebuddy/jar/asm/AnnotationWriter;)V", "")]
	public AnnotationWriter(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, bool arg1, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg2, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/AnnotationWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationWriter;)Lnet/bytebuddy/jar/asm/AnnotationWriter;", "static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter create(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationWriter;)Lnet/bytebuddy/jar/asm/AnnotationWriter;", "static")]
	public static Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter create(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void visit(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void visitEnum(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;)I", "static")]
	public static int computeAnnotationsSize(Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg0, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg1, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg2, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "")]
	public int computeAnnotationsSize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/AnnotationWriter;Lnet/bytebuddy/jar/asm/ByteVector;)V", "static")]
	public static void putAnnotations(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg1, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg2, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg3, Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter arg4, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/ByteVector;)V", "")]
	public void putAnnotations(int arg0, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Lnet/bytebuddy/jar/asm/AnnotationWriter;I)I", "static")]
	public static int computeParameterAnnotationsSize(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter> arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I[Lnet/bytebuddy/jar/asm/AnnotationWriter;ILnet/bytebuddy/jar/asm/ByteVector;)V", "static")]
	public static void putParameterAnnotations(int arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter> arg1, int arg2, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
	}
}
