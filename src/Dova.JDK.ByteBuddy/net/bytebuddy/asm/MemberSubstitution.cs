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

namespace Dova.JDK.net.bytebuddy.asm;

[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
public partial class MemberSubstitution
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods.MethodVisitorWrapper
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemberSubstitution()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strict", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePoolResolver", "Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replacementFactory", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constructor", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "on", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "strict", "()Lnet/bytebuddy/asm/MemberSubstitution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "element", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;)Lnet/bytebuddy/asm/MemberSubstitution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/asm/MemberSubstitution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "relaxed", "()Lnet/bytebuddy/asm/MemberSubstitution;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool strict_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;", "private final")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver typePoolResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;", "private final")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory replacementFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MemberSubstitution(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Z)V", "protected")]
	public MemberSubstitution(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;)V", "protected")]
	public MemberSubstitution(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedMethod;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification.ForMatchedMethod method(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification.ForMatchedMethod>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;II)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedField;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification.ForMatchedField field(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification.ForMatchedField>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification constructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/AsmVisitorWrapper$ForDeclaredMethods;", "public")]
	public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods on(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.ForDeclaredMethods>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution;", "public static")]
	public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution strict()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification element(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution with(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution with(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification invokable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution;", "public static")]
	public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution relaxed()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;", "protected static")]
	public partial class SubstitutingMethodVisitor
		: Dova.JDK.net.bytebuddy.utility.visitor.LocalVariableAwareMethodVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SubstitutingMethodVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedMethod", "Lnet/bytebuddy/description/method/MethodDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strict", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replacement", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContext", "Lnet/bytebuddy/implementation/Implementation$Context;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "virtualPrivateCalls", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackSizeBuffer", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localVariableExtension", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMaxs", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodInsn", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$102", "(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;I)I"));
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

		[JniSignatureAttribute("Z", "private final")]
		public bool strict_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement;", "private final")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement replacement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Context implementationContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
		public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool virtualPrivateCalls_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int stackSizeBuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int localVariableExtension_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SubstitutingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Z)V", "protected")]
		public SubstitutingMethodVisitor(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg3, bool arg4, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement arg5, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg6, Dova.JDK.net.bytebuddy.pool.TypePool arg7, bool arg8) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
		public void visitFieldInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(II)V", "public")]
		public void visitMaxs(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "public")]
		public void visitMethodInsn(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;)I", "static")]
		public static int access_100(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.SubstitutingMethodVisitor arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;I)I", "static")]
		public static int access_102(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.SubstitutingMethodVisitor arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor$LocalVariableTracingMethodVisitor;", "private")]
		public partial class LocalVariableTracingMethodVisitor
			: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LocalVariableTracingMethodVisitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor$LocalVariableTracingMethodVisitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/asm/MemberSubstitution$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarInsn", "(II)V"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;", "final")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.SubstitutingMethodVisitor this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.SubstitutingMethodVisitor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LocalVariableTracingMethodVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "private")]
			public LocalVariableTracingMethodVisitor(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.SubstitutingMethodVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor;Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/asm/MemberSubstitution$1;)V", "")]
			public LocalVariableTracingMethodVisitor(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.SubstitutingMethodVisitor arg0, Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg1, Dova.JDK.net.bytebuddy.asm.MemberSubstitution arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$SubstitutingMethodVisitor$LocalVariableTracingMethodVisitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(II)V", "public")]
			public void visitVarInsn(int arg0, int arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement;", "protected abstract static interface")]
	public partial interface Replacement
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Replacement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public abstract")]
		Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public abstract")]
		Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForFirstBinding;", "public static")]
		public partial class ForFirstBinding
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForFirstBinding()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForFirstBinding;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replacements", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List replacements_Property
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
			public ForFirstBinding(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
			public ForFirstBinding(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForFirstBinding;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForElementMatchers;", "public static")]
		public partial class ForElementMatchers
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForElementMatchers()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForElementMatchers;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldMatcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodMatcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchFieldRead", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchFieldWrite", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeVirtualCalls", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeSuperCalls", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "substitution", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/matcher/ElementMatcher;ZZZZLnet/bytebuddy/asm/MemberSubstitution$Substitution;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher fieldMatcher_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher methodMatcher_Property
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

			[JniSignatureAttribute("Z", "private final")]
			public bool matchFieldRead_Property
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

			[JniSignatureAttribute("Z", "private final")]
			public bool matchFieldWrite_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool includeVirtualCalls_Property
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

			[JniSignatureAttribute("Z", "private final")]
			public bool includeSuperCalls_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "private final")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution substitution_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForElementMatchers(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/matcher/ElementMatcher;ZZZZLnet/bytebuddy/asm/MemberSubstitution$Substitution;)V", "protected")]
			public ForElementMatchers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1, bool arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForElementMatchers;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForElementMatchers$Factory;", "protected static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForElementMatchers$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldMatcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodMatcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchFieldRead", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchFieldWrite", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeVirtualCalls", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeSuperCalls", "Z"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "substitutionFactory", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/matcher/ElementMatcher;ZZZZLnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofField", "(Lnet/bytebuddy/matcher/ElementMatcher;ZZLnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofMethod", "(Lnet/bytebuddy/matcher/ElementMatcher;ZZLnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
				public Dova.JDK.net.bytebuddy.matcher.ElementMatcher fieldMatcher_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
				public Dova.JDK.net.bytebuddy.matcher.ElementMatcher methodMatcher_Property
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

				[JniSignatureAttribute("Z", "private final")]
				public bool matchFieldRead_Property
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

				[JniSignatureAttribute("Z", "private final")]
				public bool matchFieldWrite_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool includeVirtualCalls_Property
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

				[JniSignatureAttribute("Z", "private final")]
				public bool includeSuperCalls_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;", "private final")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory substitutionFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/matcher/ElementMatcher;ZZZZLnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)V", "protected")]
				public Factory(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1, bool arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$ForElementMatchers$Factory;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;", "protected static")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory of(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;ZZLnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;", "protected static")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory ofField(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, bool arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg3)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;ZZLnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;", "protected static")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory ofMethod(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, bool arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg3)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;", "public static final")]
		public partial class NoOp
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoOp()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;", "public static final")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$NoOp;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.NoOp>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Z)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "public static final")]
		public partial class InvocationType
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InvocationType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VIRTUAL", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(ZZ)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(ILnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType VIRTUAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType SUPER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType OTHER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public InvocationType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public InvocationType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>(ret);
			}

			[JniSignatureAttribute("(ZZ)Z", "protected")]
			public bool matches(bool arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$InvocationType;", "protected static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType of(int arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.InvocationType>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;", "public abstract")]
			Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory$Compound;", "public static")]
			public partial class Compound
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Compound()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory$Compound;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "factories", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List factories_Property
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

				[JniSignatureAttribute("([Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;)V", "protected transient")]
				public Compound(JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
				public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory$Compound;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;", "public abstract static interface")]
		public partial interface Binding
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Binding()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBound", "()Z"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation make(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("()Z", "public abstract")]
			bool isBound()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Resolved;", "public static")]
			public partial class Resolved
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Resolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Resolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lnet/bytebuddy/description/ByteCodeElement;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "substitution", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/asm/MemberSubstitution$Substitution;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBound", "()Z"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription targetType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/ByteCodeElement;", "private final")]
				public Dova.JDK.net.bytebuddy.description.ByteCodeElement target_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "private final")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution substitution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/asm/MemberSubstitution$Substitution;)V", "protected")]
				public Resolved(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Resolved;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation make(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isBound()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;", "public static final")]
			public partial class Unresolved
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Unresolved()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBound", "()Z"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;", "public static final")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Binding$Unresolved;", "public static")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Binding.Unresolved>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation make(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isBound()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public abstract static interface")]
	public partial interface Substitution
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Substitution()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain;", "public static")]
		public partial class Chain
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Chain()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typing", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "steps", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withDefaultAssigner", "()Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing typing_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List steps_Property
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
			public Chain(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/util/List;)V", "protected")]
			public Chain(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, int arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory with(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory withDefaultAssigner()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;", "public static")]
			public partial class Factory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typing", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "steps", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executing", "(Ljava/util/List;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executing", "([Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing typing_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List steps_Property
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
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Ljava/util/List;)V", "protected")]
				public Factory(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory executing(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory>(ret);
				}

				[JniSignatureAttribute("([Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Factory;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Factory;", "public transient")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory executing(JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Factory> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Factory>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step;", "public abstract static interface")]
			public partial interface Step
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Step()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Map;I)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Resolution;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Map;I)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Resolution;", "public abstract")]
				Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Resolution resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, Dova.JDK.java.util.Map arg4, int arg5)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Resolution>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Simple;", "public static")]
				public partial class Simple
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Resolution
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Factory
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resultType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Map;I)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Resolution;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackManipulation", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResultType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resultType_Property
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
					public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "public")]
					public Simple(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Simple;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step;", "public")]
					public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step make(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/Map;I)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Resolution;", "public")]
					public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Resolution resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, Dova.JDK.java.util.Map arg4, int arg5)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Resolution>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation getStackManipulation()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getResultType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Factory;", "public abstract static interface")]
				public partial interface Factory
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Factory()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Factory;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step;"));
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step;", "public abstract")]
					Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step make(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Resolution;", "public abstract static interface")]
				public partial interface Resolution
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Resolution()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Resolution;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackManipulation", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResultType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
					Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation getStackManipulation()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
					Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getResultType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation;", "public static")]
		public partial class ForMethodInvocation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMethodInvocation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THIS_REFERENCE", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodResolver", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int THIS_REFERENCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
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

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver;", "private final")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.MethodResolver methodResolver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.MethodResolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMethodInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver;)V", "public")]
			public ForMethodInvocation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.MethodResolver arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, int arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfMatchedMethod;", "public static")]
			public partial class OfMatchedMethod
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfMatchedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfMatchedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
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
				public OfMatchedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)V", "public")]
				public OfMatchedMethod(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfMatchedMethod;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfGivenMethod;", "public static")]
			public partial class OfGivenMethod
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfGivenMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfGivenMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
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
				public OfGivenMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)V", "public")]
				public OfGivenMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfGivenMethod;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;", "static final")]
			public partial class OfInstrumentedMethod
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfInstrumentedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;", "public static final")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$OfInstrumentedMethod;", "public static")]
				public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.OfInstrumentedMethod>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver;", "public abstract static interface")]
			public partial interface MethodResolver
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodResolver()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/method/MethodDescription;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver$Matching;", "public static")]
				public partial class Matching
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.MethodResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Matching()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver$Matching;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/method/MethodDescription;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
					public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Matching(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
					public Matching(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver$Matching;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver$Simple;", "public static")]
				public partial class Simple
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForMethodInvocation.MethodResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/method/MethodDescription;"));
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
					public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)V", "public")]
					public Simple(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForMethodInvocation$MethodResolver$Simple;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess;", "public static")]
		public partial class ForFieldAccess
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForFieldAccess()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldResolver", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver;", "private final")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForFieldAccess.FieldResolver fieldResolver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForFieldAccess.FieldResolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForFieldAccess(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver;)V", "public")]
			public ForFieldAccess(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForFieldAccess.FieldResolver arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, int arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$OfMatchedField;", "public static")]
			public partial class OfMatchedField
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfMatchedField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$OfMatchedField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
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
				public OfMatchedField(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
				public OfMatchedField(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$OfMatchedField;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$OfGivenField;", "public static")]
			public partial class OfGivenField
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfGivenField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$OfGivenField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
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
				public OfGivenField(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "public")]
				public OfGivenField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$OfGivenField;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
				public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver;", "public abstract static interface")]
			public partial interface FieldResolver
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldResolver()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/field/FieldDescription;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/field/FieldDescription;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver$ForElementMatcher;", "public static")]
				public partial class ForElementMatcher
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForFieldAccess.FieldResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForElementMatcher()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver$ForElementMatcher;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/field/FieldDescription;"));
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForElementMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
					public ForElementMatcher(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver$ForElementMatcher;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver$Simple;", "public static")]
				public partial class Simple
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.ForFieldAccess.FieldResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/field/FieldDescription;"));
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
					public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "public")]
					public Simple(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$ForFieldAccess$FieldResolver$Simple;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;", "public static final")]
		public partial class Stubbing
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Stubbing()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;", "public static final")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Stubbing(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Stubbing(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Stubbing;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Stubbing>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/ByteCodeElement;Lnet/bytebuddy/description/type/TypeList$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.ByteCodeElement arg1, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg3, int arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/asm/MemberSubstitution$Substitution;", "public abstract")]
			Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;", "public abstract static interface")]
	public partial interface TypePoolResolver
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypePoolResolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;", "public abstract")]
		Dova.JDK.net.bytebuddy.pool.TypePool resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$ForClassFileLocator;", "public static")]
		public partial class ForClassFileLocator
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForClassFileLocator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$ForClassFileLocator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerMode", "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode readerMode_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForClassFileLocator(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "public")]
			public ForClassFileLocator(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V", "public")]
			public ForClassFileLocator(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$ForClassFileLocator;";
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

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver of(Dova.JDK.java.lang.ClassLoader arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$ForExplicitPool;", "public static")]
		public partial class ForExplicitPool
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForExplicitPool()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$ForExplicitPool;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForExplicitPool(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)V", "public")]
			public ForExplicitPool(Dova.JDK.net.bytebuddy.pool.TypePool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$ForExplicitPool;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;", "public static final")]
		public partial class OfImplicitPool
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfImplicitPool()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;", "public static final")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfImplicitPool(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public OfImplicitPool(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver$OfImplicitPool;", "public static")]
			public static Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver.OfImplicitPool>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public abstract static")]
	public partial class WithoutSpecification
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithoutSpecification()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePoolResolver", "Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strict", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "replacementFactory", "Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stub", "()Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWithField", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWithMethod", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWithMethod", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWithInstrumentedMethod", "()Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWithChain", "(Ljava/util/List;)Lnet/bytebuddy/asm/MemberSubstitution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWithChain", "([Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;", "protected final")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver typePoolResolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "protected final")]
		public bool strict_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;", "protected final")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory replacementFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithoutSpecification(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;)V", "protected")]
		public WithoutSpecification(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;", "public abstract")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution stub()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWithField(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWithMethod(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWithMethod(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWithInstrumentedMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWithChain(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Chain$Step$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;", "public transient")]
		public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWithChain(JavaArray<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Chain.Step.Factory> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedMethod;", "public static")]
		public partial class ForMatchedMethod
			: Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMatchedMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeVirtualCalls", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "includeSuperCalls", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;ZZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onVirtualCall", "()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onSuperCall", "()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
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

			[JniSignatureAttribute("Z", "private final")]
			public bool includeVirtualCalls_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool includeSuperCalls_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMatchedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
			public ForMatchedMethod(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;ZZ)V", "protected")]
			public ForMatchedMethod(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg4, bool arg5, bool arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedMethod;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification onVirtualCall()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification onSuperCall()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedField;", "public static")]
		public partial class ForMatchedField
			: Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMatchedField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchRead", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchWrite", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;ZZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onRead", "()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWrite", "()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;"));
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

			[JniSignatureAttribute("Z", "private final")]
			public bool matchRead_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool matchWrite_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForMatchedField(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
			public ForMatchedField(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;ZZ)V", "protected")]
			public ForMatchedField(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg4, bool arg5, bool arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedField;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification onRead()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification onWrite()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedByteCodeElement;", "protected static")]
		public partial class ForMatchedByteCodeElement
			: Dova.JDK.net.bytebuddy.asm.MemberSubstitution.WithoutSpecification
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForMatchedByteCodeElement()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedByteCodeElement;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceWith", "(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;"));
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
			public ForMatchedByteCodeElement(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/asm/MemberSubstitution$TypePoolResolver;ZLnet/bytebuddy/asm/MemberSubstitution$Replacement$Factory;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
			public ForMatchedByteCodeElement(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg0, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.TypePoolResolver arg1, bool arg2, Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Replacement.Factory arg3, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberSubstitution$WithoutSpecification$ForMatchedByteCodeElement;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/asm/MemberSubstitution$Substitution$Factory;)Lnet/bytebuddy/asm/MemberSubstitution;", "public")]
			public Dova.JDK.net.bytebuddy.asm.MemberSubstitution replaceWith(Dova.JDK.net.bytebuddy.asm.MemberSubstitution.Substitution.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberSubstitution>(ret);
			}
		}
	}
}
