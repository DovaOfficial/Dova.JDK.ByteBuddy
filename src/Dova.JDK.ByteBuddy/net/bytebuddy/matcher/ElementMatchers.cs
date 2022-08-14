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

namespace Dova.JDK.net.bytebuddy.matcher;

[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatchers;", "public final")]
public partial class ElementMatchers
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ElementMatchers()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/ElementMatchers;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isInterface", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isArray", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isPrimitive", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAnnotation", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isEnum", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isRecord", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMethod", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isConstructor", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNamed", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isStatic", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "annotationType", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "annotationType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "annotationType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSynthetic", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isPublic", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isProtected", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fieldType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fieldType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fieldType", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVarArgs", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMandated", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isBridge", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isFinal", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAbstract", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVolatile", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGetter", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGetter", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGetter", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGetter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGetter", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSetter", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSetter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSetter", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSetter", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSetter", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isPrivate", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isNative", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Ljava/lang/Object;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "is", "(Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "([Ljava/lang/reflect/Field;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "([Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "([Ljava/lang/reflect/Method;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "([Ljava/lang/Object;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "noneOf", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSynchronized", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isTransient", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isStrict", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cached", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/concurrent/ConcurrentMap;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "cached", "(Lnet/bytebuddy/matcher/ElementMatcher;I)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "not", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVirtual", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "named", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "any", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isBootstrapClassLoader", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isExtensionClassLoader", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameStartsWith", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "supportsModules", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "returns", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "returns", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "returns", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArgument", "(ILnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArgument", "(ILjava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArgument", "(ILnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasMethodName", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isTypeInitializer", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefaultMethod", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "targetsElement", "(Ljava/lang/annotation/ElementType;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArguments", "(Ljava/util/List;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArguments", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArguments", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArguments", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasAnnotation", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefaultFinalizer", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isHashCode", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isEquals", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isToString", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArguments", "(I)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArguments", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArguments", "(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArguments", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesArguments", "([Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVisibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVisibleTo", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAccessibleTo", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAccessibleTo", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isPackagePrivate", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "definedParameter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasGenericType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "none", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/lang/Object;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/lang/reflect/Method;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "anyOf", "([Ljava/lang/reflect/Field;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameEndsWithIgnoreCase", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameContainsIgnoreCase", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresGenericException", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresGenericException", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresGenericException", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresException", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresException", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOverriddenFrom", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOverriddenFrom", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOverriddenFrom", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOverriddenFromGeneric", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOverriddenFromGeneric", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isOverriddenFromGeneric", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefaultConstructor", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isMain", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isFinalizer", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isClone", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGenericSetter", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGenericSetter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGenericSetter", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGenericGetter", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGenericGetter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isGenericGetter", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasSignature", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSubTypeOf", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSubTypeOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSuperTypeOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSuperTypeOf", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasSuperClass", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasGenericSuperClass", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasSuperType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasGenericSuperType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inheritsAnnotation", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inheritsAnnotation", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "inheritsAnnotation", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresField", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresMethod", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "genericFieldType", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "genericFieldType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "genericFieldType", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSystemClassLoader", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isChildOf", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasChild", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namedOneOf", "([Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "namedIgnoreCase", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameEndsWith", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameContains", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameMatches", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasDescriptor", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDeclaredBy", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDeclaredBy", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDeclaredBy", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAnnotatedWith", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAnnotatedWith", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAnnotatedWith", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "declaresAnnotation", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "whereAny", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "whereNone", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasure", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasure", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasure", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasures", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasures", "(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasures", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "erasures", "([Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVariable", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isVariable", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "definedField", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "definedMethod", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canThrow", "(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "canThrow", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nameStartsWithIgnoreCase", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDeclaredByGeneric", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDeclaredByGeneric", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDeclaredByGeneric", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "returnsGeneric", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "returnsGeneric", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "returnsGeneric", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArgument", "(ILnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArgument", "(ILjava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesGenericArgument", "(ILnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "takesNoArguments", "()Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasParameters", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "failSafe", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSort", "(Lnet/bytebuddy/description/type/TypeDefinition$Sort;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSort", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isParentOf", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ElementMatchers(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ElementMatchers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/ElementMatchers;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isInterface()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isArray()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isPrimitive()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAnnotation()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isEnum()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isRecord()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isMethod()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isConstructor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isNamed()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isStatic()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction annotationType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction annotationType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction annotationType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSynthetic()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isPublic()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isProtected()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction fieldType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction fieldType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction fieldType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVarArgs()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isMandated()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isBridge()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isFinal()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAbstract()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVolatile()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGetter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGetter(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGetter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGetter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGetter()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSetter(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSetter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSetter(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSetter(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSetter()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isPrivate()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isNative()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction @is(Dova.JDK.java.lang.annotation.Annotation arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Field;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(JavaArray<Dova.JDK.java.lang.reflect.Field> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(JavaArray<Dova.JDK.java.lang.reflect.Constructor> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Method;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(JavaArray<Dova.JDK.java.lang.reflect.Method> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction noneOf(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSynchronized()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isTransient()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isStrict()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[55]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/concurrent/ConcurrentMap;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction cached(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.concurrent.ConcurrentMap arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;I)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction cached(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction not(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVirtual()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction named(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction any()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isBootstrapClassLoader()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isExtensionClassLoader()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameStartsWith(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction supportsModules()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction returns(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction returns(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction returns(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArgument(int arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArgument(int arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArgument(int arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasMethodName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isTypeInitializer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[73]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDefaultMethod()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[74]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/ElementType;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction targetsElement(Dova.JDK.java.lang.annotation.ElementType arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArguments(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArguments(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArguments(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArguments(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasAnnotation(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDefaultFinalizer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isHashCode()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[82]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isEquals()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[83]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isToString()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArguments(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArguments(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[86], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArguments(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[87], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArguments(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[88], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesArguments(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[89], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVisibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[90], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVisibleTo(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[91], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAccessibleTo(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[92], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAccessibleTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[93], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isPackagePrivate()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction ofType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[95], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction definedParameter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[96], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[97], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasGenericType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[98], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction none()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[99]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[100], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[101], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[102], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Method;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(JavaArray<Dova.JDK.java.lang.reflect.Method> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[103], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[104], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(JavaArray<Dova.JDK.java.lang.reflect.Constructor> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[105], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/reflect/Field;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction anyOf(JavaArray<Dova.JDK.java.lang.reflect.Field> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[106], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameEndsWithIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[107], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameContainsIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[108], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresGenericException(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[109], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresGenericException(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[110], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresGenericException(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[111], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresException(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[112], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresException(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[113], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isOverriddenFrom(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[114], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isOverriddenFrom(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[115], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isOverriddenFrom(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[116], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isOverriddenFromGeneric(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[117], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isOverriddenFromGeneric(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[118], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isOverriddenFromGeneric(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[119], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDefaultConstructor()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[120]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isMain()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[121]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isFinalizer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[122]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isClone()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[123]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGenericSetter(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[124], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGenericSetter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[125], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGenericSetter(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[126], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGenericGetter(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[127], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGenericGetter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[128], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isGenericGetter(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[129], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasSignature(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[130], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSubTypeOf(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[131], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSubTypeOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[132], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSuperTypeOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[133], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSuperTypeOf(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[134], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasSuperClass(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[135], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasGenericSuperClass(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[136], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasSuperType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[137], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasGenericSuperType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[138], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction inheritsAnnotation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[139], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction inheritsAnnotation(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[140], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction inheritsAnnotation(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[141], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresField(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[142], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresMethod(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[143], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction genericFieldType(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[144], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction genericFieldType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[145], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction genericFieldType(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[146], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isSystemClassLoader()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[147]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isChildOf(Dova.JDK.java.lang.ClassLoader arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[148], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasChild(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[149], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction namedOneOf(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[150], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction namedIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[151], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameEndsWith(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[152], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameContains(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[153], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameMatches(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[154], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasDescriptor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[155], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDeclaredBy(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[156], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDeclaredBy(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[157], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDeclaredBy(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[158], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAnnotatedWith(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[159], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAnnotatedWith(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[160], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isAnnotatedWith(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[161], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction declaresAnnotation(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[162], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction whereAny(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[163], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction whereNone(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[164], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasure(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[165], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasure(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[166], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasure(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[167], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasures(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[168], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasures(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[169], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasures(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[170], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction erasures(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[171], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVariable(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[172], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isVariable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[173], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction definedField(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[174], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction definedMethod(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[175], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction canThrow(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[176], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction canThrow(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[177], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction nameStartsWithIgnoreCase(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[178], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDeclaredByGeneric(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[179], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDeclaredByGeneric(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[180], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isDeclaredByGeneric(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[181], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction returnsGeneric(Dova.JDK.java.lang.reflect.Type arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[182], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction returnsGeneric(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[183], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction returnsGeneric(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[184], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArgument(int arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[185], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/reflect/Type;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArgument(int arg0, Dova.JDK.java.lang.reflect.Type arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[186], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(ILnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesGenericArgument(int arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[187], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction takesNoArguments()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[188]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction hasParameters(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[189], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction failSafe(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[190], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition$Sort;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction ofSort(Dova.JDK.net.bytebuddy.description.type.TypeDefinition.Sort arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[191], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction ofSort(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[192], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction isParentOf(Dova.JDK.java.lang.ClassLoader arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[193], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}
}
