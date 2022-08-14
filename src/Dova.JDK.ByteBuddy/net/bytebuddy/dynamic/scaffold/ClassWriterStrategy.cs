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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;", "public abstract interface")]
public partial interface ClassWriterStrategy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassWriterStrategy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/jar/asm/ClassWriter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/jar/asm/ClassReader;)Lnet/bytebuddy/jar/asm/ClassWriter;"));
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/jar/asm/ClassWriter;", "public abstract")]
	Dova.JDK.net.bytebuddy.jar.asm.ClassWriter resolve(int arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassWriter>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/jar/asm/ClassReader;)Lnet/bytebuddy/jar/asm/ClassWriter;", "public abstract")]
	Dova.JDK.net.bytebuddy.jar.asm.ClassWriter resolve(int arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassWriter>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$FrameComputingClassWriter;", "public static")]
	public partial class FrameComputingClassWriter
		: Dova.JDK.net.bytebuddy.jar.asm.ClassWriter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FrameComputingClassWriter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$FrameComputingClassWriter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/pool/TypePool;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassReader;ILnet/bytebuddy/pool/TypePool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCommonSuperClass", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
		public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FrameComputingClassWriter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILnet/bytebuddy/pool/TypePool;)V", "public")]
		public FrameComputingClassWriter(int arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassReader;ILnet/bytebuddy/pool/TypePool;)V", "public")]
		public FrameComputingClassWriter(Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg0, int arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$FrameComputingClassWriter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String getCommonSuperClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;", "public abstract static")]
	public partial class Default
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_POOL_RETAINING", "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_POOL_DISCARDING", "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/jar/asm/ClassWriter;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default CONSTANT_POOL_RETAINING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default CONSTANT_POOL_DISCARDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$1;)V", "")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy$Default;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy.Default>(ret);
		}

		[JniSignatureAttribute("(ILnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/jar/asm/ClassWriter;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.ClassWriter resolve(int arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassWriter>(ret);
		}
	}
}
