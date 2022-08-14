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

[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher;", "public")]
public partial class MethodSortMatcher
	: Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction.ForNonNullValues
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodSortMatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/MethodSortMatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sort", "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch_0", "(Lnet/bytebuddy/description/method/MethodDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch_1", "(Ljava/lang/Object;)Z"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort sort_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MethodSortMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;)V", "public")]
	public MethodSortMatcher(Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/MethodSortMatcher;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "public static")]
	public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction of(Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Z", "protected")]
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

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public abstract static")]
	public partial class Sort
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Sort()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD", "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR", "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_INITIALIZER", "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VIRTUAL", "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_METHOD", "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/MethodSortMatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lnet/bytebuddy/matcher/MethodSortMatcher$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatcher", "()Lnet/bytebuddy/matcher/MethodSortMatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSort", "(Lnet/bytebuddy/description/method/MethodDescription;)Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort CONSTRUCTOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort TYPE_INITIALIZER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort VIRTUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort DEFAULT_METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String description_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/MethodSortMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher matcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Sort(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public Sort(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Lnet/bytebuddy/matcher/MethodSortMatcher$1;)V", "")]
		public Sort(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/MethodSortMatcher$Sort;", "public static")]
		public static Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher.Sort>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/matcher/MethodSortMatcher;", "protected")]
		public Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher getMatcher()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.MethodSortMatcher>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Z", "protected abstract")]
		public bool isSort(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}
	}
}
