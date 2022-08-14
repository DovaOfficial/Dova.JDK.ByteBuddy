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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/DecoratingDynamicTypeBuilder;", "public")]
public partial class DecoratingDynamicTypeBuilder
	: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DecoratingDynamicTypeBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/DecoratingDynamicTypeBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAttributeAppender", "Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asmVisitorWrapper", "Lnet/bytebuddy/asm/AsmVisitorWrapper;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypeNamingStrategy", "Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationRetention", "Lnet/bytebuddy/implementation/attribute/AnnotationRetention;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContextFactory", "Lnet/bytebuddy/implementation/Implementation$Context$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeValidation", "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classWriterStrategy", "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoredMethods", "Lnet/bytebuddy/matcher/LatentMatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypes", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suffix", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestHost", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsealed", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineRecordComponent", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender typeAttributeAppender_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper;", "private final")]
	public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper asmVisitorWrapper_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "private final")]
	public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy auxiliaryTypeNamingStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationRetention;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention annotationRetention_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Factory;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory implementationContextFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation typeValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy classWriterStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.LatentMatcher ignoredMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List auxiliaryTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DecoratingDynamicTypeBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "public")]
	public DecoratingDynamicTypeBuilder(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg4, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg5, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg6, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg7, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg8, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg9, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg10) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "protected")]
	public DecoratingDynamicTypeBuilder(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg1, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg2, Dova.JDK.net.bytebuddy.ClassFileVersion arg3, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg4, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg5, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg6, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg7, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg8, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg10, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg11, Dova.JDK.java.util.List arg12, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg13) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/DecoratingDynamicTypeBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder name(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder suffix(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder transform(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder merge(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable field(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder visit(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder attribute(Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestHost(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder topLevelType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType innerTypeOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder unsealed()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition invokable(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional defineRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription toTypeDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}
}
