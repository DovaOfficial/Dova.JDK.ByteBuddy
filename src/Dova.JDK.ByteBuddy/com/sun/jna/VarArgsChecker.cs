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

[JniSignatureAttribute("Lcom/sun/jna/VarArgsChecker;", "abstract")]
public partial class VarArgsChecker
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static VarArgsChecker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/VarArgsChecker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/VarArgsChecker$1;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "(Ljava/lang/reflect/Method;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "()Lcom/sun/jna/VarArgsChecker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixedArgs", "(Ljava/lang/reflect/Method;)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public VarArgsChecker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/VarArgsChecker$1;)V", "")]
	public VarArgsChecker(Dova.JDK.com.sun.jna.VarArgsChecker arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public VarArgsChecker() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/VarArgsChecker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Z", "abstract")]
	public bool isVarArgs(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/jna/VarArgsChecker;", "static")]
	public static Dova.JDK.com.sun.jna.VarArgsChecker create()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.VarArgsChecker>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)I", "abstract")]
	public int fixedArgs(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/jna/VarArgsChecker$NoVarArgsChecker;", "private static final")]
	public partial class NoVarArgsChecker
		: Dova.JDK.com.sun.jna.VarArgsChecker
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoVarArgsChecker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/VarArgsChecker$NoVarArgsChecker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/VarArgsChecker$1;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "(Ljava/lang/reflect/Method;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixedArgs", "(Ljava/lang/reflect/Method;)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NoVarArgsChecker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/VarArgsChecker$1;)V", "")]
		public NoVarArgsChecker(Dova.JDK.com.sun.jna.VarArgsChecker arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NoVarArgsChecker() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/VarArgsChecker$NoVarArgsChecker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Z", "")]
		public bool isVarArgs(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)I", "")]
		public int fixedArgs(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/VarArgsChecker$RealVarArgsChecker;", "private static final")]
	public partial class RealVarArgsChecker
		: Dova.JDK.com.sun.jna.VarArgsChecker
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RealVarArgsChecker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/VarArgsChecker$RealVarArgsChecker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/VarArgsChecker$1;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "(Ljava/lang/reflect/Method;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fixedArgs", "(Ljava/lang/reflect/Method;)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RealVarArgsChecker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/VarArgsChecker$1;)V", "")]
		public RealVarArgsChecker(Dova.JDK.com.sun.jna.VarArgsChecker arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public RealVarArgsChecker() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/VarArgsChecker$RealVarArgsChecker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Z", "")]
		public bool isVarArgs(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)I", "")]
		public int fixedArgs(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}
}
