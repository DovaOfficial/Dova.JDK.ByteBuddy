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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/RecordComponentWriter;", "final")]
public partial class RecordComponentWriter
	: Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RecordComponentWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/RecordComponentWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbolTable", "Lnet/bytebuddy/jar/asm/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptorIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstAttribute", "Lnet/bytebuddy/jar/asm/Attribute;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lnet/bytebuddy/jar/asm/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeRecordComponentInfoSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putRecordComponentInfo", "(Lnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collectAttributePrototypes", "(Lnet/bytebuddy/jar/asm/Attribute$Set;)V"));
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

	[JniSignatureAttribute("I", "private final")]
	public int nameIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int descriptorIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int signatureIndex_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeVisibleAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeInvisibleAnnotation_Property
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
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeVisibleTypeAnnotation_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeInvisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute firstAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RecordComponentWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
	public RecordComponentWriter(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/RecordComponentWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "public")]
	public void visitAttribute(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()I", "")]
	public int computeRecordComponentInfoSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ByteVector;)V", "")]
	public void putRecordComponentInfo(Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute$Set;)V", "final")]
	public void collectAttributePrototypes(Dova.JDK.net.bytebuddy.jar.asm.Attribute.Set arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
