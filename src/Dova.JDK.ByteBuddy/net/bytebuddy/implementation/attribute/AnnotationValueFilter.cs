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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public abstract interface")]
public partial interface AnnotationValueFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationValueFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRelevant", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Z"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Z", "public abstract")]
	bool isRelevant(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;", "public abstract static")]
	public partial class Default
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter
		, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP_DEFAULTS", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPEND_DEFAULTS", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/attribute/AnnotationValueFilter$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default SKIP_DEFAULTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default APPEND_DEFAULTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default>>(ret);
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

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/attribute/AnnotationValueFilter$1;)V", "")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Default;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Default>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "public abstract static interface")]
	public partial interface Factory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter on(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter>(ret);
		}
	}
}
