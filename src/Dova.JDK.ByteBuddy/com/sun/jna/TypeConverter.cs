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

namespace Dova.JDK.com.sun.jna;

[JniSignatureAttribute("Lcom/sun/jna/TypeConverter;", "public abstract interface")]
public partial interface TypeConverter
	: IJavaObject
	, Dova.JDK.com.sun.jna.FromNativeConverter
	, Dova.JDK.com.sun.jna.ToNativeConverter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }


	static TypeConverter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/TypeConverter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
	}
}
