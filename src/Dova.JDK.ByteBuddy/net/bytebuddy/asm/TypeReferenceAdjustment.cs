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

[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment;", "public")]
public partial class TypeReferenceAdjustment
	: Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeReferenceAdjustment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeReferenceAdjustment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strict", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLnet/bytebuddy/matcher/ElementMatcher$Junction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/TypeReferenceAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "strict", "()Lnet/bytebuddy/asm/TypeReferenceAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "relaxed", "()Lnet/bytebuddy/asm/TypeReferenceAdjustment;"));
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool strict_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeReferenceAdjustment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ZLnet/bytebuddy/matcher/ElementMatcher$Junction;)V", "protected")]
	public TypeReferenceAdjustment(bool arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeReferenceAdjustment;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/TypeReferenceAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment filter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/asm/TypeReferenceAdjustment;", "public static")]
	public static Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment strict()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/asm/TypeReferenceAdjustment;", "public static")]
	public static Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment relaxed()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;", "protected static")]
	public partial class TypeReferenceClassVisitor
		: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeReferenceClassVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_ANNOTATION", "Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_FIELD", "Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_METHOD", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strict", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Lnet/bytebuddy/matcher/ElementMatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "observedTypes", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visitedInnerTypes", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;ZLnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/pool/TypePool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/jar/asm/Handle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/jar/asm/ConstantDynamic;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/jar/asm/Type;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOuterClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMember", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecordComponent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;)Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "observeInternalName", "(Ljava/lang/String;)V"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "private static final")]
		public static Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor IGNORE_ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldVisitor;", "private static final")]
		public static Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor IGNORE_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private static final")]
		public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor IGNORE_METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool strict_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher filter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
		public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set observedTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set visitedInnerTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeReferenceClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;ZLnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/pool/TypePool;)V", "protected")]
		public TypeReferenceClassVisitor(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, bool arg1, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Handle;)V", "protected")]
		public void resolve(Dova.JDK.net.bytebuddy.jar.asm.Handle arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ConstantDynamic;)V", "protected")]
		public void resolve(Dova.JDK.net.bytebuddy.jar.asm.ConstantDynamic arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
		public void resolve(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Type;)V", "protected")]
		public void resolve(Dova.JDK.net.bytebuddy.jar.asm.Type arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
		public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void visitEnd()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
		}

		[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void visitNestHost(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public void visitOuterClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void visitNestMember(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "public")]
		public void visitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor visitRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;)Ljava/util/Set;", "static")]
		public static Dova.JDK.java.util.Set access_000(Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "static")]
		public static Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor access_100()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Ljava/lang/String;)V", "static")]
		public static void access_200(Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor arg0, Dova.JDK.java.lang.String arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public void observeInternalName(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceMethodVisitor;", "protected")]
		public partial class TypeReferenceMethodVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeReferenceMethodVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceMethodVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeInsn", "(ILjava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLdcInsn", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotation", "(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamicInsn", "(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMultiANewArrayInsn", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInsnAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTryCatchBlock", "(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTryCatchAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;[Lnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;[ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;", "final")]
			public Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeReferenceMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "protected")]
			public TypeReferenceMethodVisitor(Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceMethodVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
			public void visitFieldInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
			public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			}

			[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
			public void visitTypeInsn(int arg0, Dova.JDK.java.lang.String arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
			public void visitLdcInsn(Dova.JDK.java.lang.Object arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotationDefault()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitParameterAnnotation(int arg0, Dova.JDK.java.lang.String arg1, bool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Handle;[Ljava/lang/Object;)V", "public transient")]
			public void visitInvokeDynamicInsn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.jar.asm.Handle arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
			public void visitMultiANewArrayInsn(Dova.JDK.java.lang.String arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitInsnAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;Ljava/lang/String;)V", "public")]
			public void visitTryCatchBlock(Dova.JDK.net.bytebuddy.jar.asm.Label arg0, Dova.JDK.net.bytebuddy.jar.asm.Label arg1, Dova.JDK.net.bytebuddy.jar.asm.Label arg2, Dova.JDK.java.lang.String arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTryCatchAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;[Lnet/bytebuddy/jar/asm/Label;[Lnet/bytebuddy/jar/asm/Label;[ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitLocalVariableAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg2, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg3, JavaArray<int> arg4, Dova.JDK.java.lang.String arg5, bool arg6)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceFieldVisitor;", "protected")]
		public partial class TypeReferenceFieldVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeReferenceFieldVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceFieldVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Lnet/bytebuddy/jar/asm/FieldVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;", "final")]
			public Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeReferenceFieldVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Lnet/bytebuddy/jar/asm/FieldVisitor;)V", "protected")]
			public TypeReferenceFieldVisitor(Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceFieldVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceAnnotationVisitor;", "protected")]
		public partial class TypeReferenceAnnotationVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeReferenceAnnotationVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceAnnotationVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Lnet/bytebuddy/jar/asm/AnnotationVisitor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArray", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;", "final")]
			public Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeReferenceAnnotationVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor;Lnet/bytebuddy/jar/asm/AnnotationVisitor;)V", "protected")]
			public TypeReferenceAnnotationVisitor(Dova.JDK.net.bytebuddy.asm.TypeReferenceAdjustment.TypeReferenceClassVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/TypeReferenceAdjustment$TypeReferenceClassVisitor$TypeReferenceAnnotationVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
			public void visit(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
			public void visitEnum(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitArray(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}
		}
	}
}
