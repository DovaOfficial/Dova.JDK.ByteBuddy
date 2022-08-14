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

namespace Dova.JDK.net.bytebuddy.implementation.bind;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder;", "public abstract interface")]
public partial interface MethodDelegationBinder
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodDelegationBinder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;", "public abstract")]
	Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record compile(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Processor;", "public static")]
	public partial class Processor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Processor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Processor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "records", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ambiguityResolver", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bindingResolver", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver ambiguityResolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver>(ret);
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Processor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)V", "public")]
		public Processor(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Processor;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding bind(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler arg2, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;", "public abstract static interface")]
	public partial interface TerminationHandler
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TerminationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;", "public abstract static")]
		public partial class Default
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNING", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DROPPING", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/bind/MethodDelegationBinder$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default RETURNING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default DROPPING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Default(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/bind/MethodDelegationBinder$1;)V", "")]
			public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler$Default;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler.Default>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;", "public abstract static interface")]
	public partial interface AmbiguityResolver
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AmbiguityResolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Compound;", "public static")]
		public partial class Compound
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compound()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Compound;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ambiguityResolvers", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List ambiguityResolvers_Property
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
			public Compound(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;)V", "public transient")]
			public Compound(JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
			public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Compound;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;", "public static final")]
		public partial class Directional
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Directional()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "left", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional LEFT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional RIGHT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool left_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Directional(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
			public Directional(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Directional;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Directional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;", "public static final")]
		public partial class NoOp
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoOp()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public NoOp(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$NoOp;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.NoOp>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static final")]
		public partial class Resolution
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Resolution()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNKNOWN", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMBIGUOUS", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unresolved", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnresolved", "()Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution UNKNOWN_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution LEFT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution RIGHT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution AMBIGUOUS_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool unresolved_Property
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

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Resolution(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
			public Resolution(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution merge(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isUnresolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "public abstract static interface")]
	public partial interface BindingResolver
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BindingResolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding resolve(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$StreamWriting;", "public static")]
		public partial class StreamWriting
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static StreamWriting()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$StreamWriting;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printStream", "Ljava/io/PrintStream;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;Ljava/io/PrintStream;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemOut", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemOut", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemError", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemError", "()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver @delegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/io/PrintStream;", "private final")]
			public Dova.JDK.java.io.PrintStream printStream_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public StreamWriting(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;Ljava/io/PrintStream;)V", "public")]
			public StreamWriting(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg0, Dova.JDK.java.io.PrintStream arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$StreamWriting;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding resolve(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver toSystemOut()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver toSystemOut(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver toSystemError(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver toSystemError()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;", "public static final")]
		public partial class Unique
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Unique()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLY", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int ONLY_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Unique(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Unique(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Unique;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Unique>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding resolve(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;", "public static final")]
		public partial class Default
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLY", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int ONLY_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int LEFT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
				}
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int RIGHT_Property
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

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Default(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$BindingResolver$Default;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.BindingResolver.Default>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding resolve(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver;Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/List;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "private")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding doResolve(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public abstract static interface")]
	public partial interface MethodBinding
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodBinding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetParameterIndex", "(Ljava/lang/Object;)Ljava/lang/Integer;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Integer;", "public abstract")]
		Dova.JDK.java.lang.Integer getTargetParameterIndex(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Builder;", "public static")]
		public partial class Builder
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Builder()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Builder;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodInvoker", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "candidate", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterStackManipulations", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredTargetIndices", "Ljava/util/LinkedHashMap;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextParameterIndex", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/description/method/MethodDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker methodInvoker_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription candidate_Property
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

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List parameterStackManipulations_Property
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

			[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
			public Dova.JDK.java.util.LinkedHashMap registeredTargetIndices_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int nextParameterIndex_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Builder(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/description/method/MethodDescription;)V", "public")]
			public Builder(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Builder;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;)Z", "public")]
			public bool append(Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding build(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Builder$Build;", "protected static")]
			public partial class Build
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Build()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Builder$Build;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredTargetIndices", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodInvocation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterStackManipulations", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminatingStackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Map;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/util/List;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetParameterIndex", "(Ljava/lang/Object;)Ljava/lang/Integer;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription target_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map registeredTargetIndices_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation methodInvocation_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List parameterStackManipulations_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation terminatingStackManipulation_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Build(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Ljava/util/Map;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/util/List;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "protected")]
				public Build(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg2, Dova.JDK.java.util.List arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Builder$Build;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription getTarget()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isValid()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Integer;", "public")]
				public Dova.JDK.java.lang.Integer getTargetParameterIndex(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;", "public static final")]
		public partial class Illegal
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Illegal()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetParameterIndex", "(Ljava/lang/Object;)Ljava/lang/Integer;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Illegal(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Illegal(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding$Illegal;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding.Illegal>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getTarget()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isValid()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Integer;", "public")]
			public Dova.JDK.java.lang.Integer getTargetParameterIndex(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;", "public abstract static interface")]
	public partial interface ParameterBinding
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParameterBinding()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentificationToken", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object getIdentificationToken()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Unique;", "public static")]
		public partial class Unique
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Unique()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Unique;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identificationToken", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Object;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Unique;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentificationToken", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object identificationToken_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation @delegate_Property
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
			public Unique(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Object;)V", "public")]
			public Unique(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Unique;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/Object;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Unique;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Unique of(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Unique>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isValid()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getIdentificationToken()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Anonymous;", "public static")]
		public partial class Anonymous
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Anonymous()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Anonymous;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anonymousToken", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentificationToken", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object anonymousToken_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation @delegate_Property
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
			public Anonymous(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "public")]
			public Anonymous(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Anonymous;";
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

			[JniSignatureAttribute("()Z", "public")]
			public bool isValid()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object getIdentificationToken()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;", "public static final")]
		public partial class Illegal
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Illegal()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentificationToken_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentificationToken_1", "()Ljava/lang/Void;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Illegal(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Illegal(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$ParameterBinding$Illegal;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.ParameterBinding.Illegal>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isValid()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object getIdentificationToken_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void getIdentificationToken_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;", "public abstract static interface")]
	public partial interface MethodInvoker
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodInvoker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation invoke(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Virtual;", "public static")]
		public partial class Virtual
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Virtual()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Virtual;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
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
			public Virtual(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
			public Virtual(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Virtual;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation invoke(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
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
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;", "public static final")]
		public partial class Simple
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation invoke(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker$Simple;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker.Simple>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;", "public abstract static interface")]
	public partial interface Record
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Record()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding bind(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler arg2, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;", "public static final")]
		public partial class Illegal
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Illegal()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Illegal(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Illegal(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$Record$Illegal;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.Record.Illegal>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$TerminationHandler;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodInvoker;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding bind(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.TerminationHandler arg2, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodInvoker arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding>(ret);
			}
		}
	}
}
