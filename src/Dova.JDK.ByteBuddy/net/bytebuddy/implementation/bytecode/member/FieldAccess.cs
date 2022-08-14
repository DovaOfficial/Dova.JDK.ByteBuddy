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

namespace Dova.JDK.net.bytebuddy.implementation.bytecode.member;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "public final")]
public partial class FieldAccess
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldAccess()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "putterOpcode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getterOpcode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetSizeChange", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IIILnet/bytebuddy/implementation/bytecode/StackSize;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forEnumeration", "(Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forField", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forField", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess STATIC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int putterOpcode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int getterOpcode_Property
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

	[JniSignatureAttribute("I", "private final")]
	public int targetSizeChange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FieldAccess(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;IIILnet/bytebuddy/implementation/bytecode/StackSize;)V", "private")]
	public FieldAccess(Dova.JDK.java.lang.String arg0, int arg1, int arg2, int arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;)I", "static")]
	public static int access_400(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation forEnumeration(Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;)I", "static")]
	public static int access_200(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;)I", "static")]
	public static int access_300(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined forField(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined forField(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;", "protected")]
	public partial class AccessDispatcher
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessDispatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "private final")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape fieldDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;", "final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)V", "protected")]
		public AccessDispatcher(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation write()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation read()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "static")]
		public static Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape access_000(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$FieldPutInstruction;", "protected")]
		public partial class FieldPutInstruction
			: Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher.AbstractFieldInstruction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldPutInstruction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$FieldPutInstruction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpcode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSize", "(Lnet/bytebuddy/implementation/bytecode/StackSize;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldPutInstruction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)V", "protected")]
			public FieldPutInstruction(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$FieldPutInstruction;";
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

			[JniSignatureAttribute("()I", "protected")]
			public int getOpcode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackSize;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size resolveSize(Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$FieldGetInstruction;", "protected")]
		public partial class FieldGetInstruction
			: Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher.AbstractFieldInstruction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldGetInstruction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$FieldGetInstruction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpcode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSize", "(Lnet/bytebuddy/implementation/bytecode/StackSize;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldGetInstruction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)V", "protected")]
			public FieldGetInstruction(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$FieldGetInstruction;";
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

			[JniSignatureAttribute("()I", "protected")]
			public int getOpcode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackSize;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size resolveSize(Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$AbstractFieldInstruction;", "private abstract")]
		public partial class AbstractFieldInstruction
			: Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractFieldInstruction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$AbstractFieldInstruction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$1;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpcode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSize", "(Lnet/bytebuddy/implementation/bytecode/StackSize;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractFieldInstruction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$1;)V", "")]
			public AbstractFieldInstruction(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher;)V", "private")]
			public AbstractFieldInstruction(Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.AccessDispatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$AccessDispatcher$AbstractFieldInstruction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}

			[JniSignatureAttribute("()I", "protected abstract")]
			public int getOpcode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackSize;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size resolveSize(Dova.JDK.net.bytebuddy.implementation.bytecode.StackSize arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$OfGenericField;", "protected static")]
	public partial class OfGenericField
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OfGenericField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$OfGenericField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetType", "Lnet/bytebuddy/description/type/TypeDefinition;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defined", "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition targetType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined defined_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OfGenericField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;)V", "protected")]
		public OfGenericField(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$OfGenericField;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;)Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;", "protected static")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined of(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.member.FieldAccess.Defined>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation write()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation read()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;", "public abstract static interface")]
	public partial interface Defined
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Defined()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/member/FieldAccess$Defined;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation write()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation read()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}
	}
}
