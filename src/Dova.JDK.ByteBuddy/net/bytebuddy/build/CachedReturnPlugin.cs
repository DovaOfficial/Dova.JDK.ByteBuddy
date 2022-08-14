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

[JniSignatureAttribute("Lnet/bytebuddy/build/CachedReturnPlugin;", "public")]
public partial class CachedReturnPlugin
	: Dova.JDK.net.bytebuddy.build.Plugin.ForElementMatcher
	, Dova.JDK.net.bytebuddy.build.Plugin.Factory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CachedReturnPlugin()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/CachedReturnPlugin;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAME_INFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADVICE_INFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENHANCE_VALUE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreExistingFields", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "randomString", "Lnet/bytebuddy/utility/RandomString;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "adviceByType", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/build/Plugin;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NAME_INFIX_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ADVICE_INFIX_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape ENHANCE_VALUE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool ignoreExistingFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/RandomString;", "private final")]
	public Dova.JDK.net.bytebuddy.utility.RandomString randomString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.RandomString>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "private final")]
	public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map adviceByType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CachedReturnPlugin(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CachedReturnPlugin() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public CachedReturnPlugin(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/CachedReturnPlugin;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
	public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder apply(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/build/Plugin;", "public")]
	public Dova.JDK.net.bytebuddy.build.Plugin make()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.Plugin>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/CachedReturnPlugin$CacheFieldOffsetMapping;", "protected static")]
	public partial class CacheFieldOffsetMapping
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.asm.Advice.OffsetMapping
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CacheFieldOffsetMapping()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/CachedReturnPlugin$CacheFieldOffsetMapping;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/asm/Advice$ArgumentHandler;Lnet/bytebuddy/asm/Advice$OffsetMapping$Sort;)Lnet/bytebuddy/asm/Advice$OffsetMapping$Target;"));
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CacheFieldOffsetMapping(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
		public CacheFieldOffsetMapping(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/CachedReturnPlugin$CacheFieldOffsetMapping;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/asm/Advice$ArgumentHandler;Lnet/bytebuddy/asm/Advice$OffsetMapping$Sort;)Lnet/bytebuddy/asm/Advice$OffsetMapping$Target;", "public")]
		public Dova.JDK.net.bytebuddy.asm.Advice.OffsetMapping.Target resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg2, Dova.JDK.net.bytebuddy.asm.Advice.ArgumentHandler arg3, Dova.JDK.net.bytebuddy.asm.Advice.OffsetMapping.Sort arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.Advice.OffsetMapping.Target>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/CachedReturnPlugin$CacheField;", "protected abstract static interface")]
	public partial interface CacheField
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static CacheField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/CachedReturnPlugin$CacheField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/CachedReturnPlugin$Enhance;", "public abstract static interface")]
	public partial interface Enhance
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Enhance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/CachedReturnPlugin$Enhance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String value()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
