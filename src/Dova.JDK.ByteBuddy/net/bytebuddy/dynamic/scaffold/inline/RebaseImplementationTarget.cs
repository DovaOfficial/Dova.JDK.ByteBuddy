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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold.inline;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget;", "public")]
public partial class RebaseImplementationTarget
	: Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RebaseImplementationTarget()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rebaseableMethods", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)Lnet/bytebuddy/implementation/Implementation$Target;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeSuper", "(Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeSuper", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeSuper", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map rebaseableMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RebaseImplementationTarget(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;Ljava/util/Map;)V", "protected")]
	public RebaseImplementationTarget(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)Lnet/bytebuddy/implementation/Implementation$Target;", "protected static")]
	public static Dova.JDK.net.bytebuddy.implementation.Implementation.Target of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.ClassFileVersion arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "private")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeSuper(Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "private")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeSuper(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeSuper(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getOriginType_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription getOriginType_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget$Factory;", "public static")]
	public partial class Factory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodRebaseResolver", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver methodRebaseResolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver>(ret);
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

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;)V", "public")]
		public Factory(Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget$Factory;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Target make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.ClassFileVersion arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget$RebasedMethodInvocation;", "protected static")]
	public partial class RebasedMethodInvocation
		: Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RebasedMethodInvocation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget$RebasedMethodInvocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prependedParameters", "Lnet/bytebuddy/description/type/TypeList;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeList;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCheckedCompatibilityTo", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodDescription", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeList;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList prependedParameters_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RebasedMethodInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeList;)V", "protected")]
		public RebasedMethodInvocation(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg2, Dova.JDK.net.bytebuddy.description.type.TypeList arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/RebaseImplementationTarget$RebasedMethodInvocation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "protected static")]
		public static Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation of(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeList arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation withCheckedCompatibilityTo(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethodDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
	}
}
