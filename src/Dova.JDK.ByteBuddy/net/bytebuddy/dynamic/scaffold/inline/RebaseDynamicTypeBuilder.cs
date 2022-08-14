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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold.inline;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseDynamicTypeBuilder;", "public")]
public partial class RebaseDynamicTypeBuilder
	: Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.AbstractInliningDynamicTypeBuilder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RebaseDynamicTypeBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseDynamicTypeBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodNameTransformer", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer methodNameTransformer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RebaseDynamicTypeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V", "public")]
	public RebaseDynamicTypeBuilder(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg4, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg5, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg6, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg7, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg8, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg9, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg10, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg11, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg12, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg13) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V", "protected")]
	public RebaseDynamicTypeBuilder(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg8, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg12, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg13, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg14, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg15, Dova.JDK.java.util.List arg16, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg17, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg18, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg19) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/RebaseDynamicTypeBuilder;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg8, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg12, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg13, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg14, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg15, Dova.JDK.java.util.List arg16)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}
}
