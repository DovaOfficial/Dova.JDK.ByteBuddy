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

namespace Dova.JDK.net.bytebuddy;

[JniSignatureAttribute("Lnet/bytebuddy/TypeCache;", "public")]
public partial class TypeCache
	: Dova.JDK.java.lang.@ref.ReferenceQueue
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeCache()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/TypeCache;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_FOUND", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sort", "Lnet/bytebuddy/TypeCache$Sort;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cache", "Ljava/util/concurrent/ConcurrentMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/TypeCache$Sort;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insert", "(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/ClassLoader;Ljava/lang/Object;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expungeStaleEntries", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findOrInsert", "(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;Ljava/lang/Object;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findOrInsert", "(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;)Ljava/lang/Class;"));
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private static final")]
	public static Dova.JDK.java.lang.Class NOT_FOUND_Property
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

	[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$Sort;", "protected final")]
	public Dova.JDK.net.bytebuddy.TypeCache.Sort sort_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.TypeCache.Sort>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "protected final")]
	public Dova.JDK.java.util.concurrent.ConcurrentMap cache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TypeCache(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public TypeCache() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/TypeCache$Sort;)V", "public")]
	public TypeCache(Dova.JDK.net.bytebuddy.TypeCache.Sort arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/TypeCache;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class insert(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class find(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void expungeStaleEntries()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;Ljava/lang/Object;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class findOrInsert(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.Callable arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class findOrInsert(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.Callable arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$SimpleKey;", "public static")]
	public partial class SimpleKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/TypeCache$SimpleKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Collection;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/util/Collection;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;[Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set types_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)V", "public")]
		public SimpleKey(Dova.JDK.java.util.Collection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/Collection;)V", "public")]
		public SimpleKey(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.Collection arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;)V", "public transient")]
		public SimpleKey(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/TypeCache$SimpleKey;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$WithInlineExpunction;", "public static")]
	public partial class WithInlineExpunction
		: Dova.JDK.net.bytebuddy.TypeCache
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithInlineExpunction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/TypeCache$WithInlineExpunction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/TypeCache$Sort;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insert", "(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/ClassLoader;Ljava/lang/Object;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findOrInsert", "(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findOrInsert", "(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;Ljava/lang/Object;)Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WithInlineExpunction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public WithInlineExpunction() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/TypeCache$Sort;)V", "public")]
		public WithInlineExpunction(Dova.JDK.net.bytebuddy.TypeCache.Sort arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/TypeCache$WithInlineExpunction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class insert(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Class arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class find(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class findOrInsert(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.Callable arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Object;Ljava/util/concurrent/Callable;Ljava/lang/Object;)Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class findOrInsert(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.concurrent.Callable arg2, Dova.JDK.java.lang.Object arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$StorageKey;", "protected static")]
	public partial class StorageKey
		: Dova.JDK.java.lang.@ref.WeakReference
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StorageKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/TypeCache$StorageKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;Ljava/lang/ref/ReferenceQueue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/TypeCache$StorageKey;)I"));
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
		public StorageKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/ref/ReferenceQueue;)V", "protected")]
		public StorageKey(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.@ref.ReferenceQueue arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/TypeCache$StorageKey;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/TypeCache$StorageKey;)I", "static")]
		public static int access_100(Dova.JDK.net.bytebuddy.TypeCache.StorageKey arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$LookupKey;", "protected static")]
	public partial class LookupKey
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LookupKey()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/TypeCache$LookupKey;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/TypeCache$LookupKey;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lnet/bytebuddy/TypeCache$LookupKey;)Ljava/lang/ClassLoader;"));
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

		[JniSignatureAttribute("I", "private final")]
		public int hashCode_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LookupKey(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "protected")]
		public LookupKey(Dova.JDK.java.lang.ClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/TypeCache$LookupKey;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/TypeCache$LookupKey;)I", "static")]
		public static int access_200(Dova.JDK.net.bytebuddy.TypeCache.LookupKey arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/TypeCache$LookupKey;)Ljava/lang/ClassLoader;", "static")]
		public static Dova.JDK.java.lang.ClassLoader access_300(Dova.JDK.net.bytebuddy.TypeCache.LookupKey arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$Sort;", "public abstract static")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/TypeCache$Sort;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WEAK", "Lnet/bytebuddy/TypeCache$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOFT", "Lnet/bytebuddy/TypeCache$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRONG", "Lnet/bytebuddy/TypeCache$Sort;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/TypeCache$Sort;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/TypeCache$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/TypeCache$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/TypeCache$Sort;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.TypeCache.Sort WEAK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.TypeCache.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.TypeCache.Sort SOFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.TypeCache.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/TypeCache$Sort;", "public static final")]
		public static Dova.JDK.net.bytebuddy.TypeCache.Sort STRONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.TypeCache.Sort>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/TypeCache$Sort;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.TypeCache.Sort> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.TypeCache.Sort>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Sort(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Sort(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/TypeCache$1;)V", "")]
		public Sort(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.TypeCache arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/TypeCache$Sort;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/TypeCache$Sort;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.TypeCache.Sort> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.TypeCache.Sort>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/TypeCache$Sort;", "public static")]
		public static Dova.JDK.net.bytebuddy.TypeCache.Sort valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.TypeCache.Sort>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "protected abstract")]
		public Dova.JDK.java.lang.Object wrap(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
