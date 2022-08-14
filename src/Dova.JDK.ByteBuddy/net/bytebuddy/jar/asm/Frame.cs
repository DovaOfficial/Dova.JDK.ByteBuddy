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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Frame;", "")]
public partial class Frame
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Frame()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Frame;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_LOCALS_1_STACK_ITEM_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESERVED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_LOCALS_1_STACK_ITEM_FRAME_EXTENDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHOP_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAME_FRAME_EXTENDED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPEND_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULL_FRAME", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_TOP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_INTEGER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_FLOAT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_DOUBLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_LONG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_NULL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_UNINITIALIZED_THIS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_OBJECT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_UNINITIALIZED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_ASM_BOOLEAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_ASM_BYTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_ASM_CHAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ITEM_ASM_SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIM_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KIND_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAGS_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALUE_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIM_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KIND_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLAGS_SHIFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIM_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KIND_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALUE_MASK", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_OF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELEMENT_OF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_KIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REFERENCE_KIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNINITIALIZED_KIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCAL_KIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STACK_KIND", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOP_IF_LONG_OR_DOUBLE_FLAG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOP", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNINITIALIZED_THIS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "owner", "Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputLocals", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inputStack", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputLocals", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputStack", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputStackStart", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputStackTop", "S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initializationCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initializations", "[I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lnet/bytebuddy/jar/asm/SymbolTable;Lnet/bytebuddy/jar/asm/Frame;I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "merge", "(Lnet/bytebuddy/jar/asm/SymbolTable;I[II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "execute", "(IILnet/bytebuddy/jar/asm/Symbol;Lnet/bytebuddy/jar/asm/SymbolTable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/jar/asm/MethodWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "push", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "push", "(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pop", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAbstractTypeFromDescriptor", "(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAbstractTypeFromApiFormat", "(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocal", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocal", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInitializedType", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConcreteOutputType", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializedType", "(Lnet/bytebuddy/jar/asm/SymbolTable;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyFrom", "(Lnet/bytebuddy/jar/asm/Frame;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAbstractTypeFromInternalName", "(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputFrameFromDescriptor", "(Lnet/bytebuddy/jar/asm/SymbolTable;ILjava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputFrameFromApiFormat", "(Lnet/bytebuddy/jar/asm/SymbolTable;I[Ljava/lang/Object;I[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStackSize", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putAbstractType", "(Lnet/bytebuddy/jar/asm/SymbolTable;ILnet/bytebuddy/jar/asm/ByteVector;)V"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int SAME_FRAME_Property
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
	public static int SAME_LOCALS_1_STACK_ITEM_FRAME_Property
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
	public static int RESERVED_Property
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
	public static int SAME_LOCALS_1_STACK_ITEM_FRAME_EXTENDED_Property
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
	public static int CHOP_FRAME_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int SAME_FRAME_EXTENDED_Property
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

	[JniSignatureAttribute("I", "static final")]
	public static int APPEND_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int FULL_FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_TOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_INTEGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_UNINITIALIZED_THIS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_OBJECT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("I", "static final")]
	public static int ITEM_UNINITIALIZED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ITEM_ASM_BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ITEM_ASM_BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ITEM_ASM_CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ITEM_ASM_SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[20]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[20], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DIM_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int KIND_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FLAGS_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int VALUE_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DIM_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int KIND_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[26]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[26], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FLAGS_SHIFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[27]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[27], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DIM_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int KIND_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int VALUE_MASK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ARRAY_OF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[31]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[31], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int ELEMENT_OF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CONSTANT_KIND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int REFERENCE_KIND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[34]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[34], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int UNINITIALIZED_KIND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LOCAL_KIND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int STACK_KIND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[37]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[37], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TOP_IF_LONG_OR_DOUBLE_FLAG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int TOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int CHAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[42]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[42], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[43]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[43], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INTEGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[46]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[46], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[47]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[47], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[48]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[48], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int UNINITIALIZED_THIS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Label owner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> inputLocals_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> inputStack_Property
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
	public JavaArray<int> outputLocals_Property
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

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> outputStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short outputStackStart_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[55]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[55], value);
		}
	}

	[JniSignatureAttribute("S", "private")]
	public short outputStackTop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[56]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[56], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int initializationCount_Property
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

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> initializations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Frame(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "")]
	public Frame(Dova.JDK.net.bytebuddy.jar.asm.Label arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Frame;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Lnet/bytebuddy/jar/asm/Frame;I)Z", "final")]
	public bool merge(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.net.bytebuddy.jar.asm.Frame arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;I[II)Z", "private static")]
	public static bool merge(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, JavaArray<int> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IILnet/bytebuddy/jar/asm/Symbol;Lnet/bytebuddy/jar/asm/SymbolTable;)V", "")]
	public void execute(int arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.Symbol arg2, Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodWriter;)V", "final")]
	public void accept(Dova.JDK.net.bytebuddy.jar.asm.MethodWriter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void push(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;)V", "private")]
	public void push(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void pop(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void pop(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()I", "private")]
	public int pop()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;I)I", "private static")]
	public static int getAbstractTypeFromDescriptor(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.java.lang.String arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/Object;)I", "static")]
	public static int getAbstractTypeFromApiFormat(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int getLocal(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void setLocal(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void addInitializedType(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int getConcreteOutputType(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;I)I", "private")]
	public int getInitializedType(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Frame;)V", "final")]
	public void copyFrom(Dova.JDK.net.bytebuddy.jar.asm.Frame arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Ljava/lang/String;)I", "static")]
	public static int getAbstractTypeFromInternalName(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;ILjava/lang/String;I)V", "final")]
	public void setInputFrameFromDescriptor(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;I[Ljava/lang/Object;I[Ljava/lang/Object;)V", "final")]
	public void setInputFrameFromApiFormat(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()I", "final")]
	public int getInputStackSize()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;ILnet/bytebuddy/jar/asm/ByteVector;)V", "static")]
	public static void putAbstractType(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1, arg2);
	}
}
