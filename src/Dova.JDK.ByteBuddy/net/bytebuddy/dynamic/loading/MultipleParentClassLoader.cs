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

namespace Dova.JDK.net.bytebuddy.dynamic.loading;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader;", "public")]
public partial class MultipleParentClassLoader
	: Dova.JDK.net.bytebuddy.dynamic.loading.InjectionClassLoader
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MultipleParentClassLoader()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parents", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/List;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/List;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResource", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResources", "(Ljava/lang/String;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDefineClasses", "(Ljava/util/Map;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doRegisterAsParallelCapable", "()V"));
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List parents_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MultipleParentClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/List;)V", "public")]
	public MultipleParentClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public MultipleParentClassLoader(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/List;Z)V", "public")]
	public MultipleParentClassLoader(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.List arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/Class;", "protected")]
	public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration getResources(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "protected")]
	public Dova.JDK.java.util.Map doDefineClasses(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void doRegisterAsParallelCapable()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public static")]
	public partial class Builder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLY", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sealed", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoaders", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "([Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Ljava/lang/ClassLoader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Ljava/lang/ClassLoader;)Ljava/lang/ClassLoader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendMostSpecific", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendMostSpecific", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendMostSpecific", "([Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendMostSpecific", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doBuild", "(Ljava/lang/ClassLoader;)Ljava/lang/ClassLoader;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int ONLY_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool @sealed_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List classLoaders_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Builder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;Z)V", "private")]
		public Builder(Dova.JDK.java.util.List arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public Builder(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Builder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder append(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder append(JavaArray<Dova.JDK.java.lang.ClassLoader> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder append(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder append(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder filter(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
		public Dova.JDK.java.lang.ClassLoader build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Ljava/lang/ClassLoader;", "public")]
		public Dova.JDK.java.lang.ClassLoader build(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder appendMostSpecific(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder appendMostSpecific(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder appendMostSpecific(JavaArray<Dova.JDK.java.lang.ClassLoader> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder appendMostSpecific(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.MultipleParentClassLoader.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Ljava/lang/ClassLoader;", "private")]
		public Dova.JDK.java.lang.ClassLoader doBuild(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$CompoundEnumeration;", "protected static")]
	public partial class CompoundEnumeration
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Enumeration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompoundEnumeration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$CompoundEnumeration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIRST", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumerations", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Ljava/util/Enumeration;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasMoreElements", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextElement_1", "()Ljava/net/URL;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int FIRST_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List enumerations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Enumeration;", "private")]
		public Dova.JDK.java.util.Enumeration current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompoundEnumeration(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "protected")]
		public CompoundEnumeration(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/MultipleParentClassLoader$CompoundEnumeration;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool hasMoreElements()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object nextElement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/URL;", "public")]
		public Dova.JDK.java.net.URL nextElement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}
	}
}
