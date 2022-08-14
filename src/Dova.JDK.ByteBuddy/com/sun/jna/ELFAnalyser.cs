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

namespace Dova.JDK.com.sun.jna;

[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser;", "")]
public partial class ELFAnalyser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ELFAnalyser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ELFAnalyser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELF_MAGIC", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EF_ARM_ABI_FLOAT_HARD", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EF_ARM_ABI_FLOAT_SOFT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EI_DATA_BIG_ENDIAN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "E_MACHINE_ARM", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EI_CLASS_64BIT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filename", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ELF", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_64Bit", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bigEndian", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "armHardFloatFlag", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "armSoftFloatFlag", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "armEabiAapcsVfp", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arm", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBigEndian", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "is64Bit", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseAEABI", "(Ljava/nio/ByteBuffer;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseFileAttribute", "(Ljava/nio/ByteBuffer;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readNTBS", "(Ljava/nio/ByteBuffer;Ljava/lang/Integer;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readULEB128", "(Ljava/nio/ByteBuffer;)Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArm", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "runDetection", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseEabiAapcsVfp", "(Ljava/nio/ByteBuffer;Ljava/io/RandomAccessFile;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseArmAttributes", "(Ljava/nio/ByteBuffer;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isELF", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFilename", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArmEabiAapcsVfp", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArmHardFloatFlag", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArmSoftFloatFlag", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "analyse", "(Ljava/lang/String;)Lcom/sun/jna/ELFAnalyser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArmHardFloat", "()Z"));
	}

	[JniSignatureAttribute("[B", "private static final")]
	public static JavaArray<byte> ELF_MAGIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int EF_ARM_ABI_FLOAT_HARD_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int EF_ARM_ABI_FLOAT_SOFT_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int EI_DATA_BIG_ENDIAN_Property
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

	[JniSignatureAttribute("I", "private static final")]
	public static int E_MACHINE_ARM_Property
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
	public static int EI_CLASS_64BIT_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String filename_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool ELF_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool _64Bit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool bigEndian_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool armHardFloatFlag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool armSoftFloatFlag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool armEabiAapcsVfp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool arm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ELFAnalyser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public ELFAnalyser(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/ELFAnalyser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isBigEndian()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool is64Bit()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map parseAEABI(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map parseFileAttribute(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/lang/Integer;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String readNTBS(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.lang.Integer arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/math/BigInteger;", "private static")]
	public static Dova.JDK.java.math.BigInteger readULEB128(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArm()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void runDetection()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Ljava/io/RandomAccessFile;)V", "private")]
	public void parseEabiAapcsVfp(Dova.JDK.java.nio.ByteBuffer arg0, Dova.JDK.java.io.RandomAccessFile arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map parseArmAttributes(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isELF()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFilename()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArmEabiAapcsVfp()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArmHardFloatFlag()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArmSoftFloatFlag()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jna/ELFAnalyser;", "public static")]
	public static Dova.JDK.com.sun.jna.ELFAnalyser analyse(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArmHardFloat()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "static")]
	public partial class ArmAeabiAttributesTag
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArmAeabiAttributesTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tags", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "valueMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nameMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "File", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Section", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Symbol", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPU_raw_name", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPU_name", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPU_arch", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPU_arch_profile", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARM_ISA_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THUMB_ISA_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FP_arch", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WMMX_arch", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Advanced_SIMD_arch", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PCS_config", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_PCS_R9_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_PCS_RW_data", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_PCS_RO_data", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_PCS_GOT_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_PCS_wchar_t", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_rounding", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_denormal", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_exceptions", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_user_exceptions", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_number_model", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_align_needed", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_align8_preserved", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_enum_size", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_HardFP_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_VFP_args", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_WMMX_args", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_optimization_goals", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_optimization_goals", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "compatibility", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CPU_unaligned_access", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FP_HP_extension", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABI_FP_16bit_format", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MPextension_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIV_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "nodefaults", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "also_compatible_with", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "conformance", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "T2EE_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Virtualization_use", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MPextension_use2", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByName", "(Ljava/lang/String;)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getParameterType", "(I)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterType", "()Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTag", "(ILjava/lang/String;Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTags", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getByValue", "(I)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "private final")]
		public Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType parameterType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List tags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map valueMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map nameMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag File_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag Section_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag Symbol_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag CPU_raw_name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag CPU_name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag CPU_arch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag CPU_arch_profile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ARM_ISA_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag THUMB_ISA_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag FP_arch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag WMMX_arch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag Advanced_SIMD_arch_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag PCS_config_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_PCS_R9_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_PCS_RW_data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_PCS_RO_data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_PCS_GOT_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_PCS_wchar_t_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_rounding_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_denormal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_exceptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_user_exceptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_number_model_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_align_needed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_align8_preserved_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_enum_size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_HardFP_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_VFP_args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_WMMX_args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_optimization_goals_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_optimization_goals_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag compatibility_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag CPU_unaligned_access_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag FP_HP_extension_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag ABI_FP_16bit_format_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag MPextension_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag DIV_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag nodefaults_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag also_compatible_with_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag conformance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag T2EE_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag Virtualization_use_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static final")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag MPextension_use2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ArmAeabiAttributesTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/String;Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;)V", "public")]
		public ArmAeabiAttributesTag(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getValue()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag getByName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "private static")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType getParameterType(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public")]
		public Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType getParameterType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "private static")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag addTag(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public static")]
		public static Dova.JDK.java.util.List getTags()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag;", "public static")]
		public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag getByValue(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public static final")]
		public partial class ParameterType
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ParameterType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UINT32", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NTBS", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ULEB128", "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;"));
			}

			[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public static final")]
			public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType UINT32_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public static final")]
			public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType NTBS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public static final")]
			public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType ULEB128_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ParameterType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ParameterType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/jna/ELFAnalyser$ArmAeabiAttributesTag$ParameterType;", "public static")]
			public static Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.ELFAnalyser.ArmAeabiAttributesTag.ParameterType>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ELFSectionHeaderEntry;", "static")]
	public partial class ELFSectionHeaderEntry
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ELFSectionHeaderEntry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ELFAnalyser$ELFSectionHeaderEntry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameOffset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLjava/nio/ByteBuffer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setName", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlags", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameOffset", "()I"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int nameOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int type_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int flags_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int offset_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int size_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ELFSectionHeaderEntry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZLjava/nio/ByteBuffer;)V", "public")]
		public ELFSectionHeaderEntry(bool arg0, Dova.JDK.java.nio.ByteBuffer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/ELFAnalyser$ELFSectionHeaderEntry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void setName(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getType()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getSize()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getFlags()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getNameOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/ELFAnalyser$ELFSectionHeaders;", "static")]
	public partial class ELFSectionHeaders
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ELFSectionHeaders()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/ELFAnalyser$ELFSectionHeaders;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZLjava/nio/ByteBuffer;Ljava/io/RandomAccessFile;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntries", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List entries_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ELFSectionHeaders(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZZLjava/nio/ByteBuffer;Ljava/io/RandomAccessFile;)V", "public")]
		public ELFSectionHeaders(bool arg0, bool arg1, Dova.JDK.java.nio.ByteBuffer arg2, Dova.JDK.java.io.RandomAccessFile arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/ELFAnalyser$ELFSectionHeaders;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getEntries()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}
}
