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

[JniSignatureAttribute("Lnet/bytebuddy/description/DeclaredByType;", "public abstract interface")]
public partial interface DeclaredByType
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DeclaredByType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/DeclaredByType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/DeclaredByType$WithMandatoryDeclaration;", "public abstract static interface")]
	public partial interface WithMandatoryDeclaration
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.DeclaredByType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithMandatoryDeclaration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/DeclaredByType$WithMandatoryDeclaration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}
	}
}
