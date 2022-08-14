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

namespace Dova.JDK.net.bytebuddy.build;

[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint;", "public abstract interface")]
public partial interface EntryPoint
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EntryPoint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/EntryPoint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteBuddy", "(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/ByteBuddy;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ByteBuddy arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/ByteBuddy;", "public abstract")]
	Dova.JDK.net.bytebuddy.ByteBuddy byteBuddy(Dova.JDK.net.bytebuddy.ClassFileVersion arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint$Unvalidated;", "public static")]
	public partial class Unvalidated
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.build.EntryPoint
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Unvalidated()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/EntryPoint$Unvalidated;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/build/EntryPoint;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/EntryPoint;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "byteBuddy", "(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/ByteBuddy;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint;", "private final")]
		public Dova.JDK.net.bytebuddy.build.EntryPoint @delegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.EntryPoint>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Unvalidated(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/EntryPoint;)V", "public")]
		public Unvalidated(Dova.JDK.net.bytebuddy.build.EntryPoint arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/EntryPoint$Unvalidated;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ByteBuddy arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/ByteBuddy;", "public")]
		public Dova.JDK.net.bytebuddy.ByteBuddy byteBuddy(Dova.JDK.net.bytebuddy.ClassFileVersion arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint$Default;", "public abstract static")]
	public partial class Default
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.build.EntryPoint
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/EntryPoint$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REBASE", "Lnet/bytebuddy/build/EntryPoint$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDEFINE", "Lnet/bytebuddy/build/EntryPoint$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDEFINE_LOCAL", "Lnet/bytebuddy/build/EntryPoint$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECORATE", "Lnet/bytebuddy/build/EntryPoint$Default;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/EntryPoint$Default;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/build/EntryPoint$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/EntryPoint$Default;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/EntryPoint$Default;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.build.EntryPoint.Default REBASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.build.EntryPoint.Default REDEFINE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.build.EntryPoint.Default REDEFINE_LOCAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint$Default;", "public static final")]
		public static Dova.JDK.net.bytebuddy.build.EntryPoint.Default DECORATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/build/EntryPoint$Default;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.build.EntryPoint.Default> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/build/EntryPoint$1;)V", "")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.build.EntryPoint arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/EntryPoint$Default;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/build/EntryPoint$Default;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.build.EntryPoint.Default> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/EntryPoint$Default;", "public static")]
		public static Dova.JDK.net.bytebuddy.build.EntryPoint.Default valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.EntryPoint.Default>(ret);
		}
	}
}
