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

namespace Dova.JDK.net.bytebuddy.jar.asm;

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute;", "public")]
public partial class Attribute
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Attribute()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Attribute;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "content", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nextAttribute", "Lnet/bytebuddy/jar/asm/Attribute;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Lnet/bytebuddy/jar/asm/ClassWriter;[BIII)Lnet/bytebuddy/jar/asm/ByteVector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Lnet/bytebuddy/jar/asm/ClassReader;II[CI[Lnet/bytebuddy/jar/asm/Label;)Lnet/bytebuddy/jar/asm/Attribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeAttributesSize", "(Lnet/bytebuddy/jar/asm/SymbolTable;[BIII)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "computeAttributesSize", "(Lnet/bytebuddy/jar/asm/SymbolTable;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "computeAttributesSize", "(Lnet/bytebuddy/jar/asm/SymbolTable;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAttributes", "(Lnet/bytebuddy/jar/asm/SymbolTable;Lnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "putAttributes", "(Lnet/bytebuddy/jar/asm/SymbolTable;[BIIILnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "putAttributes", "(Lnet/bytebuddy/jar/asm/SymbolTable;IILnet/bytebuddy/jar/asm/ByteVector;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnknown", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCodeAttribute", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabels", "()[Lnet/bytebuddy/jar/asm/Label;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributeCount", "()I"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String type_Property
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

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> content_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.Attribute nextAttribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Attribute>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Attribute(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
	public Attribute(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Attribute;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;[BIII)I", "final")]
	public int computeAttributesSize(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, JavaArray<byte> arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;)I", "final")]
	public int computeAttributesSize(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;II)I", "static")]
	public static int computeAttributesSize(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;Lnet/bytebuddy/jar/asm/ByteVector;)V", "final")]
	public void putAttributes(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;[BIIILnet/bytebuddy/jar/asm/ByteVector;)V", "final")]
	public void putAttributes(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, JavaArray<byte> arg1, int arg2, int arg3, int arg4, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/SymbolTable;IILnet/bytebuddy/jar/asm/ByteVector;)V", "static")]
	public static void putAttributes(Dova.JDK.net.bytebuddy.jar.asm.SymbolTable arg0, int arg1, int arg2, Dova.JDK.net.bytebuddy.jar.asm.ByteVector arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUnknown()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isCodeAttribute()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()[Lnet/bytebuddy/jar/asm/Label;", "protected")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> getLabels()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label>>(ret);
	}

	[JniSignatureAttribute("()I", "final")]
	public int getAttributeCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Attribute$Set;", "static final")]
	public partial class Set
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Set()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Attribute$Set;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZE_INCREMENT", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "[Lnet/bytebuddy/jar/asm/Attribute;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lnet/bytebuddy/jar/asm/Attribute;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "()[Lnet/bytebuddy/jar/asm/Attribute;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Lnet/bytebuddy/jar/asm/Attribute;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttributes", "(Lnet/bytebuddy/jar/asm/Attribute;)V"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int SIZE_INCREMENT_Property
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

		[JniSignatureAttribute("I", "private")]
		public int size_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/Attribute;", "private")]
		public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Set(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public Set() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Attribute$Set;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "private")]
		public void add(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()[Lnet/bytebuddy/jar/asm/Attribute;", "")]
		public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute> toArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute>>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)Z", "private")]
		public bool contains(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Attribute;)V", "")]
		public void addAttributes(Dova.JDK.net.bytebuddy.jar.asm.Attribute arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
