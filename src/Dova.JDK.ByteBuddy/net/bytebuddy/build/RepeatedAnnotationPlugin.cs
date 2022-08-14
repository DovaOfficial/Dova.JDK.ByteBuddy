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

[JniSignatureAttribute("Lnet/bytebuddy/build/RepeatedAnnotationPlugin;", "public")]
public partial class RepeatedAnnotationPlugin
	: Dova.JDK.net.bytebuddy.build.Plugin.ForElementMatcher
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RepeatedAnnotationPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/RepeatedAnnotationPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALUE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape VALUE_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RepeatedAnnotationPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RepeatedAnnotationPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/RepeatedAnnotationPlugin;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/RepeatedAnnotationPlugin$RepeatedAnnotationAppender;", "protected static")]
	public partial class RepeatedAnnotationAppender
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RepeatedAnnotationAppender()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/RepeatedAnnotationPlugin$RepeatedAnnotationAppender;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lnet/bytebuddy/description/type/TypeDescription;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription target_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RepeatedAnnotationAppender(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
		public RepeatedAnnotationAppender(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/RepeatedAnnotationPlugin$RepeatedAnnotationAppender;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter;)V", "public")]
		public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/RepeatedAnnotationPlugin$Enhance;", "public abstract static interface")]
	public partial interface Enhance
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Enhance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/RepeatedAnnotationPlugin$Enhance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public abstract")]
		Dova.JDK.java.lang.Class value()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}
}
