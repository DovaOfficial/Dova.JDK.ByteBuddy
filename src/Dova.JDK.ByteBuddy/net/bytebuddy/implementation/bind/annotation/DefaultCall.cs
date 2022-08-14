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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall;", "public abstract interface")]
public partial interface DefaultCall
	: IJavaObject
	, Dova.JDK.java.lang.annotation.Annotation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultCall()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "targetType", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nullIfImpossible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serializableProxy", "()Z"));
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public abstract")]
	Dova.JDK.java.lang.Class targetType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool nullIfImpossible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool serializableProxy()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TARGET_TYPE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERIALIZABLE_PROXY", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL_IF_IMPOSSIBLE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/ParameterDescription;Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandledType", "()Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape TARGET_TYPE_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape NULL_IF_IMPOSSIBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder>(ret);
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator;", "protected abstract static interface")]
		public partial interface DefaultMethodLocator
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DefaultMethodLocator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation resolve(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Explicit;", "public static")]
			public partial class Explicit
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Explicit()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Explicit;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
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
				public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public Explicit(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Explicit;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation resolve(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;", "public static final")]
			public partial class Implicit
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Implicit()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Implicit(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Implicit(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/annotation/DefaultCall$Binder$DefaultMethodLocator$Implicit;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.annotation.DefaultCall.Binder.DefaultMethodLocator.Implicit>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation resolve(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
				}
			}
		}
	}
}
