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

namespace Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public final")]
public partial class PrimitiveUnboxingDelegate
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrimitiveUnboxingDelegate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wrapperType", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primitiveType", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unboxingMethodName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unboxingMethodDescriptor", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Class;Ljava/lang/Class;Lnet/bytebuddy/implementation/bytecode/StackSize;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forPrimitive", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;)Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forReferenceType", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$UnboxingResponsible;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWrapperType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate BOOLEAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate BYTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate SHORT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate CHARACTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate INTEGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate LONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate FLOAT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate DOUBLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription wrapperType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription primitiveType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size size_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String unboxingMethodName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String unboxingMethodDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrimitiveUnboxingDelegate(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Class;Ljava/lang/Class;Lnet/bytebuddy/implementation/bytecode/StackSize;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public PrimitiveUnboxingDelegate(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.Class arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate forPrimitive(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
	}

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isValid()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;)Lnet/bytebuddy/description/type/TypeDescription;", "static")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription access_000(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$UnboxingResponsible;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.UnboxingResponsible forReferenceType(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.UnboxingResponsible>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getWrapperType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ImplicitlyTypedUnboxingResponsible;", "protected static")]
	public partial class ImplicitlyTypedUnboxingResponsible
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.UnboxingResponsible
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ImplicitlyTypedUnboxingResponsible()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ImplicitlyTypedUnboxingResponsible;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "originalType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assignUnboxedTo", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic originalType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ImplicitlyTypedUnboxingResponsible(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
		public ImplicitlyTypedUnboxingResponsible(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ImplicitlyTypedUnboxingResponsible;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation assignUnboxedTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$UnboxingResponsible;", "public abstract static interface")]
	public partial interface UnboxingResponsible
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UnboxingResponsible()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$UnboxingResponsible;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assignUnboxedTo", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation assignUnboxedTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "protected static final")]
	public partial class ExplicitlyTypedUnboxingResponsible
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.UnboxingResponsible
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExplicitlyTypedUnboxingResponsible()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "primitiveUnboxingDelegate", "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assignUnboxedTo", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible CHARACTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate primitiveUnboxingDelegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ExplicitlyTypedUnboxingResponsible(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate;)V", "private")]
		public ExplicitlyTypedUnboxingResponsible(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/primitive/PrimitiveUnboxingDelegate$ExplicitlyTypedUnboxingResponsible;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.primitive.PrimitiveUnboxingDelegate.ExplicitlyTypedUnboxingResponsible>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation assignUnboxedTo(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}
}
