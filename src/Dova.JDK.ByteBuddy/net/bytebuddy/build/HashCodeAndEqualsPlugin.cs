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

namespace Dova.JDK.net.bytebuddy.build;

[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin;", "public")]
public partial class HashCodeAndEqualsPlugin
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.build.Plugin
	, Dova.JDK.net.bytebuddy.build.Plugin.Factory
	, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory
	, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HashCodeAndEqualsPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_INVOKE_SUPER", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_SIMPLE_COMPARISON_FIRST", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_INCLUDE_SYNTHETIC_FIELDS", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_PERMIT_SUBCLASS_EQUALITY", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_USE_TYPE_HASH_CONSTANT", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALUE_HANDLING_VALUE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SORTED_VALUE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nonNullable", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_INVOKE_SUPER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_SIMPLE_COMPARISON_FIRST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_INCLUDE_SYNTHETIC_FIELDS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_PERMIT_SUBCLASS_EQUALITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_USE_TYPE_HASH_CONSTANT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape VALUE_HANDLING_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape SORTED_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String annotationType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HashCodeAndEqualsPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HashCodeAndEqualsPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public HashCodeAndEqualsPlugin(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
	public bool matches(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
	public bool matches(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
	public void apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
	public Dova.JDK.net.bytebuddy.build.Plugin make()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_100()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_200()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher;", "protected")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher nonNullable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueMatcher;", "protected static")]
	public partial class ValueMatcher
		: Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction.ForNonNullValues
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValueMatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueMatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sort", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch", "(Lnet/bytebuddy/description/field/FieldDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch", "(Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "private final")]
		public Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort sort_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValueMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;)V", "protected")]
		public ValueMatcher(Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueMatcher;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Z", "protected")]
		public bool doMatch(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "protected volatile")]
		public bool doMatch(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;", "protected static final")]
	public partial class AnnotationOrderComparator
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.java.util.Comparator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotationOrderComparator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compare", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;", "public static final")]
		public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotationOrderComparator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public AnnotationOrderComparator(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "public volatile")]
		public int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)I", "public")]
		public int compare(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$AnnotationOrderComparator;", "public static")]
		public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.AnnotationOrderComparator>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Sorted;", "public abstract static interface")]
	public partial interface Sorted
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Sorted()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Sorted;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int DEFAULT_Property
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

		[JniSignatureAttribute("()I", "public abstract")]
		int value()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling;", "public abstract static interface")]
	public partial interface ValueHandling
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValueHandling()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort value()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "public static final")]
		public partial class Sort
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Sort()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REVERSE_NULLABILITY", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort IGNORE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort REVERSE_NULLABILITY_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Sort(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Sort(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$ValueHandling$Sort;", "public static")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.ValueHandling.Sort>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance;", "public abstract static interface")]
	public partial interface Enhance
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Enhance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "includeSyntheticFields", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeSuper", "()Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "simpleComparisonsFirst", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permitSubclassEquality", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "useTypeHashConstant", "()Z"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool includeSyntheticFields()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper invokeSuper()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool simpleComparisonsFirst()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool permitSubclassEquality()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool useTypeHashConstant()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public abstract static")]
		public partial class InvokeSuper
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InvokeSuper()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_DECLARED", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF_ANNOTATED", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALWAYS", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEVER", "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/build/HashCodeAndEqualsPlugin$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCodeMethod", "(Lnet/bytebuddy/description/type/TypeDescription;ZZ)Lnet/bytebuddy/implementation/HashCodeMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equalsMethod", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/EqualsMethod;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper IF_DECLARED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper IF_ANNOTATED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper ALWAYS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper NEVER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InvokeSuper(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public InvokeSuper(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/build/HashCodeAndEqualsPlugin$1;)V", "")]
			public InvokeSuper(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$Enhance$InvokeSuper;", "public static")]
			public static Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin.Enhance.InvokeSuper>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;ZZ)Lnet/bytebuddy/implementation/HashCodeMethod;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.implementation.HashCodeMethod hashCodeMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, bool arg1, bool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.HashCodeMethod>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/EqualsMethod;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.implementation.EqualsMethod equalsMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.EqualsMethod>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$WithNonNullableFields;", "public static")]
	public partial class WithNonNullableFields
		: Dova.JDK.net.bytebuddy.build.HashCodeAndEqualsPlugin
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithNonNullableFields()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$WithNonNullableFields;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nonNullable", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithNonNullableFields(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public WithNonNullableFields() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public WithNonNullableFields(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/HashCodeAndEqualsPlugin$WithNonNullableFields;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool matches(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher;", "protected")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher nonNullable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
		}
	}
}
