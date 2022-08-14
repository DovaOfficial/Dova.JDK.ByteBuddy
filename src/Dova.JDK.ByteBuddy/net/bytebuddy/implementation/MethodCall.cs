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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall;", "public")]
public partial class MethodCall
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodCall()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodLocator", "Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetHandler", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentLoaders", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodInvoker", "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminationHandler", "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typing", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Factory;Ljava/util/List;Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$Factory;Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Factory;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoke", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoke", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "run", "(Ljava/lang/Runnable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/util/List;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "([Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$Factory;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "call", "(Ljava/util/concurrent/Callable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAllArguments", "()Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "([Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeSuper", "()Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "construct", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "construct", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withOwnType", "()Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgument", "([I)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invokeSelf", "()Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withReference", "([Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgumentArray", "()Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withThis", "()Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodCall", "(Lnet/bytebuddy/implementation/MethodCall;)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsField", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsField", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsField", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgumentArrayElements", "(I)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgumentArrayElements", "(III)Lnet/bytebuddy/implementation/MethodCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withArgumentArrayElements", "(II)Lnet/bytebuddy/implementation/MethodCall;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory methodLocator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory targetHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "protected final")]
	public Dova.JDK.java.util.List argumentLoaders_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory methodInvoker_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Factory;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Factory terminationHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "protected final")]
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing typing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodCall(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Factory;Ljava/util/List;Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$Factory;Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Factory;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
	public MethodCall(Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory arg0, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory arg3, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Factory arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg5, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invoke(Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invoke(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invoke(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invoke(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invoke(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invoke(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.Implementation.Composable run(Dova.JDK.java.lang.Runnable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.reflect.Type arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$Factory;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(JavaArray<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall with(JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.Implementation.Composable call(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withAllArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withField(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;[Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withField(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall invokeSuper()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/implementation/MethodCall;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall construct(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall construct(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withOwnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("([I)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withArgument(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget invokeSelf()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.WithoutSpecifiedTarget>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall;", "public transient")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withReference(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withArgumentArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withThis()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withMethodCall(Dova.JDK.net.bytebuddy.implementation.MethodCall arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting setsField(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting setsField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting setsField(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withArgumentArrayElements(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(III)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withArgumentArrayElements(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("(II)Lnet/bytebuddy/implementation/MethodCall;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.MethodCall withArgumentArrayElements(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$Appender;", "protected")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$Appender;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationTarget", "Lnet/bytebuddy/implementation/Implementation$Target;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodLocator", "Lnet/bytebuddy/implementation/MethodCall$MethodLocator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentProviders", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodInvoker", "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetHandler", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminationHandler", "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/MethodCall;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/implementation/MethodCall$Appender;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toInvokedMethod", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator methodLocator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator>(ret);
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker methodInvoker_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler targetHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler terminationHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall;", "final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;)V", "protected")]
		public Appender(Dova.JDK.net.bytebuddy.implementation.MethodCall arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$Appender;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$Appender;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "static")]
		public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler access_000(Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)Lnet/bytebuddy/description/method/MethodDescription;", "protected")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription toInvokedMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$FieldSetting;", "public static")]
	public partial class FieldSetting
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldSetting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$FieldSetting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodCall", "Lnet/bytebuddy/implementation/MethodCall;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall methodCall_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FieldSetting(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall;)V", "protected")]
		public FieldSetting(Dova.JDK.net.bytebuddy.implementation.MethodCall arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$FieldSetting;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;", "protected static final")]
		public partial class Appender
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Appender()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Appender(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$FieldSetting$Appender;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.FieldSetting.Appender>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;", "public static")]
	public partial class WithoutSpecifiedTarget
		: Dova.JDK.net.bytebuddy.implementation.MethodCall
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithoutSpecifiedTarget()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSuper", "()Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onArgument", "(I)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onField", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onField", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDefault", "()Lnet/bytebuddy/implementation/MethodCall;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodCall", "(Lnet/bytebuddy/implementation/MethodCall;)Lnet/bytebuddy/implementation/MethodCall;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithoutSpecifiedTarget(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;)V", "protected")]
		public WithoutSpecifiedTarget(Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$WithoutSpecifiedTarget;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall on(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall on(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall on(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall on(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onSuper()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onArgument(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onField(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onField(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onDefault()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall;)Lnet/bytebuddy/implementation/MethodCall;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.MethodCall onMethodCall(Dova.JDK.net.bytebuddy.implementation.MethodCall arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;", "protected abstract static interface")]
	public partial interface TerminationHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TerminationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting;", "public static")]
		public partial class FieldSetting
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldSetting()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldSetting(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
			public FieldSetting(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting$Implicit;", "protected static")]
			public partial class Implicit
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Implicit()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting$Implicit;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
				public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Implicit(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
				public Implicit(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting$Implicit;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting$Explicit;", "protected static")]
			public partial class Explicit
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Explicit()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting$Explicit;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
				public Explicit(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$FieldSetting$Explicit;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "public abstract static")]
		public partial class Simple
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNING", "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DROPPING", "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORING", "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/MethodCall$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple RETURNING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple DROPPING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple IGNORING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Simple(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/MethodCall$1;)V", "")]
			public Simple(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.MethodCall arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Simple;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler.Simple>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation prepare()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TerminationHandler$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$TerminationHandler;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TerminationHandler>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "protected abstract static interface")]
	public partial interface MethodInvoker
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodInvoker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation;", "public static")]
		public partial class ForDefaultMethodInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForDefaultMethodInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForDefaultMethodInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForDefaultMethodInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;", "static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForDefaultMethodInvocation$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForDefaultMethodInvocation.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation;", "public static")]
		public partial class ForSuperMethodInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForSuperMethodInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForSuperMethodInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForSuperMethodInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;", "static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForSuperMethodInvocation$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForSuperMethodInvocation.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation;", "public static")]
		public partial class ForVirtualInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForVirtualInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForVirtualInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForVirtualInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
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
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public Factory(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;", "protected static final")]
			public partial class WithImplicitType
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithImplicitType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithImplicitType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public WithImplicitType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForVirtualInvocation$WithImplicitType;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForVirtualInvocation.WithImplicitType>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation;", "public static")]
		public partial class ForContextualInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForContextualInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForContextualInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForContextualInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;", "static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$ForContextualInvocation$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker.ForContextualInvocation.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodInvoker$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodInvoker;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodInvoker>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "protected abstract static interface")]
	public partial interface TargetHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TargetHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall;", "public static")]
		public partial class ForMethodCall
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodCall()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appender", "Lnet/bytebuddy/implementation/MethodCall$Appender;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$Appender;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$Appender;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender appender_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodCall(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$Appender;)V", "protected")]
			public ForMethodCall(Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodCall", "Lnet/bytebuddy/implementation/MethodCall;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall methodCall_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall;)V", "public")]
				public Factory(Dova.JDK.net.bytebuddy.implementation.MethodCall arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall$Resolved;", "protected static")]
			public partial class Resolved
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Resolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall$Resolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appender", "Lnet/bytebuddy/implementation/MethodCall$Appender;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetHandler", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$Appender;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$Appender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender appender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription instrumentedMethod_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved targetHandler_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$Appender;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)V", "protected")]
				public Resolved(Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodCall$Resolved;";
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
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodParameter;", "public static")]
		public partial class ForMethodParameter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodParameter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodParameter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
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
			public ForMethodParameter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(I)V", "protected")]
			public ForMethodParameter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodParameter;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodParameter$Resolved;", "protected static")]
			public partial class Resolved
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Resolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodParameter$Resolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterDescription", "Lnet/bytebuddy/description/method/ParameterDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/ParameterDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterDescription parameterDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;)V", "protected")]
				public Resolved(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForMethodParameter$Resolved;";
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
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField;", "public static")]
		public partial class ForField
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForField(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
			public ForField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "location", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForField.Location location_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForField.Location>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location;)V", "protected")]
				public Factory(Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForField.Location arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location;", "protected abstract static interface")]
			public partial interface Location
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Location()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location$ForExplicitField;", "public static")]
				public partial class ForExplicitField
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForField.Location
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForExplicitField()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location$ForExplicitField;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForExplicitField(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
					public ForExplicitField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location$ForExplicitField;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location$ForImplicitField;", "public static")]
				public partial class ForImplicitField
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForField.Location
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForImplicitField()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location$ForImplicitField;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
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
					public ForImplicitField(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "protected")]
					public ForImplicitField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForField$Location$ForImplicitField;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForValue;", "public static")]
		public partial class ForValue
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "private final")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape fieldDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)V", "protected")]
			public ForValue(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForValue$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForValue$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_PREFIX", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
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
				public Dova.JDK.java.lang.Object target_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic fieldType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
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
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
				public Factory(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForValue$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation;", "public static")]
		public partial class ForConstructingInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForConstructingInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForConstructingInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForConstructingInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;", "static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForConstructingInvocation$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForConstructingInvocation.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation;", "public static")]
		public partial class ForSelfOrStaticInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForSelfOrStaticInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
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
			public ForSelfOrStaticInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForSelfOrStaticInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;", "protected static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.ForSelfOrStaticInvocation.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Resolved;", "protected static")]
			public partial class Resolved
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Resolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Resolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription instrumentedMethod_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)V", "protected")]
				public Resolved(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$ForSelfOrStaticInvocation$Resolved;";
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
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Factory
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "protected")]
			public Simple(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Simple;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$TargetHandler;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "public abstract static interface")]
		public partial interface Resolved
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Resolved()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader;", "public abstract static interface")]
	public partial interface ArgumentLoader
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ArgumentLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForStackManipulation;", "public static")]
		public partial class ForStackManipulation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForStackManipulation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForStackManipulation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDefinition", "Lnet/bytebuddy/description/type/TypeDefinition;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDefinition;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$Factory;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition typeDefinition_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForStackManipulation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)V", "public")]
			public ForStackManipulation(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.reflect.Type arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDefinition;)V", "public")]
			public ForStackManipulation(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForStackManipulation;";
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

			[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$Factory;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory of(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall;", "public static")]
		public partial class ForMethodCall
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodCall()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appender", "Lnet/bytebuddy/implementation/MethodCall$Appender;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetHandler", "Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$Appender;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$Appender;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender appender_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription instrumentedMethod_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved targetHandler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodCall(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$Appender;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/MethodCall$TargetHandler$Resolved;)V", "public")]
			public ForMethodCall(Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.implementation.MethodCall.TargetHandler.Resolved arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodCall", "Lnet/bytebuddy/implementation/MethodCall;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall methodCall_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall;)V", "public")]
				public Factory(Dova.JDK.net.bytebuddy.implementation.MethodCall arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall$ArgumentProvider;", "protected static")]
			public partial class ArgumentProvider
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ArgumentProvider()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall$ArgumentProvider;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appender", "Lnet/bytebuddy/implementation/MethodCall$Appender;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/MethodCall$Appender;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$Appender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender appender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ArgumentProvider(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodCall$Appender;)V", "protected")]
				public ArgumentProvider(Dova.JDK.net.bytebuddy.implementation.MethodCall.Appender arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodCall$ArgumentProvider;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField;", "public static")]
		public partial class ForField
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/method/MethodDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription instrumentedMethod_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/method/MethodDescription;)V", "public")]
			public ForField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
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
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "public")]
				public Factory(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField$ArgumentProvider;", "protected static")]
			public partial class ArgumentProvider
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ArgumentProvider()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField$ArgumentProvider;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ArgumentProvider(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
				public ArgumentProvider(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForField$ArgumentProvider;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstance;", "public static")]
		public partial class ForInstance
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForInstance()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstance;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForInstance(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "public")]
			public ForInstance(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstance;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstance$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstance$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_PREFIX", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String name_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
				public Factory(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstance$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement;", "public static")]
		public partial class ForMethodParameterArrayElement
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodParameterArrayElement()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterDescription", "Lnet/bytebuddy/description/method/ParameterDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/ParameterDescription;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterDescription parameterDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int index_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodParameterArrayElement(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;I)V", "public")]
			public ForMethodParameterArrayElement(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement$OfInvokedMethod;", "public static")]
			public partial class OfInvokedMethod
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfInvokedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement$OfInvokedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
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
				public OfInvokedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(I)V", "public")]
				public OfInvokedMethod(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement$OfInvokedMethod;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement$OfParameter;", "public static")]
			public partial class OfParameter
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfParameter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement$OfParameter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arrayIndex", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
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

				[JniSignatureAttribute("I", "private final")]
				public int arrayIndex_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfParameter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(II)V", "public")]
				public OfParameter(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArrayElement$OfParameter;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray;", "public static")]
		public partial class ForMethodParameterArray
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodParameterArray()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "Lnet/bytebuddy/description/method/ParameterList;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/ParameterList;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterList;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterList parameters_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodParameterArray(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterList;)V", "public")]
			public ForMethodParameterArray(Dova.JDK.net.bytebuddy.description.method.ParameterList arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;", "public static final")]
			public partial class ForInstrumentedMethod
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForInstrumentedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForInstrumentedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public ForInstrumentedMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameterArray$ForInstrumentedMethod;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameterArray.ForInstrumentedMethod>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter;", "public static")]
		public partial class ForMethodParameter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodParameter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILnet/bytebuddy/description/method/MethodDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription instrumentedMethod_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodParameter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/description/method/MethodDescription;)V", "public")]
			public ForMethodParameter(int arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
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
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(I)V", "public")]
				public Factory(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;", "protected static final")]
			public partial class OfInstrumentedMethod
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfInstrumentedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfInstrumentedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public OfInstrumentedMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForMethodParameter$OfInstrumentedMethod;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForMethodParameter.OfInstrumentedMethod>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
				public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType;", "public static")]
		public partial class ForInstrumentedType
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForInstrumentedType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForInstrumentedType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
			public ForInstrumentedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;", "public static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForInstrumentedType$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForInstrumentedType.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference;", "public static")]
		public partial class ForThisReference
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForThisReference()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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
			public ForThisReference(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
			public ForThisReference(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;", "public static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForThisReference$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForThisReference.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;", "public static final")]
		public partial class ForNullConstant
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForNullConstant()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStackManipulation", "(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForNullConstant(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForNullConstant(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ForNullConstant;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ForNullConstant>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation toStackManipulation(Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider make(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.ArgumentLoader.ArgumentProvider>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;", "public abstract static interface")]
		public partial interface ArgumentProvider
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ArgumentProvider()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$ArgumentLoader$ArgumentProvider;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "public abstract")]
			Dova.JDK.java.util.List resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator;", "public abstract static interface")]
	public partial interface MethodLocator
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodLocator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodLocator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForElementMatcher;", "public static")]
		public partial class ForElementMatcher
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForElementMatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForElementMatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForElementMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)V", "protected")]
			public ForElementMatcher(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForElementMatcher;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForElementMatcher$Factory;", "public static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForElementMatcher$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
				public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)V", "public")]
				public Factory(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForElementMatcher$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForExplicitMethod;", "public static")]
		public partial class ForExplicitMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForExplicitMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForExplicitMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForExplicitMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)V", "protected")]
			public ForExplicitMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForExplicitMethod;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;", "public static final")]
		public partial class ForInstrumentedMethod
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator
			, Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForInstrumentedMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForInstrumentedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForInstrumentedMethod(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator$ForInstrumentedMethod;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator.ForInstrumentedMethod>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodCall$MethodLocator$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/MethodCall$MethodLocator;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodCall.MethodLocator>(ret);
			}
		}
	}
}
