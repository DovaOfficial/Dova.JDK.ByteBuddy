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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue;", "public")]
public partial class JavaConstantValue
	: Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaConstantValue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constant", "Lnet/bytebuddy/utility/JavaConstant;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/utility/JavaConstant;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant;", "private final")]
	public Dova.JDK.net.bytebuddy.utility.JavaConstant constant_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavaConstantValue(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant;)V", "public")]
	public JavaConstantValue(Dova.JDK.net.bytebuddy.utility.JavaConstant arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;", "public static final")]
	public partial class Visitor
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Visitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onValue", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDynamic_0", "(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDynamic_1", "(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Lnet/bytebuddy/jar/asm/ConstantDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodHandle_0", "(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodHandle_1", "(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Lnet/bytebuddy/jar/asm/Handle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodType_0", "(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Lnet/bytebuddy/jar/asm/Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodType_1", "(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType_0", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType_1", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Lnet/bytebuddy/jar/asm/Type;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Visitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Visitor(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/constant/JavaConstantValue$Visitor;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.constant.JavaConstantValue.Visitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object onValue(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onDynamic_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Lnet/bytebuddy/jar/asm/ConstantDynamic;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic onDynamic_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onMethodHandle_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Lnet/bytebuddy/jar/asm/Handle;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.Handle onMethodHandle_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Handle>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Lnet/bytebuddy/jar/asm/Type;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.Type onMethodType_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onMethodType_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onType_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Lnet/bytebuddy/jar/asm/Type;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.Type onType_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Type>(ret);
		}
	}
}
