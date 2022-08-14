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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodWriter;", "final")]
public partial class MethodWriter
	: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodWriter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/MethodWriter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_NOTHING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_MAX_STACK_AND_LOCAL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_MAX_STACK_AND_LOCAL_FROM_FRAMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_INSERTED_FRAMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPUTE_ALL_FRAMES", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NA", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STACK_SIZE_DELTA", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbolTable", "Lnet/bytebuddy/jar/asm/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptorIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxStack", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxLocals", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "code", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstHandler", "Lnet/bytebuddy/jar/asm/Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastHandler", "Lnet/bytebuddy/jar/asm/Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineNumberTableLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineNumberTable", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableTableLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableTable", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableTypeTableLength", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableTypeTable", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackMapTableNumberOfEntries", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackMapTableEntries", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastCodeRuntimeVisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastCodeRuntimeInvisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstCodeAttribute", "Lnet/bytebuddy/jar/asm/Attribute;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberOfExceptions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionIndexTable", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibleAnnotableParameterCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleParameterAnnotations", "[Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invisibleAnnotableParameterCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleParameterAnnotations", "[Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeVisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRuntimeInvisibleTypeAnnotation", "Lnet/bytebuddy/jar/asm/AnnotationWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parametersCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "Lnet/bytebuddy/jar/asm/ByteVector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstAttribute", "Lnet/bytebuddy/jar/asm/Attribute;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compute", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstBasicBlock", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastBasicBlock", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentBasicBlock", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "relativeStackSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxRelativeStackSize", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentLocals", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousFrameOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousFrame", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrame", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasSubroutines", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasAsmInstructions", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastBytecodeOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceLength", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/SymbolTable;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFrame", "(II[Ljava/lang/Object;I[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMaxs", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeInsn", "(ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIntInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameter", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotableParameterCount", "(IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotation", "(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lnet/bytebuddy/jar/asm/Attribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitJumpInsn", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabel", "(Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIincInsn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTableSwitchInsn", "(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLookupSwitchInsn", "(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMultiANewArrayInsn", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsnAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTryCatchBlock", "(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTryCatchAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;[Lnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;[ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLineNumber", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canCopyMethodAttributes", "(Lnet/bytebuddy/jar/asm/ClassReader;ZZIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMethodAttributesSource", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeMethodInfoSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasFrames", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasAsmInstructions", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putMethodInfo", "(Lnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collectAttributePrototypes", "(Lnet/bytebuddy/jar/asm/Attribute$Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFrameStart", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAbstractType", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFrameEnd", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFrameType", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endCurrentBasicBlockWithNoSuccessor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSuccessorToCurrentBasicBlock", "(ILnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchInsn", "(Lnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeAllFrames", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeMaxStackAndLocal", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putFrame", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAbstractTypes", "(II)V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int COMPUTE_NOTHING_Property
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
	public static int COMPUTE_MAX_STACK_AND_LOCAL_Property
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
	public static int COMPUTE_MAX_STACK_AND_LOCAL_FROM_FRAMES_Property
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
	public static int COMPUTE_INSERTED_FRAMES_Property
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
	public static int COMPUTE_ALL_FRAMES_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int NA_Property
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

	[JniSignatureAttribute("[I", "private static final")]
	public static JavaArray<int> STACK_SIZE_DELTA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/SymbolTable;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.SymbolTable symbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int accessFlags_Property
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

	[JniSignatureAttribute("I", "private final")]
	public int nameIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int descriptorIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String descriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxLocals_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private final")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector code_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Handler;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Handler firstHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Handler;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Handler lastHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lineNumberTableLength_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector lineNumberTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int localVariableTableLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector localVariableTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int localVariableTypeTableLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector localVariableTypeTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int stackMapTableNumberOfEntries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector stackMapTableEntries_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastCodeRuntimeVisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastCodeRuntimeInvisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute firstCodeAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int numberOfExceptions_Property
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

	[JniSignatureAttribute("[I", "private final")]
	public JavaArray<int> exceptionIndexTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int signatureIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeVisibleAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeInvisibleAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int visibleAnnotableParameterCount_Property
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

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter> lastRuntimeVisibleParameterAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int invisibleAnnotableParameterCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter> lastRuntimeInvisibleParameterAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeVisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationWriter;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter lastRuntimeInvisibleTypeAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector defaultValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int parametersCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/ByteVector;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector parameters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute firstAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int compute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label firstBasicBlock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label lastBasicBlock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label currentBasicBlock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int relativeStackSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int maxRelativeStackSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int currentLocals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[50]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[50], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int previousFrameOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[51]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[51], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> previousFrame_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> currentFrame_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasSubroutines_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[54]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[54], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool hasAsmInstructions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int lastBytecodeOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[57]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[57], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int sourceLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[58]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[58], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodWriter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;I)V", "")]
	public MethodWriter(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/MethodWriter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II[Ljava/lang/Object;I[Ljava/lang/Object;)V", "public")]
	public void visitFrame(int arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void visitCode()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
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
	public void visitMaxs(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitVarInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
	public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
	public void visitTypeInsn(int arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitIntInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void visitParameter(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotationDefault()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(IZ)V", "public")]
	public void visitAnnotableParameterCount(int arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitParameterAnnotation(int arg0, Dova.JDK.java.lang.String arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "public")]
	public void visitAttribute(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V", "public transient")]
	public void visitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitJumpInsn(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLabel(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void visitIincInsn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(IILnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V", "public transient")]
	public void visitTableSwitchInsn(int arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;[I[Lnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLookupSwitchInsn(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void visitMultiANewArrayInsn(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitInsnAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Ljava/lang/String;)V", "public")]
	public void visitTryCatchBlock(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTryCatchAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;I)V", "public")]
	public void visitLocalVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.jar.asm.Label arg3, Dova.JDK.net.bytebuddy.jar.asm.Label arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;[Lnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;[ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitLocalVariableAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg2, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg3, JavaArray<int> arg4, Dova.JDK.java.lang.String arg5, bool arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "public")]
	public void visitLineNumber(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassReader;ZZIII)Z", "")]
	public bool canCopyMethodAttributes(Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg0, bool arg1, bool arg2, int arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "")]
	public void setMethodAttributesSource(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "")]
	public int computeMethodInfoSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool hasFrames()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool hasAsmInstructions()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ByteVector;)V", "")]
	public void putMethodInfo(Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute$Set;)V", "final")]
	public void collectAttributePrototypes(Dova.JDK.net.bytebuddy.jar.asm.Attribute.Set arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(III)I", "")]
	public int visitFrameStart(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "")]
	public void visitAbstractType(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void visitFrameEnd()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "private")]
	public void putFrameType(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void endCurrentBasicBlockWithNoSuccessor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42]);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/Label;)V", "private")]
	public void addSuccessorToCurrentBasicBlock(int arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;)V", "private")]
	public void visitSwitchInsn(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void computeAllFrames()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void computeMaxStackAndLocal()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void putFrame()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47]);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void putAbstractTypes(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
	}
}
