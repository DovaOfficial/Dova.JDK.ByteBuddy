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

namespace Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public final")]
public partial class PrimitiveWideningDelegate
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrimitiveWideningDelegate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toBooleanStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toByteStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toShortStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toCharacterStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toIntegerStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toLongStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toFloatStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toDoubleStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forPrimitive", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "widenTo", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate CHARACTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate INTEGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toBooleanStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toByteStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toShortStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toCharacterStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toIntegerStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toLongStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toFloatStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toDoubleStackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrimitiveWideningDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "private")]
	public PrimitiveWideningDelegate(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg5, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg6, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg7, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg8, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg9) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate forPrimitive(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
	}

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveWideningDelegate>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation widenTo(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate$WideningStackManipulation;", "protected static")]
	public partial class WideningStackManipulation
		: Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WideningStackManipulation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate$WideningStackManipulation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conversionOpcode", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/implementation/bytecode/StackManipulation$Size;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int conversionOpcode_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WideningStackManipulation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILnet/bytebuddy/implementation/bytecode/StackManipulation$Size;)V", "protected")]
		public WideningStackManipulation(int arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveWideningDelegate$WideningStackManipulation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
		}
	}
}
