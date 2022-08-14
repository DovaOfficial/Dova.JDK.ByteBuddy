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

namespace Dova.JDK.net.bytebuddy.utility.dispatcher;

[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher;", "public")]
public partial class JavaDispatcher
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.security.PrivilegedAction
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaDispatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERATE_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERATE", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOLVER", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKER", "Lnet/bytebuddy/utility/Invoker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "proxy", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "generate", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/ClassLoader;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Ljava/security/PrivilegedAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/security/PrivilegedAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;Ljava/lang/ClassLoader;Z)Ljava/security/PrivilegedAction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "()Lnet/bytebuddy/utility/Invoker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "()Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String GENERATE_PROPERTY_Property
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

	[JniSignatureAttribute("Z", "private static final")]
	public static bool GENERATE_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;", "private static final")]
	public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver RESOLVER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/Invoker;", "private static final")]
	public static Dova.JDK.net.bytebuddy.utility.Invoker INVOKER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.Invoker>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
	public Dova.JDK.java.lang.Class proxy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
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

	[JniSignatureAttribute("Z", "private final")]
	public bool generate_Property
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
	public JavaDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/ClassLoader;Z)V", "protected")]
	public JavaDispatcher(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.ClassLoader arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object run()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/security/PrivilegedAction;", "public static")]
	public static Dova.JDK.java.security.PrivilegedAction of(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivilegedAction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/ClassLoader;)Ljava/security/PrivilegedAction;", "protected static")]
	public static Dova.JDK.java.security.PrivilegedAction of(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivilegedAction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/ClassLoader;Z)Ljava/security/PrivilegedAction;", "protected static")]
	public static Dova.JDK.java.security.PrivilegedAction of(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.ClassLoader arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.security.PrivilegedAction>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/utility/Invoker;", "static")]
	public static Dova.JDK.net.bytebuddy.utility.Invoker access_100()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.Invoker>(ret);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object access_200(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;", "static")]
	public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver access_300()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader;", "protected static")]
	public partial class DynamicClassLoader
		: Dova.JDK.java.lang.ClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DynamicClassLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUMP_FOLDER", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_PARAMETER", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARGUMENT", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "proxy", "(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "invoker", "()Lnet/bytebuddy/utility/Invoker;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String DUMP_FOLDER_Property
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

		[JniSignatureAttribute("[Ljava/lang/Class;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Class> NO_PARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Object> NO_ARGUMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DynamicClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)V", "protected")]
		public DynamicClassLoader(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/Object;", "protected static")]
		public static Dova.JDK.java.lang.Object proxy(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Map arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/utility/Invoker;", "protected static")]
		public static Dova.JDK.net.bytebuddy.utility.Invoker invoker()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.Invoker>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;", "protected abstract static interface")]
		public partial interface Resolver
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Resolver()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/ClassLoader;Ljava/lang/Class;)V"));
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Class;)V", "public abstract")]
			void accept(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Class arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$ForModuleSystem;", "public static")]
			public partial class ForModuleSystem
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForModuleSystem()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$ForModuleSystem;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getModule", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isExported", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addExports", "Ljava/lang/reflect/Method;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getUnnamedModule", "Ljava/lang/reflect/Method;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/ClassLoader;Ljava/lang/Class;)V"));
				}

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method getModule_Property
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

				[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
				public Dova.JDK.java.lang.reflect.Method isExported_Property
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
				public Dova.JDK.java.lang.reflect.Method addExports_Property
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
				public Dova.JDK.java.lang.reflect.Method getUnnamedModule_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public ForModuleSystem(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "protected")]
				public ForModuleSystem(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2, Dova.JDK.java.lang.reflect.Method arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$ForModuleSystem;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Class;)V", "public")]
				public void accept(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Class arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;", "public static final")]
			public partial class NoOp
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static NoOp()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Ljava/lang/ClassLoader;Ljava/lang/Class;)V"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$NoOp;", "public static")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.NoOp>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Class;)V", "public")]
				public void accept(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Class arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;", "public static final")]
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
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction>>(ret);
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

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object run_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver;", "public")]
				public Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver run_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver>(ret);
				}

				[JniSignatureAttribute("()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DynamicClassLoader$Resolver$CreationAction;", "public static")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.DynamicClassLoader.Resolver.CreationAction>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$ProxiedInvocationHandler;", "protected static")]
	public partial class ProxiedInvocationHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.reflect.InvocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ProxiedInvocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$ProxiedInvocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARGUMENTS", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targets", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Object> NO_ARGUMENTS_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map targets_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ProxiedInvocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)V", "protected")]
		public ProxiedInvocationHandler(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$ProxiedInvocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher;", "protected abstract static interface")]
	public partial interface Dispatcher
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dispatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
		}

		[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public abstract")]
		int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForUnresolvedMethod;", "public static")]
		public partial class ForUnresolvedMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForUnresolvedMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForUnresolvedMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "message", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
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
			public ForUnresolvedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
			public ForUnresolvedMethod(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForUnresolvedMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForNonStaticMethod;", "public static")]
		public partial class ForNonStaticMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForNonStaticMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForNonStaticMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARGUMENTS", "[Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
			}

			[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
			public static JavaArray<Dova.JDK.java.lang.Object> NO_ARGUMENTS_Property
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

			[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
			public Dova.JDK.java.lang.reflect.Method method_Property
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
			public ForNonStaticMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "protected")]
			public ForNonStaticMethod(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForNonStaticMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForStaticMethod;", "public static")]
		public partial class ForStaticMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForStaticMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForStaticMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
			}

			[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
			public Dova.JDK.java.lang.reflect.Method method_Property
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
			public ForStaticMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "protected")]
			public ForStaticMethod(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForStaticMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForConstructor;", "public static")]
		public partial class ForConstructor
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Constructor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)V", "protected")]
			public ForConstructor(Dova.JDK.java.lang.reflect.Constructor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForConstructor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
		public partial class ForDefaultValue
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForDefaultValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN_REVERSE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REFERENCE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "load", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returned", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "size", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Object;III)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue VOID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue BOOLEAN_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue BOOLEAN_REVERSE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue BYTE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue SHORT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue CHARACTER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue INTEGER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue LONG_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue FLOAT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue DOUBLE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue REFERENCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object value_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int load_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int returned_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[13]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[13], value);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int size_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForDefaultValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Object;III)V", "private")]
			public ForDefaultValue(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Object arg2, int arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue;", "public static")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher;", "protected static")]
			public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher of(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfNonPrimitiveArray;", "protected static")]
			public partial class OfNonPrimitiveArray
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfNonPrimitiveArray()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfNonPrimitiveArray;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentType", "Ljava/lang/Class;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Class;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher;"));
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object value_Property
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

				[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
				public Dova.JDK.java.lang.Class componentType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfNonPrimitiveArray(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)V", "protected")]
				public OfNonPrimitiveArray(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfNonPrimitiveArray;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
				public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher;", "protected static")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher of(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "protected static final")]
			public partial class OfPrimitiveArray
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfPrimitiveArray()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARACTER", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "operand", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Object;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray BOOLEAN_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray BYTE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray SHORT_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray CHARACTER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray INTEGER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray LONG_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray FLOAT_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static final")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray DOUBLE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object value_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private final")]
				public int operand_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public OfPrimitiveArray(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Object;I)V", "private")]
				public OfPrimitiveArray(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Object arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()[Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForDefaultValue$OfPrimitiveArray;", "public static")]
				public static Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher.ForDefaultValue.OfPrimitiveArray>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
				public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForContainerCreation;", "public static")]
		public partial class ForContainerCreation
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForContainerCreation()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForContainerCreation;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/Class;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
			public Dova.JDK.java.lang.Class target_Property
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
			public ForContainerCreation(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)V", "protected")]
			public ForContainerCreation(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForContainerCreation;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForInstanceCheck;", "public static")]
		public partial class ForInstanceCheck
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher.Dispatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForInstanceCheck()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForInstanceCheck;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Ljava/lang/Class;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "([Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
			public Dova.JDK.java.lang.Class target_Property
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
			public ForInstanceCheck(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)V", "protected")]
			public ForInstanceCheck(Dova.JDK.java.lang.Class arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Dispatcher$ForInstanceCheck;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Ljava/lang/Object;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object invoke(JavaArray<Dova.JDK.java.lang.Object> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Ljava/lang/reflect/Method;)I", "public")]
			public int apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.java.lang.reflect.Method arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DirectInvoker;", "private static")]
	public partial class DirectInvoker
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.utility.Invoker
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectInvoker()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DirectInvoker;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$1;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectInvoker(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$1;)V", "")]
		public DirectInvoker(Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DirectInvoker() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$DirectInvoker;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object newInstance(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$InvokerCreationAction;", "private static")]
	public partial class InvokerCreationAction
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.security.PrivilegedAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvokerCreationAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$InvokerCreationAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$1;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_0", "()Lnet/bytebuddy/utility/Invoker;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run_1", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InvokerCreationAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$1;)V", "")]
		public InvokerCreationAction(Dova.JDK.net.bytebuddy.utility.dispatcher.JavaDispatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public InvokerCreationAction() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$InvokerCreationAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lnet/bytebuddy/utility/Invoker;", "public")]
		public Dova.JDK.net.bytebuddy.utility.Invoker run_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.Invoker>(ret);
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Defaults;", "public abstract static interface")]
	public partial interface Defaults
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Defaults()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Defaults;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Container;", "public abstract static interface")]
	public partial interface Container
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Container()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Container;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Instance;", "public abstract static interface")]
	public partial interface Instance
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Instance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Instance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$IsConstructor;", "public abstract static interface")]
	public partial interface IsConstructor
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static IsConstructor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$IsConstructor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$IsStatic;", "public abstract static interface")]
	public partial interface IsStatic
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static IsStatic()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$IsStatic;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Proxied;", "public abstract static interface")]
	public partial interface Proxied
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Proxied()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/dispatcher/JavaDispatcher$Proxied;");
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
