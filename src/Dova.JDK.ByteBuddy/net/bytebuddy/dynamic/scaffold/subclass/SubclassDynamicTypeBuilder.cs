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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassDynamicTypeBuilder;", "public")]
public partial class SubclassDynamicTypeBuilder
	: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SubclassDynamicTypeBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassDynamicTypeBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructorStrategy", "Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyConstructorStrategy", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy constructorStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SubclassDynamicTypeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)V", "public")]
	public SubclassDynamicTypeBuilder(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg4, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg5, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg6, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg7, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg8, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg9, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy arg11) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)V", "protected")]
	public SubclassDynamicTypeBuilder(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg8, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg12, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg13, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg14, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg15, Dova.JDK.java.util.List arg16, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy arg17) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassDynamicTypeBuilder;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg8, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg12, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg13, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg14, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg15, Dova.JDK.java.util.List arg16)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "private")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType applyConstructorStrategy(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassDynamicTypeBuilder$InstrumentableMatcher;", "protected static")]
	public partial class InstrumentableMatcher
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InstrumentableMatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassDynamicTypeBuilder$InstrumentableMatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoredMethods", "Lnet/bytebuddy/matcher/LatentMatcher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/LatentMatcher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.LatentMatcher ignoredMethods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InstrumentableMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)V", "protected")]
		public InstrumentableMatcher(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassDynamicTypeBuilder$InstrumentableMatcher;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;", "public")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
		}
	}
}
