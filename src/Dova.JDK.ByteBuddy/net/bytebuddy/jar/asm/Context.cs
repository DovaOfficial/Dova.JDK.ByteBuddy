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

[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Context;", "final")]
public partial class Context
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Context()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/jar/asm/Context;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributePrototypes", "[Lnet/bytebuddy/jar/asm/Attribute;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parsingOptions", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "charBuffer", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentMethodAccessFlags", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentMethodName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentMethodDescriptor", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentMethodLabels", "[Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentTypeAnnotationTarget", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentTypeAnnotationTargetPath", "Lnet/bytebuddy/jar/asm/TypePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentLocalVariableAnnotationRangeStarts", "[Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentLocalVariableAnnotationRangeEnds", "[Lnet/bytebuddy/jar/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentLocalVariableAnnotationRangeIndices", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameLocalCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameLocalCountDelta", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameLocalTypes", "[Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameStackCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentFrameStackTypes", "[Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/Attribute;", "")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute> attributePrototypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Attribute>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int parsingOptions_Property
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

	[JniSignatureAttribute("[C", "")]
	public JavaArray<char> charBuffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentMethodAccessFlags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String currentMethodName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String currentMethodDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/Label;", "")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> currentMethodLabels_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentTypeAnnotationTarget_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/TypePath;", "")]
	public Dova.JDK.net.bytebuddy.jar.asm.TypePath currentTypeAnnotationTargetPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.TypePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/Label;", "")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> currentLocalVariableAnnotationRangeStarts_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/Label;", "")]
	public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label> currentLocalVariableAnnotationRangeEnds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Label>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> currentLocalVariableAnnotationRangeIndices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentFrameOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentFrameType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentFrameLocalCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentFrameLocalCountDelta_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "")]
	public JavaArray<Dova.JDK.java.lang.Object> currentFrameLocalTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int currentFrameStackCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "")]
	public JavaArray<Dova.JDK.java.lang.Object> currentFrameStackTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Context(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Context() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/jar/asm/Context;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
