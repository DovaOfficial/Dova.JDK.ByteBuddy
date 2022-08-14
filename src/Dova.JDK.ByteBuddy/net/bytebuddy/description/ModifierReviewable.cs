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

namespace Dova.JDK.net.bytebuddy.description;

[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable;", "public abstract interface")]
public partial interface ModifierReviewable
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModifierReviewable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_MASK", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynthetic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSyntheticState", "()Lnet/bytebuddy/description/modifier/SyntheticState;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int EMPTY_MASK_Property
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

	[JniSignatureAttribute("()I", "public abstract")]
	int getModifiers()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isSynthetic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isFinal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/SyntheticState;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.modifier.SyntheticState getSyntheticState()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.SyntheticState>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForTypeDefinition
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForFieldDescription
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForMethodDescription
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.ForParameterDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotation", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnum", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynthetic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPublic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtected", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMandated", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBridge", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFinal", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAbstract", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVolatile", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrivate", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNative", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynchronized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTransient", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStrict", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecated", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSynchronizationState", "()Lnet/bytebuddy/description/modifier/SynchronizationState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodStrictness", "()Lnet/bytebuddy/description/modifier/MethodStrictness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodManifestation", "()Lnet/bytebuddy/description/modifier/MethodManifestation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeManifestation", "()Lnet/bytebuddy/description/modifier/TypeManifestation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPackagePrivate", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnership", "()Lnet/bytebuddy/description/modifier/Ownership;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumerationState", "()Lnet/bytebuddy/description/modifier/EnumerationState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSyntheticState", "()Lnet/bytebuddy/description/modifier/SyntheticState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterManifestation", "()Lnet/bytebuddy/description/modifier/ParameterManifestation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvisioningState", "()Lnet/bytebuddy/description/modifier/ProvisioningState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchesMask", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldManifestation", "()Lnet/bytebuddy/description/modifier/FieldManifestation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldPersistence", "()Lnet/bytebuddy/description/modifier/FieldPersistence;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/ModifierReviewable$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isInterface()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnnotation()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isEnum()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isStatic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSynthetic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPublic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isProtected()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isVarArgs()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isMandated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isBridge()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFinal()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAbstract()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isVolatile()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrivate()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNative()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSynchronized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTransient()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isStrict()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDeprecated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/SynchronizationState;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.SynchronizationState getSynchronizationState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.SynchronizationState>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/MethodStrictness;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.MethodStrictness getMethodStrictness()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.MethodStrictness>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/MethodManifestation;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.MethodManifestation getMethodManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.MethodManifestation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/TypeManifestation;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.TypeManifestation getTypeManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.TypeManifestation>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPackagePrivate()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Ownership;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.Ownership getOwnership()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Ownership>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/EnumerationState;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.EnumerationState getEnumerationState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/SyntheticState;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.SyntheticState getSyntheticState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.SyntheticState>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/ParameterManifestation;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.ParameterManifestation getParameterManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ParameterManifestation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/ProvisioningState;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.ProvisioningState getProvisioningState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ProvisioningState>(ret);
		}

		[JniSignatureAttribute("(I)Z", "private")]
		public bool matchesMask(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/FieldManifestation;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.FieldManifestation getFieldManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.FieldManifestation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/FieldPersistence;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.FieldPersistence getFieldPersistence()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.FieldPersistence>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$ForParameterDescription;", "public abstract static interface")]
	public partial interface ForParameterDescription
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForParameterDescription()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$ForParameterDescription;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMandated", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterManifestation", "()Lnet/bytebuddy/description/modifier/ParameterManifestation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProvisioningState", "()Lnet/bytebuddy/description/modifier/ProvisioningState;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isMandated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/ParameterManifestation;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.ParameterManifestation getParameterManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ParameterManifestation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/ProvisioningState;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.ProvisioningState getProvisioningState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ProvisioningState>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$ForMethodDescription;", "public abstract static interface")]
	public partial interface ForMethodDescription
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.OfAbstraction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForMethodDescription()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$ForMethodDescription;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVarArgs", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBridge", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNative", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynchronized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStrict", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSynchronizationState", "()Lnet/bytebuddy/description/modifier/SynchronizationState;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodStrictness", "()Lnet/bytebuddy/description/modifier/MethodStrictness;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodManifestation", "()Lnet/bytebuddy/description/modifier/MethodManifestation;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isVarArgs()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isBridge()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isNative()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isSynchronized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isStrict()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/SynchronizationState;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.SynchronizationState getSynchronizationState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.SynchronizationState>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/MethodStrictness;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.MethodStrictness getMethodStrictness()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.MethodStrictness>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/MethodManifestation;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.MethodManifestation getMethodManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.MethodManifestation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$ForFieldDescription;", "public abstract static interface")]
	public partial interface ForFieldDescription
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.OfEnumeration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForFieldDescription()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$ForFieldDescription;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVolatile", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTransient", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldManifestation", "()Lnet/bytebuddy/description/modifier/FieldManifestation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldPersistence", "()Lnet/bytebuddy/description/modifier/FieldPersistence;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isVolatile()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isTransient()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/FieldManifestation;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.FieldManifestation getFieldManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.FieldManifestation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/FieldPersistence;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.FieldPersistence getFieldPersistence()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.FieldPersistence>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$ForTypeDefinition;", "public abstract static interface")]
	public partial interface ForTypeDefinition
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.OfAbstraction
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.OfEnumeration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForTypeDefinition()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$ForTypeDefinition;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInterface", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnnotation", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeManifestation", "()Lnet/bytebuddy/description/modifier/TypeManifestation;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isInterface()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isAnnotation()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/TypeManifestation;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.TypeManifestation getTypeManifestation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.TypeManifestation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$OfEnumeration;", "public abstract static interface")]
	public partial interface OfEnumeration
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.OfByteCodeElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfEnumeration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$OfEnumeration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnum", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnumerationState", "()Lnet/bytebuddy/description/modifier/EnumerationState;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isEnum()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/EnumerationState;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.EnumerationState getEnumerationState()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.EnumerationState>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$OfAbstraction;", "public abstract static interface")]
	public partial interface OfAbstraction
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable.OfByteCodeElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfAbstraction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$OfAbstraction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAbstract", "()Z"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isAbstract()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/ModifierReviewable$OfByteCodeElement;", "public abstract static interface")]
	public partial interface OfByteCodeElement
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.ModifierReviewable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfByteCodeElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/ModifierReviewable$OfByteCodeElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPublic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProtected", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrivate", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecated", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPackagePrivate", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnership", "()Lnet/bytebuddy/description/modifier/Ownership;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isStatic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isPublic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isProtected()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isPrivate()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isDeprecated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isPackagePrivate()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Ownership;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.Ownership getOwnership()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Ownership>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
		}
	}
}
