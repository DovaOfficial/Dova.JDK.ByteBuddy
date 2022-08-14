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

namespace Dova.JDK.net.bytebuddy.pool;

[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "public abstract interface")]
public partial interface TypePool
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypePool()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void clear()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public abstract")]
	Dova.JDK.net.bytebuddy.pool.TypePool.Resolution describe(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Explicit;", "public static")]
	public partial class Explicit
		: Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.Hierarchical
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Explicit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Explicit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "types", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDescribe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map types_Property
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
		public Explicit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
		public Explicit(Dova.JDK.java.util.Map arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;)V", "public")]
		public Explicit(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Explicit;";
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

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doDescribe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$ClassLoading;", "public static")]
	public partial class ClassLoading
		: Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.Hierarchical
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassLoading()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$ClassLoading;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classLoader", "Ljava/lang/ClassLoader;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/pool/TypePool;Ljava/lang/ClassLoader;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPlatformLoader", "()Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDescribe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemLoader", "()Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLoader", "()Lnet/bytebuddy/pool/TypePool;"));
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassLoading(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/pool/TypePool;Ljava/lang/ClassLoader;)V", "public")]
		public ClassLoading(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.lang.ClassLoader arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$ClassLoading;";
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

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool of(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool of(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool ofPlatformLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doDescribe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool ofSystemLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool ofBootLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$LazyFacade;", "public static")]
	public partial class LazyFacade
		: Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LazyFacade()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$LazyFacade;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDescribe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
		public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LazyFacade(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)V", "public")]
		public LazyFacade(Dova.JDK.net.bytebuddy.pool.TypePool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$LazyFacade;";
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
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doDescribe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$LazyFacade$LazyTypeDescription;", "protected static")]
		public partial class LazyTypeDescription
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType.WithDelegation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LazyTypeDescription()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$LazyFacade$LazyTypeDescription;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegate", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private transient")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription @delegate_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LazyTypeDescription(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V", "protected")]
			public LazyTypeDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$LazyFacade$LazyTypeDescription;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "protected")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription @delegate()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$LazyFacade$LazyResolution;", "protected static")]
		public partial class LazyResolution
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LazyResolution()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$LazyFacade$LazyResolution;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LazyResolution(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V", "protected")]
			public LazyResolution(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$LazyFacade$LazyResolution;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default;", "public static")]
	public partial class Default
		: Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.Hierarchical
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IGNORE_METHOD", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileLocator", "Lnet/bytebuddy/dynamic/ClassFileLocator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readerMode", "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;Lnet/bytebuddy/pool/TypePool;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "([B)Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$3400", "()Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPlatformLoader", "()Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDescribe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemLoader", "()Lnet/bytebuddy/pool/TypePool;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLoader", "()Lnet/bytebuddy/pool/TypePool;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private static final")]
		public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor IGNORE_METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/ClassFileLocator;", "protected final")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator classFileLocator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "protected final")]
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V", "public")]
		public Default(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;Lnet/bytebuddy/pool/TypePool;)V", "public")]
		public Default(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool of(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool of(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("([B)Lnet/bytebuddy/description/type/TypeDescription;", "private")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription parse(JavaArray<byte> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/MethodVisitor;", "static")]
		public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor access_3400()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool ofPlatformLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doDescribe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool ofSystemLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool ofBootLoader()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;", "protected")]
		public partial class TypeExtractor
			: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeExtractor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER_CLASS_INDEX", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REAL_MODIFIER_MASK", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superTypeAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableBoundsAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actualModifiers", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClassName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceName", "[Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anonymousType", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestHost", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestMembers", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeContainment", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringTypeName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredTypes", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "permittedSubclasses", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestHost", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOuterClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNestMember", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClass", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRecordComponent", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$4200", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPermittedSubclass", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$4100", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$4300", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;)Ljava/util/List;"));
			}

			[JniSignatureAttribute("I", "private static final")]
			public static int SUPER_CLASS_INDEX_Property
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

			[JniSignatureAttribute("I", "private static final")]
			public static int REAL_MODIFIER_MASK_Property
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

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map superTypeAnnotationTokens_Property
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

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map typeVariableAnnotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map typeVariableBoundsAnnotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List annotationTokens_Property
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
			public Dova.JDK.java.util.List fieldTokens_Property
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

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List methodTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List recordComponentTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int actualModifiers_Property
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

			[JniSignatureAttribute("I", "private")]
			public int modifiers_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String internalName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String superClassName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String genericSignature_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Ljava/lang/String;", "private")]
			public JavaArray<Dova.JDK.java.lang.String> interfaceName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private")]
			public bool anonymousType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String nestHost_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List nestMembers_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;", "private")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment typeContainment_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private")]
			public Dova.JDK.java.lang.String declaringTypeName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List declaredTypes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List permittedSubclasses_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "private")]
			public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default;", "final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TypeExtractor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default;)V", "protected")]
			public TypeExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(IILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "public")]
			public void visit(int arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}

			[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitNestHost(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
			public void visitOuterClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitNestMember(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "public")]
			public void visitInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/RecordComponentVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor visitRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_4200(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "protected")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription toTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitPermittedSubclass(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_4100(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_4300(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$RecordComponentExtractor;", "protected")]
			public partial class RecordComponentExtractor
				: Dova.JDK.net.bytebuddy.jar.asm.RecordComponentVisitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RecordComponentExtractor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$RecordComponentExtractor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor this1_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public RecordComponentExtractor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
				public RecordComponentExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$RecordComponentExtractor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void visitEnd()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
				}

				[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$MethodExtractor;", "protected")]
			public partial class MethodExtractor
				: Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor
				, Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodExtractor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$MethodExtractor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionName", "[Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableBoundAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "receiverTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "legacyParameterBag", "Lnet/bytebuddy/pool/TypePool$Default$ParameterBag;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstLabel", "Lnet/bytebuddy/jar/asm/Label;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibleParameterShift", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invisibleParameterShift", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameter", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotationDefault", "()Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotableParameterCount", "(IZ)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterAnnotation", "(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabel", "(Lnet/bytebuddy/jar/asm/Label;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
				}

				[JniSignatureAttribute("I", "private final")]
				public int modifiers_Property
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
				public Dova.JDK.java.lang.String internalName_Property
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
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
				public JavaArray<Dova.JDK.java.lang.String> exceptionName_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeVariableAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeVariableBoundAnnotationTokens_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map returnTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map parameterTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map exceptionTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map receiverTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map parameterAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List parameterTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ParameterBag;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.ParameterBag legacyParameterBag_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ParameterBag>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/Label;", "private")]
				public Dova.JDK.net.bytebuddy.jar.asm.Label firstLabel_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.Label>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("I", "private")]
				public int visibleParameterShift_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
					}
				}

				[JniSignatureAttribute("I", "private")]
				public int invisibleParameterShift_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[17]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[17], value);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue defaultValue_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor this1_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public MethodExtractor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "protected")]
				public MethodExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$MethodExtractor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "public")]
				public void register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void visitEnd()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
				public void visitParameter(Dova.JDK.java.lang.String arg0, int arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotationDefault()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("(IZ)V", "public")]
				public void visitAnnotableParameterCount(int arg0, bool arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				}

				[JniSignatureAttribute("(ILjava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitParameterAnnotation(int arg0, Dova.JDK.java.lang.String arg1, bool arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/Label;)V", "public")]
				public void visitLabel(Dova.JDK.net.bytebuddy.jar.asm.Label arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/jar/asm/Label;Lnet/bytebuddy/jar/asm/Label;I)V", "public")]
				public void visitLocalVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.jar.asm.Label arg3, Dova.JDK.net.bytebuddy.jar.asm.Label arg4, int arg5)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
				}

				[JniSignatureAttribute("()V", "public")]
				public void onComplete()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$FieldExtractor;", "protected")]
			public partial class FieldExtractor
				: Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldExtractor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$FieldExtractor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeAnnotation", "(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
				}

				[JniSignatureAttribute("I", "private final")]
				public int modifiers_Property
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
				public Dova.JDK.java.lang.String internalName_Property
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
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor this1_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldExtractor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
				public FieldExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$FieldExtractor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, bool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void visitEnd()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
				}

				[JniSignatureAttribute("(ILnet/bytebuddy/jar/asm/TypePath;Ljava/lang/String;Z)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitTypeAnnotation(int arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.lang.String arg2, bool arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;", "protected")]
			public partial class AnnotationExtractor
				: Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AnnotationExtractor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationRegistrant", "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentTypeLocator", "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Ljava/lang/String;ILjava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Ljava/lang/String;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Ljava/lang/String;Ljava/lang/Object;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnum", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArray", "(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$3900", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;)Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant annotationRegistrant_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator componentTypeLocator_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor this1_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AnnotationExtractor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;)V", "protected")]
				public AnnotationExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Ljava/lang/String;ILjava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;)V", "protected")]
				public AnnotationExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor;Ljava/lang/String;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;)V", "protected")]
				public AnnotationExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
				public void visit(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitAnnotation(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void visitEnd()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "public")]
				public void visitEnum(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/jar/asm/AnnotationVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor visitArray(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.AnnotationVisitor>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;)Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;", "static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant access_3900(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor$AnnotationLookup;", "protected")]
				public partial class AnnotationLookup
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AnnotationLookup()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor$AnnotationLookup;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/Map;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$2", "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;Ljava/lang/String;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String descriptor_Property
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
					public Dova.JDK.java.util.Map values_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor this2_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AnnotationLookup(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
					public AnnotationLookup(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor$AnnotationLookup;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "public")]
					public void register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					}

					[JniSignatureAttribute("()V", "public")]
					public void onComplete()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor$ArrayLookup;", "protected")]
				public partial class ArrayLookup
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ArrayLookup()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor$ArrayLookup;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentTypeReference", "Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$2", "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference componentTypeReference_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List values_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor this2_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ArrayLookup(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public ArrayLookup(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;)V", "private")]
					public ArrayLookup(Dova.JDK.net.bytebuddy.pool.TypePool.Default.TypeExtractor.AnnotationExtractor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$TypeExtractor$AnnotationExtractor$ArrayLookup;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "public")]
					public void register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					}

					[JniSignatureAttribute("()V", "public")]
					public void onComplete()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "protected static")]
		public partial class LazyTypeDescription
			: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LazyTypeDescription()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_TYPE", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actualModifiers", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClassDescriptor", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceTypeDescriptors", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeContainment", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringTypeName", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredTypes", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anonymousType", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestHost", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestMembers", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClassAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableBoundsAnnotationTokens", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentTokens", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "permittedSubclasses", "Ljava/util/List;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;IILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;Ljava/lang/String;Ljava/util/List;ZLjava/lang/String;Ljava/util/List;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/ClassFileVersion;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRecord", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInterfaces", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestHost", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage", "()Lnet/bytebuddy/description/type/PackageDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredFields", "()Lnet/bytebuddy/description/field/FieldList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRecordComponents", "()Lnet/bytebuddy/description/type/RecordComponentList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredMethods", "()Lnet/bytebuddy/description/method/MethodList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestMembers", "()Lnet/bytebuddy/description/type/TypeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSealed", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1300", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$900", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "(Z)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2400", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/pool/TypePool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1100", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Ljava/util/List;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
			public static Dova.JDK.java.lang.String NO_TYPE_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int actualModifiers_Property
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
			public int modifiers_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String name_Property
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
			public Dova.JDK.java.lang.String superClassDescriptor_Property
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
			public Dova.JDK.java.lang.String genericSignature_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType signatureResolution_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List interfaceTypeDescriptors_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment typeContainment_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String declaringTypeName_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List declaredTypes_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool anonymousType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String nestHost_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List nestMembers_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map superClassAnnotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map interfaceAnnotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map typeVariableAnnotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map typeVariableBoundsAnnotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List annotationTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List fieldTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List methodTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List recordComponentTokens_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List permittedSubclasses_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "private final")]
			public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LazyTypeDescription(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;IILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;Ljava/lang/String;Ljava/util/List;ZLjava/lang/String;Ljava/util/List;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/ClassFileVersion;)V", "protected")]
			public LazyTypeDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, JavaArray<Dova.JDK.java.lang.String> arg5, Dova.JDK.java.lang.String arg6, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment arg7, Dova.JDK.java.lang.String arg8, Dova.JDK.java.util.List arg9, bool arg10, Dova.JDK.java.lang.String arg11, Dova.JDK.java.util.List arg12, Dova.JDK.java.util.Map arg13, Dova.JDK.java.util.Map arg14, Dova.JDK.java.util.Map arg15, Dova.JDK.java.util.Map arg16, Dova.JDK.java.util.List arg17, Dova.JDK.java.util.List arg18, Dova.JDK.java.util.List arg19, Dova.JDK.java.util.List arg20, Dova.JDK.java.util.List arg21, Dova.JDK.net.bytebuddy.ClassFileVersion arg22) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getModifiers()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRecord()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isSealed()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getGenericSignature()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_1300(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_900(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Z)I", "public")]
			public int getActualModifiers(bool arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isAnonymousType()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isLocalType()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
			public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/pool/TypePool;", "static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool access_2400(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_1100(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyRecordComponentDescription;", "private")]
			public partial class LazyRecordComponentDescription
				: Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyRecordComponentDescription()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyRecordComponentDescription;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;Ljava/util/Map;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualName", "()Ljava/lang/String;"));
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent signatureResolution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LazyRecordComponentDescription(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
				public LazyRecordComponentDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent arg4, Dova.JDK.java.util.Map arg5, Dova.JDK.java.util.List arg6, Dova.JDK.net.bytebuddy.pool.TypePool arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;Ljava/util/Map;Ljava/util/List;)V", "private")]
				public LazyRecordComponentDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent arg4, Dova.JDK.java.util.Map arg5, Dova.JDK.java.util.List arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyRecordComponentDescription;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getGenericSignature()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getActualName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;", "private")]
			public partial class LazyMethodDescription
				: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyMethodDescription()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeDescriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeDescriptors", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypeDescriptors", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableBoundAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "receiverTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterNames", "[Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterModifiers", "[Ljava/lang/Integer;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;[Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;[Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationValue;Lnet/bytebuddy/pool/TypePool$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2600", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)[Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2700", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)[Ljava/lang/Integer;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2800", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2900", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/Map;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$3000", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$3100", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/Map;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$3200", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/Map;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String internalName_Property
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

				[JniSignatureAttribute("I", "private final")]
				public int modifiers_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String returnTypeDescriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod signatureResolution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List parameterTypeDescriptors_Property
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
				public Dova.JDK.java.util.List exceptionTypeDescriptors_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeVariableAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeVariableBoundAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map returnTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map parameterTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map exceptionTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map receiverTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map parameterAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
				public JavaArray<Dova.JDK.java.lang.String> parameterNames_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Ljava/lang/Integer;", "private final")]
				public JavaArray<Dova.JDK.java.lang.Integer> parameterModifiers_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Integer>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue defaultValue_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LazyMethodDescription(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;[Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "private")]
				public LazyMethodDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod arg5, JavaArray<Dova.JDK.java.lang.String> arg6, Dova.JDK.java.util.Map arg7, Dova.JDK.java.util.Map arg8, Dova.JDK.java.util.Map arg9, Dova.JDK.java.util.Map arg10, Dova.JDK.java.util.Map arg11, Dova.JDK.java.util.Map arg12, Dova.JDK.java.util.List arg13, Dova.JDK.java.util.Map arg14, Dova.JDK.java.util.List arg15, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg16) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;[Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationValue;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
				public LazyMethodDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod arg5, JavaArray<Dova.JDK.java.lang.String> arg6, Dova.JDK.java.util.Map arg7, Dova.JDK.java.util.Map arg8, Dova.JDK.java.util.Map arg9, Dova.JDK.java.util.Map arg10, Dova.JDK.java.util.Map arg11, Dova.JDK.java.util.Map arg12, Dova.JDK.java.util.List arg13, Dova.JDK.java.util.Map arg14, Dova.JDK.java.util.List arg15, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg16, Dova.JDK.net.bytebuddy.pool.TypePool arg17) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()I", "public")]
				public int getModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReturnType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getGenericSignature()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getExceptionTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getDefaultValue()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterList getParameters()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getInternalName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)[Ljava/lang/String;", "static")]
				public static JavaArray<Dova.JDK.java.lang.String> access_2600(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)[Ljava/lang/Integer;", "static")]
				public static JavaArray<Dova.JDK.java.lang.Integer> access_2700(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Integer>>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/List;", "static")]
				public static Dova.JDK.java.util.List access_2800(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/Map;", "static")]
				public static Dova.JDK.java.util.Map access_2900(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;", "static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod access_3000(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/Map;", "static")]
				public static Dova.JDK.java.util.Map access_3100(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)Ljava/util/Map;", "static")]
				public static Dova.JDK.java.util.Map access_3200(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReceiverType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyNonGenericReceiverType;", "protected")]
				public partial class LazyNonGenericReceiverType
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyNonGenericReceiverType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyNonGenericReceiverType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyNonGenericReceiverType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)V", "protected")]
					public LazyNonGenericReceiverType(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public LazyNonGenericReceiverType(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyNonGenericReceiverType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;", "private")]
				public partial class LazyParameterizedReceiverType
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyParameterizedReceiverType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePath", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$3300", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;)Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyParameterizedReceiverType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)V", "protected")]
					public LazyParameterizedReceiverType(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public LazyParameterizedReceiverType(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/String;", "private")]
					public Dova.JDK.java.lang.String getTypePath()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;)Ljava/lang/String;", "static")]
					public static Dova.JDK.java.lang.String access_3300(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;", "protected")]
					public partial class TypeArgumentList
						: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static TypeArgumentList()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariables", "Ljava/util/List;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$2", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;Ljava/util/List;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
						}

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List typeVariables_Property
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

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType this2_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public TypeArgumentList(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType;Ljava/util/List;)V", "protected")]
						public TypeArgumentList(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object get_0(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("()I", "public")]
						public int size()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
							return ret;
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList$AnnotatedTypeVariable;", "protected")]
						public partial class AnnotatedTypeVariable
							: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static AnnotatedTypeVariable()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList$AnnotatedTypeVariable;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$3", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
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

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;", "final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType.TypeArgumentList this3_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType.TypeArgumentList>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public AnnotatedTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)V", "protected")]
							public AnnotatedTypeVariable(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription.LazyParameterizedReceiverType.TypeArgumentList arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterizedReceiverType$TypeArgumentList$AnnotatedTypeVariable;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
							public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
							}

							[JniSignatureAttribute("()Ljava/lang/String;", "public")]
							public Dova.JDK.java.lang.String getSymbol()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
							public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterDescription;", "private")]
				public partial class LazyParameterDescription
					: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyParameterDescription()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterDescription;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyParameterDescription(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;I)V", "protected")]
					public LazyParameterDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterDescription;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getName()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int getModifiers()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isNamed()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int getIndex()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
						return ret;
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool hasModifiers()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
						return ret;
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getDeclaringMethod_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterList;", "private")]
				public partial class LazyParameterList
					: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyParameterList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTypeList", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasExplicitMetaData", "()Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription this1_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public LazyParameterList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public LazyParameterList(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription;)V", "private")]
					public LazyParameterList(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyMethodDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyMethodDescription$LazyParameterList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
					}

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asTypeList()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool hasExplicitMetaData()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
						return ret;
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;", "private")]
			public partial class LazyFieldDescription
				: Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyFieldDescription()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;Ljava/util/Map;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericSignature", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
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

				[JniSignatureAttribute("I", "private final")]
				public int modifiers_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField signatureResolution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LazyFieldDescription(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
				public LazyFieldDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField arg5, Dova.JDK.java.util.Map arg6, Dova.JDK.java.util.List arg7, Dova.JDK.net.bytebuddy.pool.TypePool arg8) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;Ljava/util/Map;Ljava/util/List;)V", "private")]
				public LazyFieldDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField arg5, Dova.JDK.java.util.Map arg6, Dova.JDK.java.util.List arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int getModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getGenericSignature()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType;", "protected static")]
			public partial class TokenizedGenericType
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TokenizedGenericType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawTypeDescriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "erasure", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/TypeVariableSource;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/TypeVariableSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toErasure", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken genericTypeToken_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String rawTypeDescriptor_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map annotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
				public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolved_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription erasure_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public TokenizedGenericType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/TypeVariableSource;)V", "protected")]
				public TokenizedGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/TypeVariableSource;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg4)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription;", "protected static")]
				public static Dova.JDK.net.bytebuddy.description.type.TypeDescription toErasure(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$Malformed;", "protected static")]
				public partial class Malformed
					: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.LazyProjection.WithEagerNavigation
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Malformed()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$Malformed;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawTypeDescriptor", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String rawTypeDescriptor_Property
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
					public Malformed(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V", "protected")]
					public Malformed(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$Malformed;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$Malformed$TokenList;", "protected static")]
					public partial class TokenList
						: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static TokenList()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$Malformed$TokenList;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawTypeDescriptors", "Ljava/util/List;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasures", "()Lnet/bytebuddy/description/type/TypeList;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List rawTypeDescriptors_Property
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
						public TokenList(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)V", "protected")]
						public TokenList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$Malformed$TokenList;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object get_0(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("()I", "public")]
						public int size()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
							return ret;
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList asErasures()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$TypeVariableList;", "protected static")]
				public partial class TypeVariableList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static TypeVariableList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$TypeVariableList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariables", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundAnnotationTokens", "Ljava/util/Map;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List typeVariables_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
					public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map annotationTokens_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map boundAnnotationTokens_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public TypeVariableList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)V", "protected")]
					public TypeVariableList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$TypeVariableList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$TokenList;", "protected static")]
				public partial class TokenList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static TokenList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$TokenList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericTypeTokens", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rawTypeDescriptors", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/TypeVariableSource;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/TypeVariableSource;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasures", "()Lnet/bytebuddy/description/type/TypeList;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List genericTypeTokens_Property
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

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List rawTypeDescriptors_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
					public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map annotationTokens_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public TokenList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/TypeVariableSource;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public TokenList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg4, Dova.JDK.net.bytebuddy.pool.TypePool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/TypeVariableSource;)V", "private")]
					public TokenList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TokenizedGenericType$TokenList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList asErasures()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyNestMemberList;", "protected static")]
			public partial class LazyNestMemberList
				: Dova.JDK.net.bytebuddy.description.type.TypeList.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyNestMemberList()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyNestMemberList;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestMembers", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toInternalNames", "()[Ljava/lang/String;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List nestMembers_Property
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
				public LazyNestMemberList(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)V", "protected")]
				public LazyNestMemberList(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyNestMemberList;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object get_0(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription get_1(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int size()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int getStackSize()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
				public JavaArray<Dova.JDK.java.lang.String> toInternalNames()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyTypeList;", "protected static")]
			public partial class LazyTypeList
				: Dova.JDK.net.bytebuddy.description.type.TypeList.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyTypeList()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyTypeList;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptors", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toInternalNames", "()[Ljava/lang/String;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List descriptors_Property
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
				public LazyTypeList(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)V", "protected")]
				public LazyTypeList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyTypeList;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object get_0(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription get_1(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int size()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int getStackSize()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("()[Ljava/lang/String;", "public")]
				public JavaArray<Dova.JDK.java.lang.String> toInternalNames()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyPackageDescription;", "private static")]
			public partial class LazyPackageDescription
				: Dova.JDK.net.bytebuddy.description.type.PackageDescription.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyPackageDescription()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyPackageDescription;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LazyPackageDescription(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
				public LazyPackageDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V", "private")]
				public LazyPackageDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyPackageDescription;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue;", "private abstract static")]
			public partial class LazyAnnotationValue
				: Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyAnnotationValue()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/description/annotation/AnnotationValue$Loaded;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "()Lnet/bytebuddy/description/annotation/AnnotationValue$State;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
				}

				[JniSignatureAttribute("I", "private transient")]
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
				public LazyAnnotationValue(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$1;)V", "")]
				public LazyAnnotationValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				[JniSignatureAttribute("()V", "private")]
				public LazyAnnotationValue() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue;";
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

				[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/description/annotation/AnnotationValue$Loaded;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Loaded load(Dova.JDK.java.lang.ClassLoader arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Loaded>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue filter(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
				public Dova.JDK.java.lang.Object resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$State;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.State getState()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.State>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue doResolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForArray;", "private static")]
				public partial class ForArray
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationValue
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForArray()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForArray;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentTypeReference", "Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference componentTypeReference_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List values_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private transient")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue resolved_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForArray(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public ForArray(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference arg1, Dova.JDK.java.util.List arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;Ljava/util/List;)V", "private")]
					public ForArray(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForArray;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "protected")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue doResolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForEnumerationValue;", "private static")]
				public partial class ForEnumerationValue
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationValue
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForEnumerationValue()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForEnumerationValue;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
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

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String value_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private transient")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue resolved_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForEnumerationValue(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public ForEnumerationValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/lang/String;)V", "private")]
					public ForEnumerationValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForEnumerationValue;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "protected")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue doResolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForAnnotationValue;", "private static")]
				public partial class ForAnnotationValue
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationValue
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForAnnotationValue()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForAnnotationValue;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken annotationToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private transient")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue resolved_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForAnnotationValue(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public ForAnnotationValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;)V", "private")]
					public ForAnnotationValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForAnnotationValue;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "protected")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue doResolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForTypeValue;", "private static")]
				public partial class ForTypeValue
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationValue
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTypeValue()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForTypeValue;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeName", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolved", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private transient")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue resolved_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForTypeValue(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public ForTypeValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V", "private")]
					public ForTypeValue(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForTypeValue;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "protected")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue doResolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForMismatchedType;", "private static")]
				public partial class ForMismatchedType
					: Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForMismatchedType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForMismatchedType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sort", "Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/description/annotation/AnnotationValue$Loaded;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "filter", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getState", "()Lnet/bytebuddy/description/annotation/AnnotationValue$State;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String value_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;", "private final")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort sort_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForMismatchedType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public ForMismatchedType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort arg1, Dova.JDK.net.bytebuddy.pool.TypePool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;)V", "private")]
					public ForMismatchedType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationValue$ForMismatchedType;";
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

					[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/description/annotation/AnnotationValue$Loaded;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Loaded load(Dova.JDK.java.lang.ClassLoader arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Loaded>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue filter(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
					public Dova.JDK.java.lang.Object resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$State;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.State getState()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.State>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue$Sort;", "public")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort getSort()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue.Sort>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription;", "private static")]
			public partial class LazyAnnotationDescription
				: Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyAnnotationDescription()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$1;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asList", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare_0", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare_1", "(Ljava/lang/Class;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription$Loadable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asListOfNullable", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)Lnet/bytebuddy/description/annotation/AnnotationList;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "protected final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription annotationType_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
				public Dova.JDK.java.util.Map values_Property
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
				public LazyAnnotationDescription(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
				public LazyAnnotationDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V", "private")]
				public LazyAnnotationDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getAnnotationType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)Lnet/bytebuddy/description/annotation/AnnotationList;", "protected static")]
				public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationList asList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable prepare_0(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription$Loadable;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationDescription.Loadable prepare_1(Dova.JDK.java.lang.Class arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationDescription.Loadable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;)Lnet/bytebuddy/description/annotation/AnnotationList;", "protected static")]
				public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationList asListOfNullable(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription$Loadable;", "private static")]
				public partial class Loadable
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyAnnotationDescription
					, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Loadable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription$Loadable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljava/lang/Class;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/Class;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$1;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/Class;Ljava/util/Map;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()Ljava/lang/annotation/Annotation;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
					}

					[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
					public Dova.JDK.java.lang.Class annotationType_Property
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
					public Loadable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/Class;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$1;)V", "")]
					public Loadable(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/Class;Ljava/util/Map;)V", "private")]
					public Loadable(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyAnnotationDescription$Loadable;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/annotation/Annotation;", "public")]
					public Dova.JDK.java.lang.Object load()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public volatile")]
					public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable prepare(Dova.JDK.java.lang.Class arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentToken;", "protected static")]
			public partial class RecordComponentToken
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RecordComponentToken()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentToken;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toRecordComponentDescription", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1400", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentToken;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent signatureResolution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public RecordComponentToken(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/List;)V", "protected")]
				public RecordComponentToken(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentToken;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "private")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape toRecordComponentDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentToken;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "static")]
				public static Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape access_1400(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.RecordComponentToken arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken;", "protected static")]
			public partial class MethodToken
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodToken()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionName", "[Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableBoundAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "receiverTypeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMethodDescription", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1200", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
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

				[JniSignatureAttribute("I", "private final")]
				public int modifiers_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod signatureResolution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
				public JavaArray<Dova.JDK.java.lang.String> exceptionName_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeVariableAnnotationTokens_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeVariableBoundAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map returnTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map parameterTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map exceptionTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map receiverTypeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map parameterAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List parameterTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationValue;", "private final")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue defaultValue_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public MethodToken(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/Map;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "protected")]
				public MethodToken(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4, Dova.JDK.java.util.Map arg5, Dova.JDK.java.util.Map arg6, Dova.JDK.java.util.Map arg7, Dova.JDK.java.util.Map arg8, Dova.JDK.java.util.Map arg9, Dova.JDK.java.util.Map arg10, Dova.JDK.java.util.List arg11, Dova.JDK.java.util.Map arg12, Dova.JDK.java.util.List arg13, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg14) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape toMethodDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
				public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_1200(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.MethodToken arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken$ParameterToken;", "protected static")]
				public partial class ParameterToken
					: Dova.JDK.java.lang.Object
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ParameterToken()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken$ParameterToken;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NAME", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_MODIFIERS", "Ljava/lang/Integer;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "Ljava/lang/Integer;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Integer;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()Ljava/lang/Integer;"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
					public static Dova.JDK.java.lang.String NO_NAME_Property
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

					[JniSignatureAttribute("Ljava/lang/Integer;", "protected static final")]
					public static Dova.JDK.java.lang.Integer NO_MODIFIERS_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String name_Property
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

					[JniSignatureAttribute("Ljava/lang/Integer;", "private final")]
					public Dova.JDK.java.lang.Integer modifiers_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ParameterToken(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public ParameterToken() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Integer;)V", "protected")]
					public ParameterToken(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Integer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public ParameterToken(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodToken$ParameterToken;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
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

					[JniSignatureAttribute("()Ljava/lang/Integer;", "protected")]
					public Dova.JDK.java.lang.Integer getModifiers()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldToken;", "protected static")]
			public partial class FieldToken
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldToken()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldToken;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericSignature", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureResolution", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAnnotationTokens", "Ljava/util/Map;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFieldDescription", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$1000", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldToken;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;"));
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

				[JniSignatureAttribute("I", "private final")]
				public int modifiers_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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
				public Dova.JDK.java.lang.String genericSignature_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField signatureResolution_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map typeAnnotationTokens_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldToken(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/List;)V", "protected")]
				public FieldToken(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.util.Map arg4, Dova.JDK.java.util.List arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldToken;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;", "private")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyFieldDescription toFieldDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyFieldDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldToken;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$LazyFieldDescription;", "static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyFieldDescription access_1000(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.FieldToken arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.LazyFieldDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;", "protected static")]
			public partial class AnnotationToken
				: Dova.JDK.java.lang.Object
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AnnotationToken()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toAnnotationDescription", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBinaryName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$2000", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map values_Property
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
				public AnnotationToken(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)V", "protected")]
				public AnnotationToken(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution;", "private")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken.Resolution toAnnotationDescription(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken.Resolution>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
				public Dova.JDK.java.lang.String getBinaryName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution;", "static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken.Resolution access_2000(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken.Resolution>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution;", "protected abstract static interface")]
				public partial interface Resolution
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Resolution()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/annotation/AnnotationDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationDescription;", "public abstract")]
					Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription>(ret);
					}

					[JniSignatureAttribute("()Z", "public abstract")]
					bool isResolved()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution$Illegal;", "public static")]
					public partial class Illegal
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken.Resolution
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Illegal()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution$Illegal;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljava/lang/String;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/annotation/AnnotationDescription;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String annotationType_Property
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

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution$Illegal;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationDescription;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription resolve()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription>(ret);
						}

						[JniSignatureAttribute("()Z", "public")]
						public bool isResolved()
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
							return ret;
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution$Simple;", "public static")]
					public partial class Simple
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.AnnotationToken.Resolution
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Simple()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution$Simple;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationDescription", "Lnet/bytebuddy/description/annotation/AnnotationDescription;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/annotation/AnnotationDescription;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/annotation/AnnotationDescription;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription;", "private final")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription annotationDescription_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription>(ret);
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

						[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription;)V", "protected")]
						public Simple(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$AnnotationToken$Resolution$Simple;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationDescription;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription resolve()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription>(ret);
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

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "protected abstract static interface")]
			public partial interface GenericTypeToken
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static GenericTypeToken()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_TYPE_PATH", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPONENT_TYPE_PATH", "C"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WILDCARD_TYPE_PATH", "C"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INNER_CLASS_PATH", "C"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEXED_TYPE_DELIMITER", "C"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
				public static Dova.JDK.java.lang.String EMPTY_TYPE_PATH_Property
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

				[JniSignatureAttribute("C", "public static final")]
				public static char COMPONENT_TYPE_PATH_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[1]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[1], value);
					}
				}

				[JniSignatureAttribute("C", "public static final")]
				public static char WILDCARD_TYPE_PATH_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[2]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[2], value);
					}
				}

				[JniSignatureAttribute("C", "public static final")]
				public static char INNER_CLASS_PATH_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[3]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[3], value);
					}
				}

				[JniSignatureAttribute("C", "public static final")]
				public static char INDEXED_TYPE_DELIMITER_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[4]);
						return ret;
					}
					set
					{
						DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[4], value);
					}
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String getTypePathPrefix()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public abstract")]
				bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$LazyTokenList;", "public static")]
				public partial class LazyTokenList
					: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static LazyTokenList()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$LazyTokenList;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericTypeTokens", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
					public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String typePath_Property
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

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map annotationTokens_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List genericTypeTokens_Property
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
					public LazyTokenList(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Ljava/util/List;)V", "protected")]
					public LazyTokenList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$LazyTokenList;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
					public Dova.JDK.java.lang.Object get_0(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}

					[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("()I", "public")]
					public int size()
					{
						var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$LazyTokenList$ForWildcardBound;", "protected static")]
					public partial class ForWildcardBound
						: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForWildcardBound()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$LazyTokenList$ForWildcardBound;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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

						[JniSignatureAttribute("Ljava/util/Map;", "private final")]
						public Dova.JDK.java.util.Map annotationTokens_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken genericTypeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForWildcardBound(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
						public ForWildcardBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$LazyTokenList$ForWildcardBound;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
						public Dova.JDK.java.lang.Object get_0(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
						}

						[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("()I", "public")]
						public int size()
						{
							var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
							return ret;
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType;", "public static")]
				public partial class ForParameterizedType
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForParameterizedType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeTokens", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/List;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
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

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List parameterTypeTokens_Property
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
					public ForParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)V", "protected")]
					public ForParameterizedType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$LazyParameterizedType;", "protected static")]
					public partial class LazyParameterizedType
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static LazyParameterizedType()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$LazyParameterizedType;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeTokens", "Ljava/util/List;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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

						[JniSignatureAttribute("Ljava/util/Map;", "private final")]
						public Dova.JDK.java.util.Map annotationTokens_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String name_Property
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

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List parameterTypeTokens_Property
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

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public LazyParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V", "protected")]
						public LazyParameterizedType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.util.List arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$LazyParameterizedType;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$Nested;", "public static")]
					public partial class Nested
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Nested()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$Nested;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeTokens", "Ljava/util/List;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
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

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List parameterTypeTokens_Property
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

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken ownerTypeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Nested(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
						public Nested(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$Nested;";
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

						[JniSignatureAttribute("()Ljava/lang/String;", "public")]
						public Dova.JDK.java.lang.String getTypePathPrefix()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
						public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
						{
							var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return ret;
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$Nested$LazyParameterizedType;", "protected static")]
						public partial class LazyParameterizedType
							: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfParameterizedType
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static LazyParameterizedType()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$Nested$LazyParameterizedType;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeTokens", "Ljava/util/List;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
							public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/lang/String;", "private final")]
							public Dova.JDK.java.lang.String typePath_Property
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

							[JniSignatureAttribute("Ljava/util/Map;", "private final")]
							public Dova.JDK.java.util.Map annotationTokens_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
									return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/lang/String;", "private final")]
							public Dova.JDK.java.lang.String name_Property
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

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List parameterTypeTokens_Property
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

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken ownerTypeToken_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public LazyParameterizedType(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Ljava/lang/String;Ljava/util/List;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
							public LazyParameterizedType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.util.List arg5, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForParameterizedType$Nested$LazyParameterizedType;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
							public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeArguments()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUpperBoundWildcard;", "public static")]
				public partial class ForUpperBoundWildcard
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForUpperBoundWildcard()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUpperBoundWildcard;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken boundTypeToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForUpperBoundWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
					public ForUpperBoundWildcard(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUpperBoundWildcard;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUpperBoundWildcard$LazyUpperBoundWildcard;", "protected static")]
					public partial class LazyUpperBoundWildcard
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfWildcardType
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static LazyUpperBoundWildcard()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUpperBoundWildcard$LazyUpperBoundWildcard;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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

						[JniSignatureAttribute("Ljava/util/Map;", "private final")]
						public Dova.JDK.java.util.Map annotationTokens_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken boundTypeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public LazyUpperBoundWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
						public LazyUpperBoundWildcard(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUpperBoundWildcard$LazyUpperBoundWildcard;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForLowerBoundWildcard;", "public static")]
				public partial class ForLowerBoundWildcard
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForLowerBoundWildcard()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForLowerBoundWildcard;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken boundTypeToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForLowerBoundWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
					public ForLowerBoundWildcard(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForLowerBoundWildcard;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForLowerBoundWildcard$LazyLowerBoundWildcard;", "protected static")]
					public partial class LazyLowerBoundWildcard
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfWildcardType
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static LazyLowerBoundWildcard()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForLowerBoundWildcard$LazyLowerBoundWildcard;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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

						[JniSignatureAttribute("Ljava/util/Map;", "private final")]
						public Dova.JDK.java.util.Map annotationTokens_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken boundTypeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public LazyLowerBoundWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
						public LazyLowerBoundWildcard(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForLowerBoundWildcard$LazyLowerBoundWildcard;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForGenericArray;", "public static")]
				public partial class ForGenericArray
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForGenericArray()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForGenericArray;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken componentTypeToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForGenericArray(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
					public ForGenericArray(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForGenericArray;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForGenericArray$LazyGenericArray;", "protected static")]
					public partial class LazyGenericArray
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfGenericArray
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static LazyGenericArray()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForGenericArray$LazyGenericArray;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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

						[JniSignatureAttribute("Ljava/util/Map;", "private final")]
						public Dova.JDK.java.util.Map annotationTokens_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken componentTypeToken_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public LazyGenericArray(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
						public LazyGenericArray(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForGenericArray$LazyGenericArray;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable;", "public static")]
				public partial class ForTypeVariable
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String symbol_Property
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
					public ForTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public ForTypeVariable(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal;", "protected static")]
					public partial class Formal
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.OfFormalTypeVariable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Formal()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeTokens", "Ljava/util/List;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/List;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String symbol_Property
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

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List boundTypeTokens_Property
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
						public Formal(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)V", "protected")]
						public Formal(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal$LazyTypeVariable;", "protected static")]
						public partial class LazyTypeVariable
							: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static LazyTypeVariable()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal$LazyTypeVariable;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundaryAnnotationTokens", "Ljava/util/Map;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Ljava/lang/String;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeTokens", "Ljava/util/List;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
							public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/util/Map;", "private final")]
							public Dova.JDK.java.util.Map annotationTokens_Property
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

							[JniSignatureAttribute("Ljava/util/Map;", "private final")]
							public Dova.JDK.java.util.Map boundaryAnnotationTokens_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
									return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/lang/String;", "private final")]
							public Dova.JDK.java.lang.String symbol_Property
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

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List boundTypeTokens_Property
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

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public LazyTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V", "protected")]
							public LazyTypeVariable(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.util.List arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal$LazyTypeVariable;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
							public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
							}

							[JniSignatureAttribute("()Ljava/lang/String;", "public")]
							public Dova.JDK.java.lang.String getSymbol()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
							public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal$LazyTypeVariable$LazyBoundTokenList;", "protected static")]
							public partial class LazyBoundTokenList
								: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static LazyBoundTokenList()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal$LazyTypeVariable$LazyBoundTokenList;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boundTypeTokens", "Ljava/util/List;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/List;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
								public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
								public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Ljava/util/Map;", "private final")]
								public Dova.JDK.java.util.Map annotationTokens_Property
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
								public Dova.JDK.java.util.List boundTypeTokens_Property
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

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public LazyBoundTokenList(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/List;)V", "protected")]
								public LazyBoundTokenList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$Formal$LazyTypeVariable$LazyBoundTokenList;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
								public Dova.JDK.java.lang.Object get_0(int arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
								}

								[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
								public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
								}

								[JniSignatureAttribute("()I", "public")]
								public int size()
								{
									var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
									return ret;
								}
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$UnresolvedTypeVariable;", "protected static")]
					public partial class UnresolvedTypeVariable
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static UnresolvedTypeVariable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$UnresolvedTypeVariable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableSource", "Lnet/bytebuddy/description/TypeVariableSource;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "symbol", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/TypeVariableSource;Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/List;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/TypeVariableSource;", "private final")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource typeVariableSource_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String symbol_Property
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

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List annotationTokens_Property
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

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public UnresolvedTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/description/TypeVariableSource;Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/List;)V", "protected")]
						public UnresolvedTypeVariable(Dova.JDK.net.bytebuddy.description.TypeVariableSource arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$UnresolvedTypeVariable;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Ljava/lang/String;", "public")]
						public Dova.JDK.java.lang.String getSymbol()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$AnnotatedTypeVariable;", "protected static")]
					public partial class AnnotatedTypeVariable
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfTypeVariable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AnnotatedTypeVariable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$AnnotatedTypeVariable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariable", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSymbol", "()Ljava/lang/String;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariableSource", "()Lnet/bytebuddy/description/TypeVariableSource;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/util/List;", "private final")]
						public Dova.JDK.java.util.List annotationTokens_Property
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

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeVariable_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AnnotatedTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/List;Lnet/bytebuddy/description/type/TypeDescription$Generic;)V", "protected")]
						public AnnotatedTypeVariable(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.List arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForTypeVariable$AnnotatedTypeVariable;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Ljava/lang/String;", "public")]
						public Dova.JDK.java.lang.String getSymbol()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/TypeVariableSource;", "public")]
						public Dova.JDK.net.bytebuddy.description.TypeVariableSource getTypeVariableSource()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.TypeVariableSource>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForRawType;", "public static")]
				public partial class ForRawType
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForRawType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForRawType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
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
					public ForRawType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
					public ForRawType(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForRawType;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;", "public abstract static interface")]
				public partial interface Resolution
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Resolution()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveTypeVariables", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
					Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveTypeVariables(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;", "public abstract static interface")]
					public partial interface ForRecordComponent
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForRecordComponent()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveRecordType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveRecordType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent$Tokenized;", "public static")]
						public partial class Tokenized
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Tokenized()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent$Tokenized;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveRecordType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken recordComponentTypeToken_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Tokenized(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
							public Tokenized(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent$Tokenized;";
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

							[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveRecordType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;", "public abstract static interface")]
					public partial interface ForMethod
						: IJavaObject
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForMethod()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveReturnType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveParameterTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveExceptionTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveReturnType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveParameterTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveExceptionTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod$Tokenized;", "public static")]
						public partial class Tokenized
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Tokenized()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod$Tokenized;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeTokens", "Ljava/util/List;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypeTokens", "Ljava/util/List;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableTokens", "Ljava/util/List;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveTypeVariables", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveReturnType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveParameterTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveExceptionTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken returnTypeToken_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List parameterTypeTokens_Property
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

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List exceptionTypeTokens_Property
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

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List typeVariableTokens_Property
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

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Tokenized(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "protected")]
							public Tokenized(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod$Tokenized;";
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

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveTypeVariables(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveReturnType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}

							[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveParameterTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}

							[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveExceptionTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;", "public abstract static interface")]
					public partial interface ForField
						: IJavaObject
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForField()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveFieldType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveFieldType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField$Tokenized;", "public static")]
						public partial class Tokenized
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Tokenized()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField$Tokenized;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveFieldType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken fieldTypeToken_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Tokenized(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "protected")]
							public Tokenized(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField$Tokenized;";
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

							[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveFieldType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;", "public abstract static interface")]
					public partial interface ForType
						: IJavaObject
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForType()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveInterfaceTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSuperClass", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveInterfaceTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
						Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveSuperClass(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType$Tokenized;", "public static")]
						public partial class Tokenized
							: Dova.JDK.java.lang.Object
							, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Tokenized()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType$Tokenized;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClassToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceTypeTokens", "Ljava/util/List;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableTokens", "Ljava/util/List;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/util/List;Ljava/util/List;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveInterfaceTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveTypeVariables", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSuperClass", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken superClassToken_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List interfaceTypeTokens_Property
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

							[JniSignatureAttribute("Ljava/util/List;", "private final")]
							public Dova.JDK.java.util.List typeVariableTokens_Property
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
							public Tokenized(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;Ljava/util/List;Ljava/util/List;)V", "protected")]
							public Tokenized(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType$Tokenized;";
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

							[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveInterfaceTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveTypeVariables(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveSuperClass(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;", "public static final")]
					public partial class Malformed
						: Dova.JDK.java.lang.Enum
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Malformed()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;"));
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveInterfaceTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveTypeVariables", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveFieldType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveReturnType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveParameterTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveExceptionTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveRecordType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSuperClass", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;", "public static final")]
						public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed INSTANCE_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;", "private static final")]
						public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed> VALUES_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed>>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Malformed(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
						public Malformed(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;", "public static")]
						public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed> values()
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed>>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Malformed;", "public static")]
						public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed valueOf(Dova.JDK.java.lang.String arg0)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Malformed>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveInterfaceTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveTypeVariables(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveFieldType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveReturnType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveParameterTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveExceptionTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveRecordType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveSuperClass(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;", "public static final")]
					public partial class Raw
						: Dova.JDK.java.lang.Enum
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Raw()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;"));
							FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;"));
							MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveInterfaceTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveTypeVariables", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveFieldType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveReturnType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveParameterTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveExceptionTypes", "(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveRecordType", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveSuperClass", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;", "public static final")]
						public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw INSTANCE_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;", "private static final")]
						public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw> VALUES_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw>>(ret);
							}
							set
							{
								DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public Raw(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
						public Raw(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;", "public static")]
						public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw> values()
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw>>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw;", "public static")]
						public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw valueOf(Dova.JDK.java.lang.String arg0)
						{
							var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.Raw>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveInterfaceTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveTypeVariables(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveFieldType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveReturnType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveParameterTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic resolveExceptionTypes(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveRecordType(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic resolveSuperClass(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw$RawAnnotatedType;", "protected static")]
						public partial class RawAnnotatedType
							: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static RawAnnotatedType()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw$RawAnnotatedType;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
							public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/lang/String;", "private final")]
							public Dova.JDK.java.lang.String typePath_Property
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
							public Dova.JDK.java.util.Map annotationTokens_Property
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

							[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public RawAnnotatedType(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
							public RawAnnotatedType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw$RawAnnotatedType;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Ljava/lang/String;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "protected static")]
							public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic of(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.lang.String arg2)
							{
								var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
							public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
							public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw$RawAnnotatedType$LazyRawAnnotatedTypeList;", "protected static")]
							public partial class LazyRawAnnotatedTypeList
								: Dova.JDK.net.bytebuddy.description.type.TypeList.Generic.AbstractBase
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static LazyRawAnnotatedTypeList()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw$RawAnnotatedType$LazyRawAnnotatedTypeList;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
									FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptors", "Ljava/util/List;"));
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Ljava/util/List;)V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/description/type/TypeList$Generic;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStackSize", "()I"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasures", "()Lnet/bytebuddy/description/type/TypeList;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asRawTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
								}

								[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
								public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
								{
									get
									{
										var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
										return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
									}
									set
									{
										DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
									}
								}

								[JniSignatureAttribute("Ljava/util/Map;", "private final")]
								public Dova.JDK.java.util.Map annotationTokens_Property
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
								public Dova.JDK.java.util.List descriptors_Property
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
								public LazyRawAnnotatedTypeList(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Ljava/util/List;)V", "protected")]
								public LazyRawAnnotatedTypeList(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$Raw$RawAnnotatedType$LazyRawAnnotatedTypeList;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
								public Dova.JDK.java.lang.Object get_0(int arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
								}

								[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
								public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic get_1(int arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
								}

								[JniSignatureAttribute("()I", "public")]
								public int size()
								{
									var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
									return ret;
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/util/Map;Ljava/util/List;)Lnet/bytebuddy/description/type/TypeList$Generic;", "protected static")]
								public static Dova.JDK.net.bytebuddy.description.type.TypeList.Generic of(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.util.Map arg1, Dova.JDK.java.util.List arg2)
								{
									var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
								}

								[JniSignatureAttribute("()I", "public")]
								public int getStackSize()
								{
									var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
									return ret;
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
								public Dova.JDK.net.bytebuddy.description.type.TypeList asErasures()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
								public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic asRawTypes()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
								}
							}
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;", "public static final")]
				public partial class ForUnboundWildcard
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForUnboundWildcard()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForUnboundWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public ForUnboundWildcard(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForUnboundWildcard>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard$LazyUnboundWildcard;", "protected static")]
					public partial class LazyUnboundWildcard
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfWildcardType
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static LazyUnboundWildcard()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard$LazyUnboundWildcard;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/Map;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBounds", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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
						public Dova.JDK.java.util.Map annotationTokens_Property
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
						public LazyUnboundWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/Map;)V", "protected")]
						public LazyUnboundWildcard(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForUnboundWildcard$LazyUnboundWildcard;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getUpperBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getLowerBounds()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
				public partial class ForPrimitiveType
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForPrimitiveType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTEGER", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/Class;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(C)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypePathPrefix", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrimaryBound", "(Lnet/bytebuddy/pool/TypePool;)Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType BOOLEAN_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType BYTE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType SHORT_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType CHAR_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType INTEGER_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType LONG_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType FLOAT_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType DOUBLE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType VOID_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForPrimitiveType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Class;)V", "private")]
					public ForPrimitiveType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Class arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.ForPrimitiveType>(ret);
					}

					[JniSignatureAttribute("(C)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken of(char arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
					}

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String getTypePathPrefix()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/lang/String;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Z", "public")]
					public bool isPrimaryBound(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return ret;
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType$LazyPrimitiveType;", "protected static")]
					public partial class LazyPrimitiveType
						: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.OfNonGenericType
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static LazyPrimitiveType()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType$LazyPrimitiveType;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponentType_1", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asErasure", "()Lnet/bytebuddy/description/type/TypeDescription;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Ljava/lang/String;", "private final")]
						public Dova.JDK.java.lang.String typePath_Property
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
						public Dova.JDK.java.util.Map annotationTokens_Property
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

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public LazyPrimitiveType(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;Ljava/util/Map;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
						public LazyPrimitiveType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$ForPrimitiveType$LazyPrimitiveType;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getComponentType_0()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getComponentType_1()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
						public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription asErasure()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
						public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getOwnerType()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$OfFormalTypeVariable;", "public abstract static interface")]
				public partial interface OfFormalTypeVariable
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfFormalTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$OfFormalTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toGenericType", "(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/TypeVariableSource;Ljava/util/Map;Ljava/util/Map;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public abstract")]
					Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic toGenericType(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.net.bytebuddy.description.TypeVariableSource arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.util.Map arg3)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;", "protected abstract static interface")]
			public partial interface TypeContainment
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TypeContainment()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelfContained", "()Z"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
				Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Z", "public abstract")]
				bool isLocalType()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()Z", "public abstract")]
				bool isSelfContained()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$WithinMethod;", "public static")]
				public partial class WithinMethod
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithinMethod()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$WithinMethod;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodName", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescriptor", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelfContained", "()Z"));
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

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String methodName_Property
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
					public Dova.JDK.java.lang.String methodDescriptor_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithinMethod(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "protected")]
					public WithinMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$WithinMethod;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isLocalType()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
						return ret;
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isSelfContained()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$WithinType;", "public static")]
				public partial class WithinType
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithinType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$WithinType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localType", "Z"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Z)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelfContained", "()Z"));
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

					[JniSignatureAttribute("Z", "private final")]
					public bool localType_Property
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

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public WithinType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Z)V", "protected")]
					public WithinType(Dova.JDK.java.lang.String arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$WithinType;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isLocalType()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
						return ret;
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isSelfContained()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;", "public static final")]
				public partial class SelfContained
					: Dova.JDK.java.lang.Enum
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static SelfContained()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;"));
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingMethod", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelfContained", "()Z"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;", "public static final")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained INSTANCE_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;", "private static final")]
					public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained> VALUES_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained>>(ret);
						}
						set
						{
							DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public SelfContained(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
					public SelfContained(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;", "public static")]
					public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained> values()
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained>>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$TypeContainment$SelfContained;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained valueOf(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.TypeContainment.SelfContained>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
					public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
					public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isLocalType()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
						return ret;
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isSelfContained()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
						return ret;
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentTokenList;", "protected")]
			public partial class RecordComponentTokenList
				: Dova.JDK.net.bytebuddy.description.type.RecordComponentList.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RecordComponentTokenList()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentTokenList;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public RecordComponentTokenList(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)V", "protected")]
				public RecordComponentTokenList(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$RecordComponentTokenList;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object get_0(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/type/RecordComponentDescription$InDefinedShape;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape get_1(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int size()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodTokenList;", "protected")]
			public partial class MethodTokenList
				: Dova.JDK.net.bytebuddy.description.method.MethodList.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static MethodTokenList()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodTokenList;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public MethodTokenList(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)V", "protected")]
				public MethodTokenList(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$MethodTokenList;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object get_0(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape get_1(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int size()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldTokenList;", "protected")]
			public partial class FieldTokenList
				: Dova.JDK.net.bytebuddy.description.field.FieldList.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldTokenList()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldTokenList;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldTokenList(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription;)V", "protected")]
				public FieldTokenList(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$FieldTokenList;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object get_0(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape get_1(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int size()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor;", "protected static")]
		public partial class GenericTypeExtractor
			: Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant.RejectingSignatureVisitor
			, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GenericTypeExtractor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "genericTypeRegistrant", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "incompleteToken", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBaseType", "(C)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVariable", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClassType", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "()V"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant genericTypeRegistrant_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;", "private")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken incompleteToken_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public GenericTypeExtractor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant;)V", "protected")]
			public GenericTypeExtractor(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
			public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("()V", "public")]
			public void visitEnd()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("(C)V", "public")]
			public void visitBaseType(char arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitTypeVariable(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitArrayType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitClassType(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void visitInnerClassType(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
			public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitTypeArgument(char arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void visitTypeArgument()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature;", "protected abstract static")]
			public partial class ForSignature
				: Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant.RejectingSignatureVisitor
				, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForSignature()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariableTokens", "Ljava/util/List;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentTypeParameter", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentBounds", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extract", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collectTypeParameter", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFormalTypeParameter", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "protected final")]
				public Dova.JDK.java.util.List typeVariableTokens_Property
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

				[JniSignatureAttribute("Ljava/lang/String;", "protected")]
				public Dova.JDK.java.lang.String currentTypeParameter_Property
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

				[JniSignatureAttribute("Ljava/util/List;", "protected")]
				public Dova.JDK.java.util.List currentBounds_Property
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
				public ForSignature(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public ForSignature() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;", "protected static")]
				public static Dova.JDK.java.lang.Object extract(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature arg1)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
				public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;", "public abstract")]
				public Dova.JDK.java.lang.Object resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("()V", "protected")]
				public void collectTypeParameter()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterfaceBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitClassBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void visitFormalTypeParameter(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfRecordComponent;", "protected static")]
				public partial class OfRecordComponent
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfRecordComponent()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfRecordComponent;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentType", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extract", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken recordComponentType_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfRecordComponent(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public OfRecordComponent() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfRecordComponent;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent extract(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
					public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForRecordComponent;", "protected")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForRecordComponent>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;", "protected static")]
				public partial class OfMethod
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfMethod()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypeTokens", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exceptionTypeTokens", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extract", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_0", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_1", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$602", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)Ljava/util/List;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$700", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)Ljava/util/List;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturnType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptionType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List parameterTypeTokens_Property
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

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List exceptionTypeTokens_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken returnTypeToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfMethod(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public OfMethod() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod extract(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForMethod;", "public")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod resolve_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForMethod>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;", "public volatile")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution resolve_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken access_602(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg1)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)Ljava/util/List;", "static")]
					public static Dova.JDK.java.util.List access_500(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)Ljava/util/List;", "static")]
					public static Dova.JDK.java.util.List access_700(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitParameterType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitReturnType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitExceptionType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ExceptionTypeRegistrant;", "protected")]
					public partial class ExceptionTypeRegistrant
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ExceptionTypeRegistrant()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ExceptionTypeRegistrant;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ExceptionTypeRegistrant(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)V", "protected")]
						public ExceptionTypeRegistrant(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ExceptionTypeRegistrant;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ReturnTypeTypeRegistrant;", "protected")]
					public partial class ReturnTypeTypeRegistrant
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ReturnTypeTypeRegistrant()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ReturnTypeTypeRegistrant;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ReturnTypeTypeRegistrant(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)V", "protected")]
						public ReturnTypeTypeRegistrant(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ReturnTypeTypeRegistrant;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ParameterTypeRegistrant;", "protected")]
					public partial class ParameterTypeRegistrant
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ParameterTypeRegistrant()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ParameterTypeRegistrant;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ParameterTypeRegistrant(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod;)V", "protected")]
						public ParameterTypeRegistrant(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfMethod$ParameterTypeRegistrant;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfField;", "protected static")]
				public partial class OfField
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfField()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfField;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extract", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken fieldTypeToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfField(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public OfField() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfField;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField extract(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
					public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForField;", "protected")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForField>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;", "protected static")]
				public partial class OfType
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OfType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceTypeTokens", "Ljava/util/List;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClassToken", "Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "extract", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_0", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_1", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;)Ljava/util/List;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$302", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterface", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSuperclass", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					}

					[JniSignatureAttribute("Ljava/util/List;", "private final")]
					public Dova.JDK.java.util.List interfaceTypeTokens_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "private")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken superClassToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OfType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "protected")]
					public OfType() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;", "public static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType extract(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution$ForType;", "public")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType resolve_0()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution.ForType>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken$Resolution;", "public volatile")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution resolve_1()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken.Resolution>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;)Ljava/util/List;", "static")]
					public static Dova.JDK.java.util.List access_400(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "static")]
					public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken access_302(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg1)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterface()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitSuperclass()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType$InterfaceTypeRegistrant;", "protected")]
					public partial class InterfaceTypeRegistrant
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static InterfaceTypeRegistrant()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType$InterfaceTypeRegistrant;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public InterfaceTypeRegistrant(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;)V", "protected")]
						public InterfaceTypeRegistrant(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType$InterfaceTypeRegistrant;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType$SuperClassRegistrant;", "protected")]
					public partial class SuperClassRegistrant
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static SuperClassRegistrant()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType$SuperClassRegistrant;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public SuperClassRegistrant(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType;)V", "protected")]
						public SuperClassRegistrant(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.ForSignature.OfType arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$ForSignature$OfType$SuperClassRegistrant;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;", "protected abstract static interface")]
			public partial interface IncompleteToken
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static IncompleteToken()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendPlaceholder", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendLowerBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendUpperBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendDirectBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toToken", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String getName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()V", "public abstract")]
				void appendPlaceholder()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public abstract")]
				Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor appendLowerBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public abstract")]
				Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor appendUpperBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public abstract")]
				Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor appendDirectBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "public abstract")]
				Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken toToken()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
				}

				[JniSignatureAttribute("()Z", "public abstract")]
				bool isParameterized()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
					return ret;
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$ForInnerClass;", "public static")]
				public partial class ForInnerClass
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForInnerClass()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$ForInnerClass;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INNER_CLASS_SEPARATOR", "C"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outerTypeToken", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toToken", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
					}

					[JniSignatureAttribute("C", "private static final")]
					public static char INNER_CLASS_SEPARATOR_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetStaticCharField(ClassRefPtr, FieldPtrs[0]);
							return ret;
						}
						set
						{
							DovaVM.Runtime.SetStaticCharField(ClassRefPtr, FieldPtrs[0], value);
						}
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String internalName_Property
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;", "private final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken outerTypeToken_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public ForInnerClass(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken;)V", "public")]
					public ForInnerClass(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$ForInnerClass;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "public")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken toToken()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isParameterized()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$ForTopLevelType;", "public static")]
				public partial class ForTopLevelType
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTopLevelType()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$ForTopLevelType;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalName", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toToken", "()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isParameterized", "()Z"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String internalName_Property
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
					public ForTopLevelType(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public ForTopLevelType(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$ForTopLevelType;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;", "public")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken toToken()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken>(ret);
					}

					[JniSignatureAttribute("()Z", "public")]
					public bool isParameterized()
					{
						var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
						return ret;
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameters", "Ljava/util/List;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendPlaceholder", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendLowerBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendUpperBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendDirectBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					}

					[JniSignatureAttribute("Ljava/util/List;", "protected final")]
					public Dova.JDK.java.util.List parameters_Property
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
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()V", "public")]
					public void appendPlaceholder()
					{
						DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor appendLowerBound()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor appendUpperBound()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
					public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor appendDirectBound()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForLowerBound;", "protected")]
					public partial class ForLowerBound
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForLowerBound()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForLowerBound;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForLowerBound(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;)V", "protected")]
						public ForLowerBound(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForLowerBound;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForUpperBound;", "protected")]
					public partial class ForUpperBound
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForUpperBound()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForUpperBound;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForUpperBound(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;)V", "protected")]
						public ForUpperBound(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForUpperBound;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForDirectBound;", "protected")]
					public partial class ForDirectBound
						: Dova.JDK.java.lang.Object
						, Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeRegistrant
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ForDirectBound()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForDirectBound;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;", "final")]
						public Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase this0_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ForDirectBound(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase;)V", "protected")]
						public ForDirectBound(Dova.JDK.net.bytebuddy.pool.TypePool.Default.GenericTypeExtractor.IncompleteToken.AbstractBase arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeExtractor$IncompleteToken$AbstractBase$ForDirectBound;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public")]
						public void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
						{
							DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						}
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ParameterBag;", "protected static")]
		public partial class ParameterBag
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ParameterBag()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ParameterBag;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterType", "[Lnet/bytebuddy/jar/asm/Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterRegistry", "Ljava/util/Map;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/jar/asm/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(ILjava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Z)Ljava/util/List;"));
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/jar/asm/Type;", "private final")]
			public JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> parameterType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map parameterRegistry_Property
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
			public ParameterBag(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/jar/asm/Type;)V", "protected")]
			public ParameterBag(JavaArray<Dova.JDK.net.bytebuddy.jar.asm.Type> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$ParameterBag;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(ILjava/lang/String;)V", "protected")]
			public void register(int arg0, Dova.JDK.java.lang.String arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Z)Ljava/util/List;", "protected")]
			public Dova.JDK.java.util.List resolve(bool arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant;", "protected abstract static interface")]
		public partial interface GenericTypeRegistrant
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static GenericTypeRegistrant()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$LazyTypeDescription$GenericTypeToken;)V", "public abstract")]
			void register(Dova.JDK.net.bytebuddy.pool.TypePool.Default.LazyTypeDescription.GenericTypeToken arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant$RejectingSignatureVisitor;", "public static")]
			public partial class RejectingSignatureVisitor
				: Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RejectingSignatureVisitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant$RejectingSignatureVisitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MESSAGE", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEnd", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBaseType", "(C)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeVariable", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInnerClassType", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArgument", "(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterface", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassBound", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSuperclass", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParameterType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturnType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExceptionType", "()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFormalTypeParameter", "(Ljava/lang/String;)V"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
				public static Dova.JDK.java.lang.String MESSAGE_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public RejectingSignatureVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public RejectingSignatureVisitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$GenericTypeRegistrant$RejectingSignatureVisitor;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()V", "public")]
				public void visitEnd()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
				}

				[JniSignatureAttribute("(C)V", "public")]
				public void visitBaseType(char arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void visitTypeVariable(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitArrayType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void visitClassType(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void visitInnerClassType(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				}

				[JniSignatureAttribute("()V", "public")]
				public void visitTypeArgument()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
				}

				[JniSignatureAttribute("(C)Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitTypeArgument(char arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterface()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitInterfaceBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitClassBound()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitSuperclass()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitParameterType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitReturnType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/jar/asm/signature/SignatureVisitor;", "public")]
				public Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor visitExceptionType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.signature.SignatureVisitor>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public void visitFormalTypeParameter(Dova.JDK.java.lang.String arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;", "protected abstract static interface")]
		public partial interface ComponentTypeLocator
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ComponentTypeLocator()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;"));
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "public abstract")]
			Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference bind(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForArrayType;", "public static")]
			public partial class ForArrayType
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator
				, Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForArrayType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForArrayType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentType", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String componentType_Property
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
				public ForArrayType(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
				public ForArrayType(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForArrayType;";
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

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference bind(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;", "public static")]
			public partial class ForAnnotationProperty
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForAnnotationProperty()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePool", "Lnet/bytebuddy/pool/TypePool;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationName", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;)Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;)Lnet/bytebuddy/pool/TypePool;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool typePool_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String annotationName_Property
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
				public ForAnnotationProperty(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;Ljava/lang/String;)V", "public")]
				public ForAnnotationProperty(Dova.JDK.net.bytebuddy.pool.TypePool arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;";
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

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference bind(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;)Ljava/lang/String;", "static")]
				public static Dova.JDK.java.lang.String access_100(Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.ForAnnotationProperty arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;)Lnet/bytebuddy/pool/TypePool;", "static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool access_200(Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.ForAnnotationProperty arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty$Bound;", "protected")]
				public partial class Bound
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Bound()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty$Bound;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/String;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;", "final")]
					public Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.ForAnnotationProperty this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.ForAnnotationProperty>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Bound(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty;Ljava/lang/String;)V", "protected")]
					public Bound(Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.ForAnnotationProperty arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$ForAnnotationProperty$Bound;";
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

					[JniSignatureAttribute("()Ljava/lang/String;", "public")]
					public Dova.JDK.java.lang.String resolve()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;", "public static final")]
			public partial class Illegal
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Illegal()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;", "public static final")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Illegal(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Illegal(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$ComponentTypeLocator$Illegal;", "public static")]
				public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ComponentTypeLocator.Illegal>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference bind(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase.ComponentTypeReference>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;", "protected abstract static interface")]
		public partial interface AnnotationRegistrant
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AnnotationRegistrant()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "public abstract")]
			void register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("()V", "public abstract")]
			void onComplete()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable;", "public static")]
			public partial class ForTypeVariable
				: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase.ForTypeVariable
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForTypeVariable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pathMap", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;Ljava/util/Map;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathMap", "()Ljava/util/Map;"));
				}

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map pathMap_Property
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
				public ForTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;Ljava/util/Map;)V", "protected")]
				public ForTypeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
				public Dova.JDK.java.util.Map getPathMap()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable$WithIndex;", "public static")]
				public partial class WithIndex
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase.ForTypeVariable.WithIndex
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithIndex()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable$WithIndex;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexedPathMap", "Ljava/util/Map;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;ILjava/util/Map;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexedPathMap", "()Ljava/util/Map;"));
					}

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map indexedPathMap_Property
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
					public WithIndex(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;ILjava/util/Map;)V", "protected")]
					public WithIndex(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, int arg2, Dova.JDK.java.util.Map arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable$WithIndex;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
					public Dova.JDK.java.util.Map getIndexedPathMap()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable$WithIndex$DoubleIndexed;", "public static")]
					public partial class DoubleIndexed
						: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase.ForTypeVariable.WithIndex.DoubleIndexed
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static DoubleIndexed()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable$WithIndex$DoubleIndexed;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "doubleIndexedPathMap", "Ljava/util/Map;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;IILjava/util/Map;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleIndexedPathMap", "()Ljava/util/Map;"));
						}

						[JniSignatureAttribute("Ljava/util/Map;", "private final")]
						public Dova.JDK.java.util.Map doubleIndexedPathMap_Property
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
						public DoubleIndexed(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;IILjava/util/Map;)V", "protected")]
						public DoubleIndexed(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, int arg2, int arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForTypeVariable$WithIndex$DoubleIndexed;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
						public Dova.JDK.java.util.Map getDoubleIndexedPathMap()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForByteCodeElement;", "public static")]
			public partial class ForByteCodeElement
				: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForByteCodeElement()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForByteCodeElement;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTokens", "()Ljava/util/List;"));
				}

				[JniSignatureAttribute("Ljava/util/List;", "private final")]
				public Dova.JDK.java.util.List annotationTokens_Property
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
				public ForByteCodeElement(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)V", "protected")]
				public ForByteCodeElement(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForByteCodeElement;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/util/List;", "protected")]
				public Dova.JDK.java.util.List getTokens()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForByteCodeElement$WithIndex;", "public static")]
				public partial class WithIndex
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithIndex()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForByteCodeElement$WithIndex;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationTokens", "Ljava/util/Map;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/util/Map;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTokens", "()Ljava/util/List;"));
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

					[JniSignatureAttribute("Ljava/util/Map;", "private final")]
					public Dova.JDK.java.util.Map annotationTokens_Property
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
					public WithIndex(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Map;)V", "protected")]
					public WithIndex(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Map arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$ForByteCodeElement$WithIndex;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/util/List;", "protected")]
					public Dova.JDK.java.util.List getTokens()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase;", "public abstract static")]
			public partial class AbstractBase
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AbstractBase()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descriptor", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/Map;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTokens", "()Ljava/util/List;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onComplete", "()V"));
				}

				[JniSignatureAttribute("Ljava/lang/String;", "private final")]
				public Dova.JDK.java.lang.String descriptor_Property
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

				[JniSignatureAttribute("Ljava/util/Map;", "private final")]
				public Dova.JDK.java.util.Map values_Property
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
				public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
				public AbstractBase(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)V", "public")]
				public void register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				}

				[JniSignatureAttribute("()Ljava/util/List;", "protected abstract")]
				public Dova.JDK.java.util.List getTokens()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
				}

				[JniSignatureAttribute("()V", "public")]
				public void onComplete()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable;", "protected abstract static")]
				public partial class ForTypeVariable
					: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForTypeVariable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typePath", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathMap", "()Ljava/util/Map;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTokens", "()Ljava/util/List;"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String typePath_Property
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
					public ForTypeVariable(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;)V", "protected")]
					public ForTypeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("()Ljava/util/Map;", "protected abstract")]
					public Dova.JDK.java.util.Map getPathMap()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
					}

					[JniSignatureAttribute("()Ljava/util/List;", "protected")]
					public Dova.JDK.java.util.List getTokens()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable$WithIndex;", "protected abstract static")]
					public partial class WithIndex
						: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase.ForTypeVariable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static WithIndex()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable$WithIndex;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;I)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexedPathMap", "()Ljava/util/Map;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathMap", "()Ljava/util/Map;"));
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

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public WithIndex(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;I)V", "protected")]
						public WithIndex(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable$WithIndex;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("()Ljava/util/Map;", "protected abstract")]
						public Dova.JDK.java.util.Map getIndexedPathMap()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}

						[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
						public Dova.JDK.java.util.Map getPathMap()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable$WithIndex$DoubleIndexed;", "protected abstract static")]
						public partial class DoubleIndexed
							: Dova.JDK.net.bytebuddy.pool.TypePool.Default.AnnotationRegistrant.AbstractBase.ForTypeVariable.WithIndex
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static DoubleIndexed()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable$WithIndex$DoubleIndexed;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preIndex", "I"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;II)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndexedPathMap", "()Ljava/util/Map;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDoubleIndexedPathMap", "()Ljava/util/Map;"));
							}

							[JniSignatureAttribute("I", "private final")]
							public int preIndex_Property
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
							public DoubleIndexed(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/jar/asm/TypePath;II)V", "protected")]
							public DoubleIndexed(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.jar.asm.TypePath arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$AnnotationRegistrant$AbstractBase$ForTypeVariable$WithIndex$DoubleIndexed;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("()Ljava/util/Map;", "protected")]
							public Dova.JDK.java.util.Map getIndexedPathMap()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}

							[JniSignatureAttribute("()Ljava/util/Map;", "protected abstract")]
							public Dova.JDK.java.util.Map getDoubleIndexedPathMap()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
							}
						}
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;", "public static")]
		public partial class WithLazyResolution
			: Dova.JDK.net.bytebuddy.pool.TypePool.Default
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static WithLazyResolution()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;Lnet/bytebuddy/pool/TypePool;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/pool/TypePool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$001", "(Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doResolve", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPlatformLoader", "()Lnet/bytebuddy/pool/TypePool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doCache", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDescribe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSystemLoader", "()Lnet/bytebuddy/pool/TypePool;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBootLoader", "()Lnet/bytebuddy/pool/TypePool;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public WithLazyResolution(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;)V", "public")]
			public WithLazyResolution(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/dynamic/ClassFileLocator;Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;Lnet/bytebuddy/pool/TypePool;)V", "public")]
			public WithLazyResolution(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1, Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/pool/TypePool;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool of(Dova.JDK.java.lang.ClassLoader arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/pool/TypePool;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool of(Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.Resolution access_001(Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution arg0, Dova.JDK.java.lang.String arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doResolve(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool ofPlatformLoader()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doCache(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doDescribe(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool ofSystemLoader()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool ofBootLoader()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution$LazyTypeDescription;", "protected")]
			public partial class LazyTypeDescription
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType.WithDelegation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyTypeDescription()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution$LazyTypeDescription;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegate", "()Lnet/bytebuddy/description/type/TypeDescription;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private transient")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LazyTypeDescription(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;Ljava/lang/String;)V", "protected")]
				public LazyTypeDescription(Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution$LazyTypeDescription;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription @delegate()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution$LazyResolution;", "protected")]
			public partial class LazyResolution
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static LazyResolution()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution$LazyResolution;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;", "final")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public LazyResolution(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution;Ljava/lang/String;)V", "protected")]
				public LazyResolution(Dova.JDK.net.bytebuddy.pool.TypePool.Default.WithLazyResolution arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$WithLazyResolution$LazyResolution;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isResolved()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "public static final")]
		public partial class ReaderMode
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReaderMode()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDED", "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FAST", "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;II)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlags", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExtended", "()Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "public static final")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode EXTENDED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "public static final")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode FAST_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int flags_Property
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

			[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReaderMode(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;II)V", "private")]
			public ReaderMode(Dova.JDK.java.lang.String arg0, int arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Default$ReaderMode;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Default.ReaderMode>(ret);
			}

			[JniSignatureAttribute("()I", "protected")]
			public int getFlags()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isExtended()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.pool.TypePool
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMITIVE_TYPES", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIMITIVE_DESCRIPTORS", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_SYMBOL", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cacheProvider", "Lnet/bytebuddy/pool/TypePool$CacheProvider;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doCache", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doDescribe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "protected static final")]
		public static Dova.JDK.java.util.Map PRIMITIVE_TYPES_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "protected static final")]
		public static Dova.JDK.java.util.Map PRIMITIVE_DESCRIPTORS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String ARRAY_SYMBOL_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider;", "protected final")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider cacheProvider_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;)V", "protected")]
		public AbstractBase(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$AbstractBase;";
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
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution describe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doCache(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution doDescribe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$AbstractBase$ArrayTypeResolution;", "protected static")]
		public partial class ArrayTypeResolution
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ArrayTypeResolution()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$AbstractBase$ArrayTypeResolution;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolution", "Lnet/bytebuddy/pool/TypePool$Resolution;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arity", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$Resolution;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/pool/TypePool$Resolution;I)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Resolution;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution resolution_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int arity_Property
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
			public ArrayTypeResolution(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Resolution;I)V", "protected")]
			public ArrayTypeResolution(Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$AbstractBase$ArrayTypeResolution;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$Resolution;I)Lnet/bytebuddy/pool/TypePool$Resolution;", "protected static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.Resolution of(Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$AbstractBase$Hierarchical;", "public abstract static")]
		public partial class Hierarchical
			: Dova.JDK.net.bytebuddy.pool.TypePool.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Hierarchical()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$AbstractBase$Hierarchical;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Lnet/bytebuddy/pool/TypePool;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/pool/TypePool;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool parent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Hierarchical(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/pool/TypePool;)V", "protected")]
			public Hierarchical(Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$AbstractBase$Hierarchical;";
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
			public void clear()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution describe(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;", "protected abstract static interface")]
		public partial interface ComponentTypeReference
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ComponentTypeReference()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$AbstractBase$ComponentTypeReference;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARRAY", "Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
			public static Dova.JDK.java.lang.String NO_ARRAY_Property
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

			[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
			Dova.JDK.java.lang.String resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Empty;", "public static final")]
	public partial class Empty
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.pool.TypePool
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Empty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Empty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$Empty;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$Empty;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$Empty;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Empty;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "describe", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Empty;", "public static final")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool.Empty INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Empty>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$Empty;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Empty> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Empty>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Empty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$Empty;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Empty> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.Empty>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Empty;", "public static")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool.Empty valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Empty>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution describe(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider;", "public abstract static interface")]
	public partial interface CacheProvider
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CacheProvider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$CacheProvider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNRESOLVED", "Lnet/bytebuddy/pool/TypePool$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Resolution;", "public static final")]
		public static Dova.JDK.net.bytebuddy.pool.TypePool.Resolution UNRESOLVED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public abstract")]
		Dova.JDK.net.bytebuddy.pool.TypePool.Resolution register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public abstract")]
		Dova.JDK.net.bytebuddy.pool.TypePool.Resolution find(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider$Discriminating;", "public static")]
		public partial class Discriminating
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Discriminating()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$CacheProvider$Discriminating;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matched", "Lnet/bytebuddy/pool/TypePool$CacheProvider;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unmatched", "Lnet/bytebuddy/pool/TypePool$CacheProvider;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/pool/TypePool$CacheProvider;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider matched_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider;", "private final")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider unmatched_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Discriminating(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/pool/TypePool$CacheProvider;Lnet/bytebuddy/pool/TypePool$CacheProvider;)V", "public")]
			public Discriminating(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg1, Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$CacheProvider$Discriminating;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void clear()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution find(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$CacheProvider$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "storage", "Ljava/util/concurrent/ConcurrentMap;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/concurrent/ConcurrentMap;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withObjectType", "()Lnet/bytebuddy/pool/TypePool$CacheProvider;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStorage", "()Ljava/util/concurrent/ConcurrentMap;"));
			}

			[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private final")]
			public Dova.JDK.java.util.concurrent.ConcurrentMap storage_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
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

			[JniSignatureAttribute("()V", "public")]
			public Simple() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			[JniSignatureAttribute("(Ljava/util/concurrent/ConcurrentMap;)V", "public")]
			public Simple(Dova.JDK.java.util.concurrent.ConcurrentMap arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$CacheProvider$Simple;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void clear()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution find(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/pool/TypePool$CacheProvider;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider withObjectType()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/concurrent/ConcurrentMap;", "public")]
			public Dova.JDK.java.util.concurrent.ConcurrentMap getStorage()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider$Simple$UsingSoftReference;", "public static")]
			public partial class UsingSoftReference
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static UsingSoftReference()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$CacheProvider$Simple$UsingSoftReference;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "delegate", "Ljava/util/concurrent/atomic/AtomicReference;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				}

				[JniSignatureAttribute("Ljava/util/concurrent/atomic/AtomicReference;", "private final")]
				public Dova.JDK.java.util.concurrent.atomic.AtomicReference @delegate_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.atomic.AtomicReference>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public UsingSoftReference(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public UsingSoftReference() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$CacheProvider$Simple$UsingSoftReference;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()V", "public")]
				public void clear()
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
				public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution find(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;", "public static final")]
		public partial class NoOp
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoOp()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;", "public static final")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$CacheProvider$NoOp;", "public static")]
			public static Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.CacheProvider.NoOp>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void clear()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/pool/TypePool$Resolution;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution register(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/pool/TypePool$Resolution;", "public")]
			public Dova.JDK.net.bytebuddy.pool.TypePool.Resolution find(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.pool.TypePool.Resolution>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Resolution;", "public abstract static interface")]
	public partial interface Resolution
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolution()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Resolution;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isResolved()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Resolution$NoSuchTypeException;", "public static")]
		public partial class NoSuchTypeException
			: Dova.JDK.java.lang.IllegalStateException
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoSuchTypeException()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Resolution$NoSuchTypeException;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("J", "private static final")]
			public static long serialVersionUID_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public NoSuchTypeException(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public NoSuchTypeException(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Resolution$NoSuchTypeException;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Resolution$Illegal;", "public static")]
		public partial class Illegal
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Illegal()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Resolution$Illegal;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
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
			public Illegal(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public Illegal(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Resolution$Illegal;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isResolved()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/pool/TypePool$Resolution$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.pool.TypePool.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/pool/TypePool$Resolution$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isResolved", "()Z"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
			public Simple(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/pool/TypePool$Resolution$Simple;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription resolve()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
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
