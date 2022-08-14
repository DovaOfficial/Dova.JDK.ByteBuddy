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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public abstract interface")]
public partial interface ClassInjector
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassInjector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPPRESS_ACCESS_CHECKS", "Ljava/security/Permission;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLOW_EXISTING_TYPES", "Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/util/Map;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectRaw", "(Ljava/util/Map;)Ljava/util/Map;"));
	}

	[JniSignatureAttribute("Ljava/security/Permission;", "public static final")]
	public static Dova.JDK.java.security.Permission SUPPRESS_ACCESS_CHECKS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.Permission>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "public static final")]
	public static bool ALLOW_EXISTING_TYPES_Property
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

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isAlive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map inject(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map injectRaw(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna;", "public static")]
	public partial class UsingJna
		: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UsingJna()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOTSTRAP_LOADER_LOCK", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAvailable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectRaw", "(Ljava/util/Map;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPlatformLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
		public static Dova.JDK.java.lang.Object BOOTSTRAP_LOADER_LOCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader classLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
		public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UsingJna(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public")]
		public UsingJna(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)V", "public")]
		public UsingJna(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.security.ProtectionDomain arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna;";
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

		[JniSignatureAttribute("()Z", "public")]
		public bool isAlive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public static")]
		public static bool isAvailable()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map injectRaw(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofSystemLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofPlatformLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofBootLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("()Z", "public abstract")]
			bool isAvailable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Jvm;", "public abstract static interface")]
			public partial interface Jvm
				: IJavaObject
				, Dova.JDK.com.sun.jna.Library
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Jvm()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Jvm;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "JVM_DefineClass", "(Lcom/sun/jna/JNIEnv;Ljava/lang/String;Ljava/lang/ClassLoader;[BILjava/security/ProtectionDomain;)Ljava/lang/Class;"));
				}

				[JniSignatureAttribute("(Lcom/sun/jna/JNIEnv;Ljava/lang/String;Ljava/lang/ClassLoader;[BILjava/security/ProtectionDomain;)Ljava/lang/Class;", "public abstract")]
				Dova.JDK.java.lang.Class JVM_DefineClass(Dova.JDK.com.sun.jna.JNIEnv arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.ClassLoader arg2, JavaArray<byte> arg3, int arg4, Dova.JDK.java.security.ProtectionDomain arg5)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Unavailable;", "public static")]
			public partial class Unavailable
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Unavailable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Unavailable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "error", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String error_Property
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
				public Unavailable(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public Unavailable(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Unavailable;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Enabled;", "public static")]
			public partial class Enabled
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Enabled()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Enabled;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jvm", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Jvm;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Jvm;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Jvm;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Jvm jvm_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Jvm>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Enabled(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Jvm;)V", "protected")]
				public Enabled(Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Jvm arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Enabled;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;", "public static final")]
			public partial class Windows32BitFunctionMapper
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.com.sun.jna.FunctionMapper
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Windows32BitFunctionMapper()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunctionName", "(Lcom/sun/jna/NativeLibrary;Ljava/lang/reflect/Method;)Ljava/lang/String;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Windows32BitFunctionMapper(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Windows32BitFunctionMapper(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$Windows32BitFunctionMapper;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.Windows32BitFunctionMapper>(ret);
				}

				[JniSignatureAttribute("(Lcom/sun/jna/NativeLibrary;Ljava/lang/reflect/Method;)Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getFunctionName(Dova.JDK.com.sun.jna.NativeLibrary arg0, Dova.JDK.java.lang.reflect.Method arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;", "public static final")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object run_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher run_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher>(ret);
				}

				[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingJna$Dispatcher$CreationAction;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingJna.Dispatcher.CreationAction>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation;", "public static")]
	public partial class UsingInstrumentation
		: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UsingInstrumentation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAR", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_EXTENSION", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentation", "Ljava/lang/instrument/Instrumentation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "folder", "Ljava/io/File;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "randomString", "Lnet/bytebuddy/utility/RandomString;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/File;Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/utility/RandomString;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/io/File;Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAvailable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectRaw", "(Ljava/util/Map;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$600", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Dispatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "redefineModule", "(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/utility/JavaModule;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String JAR_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Dispatcher;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Dispatcher DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/instrument/Instrumentation;", "private final")]
		public Dova.JDK.java.lang.instrument.Instrumentation instrumentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.Instrumentation>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/io/File;", "private final")]
		public Dova.JDK.java.io.File folder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/RandomString;", "private final")]
		public Dova.JDK.net.bytebuddy.utility.RandomString randomString_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.RandomString>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UsingInstrumentation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/File;Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/utility/RandomString;)V", "protected")]
		public UsingInstrumentation(Dova.JDK.java.io.File arg0, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target arg1, Dova.JDK.java.lang.instrument.Instrumentation arg2, Dova.JDK.net.bytebuddy.utility.RandomString arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation;";
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

		[JniSignatureAttribute("(Ljava/io/File;Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector of(Dova.JDK.java.io.File arg0, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target arg1, Dova.JDK.java.lang.instrument.Instrumentation arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAlive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public static")]
		public static bool isAvailable()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map injectRaw(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Dispatcher;", "static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Dispatcher access_600()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Dispatcher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Lnet/bytebuddy/utility/JavaModule;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;)V", "public static")]
		public static void redefineModule(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.net.bytebuddy.utility.JavaModule arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.Map arg4, Dova.JDK.java.util.Set arg5, Dova.JDK.java.util.Map arg6)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "public abstract static")]
		public partial class Target
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Target()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOTSTRAP", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/ClassLoader;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassInjector$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "()Ljava/lang/ClassLoader;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/lang/instrument/Instrumentation;Ljava/util/jar/JarFile;)V"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target BOOTSTRAP_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target SYSTEM_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
			public Dova.JDK.java.lang.ClassLoader classLoader_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Target(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/ClassLoader;)V", "private")]
			public Target(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.ClassLoader arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassInjector$1;)V", "")]
			public Target(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.ClassLoader arg2, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Target;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingInstrumentation.Target>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "protected")]
			public Dova.JDK.java.lang.ClassLoader getClassLoader()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/util/jar/JarFile;)V", "protected abstract")]
			public void inject(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.util.jar.JarFile arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingInstrumentation$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendToBootstrapClassLoaderSearch", "(Ljava/lang/instrument/Instrumentation;Ljava/util/jar/JarFile;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendToSystemClassLoaderSearch", "(Ljava/lang/instrument/Instrumentation;Ljava/util/jar/JarFile;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "redefineModule", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/Object;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isModifiableModule", "(Ljava/lang/instrument/Instrumentation;Ljava/lang/Object;)Z"));
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/util/jar/JarFile;)V", "public abstract")]
			void appendToBootstrapClassLoaderSearch(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.util.jar.JarFile arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/util/jar/JarFile;)V", "public abstract")]
			void appendToSystemClassLoaderSearch(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.util.jar.JarFile arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/Object;Ljava/util/Set;Ljava/util/Map;Ljava/util/Map;Ljava/util/Set;Ljava/util/Map;)V", "public abstract")]
			void redefineModule(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.Map arg4, Dova.JDK.java.util.Set arg5, Dova.JDK.java.util.Map arg6)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Ljava/lang/Object;)Z", "public abstract")]
			bool isModifiableModule(Dova.JDK.java.lang.instrument.Instrumentation arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe;", "public static")]
	public partial class UsingUnsafe
		: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UsingUnsafe()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAFE_PROPERTY", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$System;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECK_PERMISSION", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOTSTRAP_LOADER_LOCK", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dispatcher", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "()Ljava/lang/reflect/Method;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$System;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAvailable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectRaw", "(Ljava/util/Map;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPlatformLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String SAFE_PROPERTY_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$System;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.System SYSTEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.System>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
		public static Dova.JDK.java.lang.reflect.Method CHECK_PERMISSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
		public static Dova.JDK.java.lang.Object BOOTSTRAP_LOADER_LOCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader classLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
		public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable dispatcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UsingUnsafe(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;)V", "protected")]
		public UsingUnsafe(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.security.ProtectionDomain arg1, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)V", "public")]
		public UsingUnsafe(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.security.ProtectionDomain arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public")]
		public UsingUnsafe(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe;";
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

		[JniSignatureAttribute("()Z", "public")]
		public bool isAlive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "static")]
		public static Dova.JDK.java.lang.reflect.Method access_300()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$System;", "static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.System access_200()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.System>(ret);
		}

		[JniSignatureAttribute("()Z", "public static")]
		public static bool isAvailable()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map injectRaw(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofSystemLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofPlatformLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofBootLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;", "static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable access_400()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$System;", "protected abstract static interface")]
		public partial interface System
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static System()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$System;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecurityManager", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object getSecurityManager()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;", "public static")]
		public partial class Factory
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dispatcher", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolve", "(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolve", "(Ljava/lang/instrument/Instrumentation;Z)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable dispatcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;)V", "protected")]
			public Factory(Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver;)V", "public")]
			public Factory(Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public Factory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;";
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

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector make(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.security.ProtectionDomain arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector make(Dova.JDK.java.lang.ClassLoader arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory resolve(Dova.JDK.java.lang.instrument.Instrumentation arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/instrument/Instrumentation;Z)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory resolve(Dova.JDK.java.lang.instrument.Instrumentation arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isAvailable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver;", "public abstract static interface")]
			public partial interface AccessResolver
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AccessResolver()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/lang/reflect/AccessibleObject;)V"));
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/AccessibleObject;)V", "public abstract")]
				void apply(Dova.JDK.java.lang.reflect.AccessibleObject arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;", "public static final")]
				public partial class Default
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Default()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Ljava/lang/reflect/AccessibleObject;)V"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;", "public static final")]
					public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Factory$AccessResolver$Default;", "public static")]
					public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Factory.AccessResolver.Default>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/AccessibleObject;)V", "public")]
					public void apply(Dova.JDK.java.lang.reflect.AccessibleObject arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Unavailable;", "public static")]
			public partial class Unavailable
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Unavailable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Unavailable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "message", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
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
				public Unavailable(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public Unavailable(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Unavailable;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Enabled;", "public static")]
			public partial class Enabled
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Enabled()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Enabled;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unsafe", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defineClass", "Ljava/lang/reflect/Method;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object @unsafe_Property
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

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method defineClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Enabled(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;)V", "protected")]
				public Enabled(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Enabled;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;", "public static final")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object run_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable run_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.Initializable>(ret);
				}

				[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$CreationAction;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher.CreationAction>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;", "public abstract static interface")]
			public partial interface Initializable
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Initializable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher$Initializable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingUnsafe$Dispatcher;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingUnsafe.Dispatcher>(ret);
				}

				[JniSignatureAttribute("()Z", "public abstract")]
				bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;", "public static")]
	public partial class UsingLookup
		: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UsingLookup()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles$Lookup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_LOOKUP", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lookup", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupType", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAvailable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectRaw", "(Ljava/util/Map;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup.MethodHandles METHOD_HANDLES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup.MethodHandles>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles$Lookup;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup.MethodHandles.Lookup METHOD_HANDLES_LOOKUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup.MethodHandles.Lookup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int PACKAGE_LOOKUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
		public Dova.JDK.java.lang.Object lookup_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UsingLookup(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
		public UsingLookup(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup of(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup @in(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingLookup>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAlive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class lookupType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()Z", "public static")]
		public static bool isAvailable()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map injectRaw(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles;", "protected abstract static interface")]
		public partial interface MethodHandles
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodHandles()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "privateLookupIn", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object privateLookupIn(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles$Lookup;", "public abstract static interface")]
			public partial interface Lookup
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Lookup()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingLookup$MethodHandles$Lookup;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/Object;[B)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupClass", "(Ljava/lang/Object;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupModes", "(Ljava/lang/Object;)I"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;[B)Ljava/lang/Class;", "public abstract")]
				Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.Object arg0, JavaArray<byte> arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
				Dova.JDK.java.lang.Class lookupClass(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
				int lookupModes(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return ret;
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection;", "public static")]
	public partial class UsingReflection
		: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UsingReflection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$System;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHECK_PERMISSION", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "protectionDomain", "Ljava/security/ProtectionDomain;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageDefinitionStrategy", "Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "forbidExisting", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAlive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemClassLoader", "()Lnet/bytebuddy/dynamic/loading/ClassInjector;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()Ljava/lang/reflect/Method;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isAvailable", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$System;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "injectRaw", "(Ljava/util/Map;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$System;", "private static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.System SYSTEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.System>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private static final")]
		public static Dova.JDK.java.lang.reflect.Method CHECK_PERMISSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/ClassLoader;", "private final")]
		public Dova.JDK.java.lang.ClassLoader classLoader_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "private final")]
		public Dova.JDK.java.security.ProtectionDomain protectionDomain_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy packageDefinitionStrategy_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool forbidExisting_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UsingReflection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;Lnet/bytebuddy/dynamic/loading/PackageDefinitionStrategy;Z)V", "public")]
		public UsingReflection(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.security.ProtectionDomain arg1, Dova.JDK.net.bytebuddy.dynamic.loading.PackageDefinitionStrategy arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)V", "public")]
		public UsingReflection(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.security.ProtectionDomain arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "public")]
		public UsingReflection(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection;";
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

		[JniSignatureAttribute("()Z", "public")]
		public bool isAlive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector ofSystemClassLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "static")]
		public static Dova.JDK.java.lang.reflect.Method access_100()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}

		[JniSignatureAttribute("()Z", "public static")]
		public static bool isAvailable()
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$System;", "static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.System access_000()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.System>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map injectRaw(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$System;", "protected abstract static interface")]
		public partial interface System
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static System()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$System;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecurityManager", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object getSecurityManager()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definePackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefinedPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "public static final")]
			public static Dova.JDK.java.lang.Class UNDEFINED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "public abstract")]
			Dova.JDK.java.lang.Package definePackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public abstract")]
			Dova.JDK.java.lang.Package getPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public abstract")]
			Dova.JDK.java.lang.Package getDefinedPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Unavailable;", "public static")]
			public partial class Unavailable
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Unavailable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Unavailable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "message", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definePackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefinedPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
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
				public Unavailable(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public Unavailable(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Unavailable;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package definePackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getDefinedPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride;", "public abstract static")]
			public partial class UsingUnsafeOverride
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static UsingUnsafeOverride()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "findLoadedClass", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defineClass", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getDefinedPackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getPackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "definePackage", "Ljava/lang/reflect/Method;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definePackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefinedPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method findLoadedClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method defineClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method getDefinedPackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method getPackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method definePackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public UsingUnsafeOverride(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
				public UsingUnsafeOverride(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package definePackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;", "protected static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable make()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getDefinedPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride$ForLegacyVm;", "protected static")]
				public partial class ForLegacyVm
					: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.UsingUnsafeOverride
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLegacyVm()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride$ForLegacyVm;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLegacyVm(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
					public ForLegacyVm(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride$ForLegacyVm;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride$ForJava7CapableVm;", "protected static")]
				public partial class ForJava7CapableVm
					: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.UsingUnsafeOverride
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJava7CapableVm()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride$ForJava7CapableVm;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getClassLoadingLock", "Ljava/lang/reflect/Method;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
					public Dova.JDK.java.lang.reflect.Method getClassLoadingLock_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJava7CapableVm(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
					public ForJava7CapableVm(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4, Dova.JDK.java.lang.reflect.Method arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeOverride$ForJava7CapableVm;";
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

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeInjection;", "public static")]
			public partial class UsingUnsafeInjection
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static UsingUnsafeInjection()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeInjection;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessor", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "findLoadedClass", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defineClass", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getDefinedPackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getPackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "definePackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getClassLoadingLock", "Ljava/lang/reflect/Method;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definePackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefinedPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object accessor_Property
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

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method findLoadedClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method defineClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method getDefinedPackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method getPackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method definePackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method getClassLoadingLock_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public UsingUnsafeInjection(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
				public UsingUnsafeInjection(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4, Dova.JDK.java.lang.reflect.Method arg5, Dova.JDK.java.lang.reflect.Method arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$UsingUnsafeInjection;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package definePackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;", "protected static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable make()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getDefinedPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct;", "public abstract static")]
			public partial class Direct
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher
				, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Direct()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "findLoadedClass", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defineClass", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getDefinedPackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getPackage", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "definePackage", "Ljava/lang/reflect/Method;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definePackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefinedPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method findLoadedClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method defineClass_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method getDefinedPackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method getPackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "protected final")]
				public Dova.JDK.java.lang.reflect.Method definePackage_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Direct(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
				public Direct(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package definePackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;", "protected static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable make()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
				public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
				public Dova.JDK.java.lang.Package getDefinedPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct$ForLegacyVm;", "protected static")]
				public partial class ForLegacyVm
					: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Direct
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLegacyVm()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct$ForLegacyVm;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLegacyVm(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
					public ForLegacyVm(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct$ForLegacyVm;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct$ForJava7CapableVm;", "protected static")]
				public partial class ForJava7CapableVm
					: Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Direct
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForJava7CapableVm()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct$ForJava7CapableVm;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getClassLoadingLock", "Ljava/lang/reflect/Method;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
					public Dova.JDK.java.lang.reflect.Method getClassLoadingLock_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForJava7CapableVm(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
					public ForJava7CapableVm(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3, Dova.JDK.java.lang.reflect.Method arg4, Dova.JDK.java.lang.reflect.Method arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Direct$ForJava7CapableVm;";
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

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;", "public static final")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;", "public static final")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object run_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable run_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable>(ret);
				}

				[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$CreationAction;", "public static")]
				public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.CreationAction>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;", "public abstract static interface")]
			public partial interface Initializable
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Initializable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher initialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher>(ret);
				}

				[JniSignatureAttribute("()Z", "public abstract")]
				bool isAvailable()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable$Unavailable;", "public static")]
				public partial class Unavailable
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher
					, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher.Initializable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Unavailable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable$Unavailable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "message", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "definePackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoadingLock", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineClass", "(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefinedPackage", "(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
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
					public Unavailable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public Unavailable(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher$Initializable$Unavailable;";
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

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/net/URL;)Ljava/lang/Package;", "public")]
					public Dova.JDK.java.lang.Package definePackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.java.lang.String arg7, Dova.JDK.java.net.URL arg8)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/loading/ClassInjector$UsingReflection$Dispatcher;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher initialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector.UsingReflection.Dispatcher>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
					public Dova.JDK.java.lang.Package getPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object getClassLoadingLock(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Class;", "public")]
					public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;[BLjava/security/ProtectionDomain;)Ljava/lang/Class;", "public")]
					public Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, JavaArray<byte> arg2, Dova.JDK.java.security.ProtectionDomain arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;)Ljava/lang/Package;", "public")]
					public Dova.JDK.java.lang.Package getDefinedPackage(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isAvailable()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
						return ret;
					}
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassInjector$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassInjector
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassInjector$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/util/Map;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassInjector$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map inject(Dova.JDK.java.util.Map arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}
}
