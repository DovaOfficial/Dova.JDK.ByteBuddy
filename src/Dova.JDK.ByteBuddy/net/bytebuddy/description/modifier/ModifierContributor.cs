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

namespace Dova.JDK.net.bytebuddy.description.modifier;

[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor;", "public abstract interface")]
public partial interface ModifierContributor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModifierContributor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/ModifierContributor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_MASK", "I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefault", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMask", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRange", "()I"));
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

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isDefault()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getMask()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getRange()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "public static")]
	public partial class Resolver
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifierContributors", "Ljava/util/Collection;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/Collection;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/Collection;", "private final")]
		public Dova.JDK.java.util.Collection modifierContributors_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Resolver(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)V", "protected")]
		public Resolver(Dova.JDK.java.util.Collection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;";
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

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver of(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver of(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver of(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver of(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver of(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForParameter> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int resolve(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int resolve()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;", "public abstract static interface")]
	public partial interface ForParameter
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForParameter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MASK_Property
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;", "public abstract static interface")]
	public partial interface ForMethod
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MASK_Property
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;", "public abstract static interface")]
	public partial interface ForField
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MASK_Property
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;", "public abstract static interface")]
	public partial interface ForType
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MASK", "I"));
		}

		[JniSignatureAttribute("I", "public static final")]
		public static int MASK_Property
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
	}
}
