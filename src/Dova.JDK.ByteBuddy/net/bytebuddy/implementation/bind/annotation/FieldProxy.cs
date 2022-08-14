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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy;", "public abstract interface")]
public partial interface FieldProxy
	: IJavaObject
	, Dova.JDK.java.lang.annotation.Annotation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldProxy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaringType", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializableProxy", "()Z"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String value()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public abstract")]
	Dova.JDK.java.lang.Class declaringType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool serializableProxy()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder;", "public static")]
	public partial class Binder
		: Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder.ForFieldBinding
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Binder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECLARING_TYPE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_NAME", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERIALIZABLE_PROXY", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldResolverFactory", "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fieldName", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandledType", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "onlyMethod", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "install", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "install", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "install", "(Ljava/lang/Class;Ljava/lang/Class;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "install", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaringType", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;)Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape DECLARING_TYPE_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape FIELD_NAME_Property
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
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape SERIALIZABLE_PROXY_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Factory fieldResolverFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Binder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
		public Binder(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
		public Binder(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory;)V", "protected")]
		public Binder(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Factory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;", "protected")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding bind(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.description.method.ParameterDescription arg3, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String fieldName(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class getHandledType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape onlyMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder install(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder install(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Class;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder install(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder install(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;)Lnet/bytebuddy/description/type/TypeDescription;", "protected")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription declaringType(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$AccessorProxy;", "protected static")]
		public partial class AccessorProxy
			: Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.AbstractBase
			, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessorProxy()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$AccessorProxy;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_NAME", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldResolver", "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serializableProxy", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuffix", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
			public static Dova.JDK.java.lang.String FIELD_NAME_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver fieldResolver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
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

			[JniSignatureAttribute("Z", "private final")]
			public bool serializableProxy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessorProxy(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Z)V", "protected")]
			public AccessorProxy(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$AccessorProxy;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType make(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSuffix()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;", "protected static")]
		public partial class FieldSetter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.Implementation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldSetter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAccessorFactory", "Lnet/bytebuddy/implementation/MethodAccessorFactory;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;)Lnet/bytebuddy/description/field/FieldDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;)Lnet/bytebuddy/implementation/MethodAccessorFactory;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;)Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory methodAccessorFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldSetter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)V", "protected")]
			public FieldSetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;)Lnet/bytebuddy/description/field/FieldDescription;", "static")]
			public static Dova.JDK.net.bytebuddy.description.field.FieldDescription access_400(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldSetter arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;)Lnet/bytebuddy/implementation/MethodAccessorFactory;", "static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory access_500(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldSetter arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;)Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "static")]
			public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner access_600(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldSetter arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter$Appender;", "protected")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter$Appender;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;Lnet/bytebuddy/implementation/Implementation$Target;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;", "final")]
				public Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldSetter this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldSetter>(ret);
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter;Lnet/bytebuddy/implementation/Implementation$Target;)V", "protected")]
				public Appender(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldSetter arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldSetter$Appender;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;", "protected static")]
		public partial class FieldGetter
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.Implementation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldGetter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAccessorFactory", "Lnet/bytebuddy/implementation/MethodAccessorFactory;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;)Lnet/bytebuddy/description/field/FieldDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;)Lnet/bytebuddy/implementation/MethodAccessorFactory;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;)Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory methodAccessorFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldGetter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)V", "protected")]
			public FieldGetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;)Lnet/bytebuddy/description/field/FieldDescription;", "static")]
			public static Dova.JDK.net.bytebuddy.description.field.FieldDescription access_100(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldGetter arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;)Lnet/bytebuddy/implementation/MethodAccessorFactory;", "static")]
			public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory access_200(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldGetter arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;)Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "static")]
			public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner access_300(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldGetter arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter$Appender;", "protected")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter$Appender;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;Lnet/bytebuddy/implementation/Implementation$Target;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;", "final")]
				public Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldGetter this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldGetter>(ret);
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter;Lnet/bytebuddy/implementation/Implementation$Target;)V", "protected")]
				public Appender(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldGetter arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldGetter$Appender;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$InstanceFieldConstructor;", "protected static")]
		public partial class InstanceFieldConstructor
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.Implementation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InstanceFieldConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$InstanceFieldConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
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
			public InstanceFieldConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public InstanceFieldConstructor(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$InstanceFieldConstructor;";
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$InstanceFieldConstructor$Appender;", "protected static")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$InstanceFieldConstructor$Appender;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/Implementation$Target;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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
				public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)V", "protected")]
				public Appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$InstanceFieldConstructor$Appender;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;", "protected static final")]
		public partial class StaticFieldConstructor
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.Implementation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static StaticFieldConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objectTypeDefaultConstructor", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;)Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription objectTypeDefaultConstructor_Property
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

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public StaticFieldConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public StaticFieldConstructor(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$StaticFieldConstructor;)Lnet/bytebuddy/description/method/MethodDescription;", "static")]
			public static Dova.JDK.net.bytebuddy.description.method.MethodDescription access_000(Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.StaticFieldConstructor arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;", "protected abstract static interface")]
		public partial interface FieldResolver
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldResolver()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("()Z", "public abstract")]
			bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.type.TypeDescription getProxyType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForGetterSetterPair;", "public static")]
			public partial class ForGetterSetterPair
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForGetterSetterPair()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForGetterSetterPair;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxyType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "setterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription proxyType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getterMethod_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape setterMethod_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForGetterSetterPair(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
				public ForGetterSetterPair(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForGetterSetterPair;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isResolved()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getProxyType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForSetter;", "public static")]
			public partial class ForSetter
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForSetter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForSetter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "setterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape setterMethod_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForSetter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
				public ForSetter(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForSetter;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isResolved()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getProxyType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForGetter;", "public static")]
			public partial class ForGetter
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForGetter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForGetter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getterMethod_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForGetter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
				public ForGetter(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$ForGetter;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isResolved()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getProxyType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;", "public static final")]
			public partial class Unresolved
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Unresolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Unresolved(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Unresolved(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Unresolved;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Unresolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isResolved()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getProxyType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory;", "public abstract static interface")]
			public partial interface Factory
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;", "public abstract")]
				Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory$Simplex;", "public static")]
				public partial class Simplex
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Factory
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simplex()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory$Simplex;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "setterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getterMethod_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape setterMethod_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Simplex(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
					public Simplex(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory$Simplex;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory$Duplex;", "public static")]
				public partial class Duplex
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver.Factory
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Duplex()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory$Duplex;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxyType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "setterMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription proxyType_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getterMethod_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape setterMethod_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Duplex(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
					public Duplex(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver$Factory$Duplex;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bind/annotation/FieldProxy$Binder$FieldResolver;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.FieldProxy.Binder.FieldResolver>(ret);
					}
				}
			}
		}
	}
}
