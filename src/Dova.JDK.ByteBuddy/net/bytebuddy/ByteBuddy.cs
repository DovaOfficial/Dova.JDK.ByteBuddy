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

namespace Dova.JDK.net.bytebuddy;

[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy;", "public")]
public partial class ByteBuddy
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ByteBuddy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_NAMING_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE_BUDDY_DEFAULT_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE_BUDDY_DEFAULT_SUFFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE_BUDDY_DEFAULT_CONTEXT_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_NAMING_STRATEGY", "Lnet/bytebuddy/NamingStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_AUXILIARY_NAMING_STRATEGY", "Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_IMPLEMENTATION_CONTEXT_FACTORY", "Lnet/bytebuddy/implementation/Implementation$Context$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namingStrategy", "Lnet/bytebuddy/NamingStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypeNamingStrategy", "Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationRetention", "Lnet/bytebuddy/implementation/attribute/AnnotationRetention;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContextFactory", "Lnet/bytebuddy/implementation/Implementation$Context$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedTypeFactory", "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoredMethods", "Lnet/bytebuddy/matcher/LatentMatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeValidation", "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibilityBridgeStrategy", "Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classWriterStrategy", "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/ClassFileVersion;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/NamingStrategy;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignore", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignore", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/TypeValidation;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/Implementation$Context$Factory;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/attribute/AnnotationRetention;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/NamingStrategy;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)Lnet/bytebuddy/ByteBuddy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Ljava/lang/Class;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInterface", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInterface", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInterface", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInterface", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInterface", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeInterface", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePackage", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeRecord", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeAnnotation", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeEnumeration", "([Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeEnumeration", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefine", "(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefine", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefine", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Lnet/bytebuddy/description/type/PackageDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Ljava/lang/Package;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rebase", "(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decorate", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decorate", "(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decorate", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_NAMING_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String BYTE_BUDDY_DEFAULT_PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String BYTE_BUDDY_DEFAULT_SUFFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String BYTE_BUDDY_DEFAULT_CONTEXT_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/NamingStrategy;", "private static final")]
	public static Dova.JDK.net.bytebuddy.NamingStrategy DEFAULT_NAMING_STRATEGY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.NamingStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;", "private static final")]
	public static Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy DEFAULT_AUXILIARY_NAMING_STRATEGY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Factory;", "private static final")]
	public static Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory DEFAULT_IMPLEMENTATION_CONTEXT_FACTORY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "protected final")]
	public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/NamingStrategy;", "protected final")]
	public Dova.JDK.net.bytebuddy.NamingStrategy namingStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.NamingStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy auxiliaryTypeNamingStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationRetention;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention annotationRetention_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory implementationContextFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory instrumentedTypeFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "protected final")]
	public Dova.JDK.net.bytebuddy.matcher.LatentMatcher ignoredMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation typeValidation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy visibilityBridgeStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy classWriterStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool ACCESS_CONTROLLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ByteBuddy(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;)V", "public")]
	public ByteBuddy(Dova.JDK.net.bytebuddy.ClassFileVersion arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ByteBuddy() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/NamingStrategy;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;)V", "protected")]
	public ByteBuddy(Dova.JDK.net.bytebuddy.ClassFileVersion arg0, Dova.JDK.net.bytebuddy.NamingStrategy arg1, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg2, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg3, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg4, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg5, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg6, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory arg7, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg8, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg10, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg11) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy;";
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

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy ignore(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy ignore(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeValidation;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.ClassFileVersion arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Context$Factory;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationRetention;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/NamingStrategy;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.NamingStrategy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)Lnet/bytebuddy/ByteBuddy;", "public")]
	public Dova.JDK.net.bytebuddy.ByteBuddy with(Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder subclass(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder subclass(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/subclass/ConstructorStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder subclass(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder subclass(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder subclass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder subclass(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeInterface()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeInterface(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeInterface(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeInterface(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeInterface(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeInterface(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makePackage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeRecord()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeAnnotation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeEnumeration(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder makeEnumeration(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder redefine(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder redefine(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder redefine(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/PackageDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.net.bytebuddy.description.type.PackageDescription arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Package;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.java.lang.Package arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder rebase(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder decorate(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder decorate(Dova.JDK.java.lang.Class arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder decorate(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "protected static final")]
	public partial class RecordObjectMethod
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RecordObjectMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HASH_CODE", "Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQUALS", "Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TO_STRING", "Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arguments", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Class;[Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "public static final")]
		public static Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod HASH_CODE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "public static final")]
		public static Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod EQUALS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "public static final")]
		public static Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod TO_STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription returnType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List arguments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RecordObjectMethod(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Class;[Ljava/lang/Class;)V", "private transient")]
		public RecordObjectMethod(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg3, Dova.JDK.java.lang.Class arg4, JavaArray<Dova.JDK.java.lang.Class> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/ByteBuddy$RecordObjectMethod;", "public static")]
		public static Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy.RecordObjectMethod>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;", "protected static final")]
	public partial class RecordConstructorStrategy
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.ConstructorStrategy
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RecordConstructorStrategy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extractConstructors", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;", "public static final")]
		public static Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RecordConstructorStrategy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public RecordConstructorStrategy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy;", "public static")]
		public static Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy.RecordConstructorStrategy>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List extractConstructors(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;)Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry inject(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy$Appender;", "protected static")]
		public partial class Appender
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Appender()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy$Appender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public Appender(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy$RecordConstructorStrategy$Appender;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$EnumerationImplementation;", "protected static")]
	public partial class EnumerationImplementation
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EnumerationImplementation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy$EnumerationImplementation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLONE_METHOD_NAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_VALUE_OF_METHOD_NAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_VALUES_METHOD_NAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_FIELD_MODIFIERS", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_VALUES", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
		public static Dova.JDK.java.lang.String CLONE_METHOD_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
		public static Dova.JDK.java.lang.String ENUM_VALUE_OF_METHOD_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
		public static Dova.JDK.java.lang.String ENUM_VALUES_METHOD_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int ENUM_FIELD_MODIFIERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String ENUM_VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List values_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EnumerationImplementation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
		public EnumerationImplementation(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy$EnumerationImplementation;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$EnumerationImplementation$InitializationAppender;", "protected static")]
		public partial class InitializationAppender
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InitializationAppender()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy$EnumerationImplementation$InitializationAppender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List values_Property
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
			public InitializationAppender(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
			public InitializationAppender(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy$EnumerationImplementation$InitializationAppender;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy$EnumerationImplementation$ValuesMethodAppender;", "protected static")]
		public partial class ValuesMethodAppender
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ValuesMethodAppender()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/ByteBuddy$EnumerationImplementation$ValuesMethodAppender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ValuesMethodAppender(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ValuesMethodAppender(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/ByteBuddy$EnumerationImplementation$ValuesMethodAppender;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
			}
		}
	}
}
