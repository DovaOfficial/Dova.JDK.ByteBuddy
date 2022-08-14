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

namespace Dova.JDK.net.bytebuddy.implementation.bind;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;", "public final")]
public partial class ArgumentTypeResolver
	: Dova.JDK.java.lang.Enum
	, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ArgumentTypeResolver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolveByScore", "(I)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolveRivalBinding", "(Lnet/bytebuddy/description/type/TypeDescription;ILnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;ILnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;", "public static final")]
	public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ArgumentTypeResolver(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
	public ArgumentTypeResolver(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "private static")]
	public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolveByScore(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;ILnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;ILnet/bytebuddy/implementation/bind/MethodDelegationBinder$MethodBinding;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "private static")]
	public static Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolveRivalBinding(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg2, int arg3, Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.MethodBinding arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$ParameterIndexToken;", "public static")]
	public partial class ParameterIndexToken
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParameterIndexToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$ParameterIndexToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterIndex", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int parameterIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParameterIndexToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public ParameterIndexToken(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$ParameterIndexToken;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "protected static final")]
	public partial class PrimitiveTypePrecedence
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrimitiveTypePrecedence()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "score", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forPrimitive", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence CHARACTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int score_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrimitiveTypePrecedence(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
		public PrimitiveTypePrecedence(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence forPrimitive(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
		}

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bind/ArgumentTypeResolver$PrimitiveTypePrecedence;)Lnet/bytebuddy/implementation/bind/MethodDelegationBinder$AmbiguityResolver$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution resolve(Dova.JDK.net.bytebuddy.implementation.bind.ArgumentTypeResolver.PrimitiveTypePrecedence arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bind.MethodDelegationBinder.AmbiguityResolver.Resolution>(ret);
		}
	}
}
