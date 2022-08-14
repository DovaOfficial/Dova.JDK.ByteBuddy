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

[JniSignatureAttribute("Lcom/sun/jna/StructureReadContext;", "public")]
public partial class StructureReadContext
	: Dova.JDK.com.sun.jna.FromNativeContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StructureReadContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/StructureReadContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "structure", "Lcom/sun/jna/Structure;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/Structure;Ljava/lang/reflect/Field;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getField", "()Ljava/lang/reflect/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStructure", "()Lcom/sun/jna/Structure;"));
	}

	[JniSignatureAttribute("Lcom/sun/jna/Structure;", "private")]
	public Dova.JDK.com.sun.jna.Structure structure_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Field;", "private")]
	public Dova.JDK.java.lang.reflect.Field field_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StructureReadContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jna/Structure;Ljava/lang/reflect/Field;)V", "")]
	public StructureReadContext(Dova.JDK.com.sun.jna.Structure arg0, Dova.JDK.java.lang.reflect.Field arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/StructureReadContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/reflect/Field;", "public")]
	public Dova.JDK.java.lang.reflect.Field getField()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/Structure;", "public")]
	public Dova.JDK.com.sun.jna.Structure getStructure()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.Structure>(ret);
	}
}
