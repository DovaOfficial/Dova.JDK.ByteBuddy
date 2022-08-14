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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ClassWriter;", "public")]
public partial class ClassWriter
	: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/ClassWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_MAXS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_FRAMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbolTable", "Lnet/bytebuddy/jar/asm/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thisClass", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClass", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstField", "Lnet/bytebuddy/jar/asm/FieldWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastField", "Lnet/bytebuddy/jar/asm/FieldWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstMethod", "Lnet/bytebuddy/jar/asm/MethodWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastMethod", "Lnet/bytebuddy/jar/asm/MethodWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberOfInnerClasses", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "innerClasses", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingClassIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingMethodIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceFileIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "debugExtension", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleWriter", "Lnet/bytebuddy/jar/asm/ModuleWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestHostClassIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberOfNestMemberClasses", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestMemberClasses", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberOfPermittedSubclasses", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "permittedSubclasses", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstRecordComponent", "Lnet/bytebuddy/jar/asm/RecordComponentWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRecordComponent", "Lnet/bytebuddy/jar/asm/RecordComponentWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstAttribute", "Lnet/bytebuddy/jar/asm/Attribute;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compute", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassReader;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toByteArray", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newModule", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSource", "(Ljava/lang/String;Ljava/lang/String;)V"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Ljava/lang/String;ILjava/lang/String;)Lnet/bytebuddy/jar/asm/ModuleVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecordComponent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceAsmInstructions", "([BZ)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributePrototypes", "()[Lnet/bytebuddy/jar/asm/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newHandle", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newHandle", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConst", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newUTF8", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newClass", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newMethodType", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newPackage", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newConstantDynamic", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInvokeDynamic", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newField", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newMethod", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newNameType", "(Ljava/lang/String;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommonSuperClass", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPermittedSubclass", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasFlags", "(I)Z"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int COMPUTE_MAXS_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int COMPUTE_FRAMES_Property
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

	[JniSignatureAttribute("I", "private final")]
	public int flags_Property
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
	public int version_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/SymbolTable;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable symbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int accessFlags_Property
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

	[JniSignatureAttribute("I", "private")]
	public int thisClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int superClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int interfaceCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> interfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.FieldWriter firstField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.FieldWriter lastField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.MethodWriter firstMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.MethodWriter lastMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numberOfInnerClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector innerClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int enclosingClassIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int enclosingMethodIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int signatureIndex_Property
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

	[JniSignatureAttribute("I", "private")]
	public int sourceFileIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector debugExtension_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeVisibleAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeInvisibleAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeVisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeInvisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ModuleWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ModuleWriter moduleWriter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ModuleWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int nestHostClassIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numberOfNestMemberClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector nestMemberClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int numberOfPermittedSubclasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector permittedSubclasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/RecordComponentWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentWriter firstRecordComponent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/RecordComponentWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentWriter lastRecordComponent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute firstAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int compute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public ClassWriter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassReader;I)V", "public")]
	public ClassWriter(Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/ClassWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "protected")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()[B", "public")]
	public JavaArray<byte> toByteArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int newModule(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public final")]
	public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public final")]
	public void visitSource(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public final")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "public final")]
	public void visitAttribute(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void visitNestHost(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public final")]
	public void visitOuterClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void visitNestMember(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "public final")]
	public void visitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)Lnet/bytebuddy/jar/asm/ModuleVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.ModuleVisitor visitModule(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ModuleVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "public final")]
	public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor visitRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
	}

	[JniSignatureAttribute("([BZ)[B", "private")]
	public JavaArray<byte> replaceAsmInstructions(JavaArray<byte> arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[Lnet/bytebuddy/jar/asm/Attribute;", "private")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute> getAttributePrototypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute>>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)I", "public")]
	public int newHandle(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int newHandle(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public")]
	public int newConst(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int newUTF8(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int newClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int newMethodType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int newPackage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)I", "public transient")]
	public int newConstantDynamic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)I", "public transient")]
	public int newInvokeDynamic(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int newField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)I", "public")]
	public int newMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)I", "public")]
	public int newNameType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getCommonSuperClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public final")]
	public void visitPermittedSubclass(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool hasFlags(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}
}
