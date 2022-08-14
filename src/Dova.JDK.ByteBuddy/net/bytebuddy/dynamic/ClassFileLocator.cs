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

namespace Dova.JDK.net.bytebuddy.dynamic;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "public abstract interface")]
public partial interface ClassFileLocator
	: IJavaObject
	, Dova.JDK.java.io.Closeable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassFileLocator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_EXTENSION", "Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
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

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
		, Dova.JDK.java.io.Closeable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocators", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/dynamic/ClassFileLocator;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List classFileLocators_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/dynamic/ClassFileLocator;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$Compound;";
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

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$PackageDiscriminating;", "public static")]
	public partial class PackageDiscriminating
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PackageDiscriminating()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$PackageDiscriminating;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocators", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map classFileLocators_Property
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
		public PackageDiscriminating(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
		public PackageDiscriminating(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$PackageDiscriminating;";
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

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation;", "public static")]
	public partial class ForInstrumentation
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForInstrumentation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentation", "Ljava/lang/instrument/Instrumentation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoadingDelegate", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolveByteBuddyAgentInstrumentation", "()Ljava/lang/instrument/Instrumentation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fromInstalledAgent", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$Dispatcher;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.Dispatcher DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/instrument/Instrumentation;", "private final")]
		public Dova.JDK.java.lang.instrument.Instrumentation instrumentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.Instrumentation>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate classLoadingDelegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForInstrumentation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;)V", "public")]
		public ForInstrumentation(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/ClassLoader;)V", "public")]
		public ForInstrumentation(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.ClassLoader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation;";
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

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "static")]
		public static Dova.JDK.java.lang.Object access_000(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/instrument/Instrumentation;", "private static")]
		public static Dova.JDK.java.lang.instrument.Instrumentation resolveByteBuddyAgentInstrumentation()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.Instrumentation>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator fromInstalledAgent(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ExtractionClassFileTransformer;", "protected static")]
		public partial class ExtractionClassFileTransformer
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.lang.instrument.ClassFileTransformer
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ExtractionClassFileTransformer()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ExtractionClassFileTransformer;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DO_NOT_TRANSFORM", "[B"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/Class;Ljava/security/ProtectionDomain;[B)[B"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBinaryRepresentation", "()[B"));
			}

			[JniSignatureAttribute("[B", "private static final")]
			public static JavaArray<byte> DO_NOT_TRANSFORM_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
			public Dova.JDK.java.lang.ClassLoader classLoader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String typeName_Property
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

			[JniSignatureAttribute("[B", "private volatile")]
			public JavaArray<byte> binaryRepresentation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ExtractionClassFileTransformer(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)V", "protected")]
			public ExtractionClassFileTransformer(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ExtractionClassFileTransformer;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/Class;Ljava/security/ProtectionDomain;[B)[B", "public")]
			public JavaArray<byte> transform(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.security.ProtectionDomain arg3, JavaArray<byte> arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}

			[JniSignatureAttribute("()[B", "protected")]
			public JavaArray<byte> getBinaryRepresentation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;", "public abstract static interface")]
		public partial interface ClassLoadingDelegate
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoadingDelegate()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Ljava/lang/Class;"));
			}

			[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public abstract")]
			Dova.JDK.java.lang.ClassLoader getClassLoader()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class locate(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Explicit;", "public static")]
			public partial class Explicit
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Explicit()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Explicit;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fallbackDelegate", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/util/Collection;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;Ljava/util/Collection;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Ljava/lang/Class;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate fallbackDelegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map types_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/util/Collection;)V", "public")]
				public Explicit(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.util.Collection arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;Ljava/util/Collection;)V", "public")]
				public Explicit(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate arg0, Dova.JDK.java.util.Collection arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Explicit;";
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

				[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate of(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
				public Dova.JDK.java.lang.ClassLoader getClassLoader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class locate(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader;", "public static")]
			public partial class ForDelegatingClassLoader
				: Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForDelegatingClassLoader()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DELEGATING_CLASS_LOADER_NAME", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ONLY", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Initializable;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDelegating", "(Ljava/lang/ClassLoader;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Ljava/lang/Class;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String DELEGATING_CLASS_LOADER_NAME_Property
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

				[JniSignatureAttribute("I", "private static final")]
				public static int ONLY_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Initializable;", "private static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.Initializable DISPATCHER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.Initializable>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Z", "private static final")]
				public static bool ACCESS_CONTROLLER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForDelegatingClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "protected")]
				public ForDelegatingClassLoader(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
				public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Z", "protected static")]
				public static bool isDelegating(Dova.JDK.java.lang.ClassLoader arg0)
				{
					var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class locate(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;", "protected abstract static interface")]
				public partial interface Dispatcher
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Dispatcher()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extract", "(Ljava/lang/ClassLoader;)Ljava/util/Vector;"));
					}

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Ljava/util/Vector;", "public abstract")]
					Dova.JDK.java.util.Vector extract(Dova.JDK.java.lang.ClassLoader arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Unresolved;", "public static")]
					public partial class Unresolved
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.Initializable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Unresolved()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Unresolved;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "message", "Ljava/lang/String;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;"));
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String message_Property
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
						public Unresolved(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
						public Unresolved(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Unresolved;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher initialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Resolved;", "public static")]
					public partial class Resolved
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher
						, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.Initializable
						, Dova.JDK.java.security.PrivilegedAction
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Resolved()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Resolved;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/lang/reflect/Field;"));
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Field;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "extract", "(Ljava/lang/ClassLoader;)Ljava/util/Vector;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;"));
						}

						[JniSignatureAttribute("Ljava/lang/reflect/Field;", "private final")]
						public Dova.JDK.java.lang.reflect.Field field_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Field>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Z", "private static final")]
						public static bool ACCESS_CONTROLLER_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
								return ret;
							}
							set
							{
								DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/reflect/Field;)V", "public")]
						public Resolved(Dova.JDK.java.lang.reflect.Field arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Resolved;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher run_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher>(ret);
						}

						[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object run_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
						public bool equals(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return ret;
						}

						[JniSignatureAttribute("()I", "public")]
						public int hashCode()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
							return ret;
						}

						[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Ljava/util/Vector;", "public")]
						public Dova.JDK.java.util.Vector extract(Dova.JDK.java.lang.ClassLoader arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
						}

						[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
						public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher initialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;", "public static final")]
					public partial class CreationAction
						: Dova.JDK.java.lang.Enum
						, Dova.JDK.java.security.PrivilegedAction
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static CreationAction()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;"));
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Initializable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;", "public static final")]
						public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction INSTANCE_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;", "private static final")]
						public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction> VALUES_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction>>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public CreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
						public CreationAction(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object run_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Initializable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.Initializable run_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.Initializable>(ret);
						}

						[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;", "public static")]
						public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction> values()
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction>>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$CreationAction;", "public static")]
						public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher.CreationAction>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Initializable;", "public abstract static interface")]
					public partial interface Initializable
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Initializable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher$Initializable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;"));
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$ForDelegatingClassLoader$Dispatcher;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher initialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.ForDelegatingClassLoader.Dispatcher>(ret);
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default;", "public static")]
			public partial class Default
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Default()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOT_LOADER_PROXY", "Ljava/lang/ClassLoader;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Ljava/lang/Class;"));
				}

				[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private static final")]
				public static Dova.JDK.java.lang.ClassLoader BOOT_LOADER_PROXY_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/ClassLoader;", "protected final")]
				public Dova.JDK.java.lang.ClassLoader classLoader_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Default(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "protected")]
				public Default(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate of(Dova.JDK.java.lang.ClassLoader arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
				public Dova.JDK.java.lang.ClassLoader getClassLoader()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class locate(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;", "protected static final")]
				public partial class BootLoaderProxyCreationAction
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.java.security.PrivilegedAction
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static BootLoaderProxyCreationAction()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/ClassLoader;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public BootLoaderProxyCreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public BootLoaderProxyCreationAction(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object run_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
					public Dova.JDK.java.lang.ClassLoader run_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
					}

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$ClassLoadingDelegate$Default$BootLoaderProxyCreationAction;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForInstrumentation.ClassLoadingDelegate.Default.BootLoaderProxyCreationAction>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForInstrumentation$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTransformer", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/instrument/ClassFileTransformer;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRetransformClassesSupported", "(Ljava/lang/instrument/Instrumentation;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "retransformClasses", "(Ljava/lang/instrument/Instrumentation;[Ljava/lang/Class;)V"));
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/instrument/ClassFileTransformer;Z)V", "public abstract")]
			void addTransformer(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.instrument.ClassFileTransformer arg1, bool arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Z", "public abstract")]
			bool isRetransformClassesSupported(Dova.JDK.java.lang.instrument.Instrumentation arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;[Ljava/lang/Class;)V", "public abstract")]
			void retransformClasses(Dova.JDK.java.lang.instrument.Instrumentation arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForUrl;", "public static")]
	public partial class ForUrl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForUrl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForUrl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/net/URL;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader classLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForUrl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/net/URL;)V", "public transient")]
		public ForUrl(JavaArray<Dova.JDK.java.net.URL> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)V", "public")]
		public ForUrl(Dova.JDK.java.util.Collection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForUrl;";
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

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForUrl$ClassLoaderCreationAction;", "protected static")]
		public partial class ClassLoaderCreationAction
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.security.PrivilegedAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ClassLoaderCreationAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForUrl$ClassLoaderCreationAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "url", "[Ljava/net/URL;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/net/URL;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			}

			[JniSignatureAttribute("[Ljava/net/URL;", "private final")]
			public JavaArray<Dova.JDK.java.net.URL> url_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.URL>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ClassLoaderCreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([Ljava/net/URL;)V", "protected")]
			public ClassLoaderCreationAction(JavaArray<Dova.JDK.java.net.URL> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForUrl$ClassLoaderCreationAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object run_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
			public Dova.JDK.java.lang.ClassLoader run_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForFolder;", "public static")]
	public partial class ForFolder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForFolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForFolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/io/File;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForFolder;";
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

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForModuleFile;", "public static")]
	public partial class ForModuleFile
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForModuleFile()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForModuleFile;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JMOD_FILE_EXTENSION", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOT_LOCATIONS", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zipFile", "Ljava/util/zip/ZipFile;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/zip/ZipFile;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/io/File;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofModulePath", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofModulePath", "(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofModulePath", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootPath", "(Ljava/io/File;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootPath", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String JMOD_FILE_EXTENSION_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List BOOT_LOCATIONS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/zip/ZipFile;", "private final")]
		public Dova.JDK.java.util.zip.ZipFile zipFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.zip.ZipFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForModuleFile(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/zip/ZipFile;)V", "public")]
		public ForModuleFile(Dova.JDK.java.util.zip.ZipFile arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForModuleFile;";
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

		[JniSignatureAttribute("(Ljava/io/File;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofModulePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofModulePath(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofModulePath()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofBootPath(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofBootPath()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForJarFile;", "public static")]
	public partial class ForJarFile
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForJarFile()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForJarFile;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RUNTIME_LOCATIONS", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jarFile", "Ljava/util/jar/JarFile;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/jar/JarFile;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/io/File;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofClassPath", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofClassPath", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofRuntimeJar", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private static final")]
		public static Dova.JDK.java.util.List RUNTIME_LOCATIONS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/jar/JarFile;", "private final")]
		public Dova.JDK.java.util.jar.JarFile jarFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForJarFile;";
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

		[JniSignatureAttribute("(Ljava/io/File;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofClassPath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofClassPath()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofRuntimeJar()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForModule;", "public static")]
	public partial class ForModule
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForModule()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForModule;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARGUMENT", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "module", "Lnet/bytebuddy/utility/JavaModule;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/utility/JavaModule;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/utility/JavaModule;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLayer", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locate", "(Lnet/bytebuddy/utility/JavaModule;Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Object> NO_ARGUMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaModule;", "private final")]
		public Dova.JDK.net.bytebuddy.utility.JavaModule module_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaModule>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForModule(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaModule;)V", "protected")]
		public ForModule(Dova.JDK.net.bytebuddy.utility.JavaModule arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForModule;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaModule;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.net.bytebuddy.utility.JavaModule arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofBootLayer()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaModule;Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "protected static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.net.bytebuddy.utility.JavaModule arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForModule$WeaklyReferenced;", "public static")]
		public partial class WeaklyReferenced
			: Dova.JDK.java.lang.@ref.WeakReference
			, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WeaklyReferenced()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForModule$WeaklyReferenced;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/utility/JavaModule;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
			}

			[JniSignatureAttribute("I", "private final")]
			public int hashCode_Property
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
			public WeaklyReferenced(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
			public WeaklyReferenced(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForModule$WeaklyReferenced;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaModule;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.net.bytebuddy.utility.JavaModule arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void close()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader;", "public static")]
	public partial class ForClassLoader
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForClassLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOT_LOADER_PROXY", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "([Ljava/lang/Class;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/util/Collection;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/lang/Class;)[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPlatformLoader", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readToNames", "([Ljava/lang/Class;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readToNames", "(Ljava/util/Collection;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "locate", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemLoader", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLoader", "()Lnet/bytebuddy/dynamic/ClassFileLocator;"));
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private static final")]
		public static Dova.JDK.java.lang.ClassLoader BOOT_LOADER_PROXY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader classLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "protected")]
		public ForClassLoader(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader;";
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

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Ljava/util/Map;", "public static transient")]
		public static Dova.JDK.java.util.Map read(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/util/Map;", "public static")]
		public static Dova.JDK.java.util.Map read(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)[B", "public static")]
		public static JavaArray<byte> read(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofPlatformLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Ljava/util/Map;", "public static transient")]
		public static Dova.JDK.java.util.Map readToNames(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/util/Map;", "public static")]
		public static Dova.JDK.java.util.Map readToNames(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "protected static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofSystemLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofBootLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$WeaklyReferenced;", "public static")]
		public partial class WeaklyReferenced
			: Dova.JDK.java.lang.@ref.WeakReference
			, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WeaklyReferenced()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$WeaklyReferenced;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
			}

			[JniSignatureAttribute("I", "private final")]
			public int hashCode_Property
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
			public WeaklyReferenced(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "protected")]
			public WeaklyReferenced(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$WeaklyReferenced;";
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

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.lang.ClassLoader arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void close()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;", "protected static final")]
		public partial class BootLoaderProxyCreationAction
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.java.security.PrivilegedAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BootLoaderProxyCreationAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BootLoaderProxyCreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public BootLoaderProxyCreationAction(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object run_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public")]
			public Dova.JDK.java.lang.ClassLoader run_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$ForClassLoader$BootLoaderProxyCreationAction;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.ForClassLoader.BootLoaderProxyCreationAction>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$Simple;", "public static")]
	public partial class Simple
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Simple()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$Simple;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFiles", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;[B)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/util/Map;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofResources", "(Ljava/util/Map;)Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map classFiles_Property
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
		public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
		public Simple(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$Simple;";
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

		[JniSignatureAttribute("(Ljava/lang/String;[B)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.net.bytebuddy.dynamic.DynamicType arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator of(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Lnet/bytebuddy/dynamic/ClassFileLocator;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator ofResources(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.NoOp>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public abstract static interface")]
	public partial interface Resolution
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolution()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
		}

		[JniSignatureAttribute("()[B", "public abstract")]
		JavaArray<byte> resolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isResolved()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution$Explicit;", "public static")]
		public partial class Explicit
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Explicit()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution$Explicit;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([B)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()[B"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
			}

			[JniSignatureAttribute("[B", "private final")]
			public JavaArray<byte> binaryRepresentation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([B)V", "public")]
			public Explicit(JavaArray<byte> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution$Explicit;";
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

			[JniSignatureAttribute("()[B", "public")]
			public JavaArray<byte> resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution$Illegal;", "public static")]
		public partial class Illegal
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Illegal()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution$Illegal;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()[B"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String typeName_Property
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
			public Illegal(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public Illegal(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution$Illegal;";
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

			[JniSignatureAttribute("()[B", "public")]
			public JavaArray<byte> resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}
	}
}
