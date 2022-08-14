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

[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberAttributeExtension;", "public abstract")]
public partial class MemberAttributeExtension
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemberAttributeExtension()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberAttributeExtension;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributeAppenderFactory", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "protected final")]
	public Dova.JDK.java.lang.Object attributeAppenderFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MemberAttributeExtension(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Ljava/lang/Object;)V", "protected")]
	public MemberAttributeExtension(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberAttributeExtension;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public static")]
	public partial class ForMethod
		: Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension
		, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods.MethodVisitorWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/AsmVisitorWrapper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/List;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/Collection;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(I[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/Collection;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(I[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/List;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForMethod(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V", "protected")]
		public ForMethod(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
		public ForMethod(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForMethod() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, int arg5, int arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/AsmVisitorWrapper;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper on(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod attribute(Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateMethod(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateMethod(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateMethod(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateMethod(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("(I[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateParameter(int arg0, JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("(ILjava/util/Collection;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateParameter(int arg0, Dova.JDK.java.util.Collection arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("(I[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateParameter(int arg0, JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("(ILjava/util/List;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod annotateParameter(int arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForMethod>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod$AttributeAppendingMethodVisitor;", "private static")]
		public partial class AttributeAppendingMethodVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AttributeAppendingMethodVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod$AttributeAppendingMethodVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppender", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilter", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "applicable", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;Lnet/bytebuddy/asm/MemberAttributeExtension$1;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCode", "()V"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender methodAttributeAppender_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter annotationValueFilter_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private")]
			public bool applicable_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AttributeAppendingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;Lnet/bytebuddy/asm/MemberAttributeExtension$1;)V", "")]
			public AttributeAppendingMethodVisitor(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg3, Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "private")]
			public AttributeAppendingMethodVisitor(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberAttributeExtension$ForMethod$AttributeAppendingMethodVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void visitEnd()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("()V", "public")]
			public void visitCode()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;", "public static")]
	public partial class ForField
		: Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension
		, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredFields.FieldVisitorWrapper
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/jar/asm/FieldVisitor;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/AsmVisitorWrapper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "(Ljava/util/List;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotate", "(Ljava/util/Collection;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)V", "protected")]
		public ForField(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
		public ForField(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForField() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/jar/asm/FieldVisitor;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/AsmVisitorWrapper;", "public")]
		public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper on(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField attribute(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField annotate(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField annotate(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField annotate(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/asm/MemberAttributeExtension$ForField;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField annotate(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension.ForField>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberAttributeExtension$ForField$FieldAttributeVisitor;", "private static")]
		public partial class FieldAttributeVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldAttributeVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberAttributeExtension$ForField$FieldAttributeVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAttributeAppender", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilter", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;Lnet/bytebuddy/asm/MemberAttributeExtension$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender fieldAttributeAppender_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter annotationValueFilter_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldAttributeVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "private")]
			public FieldAttributeVisitor(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;Lnet/bytebuddy/asm/MemberAttributeExtension$1;)V", "")]
			public FieldAttributeVisitor(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg3, Dova.JDK.net.bytebuddy.asm.MemberAttributeExtension arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberAttributeExtension$ForField$FieldAttributeVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void visitEnd()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}
		}
	}
}
