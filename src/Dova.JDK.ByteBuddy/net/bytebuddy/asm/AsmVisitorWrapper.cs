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

[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper;", "public abstract interface")]
public partial interface AsmVisitorWrapper
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AsmVisitorWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_FLAGS", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWriter", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeReader", "(I)I"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int NO_FLAGS_Property
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "public abstract")]
	Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	int mergeWriter(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public abstract")]
	int mergeReader(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asmVisitorWrappers", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/asm/AsmVisitorWrapper;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWriter", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeReader", "(I)I"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List asmVisitorWrappers_Property
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
		public Compound(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/asm/AsmVisitorWrapper;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$Compound;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public static")]
	public partial class ForDeclaredMethods
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForDeclaredMethods()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writerFlags", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerFlags", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constructor", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constructor", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writerFlags", "(I)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readerFlags", "(I)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWriter", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeReader", "(I)I"));
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

		[JniSignatureAttribute("I", "private final")]
		public int writerFlags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int readerFlags_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForDeclaredMethods(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForDeclaredMethods() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;II)V", "protected")]
		public ForDeclaredMethods(Dova.JDK.java.util.List arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods method(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods method(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods.MethodVisitorWrapper> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods constructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods.MethodVisitorWrapper> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods constructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;)Ljava/util/List;", "static")]
		public static Dova.JDK.java.util.List access_100(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods invokable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods invokable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods.MethodVisitorWrapper> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods writerFlags(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods readerFlags(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int mergeWriter(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int mergeReader(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$DispatchingVisitor;", "protected")]
		public partial class DispatchingVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DispatchingVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$DispatchingVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContext", "Lnet/bytebuddy/implementation/Implementation$Context;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writerFlags", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerFlags", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;II)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Context implementationContext_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int writerFlags_Property
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
			public int readerFlags_Property
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

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map methods_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "final")]
			public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DispatchingVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;II)V", "protected")]
			public DispatchingVisitor(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, Dova.JDK.java.util.Map arg5, int arg6, int arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$DispatchingVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$Entry;", "protected static")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.matcher.ElementMatcher
			, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods.MethodVisitorWrapper
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodVisitorWrappers", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/method/MethodDescription;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List methodVisitorWrappers_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)V", "protected")]
			public Entry(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$Entry;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, int arg5, int arg6)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Z", "public")]
			public bool matches(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool matches(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;", "public abstract static interface")]
		public partial interface MethodVisitorWrapper
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodVisitorWrapper()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods$MethodVisitorWrapper;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public abstract")]
			Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, int arg5, int arg6)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;", "public static")]
	public partial class ForDeclaredFields
		: Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForDeclaredFields()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$FieldVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;)Ljava/util/List;"));
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
		public ForDeclaredFields(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForDeclaredFields() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
		public ForDeclaredFields(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields field(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$FieldVisitorWrapper;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields field(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields.FieldVisitorWrapper> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;)Ljava/util/List;", "static")]
		public static Dova.JDK.java.util.List access_000(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$DispatchingVisitor;", "protected")]
		public partial class DispatchingVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DispatchingVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$DispatchingVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map fields_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;", "final")]
			public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DispatchingVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V", "protected")]
			public DispatchingVisitor(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$DispatchingVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$Entry;", "protected static")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.matcher.ElementMatcher
			, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields.FieldVisitorWrapper
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldVisitorWrappers", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/jar/asm/FieldVisitor;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List fieldVisitorWrappers_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)V", "protected")]
			public Entry(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$Entry;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/jar/asm/FieldVisitor;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Z", "public")]
			public bool matches(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool matches(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$FieldVisitorWrapper;", "public abstract static interface")]
		public partial interface FieldVisitorWrapper
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldVisitorWrapper()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredFields$FieldVisitorWrapper;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/jar/asm/FieldVisitor;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/jar/asm/FieldVisitor;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public abstract")]
			Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWriter", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeReader", "(I)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)I", "public")]
		public int mergeWriter(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int mergeReader(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeWriter", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mergeReader", "(I)I"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public NoOp(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/AsmVisitorWrapper$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.NoOp>(ret);
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
	}
}
