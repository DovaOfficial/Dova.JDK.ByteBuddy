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

namespace Dova.JDK.net.bytebuddy.implementation;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod;", "public")]
public partial class ToStringMethod
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.implementation.Implementation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ToStringMethod()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/ToStringMethod;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING_BUILDER_CONSTRUCTOR", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TO_STRING", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefixResolver", "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "separator", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "definer", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignored", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/matcher/ElementMatcher$Junction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prefixedBySimpleClassName", "()Lnet/bytebuddy/implementation/ToStringMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender_0", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/ToStringMethod$Appender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender_1", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withIgnoredFields", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/ToStringMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prefixedBy", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/ToStringMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prefixedBy", "(Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;)Lnet/bytebuddy/implementation/ToStringMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prefixedByCanonicalClassName", "()Lnet/bytebuddy/implementation/ToStringMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTokens", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "prefixedByFullyQualifiedClassName", "()Lnet/bytebuddy/implementation/ToStringMethod;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape STRING_BUILDER_CONSTRUCTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape TO_STRING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;", "private final")]
	public Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver prefixResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String start_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String end_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String separator_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String definer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction ignored_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ToStringMethod(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;)V", "protected")]
	public ToStringMethod(Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/matcher/ElementMatcher$Junction;)V", "private")]
	public ToStringMethod(Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/ToStringMethod;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_000()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_100()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/ToStringMethod;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod prefixedBySimpleClassName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/ToStringMethod$Appender;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.ToStringMethod.Appender appender_0(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.Appender>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public volatile")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender_1(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/implementation/ToStringMethod;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.ToStringMethod withIgnoredFields(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/ToStringMethod;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod prefixedBy(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;)Lnet/bytebuddy/implementation/ToStringMethod;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod prefixedBy(Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/ToStringMethod;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod prefixedByCanonicalClassName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation;", "public")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation withTokens(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/ToStringMethod;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod prefixedByFullyQualifiedClassName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "protected abstract static")]
	public partial class ValueConsumer
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValueConsumer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER_SEQUENCE", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REFERENCE_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NESTED_ARRAY", "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/ToStringMethod$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer CHARACTER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer INTEGER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer CHARACTER_SEQUENCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer OBJECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer BOOLEAN_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer BYTE_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer SHORT_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer CHARACTER_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer INTEGER_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer LONG_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer FLOAT_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer DOUBLE_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer REFERENCE_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer NESTED_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValueConsumer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ValueConsumer(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/ToStringMethod$1;)V", "")]
		public ValueConsumer(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.ToStringMethod arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/ToStringMethod$ValueConsumer;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.ValueConsumer>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected static")]
		public static Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isValid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;", "public abstract static interface")]
	public partial interface PrefixResolver
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrefixResolver()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$ForFixedValue;", "public static")]
		public partial class ForFixedValue
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForFixedValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$ForFixedValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefix", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String prefix_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForFixedValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
			public ForFixedValue(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$ForFixedValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "public abstract static")]
		public partial class Default
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULLY_QUALIFIED_CLASS_NAME", "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANONICAL_CLASS_NAME", "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIMPLE_CLASS_NAME", "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/ToStringMethod$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default FULLY_QUALIFIED_CLASS_NAME_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default CANONICAL_CLASS_NAME_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default SIMPLE_CLASS_NAME_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
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

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/ToStringMethod$1;)V", "")]
			public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.ToStringMethod arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$Appender;", "protected static")]
	public partial class Appender
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Appender()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/ToStringMethod$Appender;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefix", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "separator", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "definer", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescriptions", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String prefix_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String start_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String end_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String separator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String definer_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List fieldDescriptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "protected")]
		public Appender(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.util.List arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/ToStringMethod$Appender;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
		}
	}
}
