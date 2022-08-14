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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/InliningImplementationMatcher;", "public")]
public partial class InliningImplementationMatcher
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InliningImplementationMatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/InliningImplementationMatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoredMethods", "Lnet/bytebuddy/matcher/LatentMatcher;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "predefinedMethodSignatures", "Lnet/bytebuddy/matcher/ElementMatcher;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/LatentMatcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.LatentMatcher ignoredMethods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher predefinedMethodSignatures_Property
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
	public InliningImplementationMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
	public InliningImplementationMatcher(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/InliningImplementationMatcher;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/LatentMatcher;", "protected static")]
	public static Dova.JDK.net.bytebuddy.matcher.LatentMatcher of(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;", "public")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
	}
}
