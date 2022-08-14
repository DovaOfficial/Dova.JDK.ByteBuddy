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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;", "public abstract interface")]
public partial interface PackageDefinitionStrategy
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PackageDefinitionStrategy()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;"));
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition define(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading;", "public static")]
	public partial class ManifestReading
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ManifestReading()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_SEALED", "Ljava/net/URL;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ATTRIBUTE_NAMES", "[Ljava/util/jar/Attributes$Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sealBaseLocator", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Ljava/net/URL;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;"));
		}

		[JniSignatureAttribute("Ljava/net/URL;", "private static final")]
		public static Dova.JDK.java.net.URL NOT_SEALED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/util/jar/Attributes$Name;", "private static final")]
		public static JavaArray<Dova.JDK.java.util.jar.Attributes.Name> ATTRIBUTE_NAMES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.jar.Attributes.Name>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator sealBaseLocator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ManifestReading(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ManifestReading() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;)V", "public")]
		public ManifestReading(Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading;";
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

		[JniSignatureAttribute("()Ljava/net/URL;", "static")]
		public static Dova.JDK.java.net.URL access_000()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition define(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;", "public abstract static interface")]
		public partial interface SealBaseLocator
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SealBaseLocator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSealBase", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;"));
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;", "public abstract")]
			Dova.JDK.java.net.URL findSealBase(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$ForTypeResourceUrl;", "public static")]
			public partial class ForTypeResourceUrl
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForTypeResourceUrl()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$ForTypeResourceUrl;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCLUDE_INITIAL_SLASH", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_EXTENSION", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAR_FILE", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILE_SYSTEM", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNTIME_IMAGE", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fallback", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSealBase", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;"));
				}

				[JniSignatureAttribute("I", "private static final")]
				public static int EXCLUDE_INITIAL_SLASH_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String CLASS_FILE_EXTENSION_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String JAR_FILE_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String FILE_SYSTEM_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String RUNTIME_IMAGE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator fallback_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForTypeResourceUrl(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public ForTypeResourceUrl() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator;)V", "public")]
				public ForTypeResourceUrl(Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$ForTypeResourceUrl;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;", "public")]
				public Dova.JDK.java.net.URL findSealBase(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$ForFixedValue;", "public static")]
			public partial class ForFixedValue
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForFixedValue()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$ForFixedValue;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sealBase", "Ljava/net/URL;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/net/URL;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSealBase", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;"));
				}

				[JniSignatureAttribute("Ljava/net/URL;", "private final")]
				public Dova.JDK.java.net.URL sealBase_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
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

				[JniSignatureAttribute("(Ljava/net/URL;)V", "public")]
				public ForFixedValue(Dova.JDK.java.net.URL arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$ForFixedValue;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;", "public")]
				public Dova.JDK.java.net.URL findSealBase(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;", "public static final")]
			public partial class NonSealing
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static NonSealing()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSealBase", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public NonSealing(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public NonSealing(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$ManifestReading$SealBaseLocator$NonSealing;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.ManifestReading.SealBaseLocator.NonSealing>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/net/URL;", "public")]
				public Dova.JDK.java.net.URL findSealBase(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;", "public abstract static interface")]
	public partial interface Definition
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Definition()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationTitle", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVersion", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVendor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationTitle", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVersion", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVendor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSealBase", "()Ljava/net/URL;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompatibleTo", "(Ljava/lang/Package;)Z"));
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isDefined()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getSpecificationTitle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getSpecificationVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getSpecificationVendor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getImplementationTitle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getImplementationVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getImplementationVendor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/net/URL;", "public abstract")]
		Dova.JDK.java.net.URL getSealBase()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Package;)Z", "public abstract")]
		bool isCompatibleTo(Dova.JDK.java.lang.Package arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sealBase", "Ljava/net/URL;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specificationTitle", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specificationVersion", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "specificationVendor", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationTitle", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationVersion", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationVendor", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationTitle", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVersion", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVendor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationTitle", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVersion", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVendor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSealBase", "()Ljava/net/URL;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompatibleTo", "(Ljava/lang/Package;)Z"));
			}

			[JniSignatureAttribute("Ljava/net/URL;", "protected final")]
			public Dova.JDK.java.net.URL sealBase_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String specificationTitle_Property
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
			public Dova.JDK.java.lang.String specificationVersion_Property
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
			public Dova.JDK.java.lang.String specificationVendor_Property
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
			public Dova.JDK.java.lang.String implementationTitle_Property
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
			public Dova.JDK.java.lang.String implementationVersion_Property
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
			public Dova.JDK.java.lang.String implementationVendor_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)V", "public")]
			public Simple(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.net.URL arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Simple;";
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
			public bool isDefined()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationTitle()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationVendor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationTitle()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationVendor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/net/URL;", "public")]
			public Dova.JDK.java.net.URL getSealBase()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Package;)Z", "public")]
			public bool isCompatibleTo(Dova.JDK.java.lang.Package arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;", "public static final")]
		public partial class Trivial
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Trivial()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_VALUE", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_SEALED", "Ljava/net/URL;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationTitle", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVersion", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVendor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationTitle", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVersion", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVendor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSealBase", "()Ljava/net/URL;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompatibleTo", "(Ljava/lang/Package;)Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String NO_VALUE_Property
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

			[JniSignatureAttribute("Ljava/net/URL;", "private static final")]
			public static Dova.JDK.java.net.URL NOT_SEALED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Trivial(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Trivial(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Trivial;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Trivial>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isDefined()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationTitle()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationVendor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationTitle()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationVendor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/net/URL;", "public")]
			public Dova.JDK.java.net.URL getSealBase()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Package;)Z", "public")]
			public bool isCompatibleTo(Dova.JDK.java.lang.Package arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;", "public static final")]
		public partial class Undefined
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Undefined()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationTitle", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVersion", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpecificationVendor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationTitle", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVersion", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationVendor", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSealBase", "()Ljava/net/URL;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCompatibleTo", "(Ljava/lang/Package;)Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Undefined(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Undefined(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition$Undefined;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition.Undefined>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isDefined()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationTitle()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getSpecificationVendor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationTitle()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getImplementationVendor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljava/net/URL;", "public")]
			public Dova.JDK.java.net.URL getSealBase()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Package;)Z", "public")]
			public bool isCompatibleTo(Dova.JDK.java.lang.Package arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;", "public static final")]
	public partial class Trivial
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Trivial()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Trivial(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Trivial(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Trivial;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Trivial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition define(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.NoOp>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy$Definition;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition define(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy.Definition>(ret);
		}
	}
}
