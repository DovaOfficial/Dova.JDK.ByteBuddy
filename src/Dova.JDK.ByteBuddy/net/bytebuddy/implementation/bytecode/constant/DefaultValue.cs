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

namespace Dova.JDK.net.bytebuddy.implementation.bytecode.constant;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public final")]
public partial class DefaultValue
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultValue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REFERENCE", "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue INTEGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue VOID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue REFERENCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultValue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "private")]
	public DefaultValue(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/constant/DefaultValue;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.DefaultValue>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation of(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
