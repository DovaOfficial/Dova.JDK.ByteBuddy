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

namespace Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;", "public final")]
public partial class GenericTypeAwareAssigner
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GenericTypeAwareAssigner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assign", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GenericTypeAwareAssigner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public GenericTypeAwareAssigner(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation assign(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor;", "protected static")]
	public partial class IsAssignableToVisitor
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IsAssignableToVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "polymorphic", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeDescription_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool polymorphic_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IsAssignableToVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "public")]
		public IsAssignableToVisitor(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V", "protected")]
		public IsAssignableToVisitor(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
		public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfNonGenericType;", "protected static")]
		public partial class OfNonGenericType
			: Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner.IsAssignableToVisitor.OfSimpleType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfNonGenericType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfNonGenericType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfNonGenericType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V", "protected")]
			public OfNonGenericType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfNonGenericType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfParameterizedType;", "protected static")]
		public partial class OfParameterizedType
			: Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner.IsAssignableToVisitor.OfSimpleType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfParameterizedType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfParameterizedType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V", "protected")]
			public OfParameterizedType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfParameterizedType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfWildcard;", "protected static")]
		public partial class OfWildcard
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfWildcard()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfWildcard;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wildcard", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic wildcard_Property
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
			public OfWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
			public OfWildcard(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfWildcard;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfGenericArray;", "protected static")]
		public partial class OfGenericArray
			: Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner.IsAssignableToVisitor.OfManifestType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfGenericArray()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfGenericArray;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onGenericArray_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfGenericArray(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V", "protected")]
			public OfGenericArray(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfGenericArray;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onGenericArray_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onGenericArray_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfSimpleType;", "protected abstract static")]
		public partial class OfSimpleType
			: Dova.JDK.net.bytebuddy.implementation.bytecode.assign.reference.GenericTypeAwareAssigner.IsAssignableToVisitor.OfManifestType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfSimpleType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfSimpleType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onParameterizedType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onNonGenericType_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfSimpleType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V", "protected")]
			public OfSimpleType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfSimpleType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onParameterizedType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onParameterizedType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onNonGenericType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onNonGenericType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfManifestType;", "protected abstract static")]
		public partial class OfManifestType
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfManifestType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfManifestType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "polymorphic", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onWildcard_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeDescription_Property
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

			[JniSignatureAttribute("Z", "protected final")]
			public bool polymorphic_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfManifestType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;Z)V", "protected")]
			public OfManifestType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bytecode/assign/reference/GenericTypeAwareAssigner$IsAssignableToVisitor$OfManifestType;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onWildcard_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onWildcard_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Boolean;", "public")]
			public Dova.JDK.java.lang.Boolean onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
			}
		}
	}
}
