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

[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin;", "public abstract interface")]
public partial interface Plugin
	: IJavaObject
	, Dova.JDK.net.bytebuddy.matcher.ElementMatcher
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Plugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$ForElementMatcher;", "public abstract static")]
	public partial class ForElementMatcher
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.build.Plugin
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForElementMatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$ForElementMatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForElementMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)V", "protected")]
		public ForElementMatcher(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$ForElementMatcher;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool matches(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool matches(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$NoOp;", "public static")]
	public partial class NoOp
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.build.Plugin
		, Dova.JDK.net.bytebuddy.build.Plugin.Factory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public NoOp() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$NoOp;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool matches(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Z", "public")]
		public bool matches(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
		public Dova.JDK.net.bytebuddy.build.Plugin make()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine;", "public abstract static interface")]
	public partial interface Engine
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Engine()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_EXTENSION", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_INFO", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_INFO", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUGIN_FILE", "Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/io/File;Ljava/io/File;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/io/File;Ljava/io/File;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignore", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/ByteBuddy;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$Listener;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withErrorHandlers", "(Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withErrorHandlers", "([Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutErrorHandlers", "()Lnet/bytebuddy/build/Plugin$Engine;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParallelTransformation", "(I)Lnet/bytebuddy/build/Plugin$Engine;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String CLASS_FILE_EXTENSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String MODULE_INFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String PACKAGE_INFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String PLUGIN_FILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1, JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target arg1, JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine ignore(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.ByteBuddy arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Listener;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine withErrorHandlers(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine withErrorHandlers(JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine withoutErrorHandlers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/build/Plugin$Engine;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin.Engine withParallelTransformation(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default;", "public static")]
		public partial class Default
			: Dova.JDK.net.bytebuddy.build.Plugin.Engine.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteBuddy", "Lnet/bytebuddy/ByteBuddy;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeStrategy", "Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "poolStrategy", "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listener", "Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorHandler", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dispatcherFactory", "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoredTypeMatcher", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/build/Plugin$Engine$Listener;Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;Lnet/bytebuddy/matcher/ElementMatcher$Junction;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/ByteBuddy;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "main", "([Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/build/EntryPoint;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignore", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "scan", "(Ljava/lang/ClassLoader;)Ljava/util/Set;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$Listener;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/ByteBuddy;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1400", "(Lnet/bytebuddy/build/Plugin$Engine$Default;)Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1200", "(Lnet/bytebuddy/build/Plugin$Engine$Default;)Lnet/bytebuddy/ByteBuddy;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$800", "(Lnet/bytebuddy/build/Plugin$Engine$Default;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withErrorHandlers", "(Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutErrorHandlers", "()Lnet/bytebuddy/build/Plugin$Engine;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/ByteBuddy;", "private final")]
			public Dova.JDK.net.bytebuddy.ByteBuddy byteBuddy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;", "private final")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy typeStrategy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;", "private final")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy poolStrategy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener;", "private final")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener listener_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;", "private final")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler errorHandler_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;", "private final")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory dispatcherFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction ignoredTypeMatcher_Property
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
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/build/Plugin$Engine$Listener;Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;Lnet/bytebuddy/matcher/ElementMatcher$Junction;)V", "protected")]
			public Default(Dova.JDK.net.bytebuddy.ByteBuddy arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy arg1, Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy arg2, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg3, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg4, Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler arg5, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory arg6, Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;)V", "protected")]
			public Default(Dova.JDK.net.bytebuddy.ByteBuddy arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;)V", "public")]
			public Default(Dova.JDK.net.bytebuddy.ByteBuddy arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public Default() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Default;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/String;)V", "public static transient")]
			public static void main(JavaArray<Dova.JDK.java.lang.String> arg0)
			{
				DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/EntryPoint;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/build/Plugin$Engine;", "public static")]
			public static Dova.JDK.net.bytebuddy.build.Plugin.Engine of(Dova.JDK.net.bytebuddy.build.EntryPoint arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine ignore(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Ljava/util/Set;", "public static")]
			public static Dova.JDK.java.util.Set scan(Dova.JDK.java.lang.ClassLoader arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Listener;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine with(Dova.JDK.net.bytebuddy.ByteBuddy arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default;)Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;", "static")]
			public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy access_1400(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default;)Lnet/bytebuddy/ByteBuddy;", "static")]
			public static Dova.JDK.net.bytebuddy.ByteBuddy access_1200(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ByteBuddy>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default;)Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "static")]
			public static Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction access_800(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine withErrorHandlers(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine withoutErrorHandlers()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;", "private")]
			public partial class Preprocessor
				: Dova.JDK.java.lang.Object
				, Dova.JDK.java.util.concurrent.Callable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Preprocessor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listener", "Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plugins", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preprocessors", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/build/Plugin$Engine$Default;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default;Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Ljava/lang/String;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/build/Plugin$Engine$Listener;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/build/Plugin$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default;Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Ljava/lang/String;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/build/Plugin$Engine$Listener;Ljava/util/List;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Ljava/util/concurrent/Callable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1600", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1700", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1300", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1500", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1800", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/pool/TypePool;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1900", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Ljava/lang/String;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element element_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String typeName_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener listener_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List plugins_Property
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

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List preprocessors_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default;", "final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Preprocessor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default;Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Ljava/lang/String;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/build/Plugin$Engine$Listener;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/build/Plugin$1;)V", "")]
				public Preprocessor(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg5, Dova.JDK.java.util.List arg6, Dova.JDK.java.util.List arg7, Dova.JDK.net.bytebuddy.build.Plugin arg8) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default;Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Ljava/lang/String;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/build/Plugin$Engine$Listener;Ljava/util/List;Ljava/util/List;)V", "private")]
				public Preprocessor(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg3, Dova.JDK.net.bytebuddy.pool.TypePool arg4, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg5, Dova.JDK.java.util.List arg6, Dova.JDK.java.util.List arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/concurrent/Callable;", "public")]
				public Dova.JDK.java.util.concurrent.Callable call_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Callable>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object call_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/build/Plugin$Engine$Listener;", "static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener access_1600(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element access_1700(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "static")]
				public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator access_1300(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Ljava/util/List;", "static")]
				public static Dova.JDK.java.util.List access_1500(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Lnet/bytebuddy/pool/TypePool;", "static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool access_1800(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)Ljava/lang/String;", "static")]
				public static Dova.JDK.java.lang.String access_1900(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Unresolved;", "private")]
				public partial class Unresolved
					: Dova.JDK.java.lang.Object
					, Dova.JDK.java.util.concurrent.Callable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Unresolved()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Unresolved;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/build/Plugin$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;", "final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Unresolved(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/build/Plugin$1;)V", "")]
					public Unresolved(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;)V", "private")]
					public Unresolved(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Unresolved;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable call_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object call_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Ignored;", "private")]
				public partial class Ignored
					: Dova.JDK.java.lang.Object
					, Dova.JDK.java.util.concurrent.Callable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Ignored()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Ignored;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;", "final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Ignored(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin$1;)V", "")]
					public Ignored(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.build.Plugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;)V", "private")]
					public Ignored(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Ignored;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable call_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object call_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Resolved;", "private")]
				public partial class Resolved
					: Dova.JDK.java.lang.Object
					, Dova.JDK.java.util.concurrent.Callable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Resolved()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Resolved;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;", "final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin$1;)V", "")]
					public Resolved(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.build.Plugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor;Lnet/bytebuddy/description/type/TypeDescription;)V", "private")]
					public Resolved(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Default.Preprocessor arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Default$Preprocessor$Resolved;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable call_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object call_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.build.Plugin.Engine
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/io/File;Ljava/io/File;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/io/File;Ljava/io/File;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withErrorHandlers", "([Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)Lnet/bytebuddy/build/Plugin$Engine;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParallelTransformation", "(I)Lnet/bytebuddy/build/Plugin$Engine;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public transient")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1, JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
			}

			[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1, Dova.JDK.java.util.List arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/build/Plugin$Engine$Target;[Lnet/bytebuddy/build/Plugin$Factory;)Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public transient")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary apply(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target arg1, JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Summary>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)Lnet/bytebuddy/build/Plugin$Engine;", "public transient")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine withErrorHandlers(JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/build/Plugin$Engine;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Engine withParallelTransformation(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Summary;", "public static")]
		public partial class Summary
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Summary()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Summary;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformed", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failed", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unresolved", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransformed", "()Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFailed", "()Ljava/util/Map;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnresolved", "()Ljava/util/List;"));
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List transformed_Property
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

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map failed_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List unresolved_Property
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
			public Summary(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "public")]
			public Summary(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Summary;";
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

			[JniSignatureAttribute("()Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List getTransformed()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Map;", "public")]
			public Dova.JDK.java.util.Map getFailed()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List getUnresolved()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;", "public abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
			, Dova.JDK.java.io.Closeable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/util/concurrent/Callable;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/Callable;Z)V", "public abstract")]
			void accept(Dova.JDK.java.util.concurrent.Callable arg0, bool arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("()V", "public abstract")]
			void complete()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation;", "public static")]
			public partial class ForParallelTransformation
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForParallelTransformation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sink", "Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformed", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failed", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unresolved", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preprocessings", "Ljava/util/concurrent/CompletionService;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "materializers", "Ljava/util/concurrent/CompletionService;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deferred", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "futures", "Ljava/util/Set;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/util/concurrent/Callable;Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink sink_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List transformed_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map failed_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List unresolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/concurrent/CompletionService;", "private final")]
				public Dova.JDK.java.util.concurrent.CompletionService preprocessings_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionService>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/concurrent/CompletionService;", "private final")]
				public Dova.JDK.java.util.concurrent.CompletionService materializers_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.CompletionService>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private")]
				public int deferred_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
					}
				}

				[JniSignatureAttribute("Ljava/util/Set;", "private final")]
				public Dova.JDK.java.util.Set futures_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForParallelTransformation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/concurrent/Executor;Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "protected")]
				public ForParallelTransformation(Dova.JDK.java.util.concurrent.Executor arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/util/concurrent/Callable;Z)V", "public")]
				public void accept(Dova.JDK.java.util.concurrent.Callable arg0, bool arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
				}

				[JniSignatureAttribute("()V", "public")]
				public void complete()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$EagerWork;", "protected static")]
				public partial class EagerWork
					: Dova.JDK.java.lang.Object
					, Dova.JDK.java.util.concurrent.Callable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static EagerWork()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$EagerWork;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "work", "Ljava/util/concurrent/Callable;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Callable;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_0", "()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call_1", "()Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Ljava/util/concurrent/Callable;", "private final")]
					public Dova.JDK.java.util.concurrent.Callable work_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Callable>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public EagerWork(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)V", "protected")]
					public EagerWork(Dova.JDK.java.util.concurrent.Callable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$EagerWork;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable call_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object call_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$Factory;", "public static")]
				public partial class Factory
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Factory()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$Factory;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executor", "Ljava/util/concurrent/Executor;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/Executor;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;"));
					}

					[JniSignatureAttribute("Ljava/util/concurrent/Executor;", "private final")]
					public Dova.JDK.java.util.concurrent.Executor executor_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.Executor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/concurrent/Executor;)V", "public")]
					public Factory(Dova.JDK.java.util.concurrent.Executor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$Factory;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher make(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$WithThrowawayExecutorService;", "public static")]
				public partial class WithThrowawayExecutorService
					: Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForParallelTransformation
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithThrowawayExecutorService()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$WithThrowawayExecutorService;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "executorService", "Ljava/util/concurrent/ExecutorService;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ExecutorService;Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					}

					[JniSignatureAttribute("Ljava/util/concurrent/ExecutorService;", "private final")]
					public Dova.JDK.java.util.concurrent.ExecutorService executorService_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ExecutorService>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithThrowawayExecutorService(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/concurrent/ExecutorService;Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "protected")]
					public WithThrowawayExecutorService(Dova.JDK.java.util.concurrent.ExecutorService arg0, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$WithThrowawayExecutorService;";
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

					[JniSignatureAttribute("()V", "public")]
					public void close()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$WithThrowawayExecutorService$Factory;", "public static")]
					public partial class Factory
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Factory()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$WithThrowawayExecutorService$Factory;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "threads", "I"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;"));
						}

						[JniSignatureAttribute("I", "private final")]
						public int threads_Property
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
						public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(I)V", "public")]
						public Factory(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForParallelTransformation$WithThrowawayExecutorService$Factory;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;", "public")]
						public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher make(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher>(ret);
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation;", "public static")]
			public partial class ForSerialTransformation
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForSerialTransformation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sink", "Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformed", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "failed", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unresolved", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preprocessings", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/util/concurrent/Callable;Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "()V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink sink_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List transformed_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map failed_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List unresolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List preprocessings_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForSerialTransformation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "protected")]
				public ForSerialTransformation(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/util/concurrent/Callable;Z)V", "public")]
				public void accept(Dova.JDK.java.util.concurrent.Callable arg0, bool arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
				}

				[JniSignatureAttribute("()V", "public")]
				public void complete()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;", "public static final")]
				public partial class Factory
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Factory
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Factory()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;", "public static final")]
					public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$ForSerialTransformation$Factory;", "public static")]
					public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.ForSerialTransformation.Factory>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher make(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;", "public abstract static interface")]
			public partial interface Factory
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Engine$Dispatcher;", "public abstract")]
				Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher make(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;", "public abstract static interface")]
			public partial interface Materializable
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Materializable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "public abstract")]
				void materialize(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForUnresolvedElement;", "public static")]
				public partial class ForUnresolvedElement
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForUnresolvedElement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForUnresolvedElement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "private final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element element_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String typeName_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForUnresolvedElement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Ljava/lang/String;)V", "protected")]
					public ForUnresolvedElement(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForUnresolvedElement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "public")]
					public void materialize(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForFailedElement;", "public static")]
				public partial class ForFailedElement
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForFailedElement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForFailedElement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errored", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "private final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element element_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List errored_Property
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
					public ForFailedElement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
					public ForFailedElement(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForFailedElement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "public")]
					public void materialize(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForRetainedElement;", "public static")]
				public partial class ForRetainedElement
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForRetainedElement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForRetainedElement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "private final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element element_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForRetainedElement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V", "protected")]
					public ForRetainedElement(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForRetainedElement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "public")]
					public void materialize(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForTransformedElement;", "public static")]
				public partial class ForTransformedElement
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Dispatcher.Materializable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTransformedElement()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForTransformedElement;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dynamicType", "Lnet/bytebuddy/dynamic/DynamicType;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType;", "private final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType dynamicType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForTransformedElement(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;)V", "protected")]
					public ForTransformedElement(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Dispatcher$Materializable$ForTransformedElement;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;Ljava/util/List;Ljava/util/Map;Ljava/util/List;)V", "public")]
					public void materialize(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target;", "public abstract static interface")]
		public partial interface Target
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Target()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
			}

			[JniSignatureAttribute("(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "public abstract")]
			Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink write(Dova.JDK.java.util.jar.Manifest arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$ForJarFile;", "public static")]
			public partial class ForJarFile
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForJarFile()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target$ForJarFile;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/io/File;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
				}

				[JniSignatureAttribute("Ljava/io/File;", "private final")]
				public Dova.JDK.java.io.File file_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForJarFile(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
				public ForJarFile(Dova.JDK.java.io.File arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Target$ForJarFile;";
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

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink write(Dova.JDK.java.util.jar.Manifest arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$ForFolder;", "public static")]
			public partial class ForFolder
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForFolder()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target$ForFolder;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/io/File;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retain", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V"));
				}

				[JniSignatureAttribute("Ljava/io/File;", "private final")]
				public Dova.JDK.java.io.File folder_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForFolder(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
				public ForFolder(Dova.JDK.java.io.File arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Target$ForFolder;";
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

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void store(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink write(Dova.JDK.java.util.jar.Manifest arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V", "public")]
				public void retain(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$InMemory;", "public static")]
			public partial class InMemory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static InMemory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target$InMemory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "storage", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTypeMap", "()Ljava/util/Map;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStorage", "()Ljava/util/Map;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retain", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V"));
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map storage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public InMemory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public InMemory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public InMemory(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Target$InMemory;";
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

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void store(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink write(Dova.JDK.java.util.jar.Manifest arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("()Ljava/util/Map;", "public")]
				public Dova.JDK.java.util.Map toTypeMap()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Map;", "public")]
				public Dova.JDK.java.util.Map getStorage()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V", "public")]
				public void retain(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;", "public static final")]
			public partial class Discarding
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Discarding()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retain", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Discarding(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Discarding(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding>>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void store(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Target$Discarding;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Discarding>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink write(Dova.JDK.java.util.jar.Manifest arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V", "public")]
				public void retain(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;", "public abstract static interface")]
			public partial interface Sink
				: IJavaObject
				, Dova.JDK.java.io.Closeable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Sink()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target$Sink;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retain", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V"));
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public abstract")]
				void store(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V", "public abstract")]
				void retain(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Target$Sink$ForJarOutputStream;", "public static")]
				public partial class ForJarOutputStream
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Target.Sink
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJarOutputStream()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Target$Sink$ForJarOutputStream;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outputStream", "Ljava/util/jar/JarOutputStream;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/jar/JarOutputStream;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "store", "(Ljava/util/Map;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retain", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V"));
					}

					[JniSignatureAttribute("Ljava/util/jar/JarOutputStream;", "private final")]
					public Dova.JDK.java.util.jar.JarOutputStream outputStream_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarOutputStream>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJarOutputStream(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/jar/JarOutputStream;)V", "public")]
					public ForJarOutputStream(Dova.JDK.java.util.jar.JarOutputStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Target$Sink$ForJarOutputStream;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
					public void store(Dova.JDK.java.util.Map arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					}

					[JniSignatureAttribute("()V", "public")]
					public void close()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Element;)V", "public")]
					public void retain(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source;", "public abstract static interface")]
		public partial interface Source
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Source()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public abstract")]
			Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin read()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Filtering;", "public static")]
			public partial class Filtering
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Filtering()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Filtering;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/build/Plugin$Engine$Source;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifest", "Z"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/matcher/ElementMatcher;Z)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
				public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Z", "private final")]
				public bool manifest_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Filtering(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
				public Filtering(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source;Lnet/bytebuddy/matcher/ElementMatcher;Z)V", "public")]
				public Filtering(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Filtering;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin read()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$ForJarFile;", "public static")]
			public partial class ForJarFile
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForJarFile()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$ForJarFile;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/io/File;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
				}

				[JniSignatureAttribute("Ljava/io/File;", "private final")]
				public Dova.JDK.java.io.File file_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForJarFile(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
				public ForJarFile(Dova.JDK.java.io.File arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$ForJarFile;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin read()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;", "public static")]
			public partial class ForFolder
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForFolder()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/io/File;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "(Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;)Ljava/io/File;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileLocator", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				}

				[JniSignatureAttribute("Ljava/io/File;", "private final")]
				public Dova.JDK.java.io.File folder_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForFolder(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/io/File;)V", "public")]
				public ForFolder(Dova.JDK.java.io.File arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;";
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

				[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
				public Dova.JDK.java.util.Iterator iterator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin read()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public")]
				public Dova.JDK.java.util.jar.Manifest getManifest()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;)Ljava/io/File;", "static")]
				public static Dova.JDK.java.io.File access_600(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.ForFolder arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator getClassFileLocator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder$FolderIterator;", "protected")]
				public partial class FolderIterator
					: Dova.JDK.java.lang.Object
					, Dova.JDK.java.util.Iterator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static FolderIterator()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder$FolderIterator;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "files", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;Ljava/io/File;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List files_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;", "final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.ForFolder this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.ForFolder>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public FolderIterator(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder;Ljava/io/File;)V", "protected")]
					public FolderIterator(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.ForFolder arg0, Dova.JDK.java.io.File arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$ForFolder$FolderIterator;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()V", "public")]
					public void remove()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool hasNext()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object next_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element next_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$InMemory;", "public static")]
			public partial class InMemory
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static InMemory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$InMemory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "storage", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileLocator", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofTypes", "(Ljava/util/Collection;)Lnet/bytebuddy/build/Plugin$Engine$Source;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofTypes", "([Ljava/lang/Class;)Lnet/bytebuddy/build/Plugin$Engine$Source;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofTypes", "(Ljava/util/Map;)Lnet/bytebuddy/build/Plugin$Engine$Source;"));
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map storage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public InMemory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public InMemory(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$InMemory;";
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

				[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
				public Dova.JDK.java.util.Iterator iterator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin read()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public")]
				public Dova.JDK.java.util.jar.Manifest getManifest()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator getClassFileLocator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/build/Plugin$Engine$Source;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source ofTypes(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source>(ret);
				}

				[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/build/Plugin$Engine$Source;", "public static transient")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source ofTypes(JavaArray<Dova.JDK.java.lang.Class> arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)Lnet/bytebuddy/build/Plugin$Engine$Source;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source ofTypes(Dova.JDK.java.util.Map arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$InMemory$MapEntryIterator;", "protected static")]
				public partial class MapEntryIterator
					: Dova.JDK.java.lang.Object
					, Dova.JDK.java.util.Iterator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MapEntryIterator()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$InMemory$MapEntryIterator;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iterator", "Ljava/util/Iterator;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Iterator;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
					}

					[JniSignatureAttribute("Ljava/util/Iterator;", "private final")]
					public Dova.JDK.java.util.Iterator iterator_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MapEntryIterator(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/Iterator;)V", "protected")]
					public MapEntryIterator(Dova.JDK.java.util.Iterator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$InMemory$MapEntryIterator;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()V", "public")]
					public void remove()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool hasNext()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object next_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element next_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;", "public static final")]
			public partial class Empty
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Empty()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileLocator", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Empty(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Empty(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Source$Empty;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Empty>(ret);
				}

				[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
				public Dova.JDK.java.util.Iterator iterator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin read()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void close()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
				}

				[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public")]
				public Dova.JDK.java.util.jar.Manifest getManifest()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator getClassFileLocator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "public abstract static interface")]
			public partial interface Element
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Element()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/InputStream;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAs", "(Ljava/lang/Class;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String getName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Ljava/io/InputStream;", "public abstract")]
				Dova.JDK.java.io.InputStream getInputStream()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object resolveAs(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForJarEntry;", "public static")]
				public partial class ForJarEntry
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJarEntry()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForJarEntry;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/util/jar/JarFile;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entry", "Ljava/util/jar/JarEntry;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/InputStream;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAs", "(Ljava/lang/Class;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Ljava/util/jar/JarFile;", "private final")]
					public Dova.JDK.java.util.jar.JarFile file_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/jar/JarEntry;", "private final")]
					public Dova.JDK.java.util.jar.JarEntry entry_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJarEntry(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/jar/JarFile;Ljava/util/jar/JarEntry;)V", "public")]
					public ForJarEntry(Dova.JDK.java.util.jar.JarFile arg0, Dova.JDK.java.util.jar.JarEntry arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForJarEntry;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getName()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
					public Dova.JDK.java.io.InputStream getInputStream()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object resolveAs(Dova.JDK.java.lang.Class arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForFile;", "public static")]
				public partial class ForFile
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForFile()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForFile;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljava/io/File;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/io/File;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;Ljava/io/File;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/InputStream;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAs", "(Ljava/lang/Class;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Ljava/io/File;", "private final")]
					public Dova.JDK.java.io.File root_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/io/File;", "private final")]
					public Dova.JDK.java.io.File file_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForFile(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public")]
					public ForFile(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForFile;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getName()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
					public Dova.JDK.java.io.InputStream getInputStream()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object resolveAs(Dova.JDK.java.lang.Class arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForByteArray;", "public static")]
				public partial class ForByteArray
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForByteArray()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForByteArray;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;[B)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/InputStream;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveAs", "(Ljava/lang/Class;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String name_Property
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

					[JniSignatureAttribute("[B", "private final")]
					public JavaArray<byte> binaryRepresentation_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForByteArray(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;[B)V", "public")]
					public ForByteArray(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Element$ForByteArray;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getName()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
					public bool equals(Dova.JDK.java.lang.Object arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return ret;
					}

					[JniSignatureAttribute("()I", "public")]
					public int hashCode()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
					public Dova.JDK.java.io.InputStream getInputStream()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object resolveAs(Dova.JDK.java.lang.Class arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "public abstract static interface")]
			public partial interface Origin
				: IJavaObject
				, Dova.JDK.java.lang.Iterable
				, Dova.JDK.java.io.Closeable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Origin()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_MANIFEST", "Ljava/util/jar/Manifest;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileLocator", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				}

				[JniSignatureAttribute("Ljava/util/jar/Manifest;", "public static final")]
				public static Dova.JDK.java.util.jar.Manifest NO_MANIFEST_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public abstract")]
				Dova.JDK.java.util.jar.Manifest getManifest()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator getClassFileLocator()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$Filtering;", "public static")]
				public partial class Filtering
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Filtering()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$Filtering;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "manifest", "Z"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;Lnet/bytebuddy/matcher/ElementMatcher;Z)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileLocator", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;", "private final")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin @delegate_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
					public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Z", "private final")]
					public bool manifest_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Filtering(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
					public Filtering(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin;Lnet/bytebuddy/matcher/ElementMatcher;Z)V", "public")]
					public Filtering(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$Filtering;";
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

					[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
					public Dova.JDK.java.util.Iterator iterator()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void close()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
					}

					[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public")]
					public Dova.JDK.java.util.jar.Manifest getManifest()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator getClassFileLocator()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$Filtering$FilteringIterator;", "private static")]
					public partial class FilteringIterator
						: Dova.JDK.java.lang.Object
						, Dova.JDK.java.util.Iterator
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static FilteringIterator()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$Filtering$FilteringIterator;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iterator", "Ljava/util/Iterator;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Iterator;Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/build/Plugin$1;)V"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Iterator;Lnet/bytebuddy/matcher/ElementMatcher;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
						}

						[JniSignatureAttribute("Ljava/util/Iterator;", "private final")]
						public Dova.JDK.java.util.Iterator iterator_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
						public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "private")]
						public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element current_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public FilteringIterator(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/util/Iterator;Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/build/Plugin$1;)V", "")]
						public FilteringIterator(Dova.JDK.java.util.Iterator arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1, Dova.JDK.net.bytebuddy.build.Plugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						[JniSignatureAttribute("(Ljava/util/Iterator;Lnet/bytebuddy/matcher/ElementMatcher;)V", "private")]
						public FilteringIterator(Dova.JDK.java.util.Iterator arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$Filtering$FilteringIterator;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()V", "public")]
						public void remove()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
						}

						[JniSignatureAttribute("()Z", "public")]
						public bool hasNext()
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object next_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "public")]
						public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element next_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;", "public static")]
				public partial class ForJarFile
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJarFile()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Ljava/util/jar/JarFile;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/jar/JarFile;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getManifest", "()Ljava/util/jar/Manifest;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;)Ljava/util/jar/JarFile;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileLocator", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
					}

					[JniSignatureAttribute("Ljava/util/jar/JarFile;", "private final")]
					public Dova.JDK.java.util.jar.JarFile file_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJarFile(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/util/jar/JarFile;)V", "public")]
					public ForJarFile(Dova.JDK.java.util.jar.JarFile arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
					public Dova.JDK.java.util.Iterator iterator()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
					}

					[JniSignatureAttribute("()V", "public")]
					public void close()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
					}

					[JniSignatureAttribute("()Ljava/util/jar/Manifest;", "public")]
					public Dova.JDK.java.util.jar.Manifest getManifest()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.Manifest>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;)Ljava/util/jar/JarFile;", "static")]
					public static Dova.JDK.java.util.jar.JarFile access_400(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin.ForJarFile arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator getClassFileLocator()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile$JarFileIterator;", "protected")]
					public partial class JarFileIterator
						: Dova.JDK.java.lang.Object
						, Dova.JDK.java.util.Iterator
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static JarFileIterator()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile$JarFileIterator;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enumeration", "Ljava/util/Enumeration;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;Ljava/util/Enumeration;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNext", "()Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_0", "()Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "next_1", "()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;"));
						}

						[JniSignatureAttribute("Ljava/util/Enumeration;", "private final")]
						public Dova.JDK.java.util.Enumeration enumeration_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;", "final")]
						public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin.ForJarFile this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin.ForJarFile>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public JarFileIterator(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile;Ljava/util/Enumeration;)V", "protected")]
						public JarFileIterator(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Origin.ForJarFile arg0, Dova.JDK.java.util.Enumeration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Source$Origin$ForJarFile$JarFileIterator;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()V", "public")]
						public void remove()
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
						}

						[JniSignatureAttribute("()Z", "public")]
						public bool hasNext()
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
							return ret;
						}

						[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object next_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Source$Element;", "public")]
						public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element next_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Source.Element>(ret);
						}
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener;", "public abstract static interface")]
		public partial interface Listener
			: IJavaObject
			, Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Listener()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDiscovery", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public abstract")]
			void onComplete(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
			void onDiscovery(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public abstract")]
			void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public abstract")]
			void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public abstract")]
			void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public abstract")]
			void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$Compound;", "public static")]
			public partial class Compound
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Compound()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$Compound;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listeners", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/build/Plugin$Engine$Listener;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDiscovery", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List listeners_Property
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
				public Compound(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("([Lnet/bytebuddy/build/Plugin$Engine$Listener;)V", "public transient")]
				public Compound(JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
				public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$Compound;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onComplete(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onDiscovery(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$ForErrorHandler;", "public static")]
			public partial class ForErrorHandler
				: Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.Adapter
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForErrorHandler()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$ForErrorHandler;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorHandler", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler errorHandler_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForErrorHandler(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)V", "public")]
				public ForErrorHandler(Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$ForErrorHandler;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$WithErrorsOnly;", "public static")]
			public partial class WithErrorsOnly
				: Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.Adapter
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithErrorsOnly()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$WithErrorsOnly;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Listener;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithErrorsOnly(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Listener;)V", "public")]
				public WithErrorsOnly(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$WithErrorsOnly;";
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

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$WithTransformationsOnly;", "public static")]
			public partial class WithTransformationsOnly
				: Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.Adapter
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static WithTransformationsOnly()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$WithTransformationsOnly;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin$Engine$Listener;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener;", "private final")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public WithTransformationsOnly(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Engine$Listener;)V", "public")]
				public WithTransformationsOnly(Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$WithTransformationsOnly;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;", "public static")]
			public partial class StreamWriting
				: Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.Adapter
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static StreamWriting()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREFIX", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printStream", "Ljava/io/PrintStream;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/PrintStream;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDiscovery", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemOut", "()Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemError", "()Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTransformationsOnly", "()Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withErrorsOnly", "()Lnet/bytebuddy/build/Plugin$Engine$Listener;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
				public static Dova.JDK.java.lang.String PREFIX_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/io/PrintStream;", "private final")]
				public Dova.JDK.java.io.PrintStream printStream_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public StreamWriting(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/io/PrintStream;)V", "public")]
				public StreamWriting(Dova.JDK.java.io.PrintStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onComplete(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onDiscovery(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.StreamWriting toSystemOut()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.StreamWriting>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Listener$StreamWriting;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.StreamWriting toSystemError()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.StreamWriting>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Listener;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener withTransformationsOnly()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin$Engine$Listener;", "public")]
				public Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener withErrorsOnly()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$Adapter;", "public abstract static")]
			public partial class Adapter
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Adapter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$Adapter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDiscovery", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public Adapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$Adapter;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onComplete(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onDiscovery(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;", "public static final")]
			public partial class NoOp
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static NoOp()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDiscovery", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTransformation", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onIgnored", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public NoOp(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$Listener$NoOp;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.Listener.NoOp>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onComplete(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onDiscovery(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onTransformation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;)V", "public")]
				public void onIgnored(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;", "public abstract static interface")]
		public partial interface ErrorHandler
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ErrorHandler()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public abstract")]
			void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public abstract")]
			void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/util/Map;)V", "public abstract")]
			void onError(Dova.JDK.java.util.Map arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public abstract")]
			void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public abstract")]
			void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
			void onUnresolved(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public abstract")]
			void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
			void onResource(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Compound;", "public static")]
			public partial class Compound
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Compound()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Compound;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errorHandlers", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List errorHandlers_Property
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
				public Compound(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("([Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler;)V", "public transient")]
				public Compound(JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
				public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Compound;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static")]
			public partial class Enforcing
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Enforcing()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_TYPES_RESOLVED", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_LIVE_INITIALIZERS", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILES_ONLY", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MANIFEST_REQUIRED", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/build/Plugin$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing ALL_TYPES_RESOLVED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing NO_LIVE_INITIALIZERS_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing CLASS_FILES_ONLY_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing MANIFEST_REQUIRED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Enforcing(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Enforcing(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/build/Plugin$1;)V", "")]
				public Enforcing(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.build.Plugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Enforcing;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Enforcing>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.build.Plugin arg1, Dova.JDK.java.lang.Throwable arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
				public void onError(Dova.JDK.java.util.Map arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "public abstract static")]
			public partial class Failing
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Failing()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAIL_FAST", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAIL_AFTER_TYPE", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAIL_LAST", "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/build/Plugin$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onError", "(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onLiveInitializer", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onUnresolved", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onManifest", "(Ljava/util/jar/Manifest;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onResource", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing FAIL_FAST_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing FAIL_AFTER_TYPE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing FAIL_LAST_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Failing(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Failing(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/build/Plugin$1;)V", "")]
				public Failing(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.build.Plugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$ErrorHandler$Failing;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.ErrorHandler.Failing>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;Ljava/lang/Throwable;)V", "public")]
				public void onError(Dova.JDK.net.bytebuddy.build.Plugin arg0, Dova.JDK.java.lang.Throwable arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
				public void onLiveInitializer(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onUnresolved(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				}

				[JniSignatureAttribute("(Ljava/util/jar/Manifest;)V", "public")]
				public void onManifest(Dova.JDK.java.util.jar.Manifest arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void onResource(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;", "public abstract static interface")]
		public partial interface PoolStrategy
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PoolStrategy()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typePool", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;", "public abstract")]
			Dova.JDK.net.bytebuddy.pool.TypePool typePool(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;", "public static final")]
			public partial class Eager
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Eager()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAST", "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDED", "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerMode", "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typePool", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager FAST_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager EXTENDED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode readerMode_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Eager(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V", "private")]
				public Eager(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Eager;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Eager>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;", "public static final")]
			public partial class Default
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Default()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAST", "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDED", "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerMode", "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typePool", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default FAST_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default EXTENDED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode readerMode_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default>>(ret);
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

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V", "private")]
				public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$PoolStrategy$Default;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.PoolStrategy.Default>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;", "public abstract static interface")]
		public partial interface TypeStrategy
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeStrategy()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "builder", "(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder builder(Dova.JDK.net.bytebuddy.ByteBuddy arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$ForEntryPoint;", "public static")]
			public partial class ForEntryPoint
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForEntryPoint()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$ForEntryPoint;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entryPoint", "Lnet/bytebuddy/build/EntryPoint;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodNameTransformer", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/EntryPoint;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "builder", "(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/EntryPoint;", "private final")]
				public Dova.JDK.net.bytebuddy.build.EntryPoint entryPoint_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer methodNameTransformer_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForEntryPoint(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/EntryPoint;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V", "public")]
				public ForEntryPoint(Dova.JDK.net.bytebuddy.build.EntryPoint arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$ForEntryPoint;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/ByteBuddy;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder builder(Dova.JDK.net.bytebuddy.ByteBuddy arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "public abstract static")]
			public partial class Default
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Default()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REDEFINE", "Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REBASE", "Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECORATE", "Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/build/Plugin$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default REDEFINE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default REBASE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "public static final")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default DECORATE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default>>(ret);
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

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/build/Plugin$1;)V", "")]
				public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.build.Plugin arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Engine$TypeStrategy$Default;", "public static")]
				public static Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Engine.TypeStrategy.Default>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory;", "public abstract static interface")]
	public partial interface Factory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.Plugin make()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;", "public static")]
		public partial class UsingReflection
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.build.Plugin.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static UsingReflection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argumentResolvers", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "([Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
			public Dova.JDK.java.lang.Class type_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List argumentResolvers_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public UsingReflection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
			public UsingReflection(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/List;)V", "protected")]
			public UsingReflection(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin make()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;", "public transient")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection with(JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection with(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver;", "public abstract static interface")]
			public partial interface ArgumentResolver
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ArgumentResolver()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;"));
				}

				[JniSignatureAttribute("(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;", "public abstract")]
				Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution resolve(int arg0, Dova.JDK.java.lang.Class arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForIndex;", "public static")]
				public partial class ForIndex
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForIndex()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForIndex;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WRAPPER_TYPES", "Ljava/util/Map;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/Object;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Ljava/util/Map;"));
					}

					[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
					public static Dova.JDK.java.util.Map WRAPPER_TYPES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int index_Property
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

					[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
					public Dova.JDK.java.lang.Object value_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForIndex(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(ILjava/lang/Object;)V", "public")]
					public ForIndex(int arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForIndex;";
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

					[JniSignatureAttribute("(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution resolve(int arg0, Dova.JDK.java.lang.Class arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution>(ret);
					}

					[JniSignatureAttribute("()Ljava/util/Map;", "static")]
					public static Dova.JDK.java.util.Map access_000()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForIndex$WithDynamicType;", "public static")]
					public partial class WithDynamicType
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static WithDynamicType()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForIndex$WithDynamicType;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;"));
						}

						[JniSignatureAttribute("I", "private final")]
						public int index_Property
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

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String value_Property
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

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public WithDynamicType(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(ILjava/lang/String;)V", "public")]
						public WithDynamicType(int arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForIndex$WithDynamicType;";
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

						[JniSignatureAttribute("(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;", "public")]
						public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution resolve(int arg0, Dova.JDK.java.lang.Class arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForType;", "public static")]
				public partial class ForType
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/Object;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;Ljava/lang/Object;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;"));
					}

					[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
					public Dova.JDK.java.lang.Class type_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
					public Dova.JDK.java.lang.Object value_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)V", "protected")]
					public ForType(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$ForType;";
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

					[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver;", "public static")]
					public static Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver of(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver>(ret);
					}

					[JniSignatureAttribute("(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution resolve(int arg0, Dova.JDK.java.lang.Class arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;", "public static final")]
				public partial class NoOp
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static NoOp()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;", "public static final")]
					public static Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public NoOp(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public NoOp(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$NoOp;", "public static")]
					public static Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.NoOp>(ret);
					}

					[JniSignatureAttribute("(ILjava/lang/Class;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution resolve(int arg0, Dova.JDK.java.lang.Class arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;", "public abstract static interface")]
				public partial interface Resolution
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Resolution()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgument", "()Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("()Z", "public abstract")]
					bool isResolved()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
						return ret;
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
					Dova.JDK.java.lang.Object getArgument()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Resolved;", "public static")]
					public partial class Resolved
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Resolved()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Resolved;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argument", "Ljava/lang/Object;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgument", "()Ljava/lang/Object;"));
						}

						[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
						public Dova.JDK.java.lang.Object argument_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
						public Resolved(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Resolved;";
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

						[JniSignatureAttribute("()Z", "public")]
						public bool isResolved()
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
							return ret;
						}

						[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
						public Dova.JDK.java.lang.Object getArgument()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;", "public static final")]
					public partial class Unresolved
						: Dova.JDK.java.lang.Enum
						, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Unresolved()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;"));
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArgument", "()Ljava/lang/Object;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;", "public static final")]
						public static Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved INSTANCE_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;", "private static final")]
						public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved> VALUES_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved>>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Unresolved(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
						public Unresolved(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()[Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;", "public static")]
						public static JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved> values()
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved>>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$ArgumentResolver$Resolution$Unresolved;", "public static")]
						public static Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved valueOf(Dova.JDK.java.lang.String arg0)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.ArgumentResolver.Resolution.Unresolved>(ret);
						}

						[JniSignatureAttribute("()Z", "public")]
						public bool isResolved()
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
							return ret;
						}

						[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
						public Dova.JDK.java.lang.Object getArgument()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Priority;", "public abstract static interface")]
			public partial interface Priority
				: IJavaObject
				, Dova.JDK.java.lang.annotation.Annotation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Priority()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Priority;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()I"));
				}

				[JniSignatureAttribute("I", "public static final")]
				public static int DEFAULT_Property
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

				[JniSignatureAttribute("()I", "public abstract")]
				int value()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;", "protected abstract static interface")]
			public partial interface Instantiator
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Instantiator()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "()Lnet/bytebuddy/build/Plugin;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceBy", "(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;"));
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public abstract")]
				Dova.JDK.net.bytebuddy.build.Plugin instantiate()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;", "public abstract")]
				Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator replaceBy(Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator.Resolved arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;", "public static")]
				public partial class Resolved
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Resolved()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arguments", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructor", "()Ljava/lang/reflect/Constructor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "()Lnet/bytebuddy/build/Plugin;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceBy", "(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;"));
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private final")]
					public Dova.JDK.java.lang.reflect.Constructor constructor_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List arguments_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljava/util/List;)V", "protected")]
					public Resolved(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;";
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

					[JniSignatureAttribute("()Ljava/lang/reflect/Constructor;", "protected")]
					public Dova.JDK.java.lang.reflect.Constructor getConstructor()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin instantiate()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator replaceBy(Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator.Resolved arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Ambiguous;", "public static")]
				public partial class Ambiguous
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Ambiguous()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Ambiguous;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "left", "Ljava/lang/reflect/Constructor;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "right", "Ljava/lang/reflect/Constructor;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "priority", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "I"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;Ljava/lang/reflect/Constructor;II)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "()Lnet/bytebuddy/build/Plugin;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceBy", "(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;"));
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private final")]
					public Dova.JDK.java.lang.reflect.Constructor left_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private final")]
					public Dova.JDK.java.lang.reflect.Constructor right_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("I", "private final")]
					public int priority_Property
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
					public int parameters_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Ambiguous(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljava/lang/reflect/Constructor;II)V", "protected")]
					public Ambiguous(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.java.lang.reflect.Constructor arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Ambiguous;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin instantiate()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator replaceBy(Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator.Resolved arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Unresolved;", "public static")]
				public partial class Unresolved
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Unresolved()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Unresolved;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Ljava/lang/Class;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "()Lnet/bytebuddy/build/Plugin;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceBy", "(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;"));
					}

					[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
					public Dova.JDK.java.lang.Class type_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Unresolved(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/Class;)V", "protected")]
					public Unresolved(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Unresolved;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin instantiate()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator$Resolved;)Lnet/bytebuddy/build/Plugin$Factory$UsingReflection$Instantiator;", "public")]
					public Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator replaceBy(Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator.Resolved arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin.Factory.UsingReflection.Instantiator>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$Factory$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.build.Plugin.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$Factory$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "plugin", "Lnet/bytebuddy/build/Plugin;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/build/Plugin;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin;", "private final")]
			public Dova.JDK.net.bytebuddy.build.Plugin plugin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/build/Plugin;)V", "public")]
			public Simple(Dova.JDK.net.bytebuddy.build.Plugin arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/Plugin$Factory$Simple;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
			public Dova.JDK.net.bytebuddy.build.Plugin make()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$WithInitialization;", "public abstract static interface")]
	public partial interface WithInitialization
		: IJavaObject
		, Dova.JDK.net.bytebuddy.build.Plugin
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithInitialization()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$WithInitialization;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Ljava/util/Map;", "public abstract")]
		Dova.JDK.java.util.Map initialize(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/Plugin$WithPreprocessor;", "public abstract static interface")]
	public partial interface WithPreprocessor
		: IJavaObject
		, Dova.JDK.net.bytebuddy.build.Plugin
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithPreprocessor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/Plugin$WithPreprocessor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onPreprocess", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "public abstract")]
		void onPreprocess(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}
}
