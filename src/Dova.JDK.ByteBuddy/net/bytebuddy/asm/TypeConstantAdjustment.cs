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

namespace Dova.JDK.net.bytebuddy.asm;

[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeConstantAdjustment;", "public final")]
public partial class TypeConstantAdjustment
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeConstantAdjustment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeConstantAdjustment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/TypeConstantAdjustment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/TypeConstantAdjustment;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/TypeConstantAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/TypeConstantAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWriter", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeReader", "(I)I"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeConstantAdjustment;", "public static final")]
	public static Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/asm/TypeConstantAdjustment;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeConstantAdjustment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public TypeConstantAdjustment(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeConstantAdjustment;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/asm/TypeConstantAdjustment;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/TypeConstantAdjustment;", "public static")]
	public static Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeConstantAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int mergeWriter(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int mergeReader(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeConstantAdjustment$TypeConstantDissolvingClassVisitor;", "protected static")]
	public partial class TypeConstantDissolvingClassVisitor
		: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeConstantDissolvingClassVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeConstantAdjustment$TypeConstantDissolvingClassVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "supportsTypeConstants", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool supportsTypeConstants_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeConstantDissolvingClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;)V", "protected")]
		public TypeConstantDissolvingClassVisitor(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeConstantAdjustment$TypeConstantDissolvingClassVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
		public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeConstantAdjustment$TypeConstantDissolvingClassVisitor$TypeConstantDissolvingMethodVisitor;", "protected static")]
		public partial class TypeConstantDissolvingMethodVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeConstantDissolvingMethodVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeConstantAdjustment$TypeConstantDissolvingClassVisitor$TypeConstantDissolvingMethodVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_LANG_CLASS", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_NAME", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DESCRIPTOR", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String JAVA_LANG_CLASS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String FOR_NAME_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String DESCRIPTOR_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeConstantDissolvingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "protected")]
			public TypeConstantDissolvingMethodVisitor(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeConstantAdjustment$TypeConstantDissolvingClassVisitor$TypeConstantDissolvingMethodVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}
		}
	}
}
