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

[JniSignatureAttribute("Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
public partial class ModifierAdjustment
	: Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModifierAdjustment()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/ModifierAdjustment;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAdjustments", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAdjustments", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAdjustments", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_0", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap_1", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/asm/ModifierAdjustment$ModifierAdjustingClassVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodModifiers", "(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethodModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeModifiers", "(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFieldModifiers", "(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFieldModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFieldModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFieldModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokableModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokableModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokableModifiers", "(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInvokableModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withConstructorModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withConstructorModifiers", "(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withConstructorModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withConstructorModifiers", "(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List typeAdjustments_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List fieldAdjustments_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List methodAdjustments_Property
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
	public ModifierAdjustment(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ModifierAdjustment() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "protected")]
	public ModifierAdjustment(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/ModifierAdjustment;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "public volatile")]
	public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor wrap_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/asm/ModifierAdjustment$ModifierAdjustingClassVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment.ModifierAdjustingClassVisitor wrap_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment.ModifierAdjustingClassVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withMethodModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withMethodModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withMethodModifiers(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withMethodModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withTypeModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withTypeModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withTypeModifiers(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withTypeModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withFieldModifiers(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withFieldModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withFieldModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withFieldModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withInvokableModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withInvokableModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withInvokableModifiers(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withInvokableModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withConstructorModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withConstructorModifiers(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public transient")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withConstructorModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Ljava/util/List;)Lnet/bytebuddy/asm/ModifierAdjustment;", "public")]
	public Dova.JDK.net.bytebuddy.asm.ModifierAdjustment withConstructorModifiers(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.ModifierAdjustment>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/ModifierAdjustment$ModifierAdjustingClassVisitor;", "protected static")]
	public partial class ModifierAdjustingClassVisitor
		: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModifierAdjustingClassVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/ModifierAdjustment$ModifierAdjustingClassVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAdjustments", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAdjustments", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAdjustments", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List typeAdjustments_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List fieldAdjustments_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List methodAdjustments_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map fields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map methods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModifierAdjustingClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;Ljava/util/Map;)V", "protected")]
		public ModifierAdjustingClassVisitor(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg4, Dova.JDK.java.util.Map arg5, Dova.JDK.java.util.Map arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/ModifierAdjustment$ModifierAdjustingClassVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
		public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "public")]
		public void visitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/ModifierAdjustment$Adjustment;", "protected static")]
	public partial class Adjustment
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.ElementMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Adjustment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/ModifierAdjustment$Adjustment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolver", "Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(I)I"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "private final")]
		public Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver resolver_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Adjustment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;)V", "protected")]
		public Adjustment(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/ModifierAdjustment$Adjustment;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool matches(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "protected")]
		public int resolve(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}
	}
}
