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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
public partial class InvokeDynamic
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InvokeDynamic()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootstrap", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arguments", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocationProvider", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminationHandler", "Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typing", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lambda", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lambda", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lambda", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lambda", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/reflect/Method;[Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/reflect/Method;Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/reflect/Constructor;Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withType", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withValue", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBooleanValue", "([Z)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withByteValue", "([B)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withShortValue", "([S)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCharacterValue", "([C)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withIntegerValue", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFloatValue", "([F)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDoubleValue", "([D)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnumeration", "([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInstance", "([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withImplicitAndMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLongValue", "([J)Lnet/bytebuddy/implementation/InvokeDynamic;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "protected final")]
	public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape bootstrap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected final")]
	public Dova.JDK.java.util.List arguments_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider invocationProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler terminationHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing typing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InvokeDynamic(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
	public InvokeDynamic(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic;";
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

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments lambda(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Type arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments lambda(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Type;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments lambda(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments lambda(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;[Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget bootstrap(Dova.JDK.java.lang.reflect.Method arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget bootstrap(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget bootstrap(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget bootstrap(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget bootstrap(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static transient")]
	public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget bootstrap(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitTarget>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withType(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withValue(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withArgument(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withArgument(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withReference(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withReference(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Z)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withBooleanValue(JavaArray<bool> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([B)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withByteValue(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([S)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withShortValue(JavaArray<short> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([C)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withCharacterValue(JavaArray<char> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withIntegerValue(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([F)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withFloatValue(JavaArray<float> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([D)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withDoubleValue(JavaArray<double> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withEnumeration(JavaArray<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withInstance(JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.java.lang.Class> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withMethodArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withImplicitAndMethodArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("([J)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withLongValue(JavaArray<long> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$Appender;", "protected")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$Appender;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/InvokeDynamic;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/InvokeDynamic;Lnet/bytebuddy/description/type/TypeDescription;)V"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic;", "final")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
		public Appender(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$Appender;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public abstract static")]
	public partial class WithImplicitType
		: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.AbstractDelegator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithImplicitType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "as", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "as", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withType", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withValue", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBooleanValue", "([Z)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withByteValue", "([B)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withShortValue", "([S)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCharacterValue", "([C)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withIntegerValue", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFloatValue", "([F)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDoubleValue", "([D)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnumeration", "([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInstance", "([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withImplicitAndMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLongValue", "([J)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithImplicitType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
		public WithImplicitType(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic @as(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public abstract")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic @as(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withType(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withValue(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withArgument(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withArgument(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withReference(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withReference(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Z)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withBooleanValue(JavaArray<bool> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([B)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withByteValue(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([S)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withShortValue(JavaArray<short> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([C)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withCharacterValue(JavaArray<char> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withIntegerValue(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([F)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withFloatValue(JavaArray<float> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([D)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withDoubleValue(JavaArray<double> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withEnumeration(JavaArray<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withInstance(JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withMethodArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withImplicitAndMethodArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([J)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withLongValue(JavaArray<long> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfField;", "protected static")]
		public partial class OfField
			: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "as", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
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

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory fieldLocatorFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfField(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "protected")]
			public OfField(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfField;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic @as(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic materialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfArgument;", "protected static")]
		public partial class OfArgument
			: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfArgument()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfArgument;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "as", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			}

			[JniSignatureAttribute("I", "private final")]
			public int index_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfArgument(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;I)V", "protected")]
			public OfArgument(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5, int arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfArgument;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic @as(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic materialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfInstance;", "protected static")]
		public partial class OfInstance
			: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfInstance()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfInstance;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentProvider", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "as", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object value_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider argumentProvider_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfInstance(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/lang/Object;)V", "protected")]
			public OfInstance(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5, Dova.JDK.java.lang.Object arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType$OfInstance;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic @as(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic materialize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;", "public static")]
	public partial class WithImplicitTarget
		: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithImplicitTarget()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/String;Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithImplicitTarget(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
		public WithImplicitTarget(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitTarget;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments invoke(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments invoke(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments invoke(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments invoke(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments invoke(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public static")]
	public partial class WithImplicitArguments
		: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.AbstractDelegator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithImplicitArguments()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withType", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withValue", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner_0", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner_1", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBooleanValue", "([Z)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withByteValue", "([B)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withShortValue", "([S)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCharacterValue", "([C)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withIntegerValue", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFloatValue", "([F)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDoubleValue", "([D)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnumeration", "([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInstance", "([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withImplicitAndMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLongValue", "([J)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithImplicitArguments(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
		public WithImplicitArguments(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "protected")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic materialize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withType(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withValue(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withArgument(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withArgument(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner_0(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitArguments;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments withAssigner_1(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitArguments>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withReference(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withReference(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Z)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withBooleanValue(JavaArray<bool> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([B)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withByteValue(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([S)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withShortValue(JavaArray<short> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([C)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withCharacterValue(JavaArray<char> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withIntegerValue(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([F)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withFloatValue(JavaArray<float> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([D)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withDoubleValue(JavaArray<double> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withEnumeration(JavaArray<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withInstance(JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withMethodArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withImplicitAndMethodArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([J)Lnet/bytebuddy/implementation/InvokeDynamic;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withLongValue(JavaArray<long> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withoutArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$AbstractDelegator;", "protected abstract static")]
	public partial class AbstractDelegator
		: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractDelegator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$AbstractDelegator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withType", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withValue", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withBooleanValue", "([Z)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withByteValue", "([B)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withShortValue", "([S)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCharacterValue", "([C)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withIntegerValue", "([I)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFloatValue", "([F)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDoubleValue", "([D)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnumeration", "([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInstance", "([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNullValue", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withImplicitAndMethodArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLongValue", "([J)Lnet/bytebuddy/implementation/InvokeDynamic;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractDelegator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
		public AbstractDelegator(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider arg2, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$AbstractDelegator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic materialize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withType(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withValue(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withField(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withField(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withArgument(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withArgument(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withReference(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$WithImplicitType;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType withReference(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.WithImplicitType>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withThis(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Z)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withBooleanValue(JavaArray<bool> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([B)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withByteValue(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([S)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withShortValue(JavaArray<short> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([C)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withCharacterValue(JavaArray<char> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withIntegerValue(JavaArray<int> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([F)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withFloatValue(JavaArray<float> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([D)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withDoubleValue(JavaArray<double> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withEnumeration(JavaArray<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withInstance(JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withNullValue(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withMethodArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withImplicitAndMethodArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}

		[JniSignatureAttribute("([J)Lnet/bytebuddy/implementation/InvokeDynamic;", "public transient")]
		public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic withLongValue(JavaArray<long> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "protected abstract static")]
	public partial class TerminationHandler
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TerminationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNING", "Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DROPPING", "Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/InvokeDynamic$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler RETURNING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler DROPPING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TerminationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public TerminationHandler(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/InvokeDynamic$1;)V", "")]
		public TerminationHandler(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$TerminationHandler;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.TerminationHandler>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "protected abstract static interface")]
	public partial interface InvocationProvider
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvocationProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendArguments", "(Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendArgument", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNameProvider", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReturnTypeProvider", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target make(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider appendArguments(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider appendArgument(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider withoutArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider withNameProvider(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider withReturnTypeProvider(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default;", "public static")]
		public partial class Default
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameProvider", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeProvider", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentProviders", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make_0", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default$Target;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make_1", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendArguments", "(Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendArgument", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutArguments", "()Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNameProvider", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReturnTypeProvider", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider nameProvider_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider returnTypeProvider_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List argumentProviders_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "protected")]
			public Default() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;Ljava/util/List;)V", "protected")]
			public Default(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider arg0, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default$Target;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Default.Target make_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Default.Target>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target;", "public volatile")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target make_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider appendArguments(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider appendArgument(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider withoutArguments()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider withNameProvider(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider withReturnTypeProvider(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default$Target;", "protected static")]
			public partial class Target
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Target()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default$Target;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentProviders", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;Lnet/bytebuddy/description/method/MethodDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String internalName_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription returnType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List argumentProviders_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription instrumentedMethod_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Target(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;Lnet/bytebuddy/description/method/MethodDescription;)V", "protected")]
				public Target(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Default$Target;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target.Resolved>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;", "public abstract static interface")]
		public partial interface ReturnTypeProvider
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReturnTypeProvider()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForExplicitType;", "public static")]
			public partial class ForExplicitType
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForExplicitType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForExplicitType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForExplicitType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForExplicitType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForExplicitType;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;", "public static final")]
			public partial class ForInterceptedMethod
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForInterceptedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForInterceptedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public ForInterceptedMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ReturnTypeProvider$ForInterceptedMethod;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ReturnTypeProvider.ForInterceptedMethod>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;", "public abstract static interface")]
		public partial interface NameProvider
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NameProvider()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;", "public abstract")]
			Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForExplicitName;", "public static")]
			public partial class ForExplicitName
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForExplicitName()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForExplicitName;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String internalName_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForExplicitName(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public ForExplicitName(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForExplicitName;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;", "public static final")]
			public partial class ForInterceptedMethod
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForInterceptedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForInterceptedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public ForInterceptedMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$NameProvider$ForInterceptedMethod;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.NameProvider.ForInterceptedMethod>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;", "public abstract static interface")]
		public partial interface ArgumentProvider
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ArgumentProvider()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForJavaConstant;", "public static")]
			public partial class ForJavaConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForJavaConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForJavaConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javaConstant", "Lnet/bytebuddy/utility/JavaConstant;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/utility/JavaConstant;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant;", "private final")]
				public Dova.JDK.net.bytebuddy.utility.JavaConstant javaConstant_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForJavaConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant;)V", "protected")]
				public ForJavaConstant(Dova.JDK.net.bytebuddy.utility.JavaConstant arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForJavaConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForNullValue;", "public static")]
			public partial class ForNullValue
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForNullValue()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForNullValue;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForNullValue(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForNullValue(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForNullValue;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForEnumerationValue;", "public static")]
			public partial class ForEnumerationValue
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForEnumerationValue()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForEnumerationValue;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumerationDescription", "Lnet/bytebuddy/description/enumeration/EnumerationDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/enumeration/EnumerationDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/enumeration/EnumerationDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription enumerationDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForEnumerationValue(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/enumeration/EnumerationDescription;)V", "protected")]
				public ForEnumerationValue(Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForEnumerationValue;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForClassConstant;", "public static")]
			public partial class ForClassConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForClassConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForClassConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForClassConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForClassConstant(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForClassConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForStringConstant;", "public static")]
			public partial class ForStringConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForStringConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForStringConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String value_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForStringConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public ForStringConstant(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForStringConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForDoubleConstant;", "public static")]
			public partial class ForDoubleConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForDoubleConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForDoubleConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "D"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(D)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("D", "private final")]
				public double value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetDoubleField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetDoubleField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForDoubleConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(D)V", "protected")]
				public ForDoubleConstant(double arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForDoubleConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForFloatConstant;", "public static")]
			public partial class ForFloatConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForFloatConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForFloatConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "F"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(F)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("F", "private final")]
				public float value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForFloatConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(F)V", "protected")]
				public ForFloatConstant(float arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForFloatConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForLongConstant;", "public static")]
			public partial class ForLongConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForLongConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForLongConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "J"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(J)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("J", "private final")]
				public long value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForLongConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(J)V", "protected")]
				public ForLongConstant(long arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForLongConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForIntegerConstant;", "public static")]
			public partial class ForIntegerConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForIntegerConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForIntegerConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("I", "private final")]
				public int value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForIntegerConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(I)V", "protected")]
				public ForIntegerConstant(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForIntegerConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForCharacterConstant;", "public static")]
			public partial class ForCharacterConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForCharacterConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForCharacterConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "C"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(C)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("C", "private final")]
				public char value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForCharacterConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(C)V", "protected")]
				public ForCharacterConstant(char arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForCharacterConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForShortConstant;", "public static")]
			public partial class ForShortConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForShortConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForShortConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "S"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(S)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("S", "private final")]
				public short value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForShortConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(S)V", "protected")]
				public ForShortConstant(short arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForShortConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForByteConstant;", "public static")]
			public partial class ForByteConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForByteConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForByteConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "B"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(B)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("B", "private final")]
				public byte value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetByteField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetByteField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForByteConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(B)V", "protected")]
				public ForByteConstant(byte arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForByteConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForBooleanConstant;", "public static")]
			public partial class ForBooleanConstant
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForBooleanConstant()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForBooleanConstant;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Z"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForBooleanConstant(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Z)V", "protected")]
				public ForBooleanConstant(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForBooleanConstant;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForMethodParameter;", "public static")]
			public partial class ForMethodParameter
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForMethodParameter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForMethodParameter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
				}

				[JniSignatureAttribute("I", "protected final")]
				public int index_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForMethodParameter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(I)V", "protected")]
				public ForMethodParameter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForMethodParameter;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved doResolve(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForMethodParameter$WithExplicitType;", "protected static")]
				public partial class WithExplicitType
					: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForMethodParameter
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithExplicitType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForMethodParameter$WithExplicitType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithExplicitType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(ILnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public WithExplicitType(int arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForMethodParameter$WithExplicitType;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "protected")]
					public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved doResolve(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForField;", "public static")]
			public partial class ForField
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory fieldLocatorFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory>(ret);
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

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "protected")]
				public ForField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForField;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved doResolve(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForField$WithExplicitType;", "protected static")]
				public partial class WithExplicitType
					: Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForField
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithExplicitType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForField$WithExplicitType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithExplicitType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public WithExplicitType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForField$WithExplicitType;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "protected")]
					public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved doResolve(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInstance;", "public static")]
			public partial class ForInstance
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForInstance()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInstance;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_PREFIX", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String FIELD_PREFIX_Property
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

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription fieldType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForInstance(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForInstance(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInstance;";
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

				[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;", "protected static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider of(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForThisInstance;", "public static")]
			public partial class ForThisInstance
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForThisInstance()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForThisInstance;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForThisInstance(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public ForThisInstance(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForThisInstance;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public abstract static interface")]
			public partial interface Resolved
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Resolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypes", "()Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadInstruction", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				}

				[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
				Dova.JDK.java.util.List getLoadedTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
				Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation getLoadInstruction()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved$Simple;", "public static")]
				public partial class Simple
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypes", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypes", "()Ljava/util/List;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadInstruction", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List loadedTypes_Property
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
					public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
					public Simple(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/util/List;)V", "public")]
					public Simple(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved$Simple;";
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

					[JniSignatureAttribute("()Ljava/util/List;", "public")]
					public Dova.JDK.java.util.List getLoadedTypes()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation getLoadInstruction()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public abstract static")]
			public partial class ConstantPoolWrapper
				: Dova.JDK.java.lang.Enum
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ConstantPoolWrapper()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primitiveType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wrapperType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Class;Ljava/lang/Class;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Class;Ljava/lang/Class;Lnet/bytebuddy/implementation/InvokeDynamic$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;)Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper BOOLEAN_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper BYTE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper SHORT_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper CHARACTER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper INTEGER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper LONG_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper FLOAT_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper DOUBLE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription primitiveType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription wrapperType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ConstantPoolWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Class;Ljava/lang/Class;)V", "private")]
				public ConstantPoolWrapper(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Class arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Class;Ljava/lang/Class;Lnet/bytebuddy/implementation/InvokeDynamic$1;)V", "")]
				public ConstantPoolWrapper(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider of(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider make(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;)Lnet/bytebuddy/description/type/TypeDescription;", "static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription access_100(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;)Lnet/bytebuddy/description/type/TypeDescription;", "static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription access_200(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper$WrappingArgumentProvider;", "protected")]
				public partial class WrappingArgumentProvider
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WrappingArgumentProvider()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper$WrappingArgumentProvider;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;", "final")]
					public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WrappingArgumentProvider(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "protected")]
					public WrappingArgumentProvider(Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ConstantPoolWrapper arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ConstantPoolWrapper$WrappingArgumentProvider;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;", "public static final")]
			public partial class ForInterceptedMethodParameters
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForInterceptedMethodParameters()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForInterceptedMethodParameters(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public ForInterceptedMethodParameters(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodParameters;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodParameters>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;", "public static final")]
			public partial class ForInterceptedMethodInstanceAndParameters
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForInterceptedMethodInstanceAndParameters()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForInterceptedMethodInstanceAndParameters(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public ForInterceptedMethodInstanceAndParameters(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$ForInterceptedMethodInstanceAndParameters;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.ForInterceptedMethodInstanceAndParameters>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$ArgumentProvider$Resolved;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.ArgumentProvider.Resolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target;", "public abstract static interface")]
		public partial interface Target
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Target()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target.Resolved resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target.Resolved>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved;", "public abstract static interface")]
			public partial interface Resolved
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Resolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackManipulation", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.type.TypeDescription getReturnType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
				Dova.JDK.java.util.List getParameterTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String getInternalName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
				Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation getStackManipulation()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved$Simple;", "public static")]
				public partial class Simple
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.InvokeDynamic.InvocationProvider.Target.Resolved
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypes", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Ljava/util/List;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackManipulation", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String internalName_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription returnType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List parameterTypes_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
					public Simple(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvokeDynamic$InvocationProvider$Target$Resolved$Simple;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription getReturnType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Ljava/util/List;", "public")]
					public Dova.JDK.java.util.List getParameterTypes()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getInternalName()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation getStackManipulation()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}
				}
			}
		}
	}
}
