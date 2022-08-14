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

namespace Dova.JDK.net.bytebuddy.implementation;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
public partial class MethodDelegation
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodDelegation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationDelegate", "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterBinders", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ambiguityResolver", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminationHandler", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindingResolver", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "to", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withEmptyConfiguration", "()Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toConstructor", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toConstructor", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toMethodReturnOf", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toMethodReturnOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withDefaultConfiguration", "()Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate implementationDelegate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List parameterBinders_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver ambiguityResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler terminationHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver bindingResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodDelegation(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)V", "protected")]
	public MethodDelegation(Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg2, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)V", "private")]
	public MethodDelegation(Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg2, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation;";
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

	[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withEmptyConfiguration()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toConstructor(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toConstructor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toMethodReturnOf(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation toMethodReturnOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withDefaultConfiguration()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public static")]
	public partial class WithCustomProperties
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithCustomProperties()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ambiguityResolver", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterBinders", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindingResolver", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Ljava/util/List;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "to", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBindingResolver", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withResolvers", "(Ljava/util/List;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withResolvers", "([Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBinders", "([Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBinders", "(Ljava/util/List;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toConstructor", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toConstructor", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMethodReturnOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMethodReturnOf", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver ambiguityResolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List parameterBinders_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver bindingResolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithCustomProperties(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Ljava/util/List;)V", "protected")]
		public WithCustomProperties(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;Lnet/bytebuddy/matcher/ElementMatcher;)V", "private")]
		public WithCustomProperties(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg2, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation to(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties filter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withBindingResolver(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withResolvers(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withResolvers(JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withBinders(JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/implementation/MethodDelegation$WithCustomProperties;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties withBinders(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.WithCustomProperties>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toField(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toConstructor(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toConstructor(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toMethodReturnOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodDelegation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation toMethodReturnOf(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$Appender;", "protected static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$Appender;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationTarget", "Lnet/bytebuddy/implementation/Implementation$Target;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "processor", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminationHandler", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "compiled", "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Target implementationTarget_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record processor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler terminationHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled compiled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;)V", "protected")]
		public Appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg3, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$Appender;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;", "protected abstract static interface")]
	public partial interface ImplementationDelegate
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImplementationDelegate()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_NAME_PREFIX", "Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String FIELD_NAME_PREFIX_Property
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForConstruction;", "public static")]
		public partial class ForConstruction
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForConstruction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForConstruction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
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

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List records_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForConstruction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
			public ForConstruction(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForConstruction;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;", "protected static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodList arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForMethodReturn;", "public static")]
		public partial class ForMethodReturn
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodReturn()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForMethodReturn;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterBinders", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String name_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List parameterBinders_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodReturn(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
			public ForMethodReturn(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForMethodReturn;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField;", "public abstract static")]
		public partial class ForField
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterBinders", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
			public Dova.JDK.java.lang.String fieldName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "protected final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "protected final")]
			public Dova.JDK.java.util.List parameterBinders_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "protected final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForField(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
			public ForField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField$WithLookup;", "protected static")]
			public partial class WithLookup
				: Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.ForField
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithLookup()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField$WithLookup;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory fieldLocatorFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithLookup(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "protected")]
				public WithLookup(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg3, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField$WithLookup;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "protected")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField$WithInstance;", "protected static")]
			public partial class WithInstance
				: Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.ForField
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithInstance()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField$WithInstance;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object target_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic fieldType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithInstance(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Ljava/util/List;Lnet/bytebuddy/matcher/ElementMatcher;Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
				public WithInstance(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForField$WithInstance;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "protected")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForStaticMethod;", "public static")]
		public partial class ForStaticMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForStaticMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForStaticMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List records_Property
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
			public ForStaticMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
			public ForStaticMethod(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$ForStaticMethod;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodList;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder;)Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate;", "protected static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate of(Dova.JDK.net.bytebuddy.description.method.MethodList arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;", "public abstract static interface")]
		public partial interface Compiled
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compiled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecords", "()Ljava/util/List;"));
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker invoke()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
			Dova.JDK.java.util.List getRecords()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForConstruction;", "public static")]
			public partial class ForConstruction
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForConstruction()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForConstruction;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecords", "()Ljava/util/List;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
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

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List records_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForConstruction(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
				public ForConstruction(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForConstruction;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker invoke()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List getRecords()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForMethodReturn;", "public static")]
			public partial class ForMethodReturn
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForMethodReturn()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForMethodReturn;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecords", "()Ljava/util/List;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List records_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForMethodReturn(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)V", "protected")]
				public ForMethodReturn(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForMethodReturn;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker invoke()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List getRecords()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForField;", "public static")]
			public partial class ForField
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecords", "()Ljava/util/List;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List records_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForField(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Ljava/util/List;)V", "protected")]
				public ForField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForField;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker invoke()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List getRecords()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForStaticCall;", "public static")]
			public partial class ForStaticCall
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodDelegation.ImplementationDelegate.Compiled
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForStaticCall()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForStaticCall;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecords", "()Ljava/util/List;"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List records_Property
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
				public ForStaticCall(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
				public ForStaticCall(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodDelegation$ImplementationDelegate$Compiled$ForStaticCall;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker invoke()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List getRecords()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
			}
		}
	}
}
