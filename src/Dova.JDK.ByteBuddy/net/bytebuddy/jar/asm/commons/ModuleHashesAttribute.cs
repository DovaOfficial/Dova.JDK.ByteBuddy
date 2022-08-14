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

namespace Dova.JDK.net.bytebuddy.jar.asm.commons;

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/commons/ModuleHashesAttribute;", "public final")]
public partial class ModuleHashesAttribute
	: Dova.JDK.net.bytebuddy.jar.asm.Attribute
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleHashesAttribute()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/commons/ModuleHashesAttribute;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "algorithm", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modules", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashes", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lnet/bytebuddy/jar/asm/ClassWriter;[BIII)Lnet/bytebuddy/jar/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Lnet/bytebuddy/jar/asm/ClassReader;II[CI[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Attribute;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String algorithm_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List modules_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List hashes_Property
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
	public ModuleHashesAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", "public")]
	public ModuleHashesAttribute(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ModuleHashesAttribute() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/commons/ModuleHashesAttribute;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassWriter;[BIII)Lnet/bytebuddy/jar/asm/ByteVector;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.ByteVector write(Dova.JDK.net.bytebuddy.jar.asm.ClassWriter arg0, JavaArray<byte> arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ByteVector>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassReader;II[CI[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Attribute;", "protected")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute read(Dova.JDK.net.bytebuddy.jar.asm.ClassReader arg0, int arg1, int arg2, JavaArray<char> arg3, int arg4, JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
	}
}
