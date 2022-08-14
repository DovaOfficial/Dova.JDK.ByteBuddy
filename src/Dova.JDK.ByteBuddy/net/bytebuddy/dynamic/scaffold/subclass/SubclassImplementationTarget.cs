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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget;", "public")]
public partial class SubclassImplementationTarget
	: Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SubclassImplementationTarget()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originTypeResolver", "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeSuper", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeConstructor", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeMethod", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "protected final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver originTypeResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SubclassImplementationTarget(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;)V", "protected")]
	public SubclassImplementationTarget(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeSuper(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getOriginType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "private")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeConstructor(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "private")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;", "public static final")]
	public partial class Factory
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.Implementation.Target.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER_CLASS", "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEVEL_TYPE", "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originTypeResolver", "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory SUPER_CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory LEVEL_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver originTypeResolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;)V", "private")]
		public Factory(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$Factory;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.Factory>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Target make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.ClassFileVersion arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "public abstract static")]
	public partial class OriginTypeResolver
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OriginTypeResolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER_CLASS", "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEVEL_TYPE", "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "identify", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDefinition;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver SUPER_CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver LEVEL_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OriginTypeResolver(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public OriginTypeResolver(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$1;)V", "")]
		public OriginTypeResolver(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/subclass/SubclassImplementationTarget$OriginTypeResolver;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.subclass.SubclassImplementationTarget.OriginTypeResolver>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDefinition;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition identify(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}
	}
}
