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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/commons/AnnotationRemapper;", "public")]
public partial class AnnotationRemapper
	: Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationRemapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/commons/AnnotationRemapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "remapper", "Lnet/bytebuddy/jar/asm/commons/Remapper;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArray", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "orDeprecatedValue", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapAnnotationAttributeName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAnnotationRemapper", "(Lnet/bytebuddy/jar/asm/AnnotationVisitor;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createAnnotationRemapper", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationVisitor;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String descriptor_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/commons/Remapper;", "protected final")]
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AnnotationRemapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "protected")]
	public AnnotationRemapper(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg2, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "protected")]
	public AnnotationRemapper(int arg0, Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg1, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "public")]
	public AnnotationRemapper(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg1, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;Lnet/bytebuddy/jar/asm/commons/Remapper;)V", "public")]
	public AnnotationRemapper(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.commons.Remapper arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/commons/AnnotationRemapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void visit(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void visitEnum(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitArray(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "final")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor orDeprecatedValue(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String mapAnnotationAttributeName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/AnnotationVisitor;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor createAnnotationRemapper(Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/AnnotationVisitor;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor createAnnotationRemapper(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}
}
