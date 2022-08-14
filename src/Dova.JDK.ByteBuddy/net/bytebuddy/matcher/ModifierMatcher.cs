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

namespace Dova.JDK.net.bytebuddy.matcher;

[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher;", "public")]
public partial class ModifierMatcher
	: Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction.ForNonNullValues
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModifierMatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/ModifierMatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ModifierMatcher$Mode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/matcher/ModifierMatcher$Mode;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch_0", "(Lnet/bytebuddy/description/ModifierReviewable;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch_1", "(Ljava/lang/Object;)Z"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode mode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModifierMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ModifierMatcher$Mode;)V", "public")]
	public ModifierMatcher(Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/ModifierMatcher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ModifierMatcher$Mode;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction of(Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/ModifierReviewable;)Z", "protected")]
	public bool doMatch_0(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "protected volatile")]
	public bool doMatch_1(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
	public partial class Mode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Mode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTECTED", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVATE", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINAL", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNCHRONIZED", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRICT", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR_ARGS", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNTHETIC", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BRIDGE", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSTRACT", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOLATILE", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSIENT", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MANDATED", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUMERATION", "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ModifierMatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/ModifierMatcher$Mode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatcher", "()Lnet/bytebuddy/matcher/ModifierMatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode PUBLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode PROTECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode PRIVATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode FINAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode SYNCHRONIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode NATIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode STRICT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode VAR_ARGS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode SYNTHETIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode BRIDGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode ABSTRACT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode TRANSIENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode MANDATED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode ENUMERATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int modifiers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ModifierMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ModifierMatcher matcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Mode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IILjava/lang/String;)V", "private")]
		public Mode(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/ModifierMatcher$Mode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>>(ret);
		}

		[JniSignatureAttribute("()I", "protected")]
		public int getModifiers()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/ModifierMatcher$Mode;", "public static")]
		public static Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher.Mode>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/matcher/ModifierMatcher;", "protected")]
		public Dova.JDK.net.bytebuddy.matcher.ModifierMatcher getMatcher()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ModifierMatcher>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
