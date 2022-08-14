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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public abstract interface")]
public partial interface RecordComponentAttributeAppender
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RecordComponentAttributeAppender()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public abstract")]
	void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentAttributeAppenders", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List recordComponentAttributeAppenders_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Compound;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Explicit;", "public static")]
	public partial class Explicit
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Explicit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Explicit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Explicit;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;", "public static final")]
	public partial class ForInstrumentedRecordComponent
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForInstrumentedRecordComponent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForInstrumentedRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ForInstrumentedRecordComponent(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$ForInstrumentedRecordComponent;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.ForInstrumentedRecordComponent>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;", "public abstract static interface")]
	public partial interface Factory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory$Compound;", "public static")]
		public partial class Compound
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compound()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory$Compound;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factories", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
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

			[JniSignatureAttribute("([Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)V", "public transient")]
			public Compound(JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
			public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory$Compound;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender
		, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.NoOp>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/RecordComponentVisitor;Lnet/bytebuddy/description/type/RecordComponentDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender>(ret);
		}
	}
}
