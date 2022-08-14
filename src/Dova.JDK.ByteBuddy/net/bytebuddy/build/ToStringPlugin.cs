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

[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin;", "public")]
public partial class ToStringPlugin
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.build.Plugin
	, Dova.JDK.net.bytebuddy.build.Plugin.Factory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ToStringPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/ToStringPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_PREFIX", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_INCLUDE_SYNTHETIC_FIELDS", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/type/TypeDescription;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_PREFIX_Property
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
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_INCLUDE_SYNTHETIC_FIELDS_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ToStringPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ToStringPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/ToStringPlugin;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin$Exclude;", "public abstract static interface")]
	public partial interface Exclude
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Exclude()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/ToStringPlugin$Exclude;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin$Enhance;", "public abstract static interface")]
	public partial interface Enhance
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Enhance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/ToStringPlugin$Enhance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefix", "()Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "includeSyntheticFields", "()Z"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public abstract")]
		Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix prefix()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool includeSyntheticFields()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public static final")]
		public partial class Prefix
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Prefix()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FULLY_QUALIFIED", "Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANONICAL", "Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIMPLE", "Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefixResolver", "Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrefixResolver", "()Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix FULLY_QUALIFIED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix CANONICAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public static final")]
			public static Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix SIMPLE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default prefixResolver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Prefix(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;)V", "private")]
			public Prefix(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/ToStringPlugin$Enhance$Prefix;", "public static")]
			public static Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.ToStringPlugin.Enhance.Prefix>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/ToStringMethod$PrefixResolver$Default;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default getPrefixResolver()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.ToStringMethod.PrefixResolver.Default>(ret);
			}
		}
	}
}
