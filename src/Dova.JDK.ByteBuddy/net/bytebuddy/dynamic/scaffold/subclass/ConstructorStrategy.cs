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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;", "public abstract interface")]
public partial interface ConstructorStrategy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConstructorStrategy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractConstructors", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List extractConstructors(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry inject(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$ForDefaultConstructor;", "public static")]
	public partial class ForDefaultConstructor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForDefaultConstructor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$ForDefaultConstructor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementMatcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractConstructors", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher elementMatcher_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory methodAttributeAppenderFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForDefaultConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V", "public")]
		public ForDefaultConstructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V", "public")]
		public ForDefaultConstructor(Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
		public ForDefaultConstructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ForDefaultConstructor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$ForDefaultConstructor;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List extractConstructors(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry inject(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public abstract static")]
	public partial class Default
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_CONSTRUCTORS", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_CONSTRUCTOR", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMITATE_SUPER_CLASS", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMITATE_SUPER_CLASS_PUBLIC", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMITATE_SUPER_CLASS_OPENING", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doInject", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractConstructors", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInheritedAnnotations", "()Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doExtractConstructors", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveModifier", "(I)I"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default NO_CONSTRUCTORS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default DEFAULT_CONSTRUCTOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default IMITATE_SUPER_CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default IMITATE_SUPER_CLASS_PUBLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default IMITATE_SUPER_CLASS_OPENING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
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

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$1;)V", "")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy with(Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry doInject(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List extractConstructors(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry inject(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy withInheritedAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;", "protected abstract")]
		public Dova.JDK.java.util.List doExtractConstructors(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(I)I", "protected")]
		public int resolveModifier(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default$WithMethodAttributeAppenderFactory;", "protected static")]
		public partial class WithMethodAttributeAppenderFactory
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WithMethodAttributeAppenderFactory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default$WithMethodAttributeAppenderFactory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractConstructors", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default @delegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory methodAttributeAppenderFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public WithMethodAttributeAppenderFactory(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)V", "protected")]
			public WithMethodAttributeAppenderFactory(Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy.Default arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy$Default$WithMethodAttributeAppenderFactory;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List extractConstructors(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry inject(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
			}
		}
	}
}
