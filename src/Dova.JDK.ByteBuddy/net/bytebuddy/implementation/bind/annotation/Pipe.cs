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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe;", "public abstract interface")]
public partial interface Pipe
	: IJavaObject
	, Dova.JDK.java.lang.annotation.Annotation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Pipe()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializableProxy", "()Z"));
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool serializableProxy()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder;", "public static")]
	public partial class Binder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Binder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERIALIZABLE_PROXY", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forwardingMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandledType", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "onlyMethod", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "install", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "install", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape SERIALIZABLE_PROXY_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription forwardingMethod_Property
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
		public Binder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)V", "protected")]
		public Binder(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "private static")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription onlyMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder install(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/annotation/TargetMethodAnnotationDrivenBinder$ParameterBinder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder install(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.TargetMethodAnnotationDrivenBinder.ParameterBinder>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy;", "protected static")]
		public partial class RedirectionProxy
			: Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.AbstractBase
			, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RedirectionProxy()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_NAME_PREFIX", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forwardingType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourceMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serializableProxy", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/String;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/MethodAccessorFactory;)Lnet/bytebuddy/dynamic/DynamicType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fieldName", "(I)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuffix", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extractFields", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/LinkedHashMap;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription forwardingType_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription sourceMethod_Property
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

			[JniSignatureAttribute("Z", "private final")]
			public bool serializableProxy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public RedirectionProxy(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Z)V", "protected")]
			public RedirectionProxy(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy;";
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

			[JniSignatureAttribute("(I)Ljava/lang/String;", "private static")]
			public static Dova.JDK.java.lang.String fieldName(int arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSuffix()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/LinkedHashMap;", "private static")]
			public static Dova.JDK.java.util.LinkedHashMap extractFields(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;", "protected static")]
			public partial class MethodCall
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.Implementation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodCall()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "redirectedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bind/annotation/Pipe$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;)Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;)Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription redirectedMethod_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public MethodCall(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bind/annotation/Pipe$1;)V", "")]
				public MethodCall(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)V", "private")]
				public MethodCall(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;)Lnet/bytebuddy/description/method/MethodDescription;", "static")]
				public static Dova.JDK.net.bytebuddy.description.method.MethodDescription access_400(Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.MethodCall arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;)Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "static")]
				public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner access_500(Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.MethodCall arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall$Appender;", "private")]
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
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall$Appender;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bind/annotation/Pipe$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;Lnet/bytebuddy/description/type/TypeDescription;)V"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;", "final")]
					public Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.MethodCall this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.MethodCall>(ret);
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

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bind/annotation/Pipe$1;)V", "")]
					public Appender(Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.MethodCall arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall;Lnet/bytebuddy/description/type/TypeDescription;)V", "private")]
					public Appender(Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.MethodCall arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$MethodCall$Appender;";
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;", "protected static final")]
			public partial class ConstructorCall
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.Implementation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ConstructorCall()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "objectTypeDefaultConstructor", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final transient")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape objectTypeDefaultConstructor_Property
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

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ConstructorCall(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public ConstructorCall(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
				public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_200(Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe.Binder.RedirectionProxy.ConstructorCall arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall$Appender;", "private static")]
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
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall$Appender;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bind/annotation/Pipe$1;)V"));
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bind/annotation/Pipe$1;)V", "")]
					public Appender(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.annotation.Pipe arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "private")]
					public Appender(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/Pipe$Binder$RedirectionProxy$ConstructorCall$Appender;";
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
	}
}
