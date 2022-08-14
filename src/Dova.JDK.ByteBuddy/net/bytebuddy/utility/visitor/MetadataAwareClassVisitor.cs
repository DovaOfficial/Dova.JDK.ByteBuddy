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

[JniSignatureAttribute("Lnet/bytebuddy/utility/visitor/MetadataAwareClassVisitor;", "public abstract")]
public partial class MetadataAwareClassVisitor
	: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MetadataAwareClassVisitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/visitor/MetadataAwareClassVisitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "triggerNestHost", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "triggerOuterClass", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "triggerAttributes", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/jar/asm/ClassVisitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lnet/bytebuddy/jar/asm/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOuterClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMember", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecordComponent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPermittedSubclass", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitNestHost", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNestHost", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitPermittedSubclass", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitOuterClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onOuterType", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onAfterAttributes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitRecordComponent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitInnerClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitNestMember", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "considerTriggerNestHost", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "considerTriggerOuterClass", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "considerTriggerAfterAttributes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVisitAttribute", "(Lnet/bytebuddy/jar/asm/Attribute;)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool triggerNestHost_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool triggerOuterClass_Property
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
	public bool triggerAttributes_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MetadataAwareClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/ClassVisitor;)V", "protected")]
	public MetadataAwareClassVisitor(int arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/visitor/MetadataAwareClassVisitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "public final")]
	public void visitAttribute(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void visitNestHost(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public final")]
	public void visitOuterClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void visitNestMember(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "public final")]
	public void visitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor visitRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void visitPermittedSubclass(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void onVisitNestHost(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void onNestHost()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void onVisitPermittedSubclass(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
	public void onVisitOuterClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void onOuterType()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void onAfterAttributes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor onVisitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor onVisitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor onVisitRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor onVisitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor onVisitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "protected")]
	public void onVisitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public void onVisitNestMember(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void onVisitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void considerTriggerNestHost()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void considerTriggerOuterClass()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void considerTriggerAfterAttributes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "protected")]
	public void onVisitAttribute(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
	}
}
