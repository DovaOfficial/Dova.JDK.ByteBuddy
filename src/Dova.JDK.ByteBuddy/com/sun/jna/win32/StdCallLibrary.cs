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

namespace Dova.JDK.com.sun.jna.win32;

[JniSignatureAttribute("Lcom/sun/jna/win32/StdCallLibrary;", "public abstract interface")]
public partial interface StdCallLibrary
	: IJavaObject
	, Dova.JDK.com.sun.jna.Library
	, Dova.JDK.com.sun.jna.win32.StdCall
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StdCallLibrary()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/win32/StdCallLibrary;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STDCALL_CONVENTION", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FUNCTION_MAPPER", "Lcom/sun/jna/FunctionMapper;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int STDCALL_CONVENTION_Property
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

	[JniSignatureAttribute("Lcom/sun/jna/FunctionMapper;", "public static final")]
	public static Dova.JDK.com.sun.jna.FunctionMapper FUNCTION_MAPPER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.FunctionMapper>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/win32/StdCallLibrary$StdCallCallback;", "public abstract static interface")]
	public partial interface StdCallCallback
		: IJavaObject
		, Dova.JDK.com.sun.jna.Callback
		, Dova.JDK.com.sun.jna.win32.StdCall
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static StdCallCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/win32/StdCallLibrary$StdCallCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}
}
