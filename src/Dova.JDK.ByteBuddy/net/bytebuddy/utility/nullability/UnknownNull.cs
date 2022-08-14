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

namespace Dova.JDK.net.bytebuddy.utility.nullability;

[JniSignatureAttribute("Lnet/bytebuddy/utility/nullability/UnknownNull;", "public abstract interface")]
public partial interface UnknownNull
	: IJavaObject
	, Dova.JDK.java.lang.annotation.Annotation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static UnknownNull()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/nullability/UnknownNull;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
