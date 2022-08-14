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

namespace Dova.JDK.net.bytebuddy.implementation.attribute;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public abstract interface")]
public partial interface FieldAttributeAppender
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldAttributeAppender()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public abstract")]
	void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAttributeAppenders", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List fieldAttributeAppenders_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Compound;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Explicit;", "public static")]
	public partial class Explicit
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Explicit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Explicit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List annotations_Property
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
		public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Explicit(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Explicit;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;", "public static final")]
	public partial class ForInstrumentedField
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForInstrumentedField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForInstrumentedField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ForInstrumentedField(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$ForInstrumentedField;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.ForInstrumentedField>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;", "public abstract static interface")]
	public partial interface Factory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory$Compound;", "public static")]
		public partial class Compound
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compound()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory$Compound;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factories", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List factories_Property
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

			[JniSignatureAttribute("([Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)V", "public transient")]
			public Compound(JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
			public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory$Compound;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender
		, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.NoOp>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/FieldVisitor;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
		}
	}
}
