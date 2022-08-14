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

namespace Dova.JDK.net.bytebuddy.implementation.bind.annotation;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Origin;", "public abstract interface")]
public partial interface Origin
	: IJavaObject
	, Dova.JDK.java.lang.annotation.Annotation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Origin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Origin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cache", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privileged", "()Z"));
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool cache()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool privileged()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;", "public static final")]
	public partial class Binder
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Binder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVILEGED", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandledType", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "methodConstant", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape CACHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape PRIVILEGED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Binder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Binder(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/Origin$Binder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Origin.Binder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding bind(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class getHandledType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private static")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation methodConstant(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}
}
