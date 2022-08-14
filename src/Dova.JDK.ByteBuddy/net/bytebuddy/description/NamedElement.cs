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

[JniSignatureAttribute("Lnet/bytebuddy/description/NamedElement;", "public abstract interface")]
public partial interface NamedElement
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NamedElement()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/NamedElement;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NAME", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_NAME", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NO_NAME_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EMPTY_NAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getActualName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/NamedElement$WithDescriptor;", "public abstract static interface")]
	public partial interface WithDescriptor
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.NamedElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithDescriptor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/NamedElement$WithDescriptor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NON_GENERIC_SIGNATURE", "Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String NON_GENERIC_SIGNATURE_Property
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

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getGenericSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/NamedElement$WithGenericName;", "public abstract static interface")]
	public partial interface WithGenericName
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.NamedElement.WithRuntimeName
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithGenericName()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/NamedElement$WithGenericName;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String toGenericString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/NamedElement$WithOptionalName;", "public abstract static interface")]
	public partial interface WithOptionalName
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.NamedElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithOptionalName()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/NamedElement$WithOptionalName;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isNamed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/NamedElement$WithRuntimeName;", "public abstract static interface")]
	public partial interface WithRuntimeName
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.NamedElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithRuntimeName()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/NamedElement$WithRuntimeName;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getInternalName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
