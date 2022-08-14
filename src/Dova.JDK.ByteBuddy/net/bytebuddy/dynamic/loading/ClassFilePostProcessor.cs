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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;", "public abstract interface")]
public partial interface ClassFilePostProcessor
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassFilePostProcessor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/security/ProtectionDomain;[B)[B"));
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/security/ProtectionDomain;[B)[B", "public abstract")]
	JavaArray<byte> transform(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.ProtectionDomain arg2, JavaArray<byte> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$ForClassFileTransformer;", "public static")]
	public partial class ForClassFileTransformer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForClassFileTransformer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$ForClassFileTransformer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_PRIVILEGES", "Ljava/security/ProtectionDomain;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNLOADED_TYPE", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileTransformer", "Ljava/lang/instrument/ClassFileTransformer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/instrument/ClassFileTransformer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/security/ProtectionDomain;[B)[B"));
		}

		[JniSignatureAttribute("Ljava/security/ProtectionDomain;", "protected static final")]
		public static Dova.JDK.java.security.ProtectionDomain ALL_PRIVILEGES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.ProtectionDomain>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private static final")]
		public static Dova.JDK.java.lang.Class UNLOADED_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/instrument/ClassFileTransformer;", "private final")]
		public Dova.JDK.java.lang.instrument.ClassFileTransformer classFileTransformer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.instrument.ClassFileTransformer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForClassFileTransformer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/instrument/ClassFileTransformer;)V", "public")]
		public ForClassFileTransformer(Dova.JDK.java.lang.instrument.ClassFileTransformer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$ForClassFileTransformer;";
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

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/security/ProtectionDomain;[B)[B", "public")]
		public JavaArray<byte> transform(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.ProtectionDomain arg2, JavaArray<byte> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$ForClassFileTransformer$AllPermissionsCollection;", "protected static")]
		public partial class AllPermissionsCollection
			: Dova.JDK.java.security.PermissionCollection
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AllPermissionsCollection()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$ForClassFileTransformer$AllPermissionsCollection;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/security/Permission;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "elements", "()Ljava/util/Enumeration;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implies", "(Ljava/security/Permission;)Z"));
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AllPermissionsCollection(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "protected")]
			public AllPermissionsCollection() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$ForClassFileTransformer$AllPermissionsCollection;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/security/Permission;)V", "public")]
			public void add(Dova.JDK.java.security.Permission arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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

			[JniSignatureAttribute("()Ljava/util/Enumeration;", "public")]
			public Dova.JDK.java.util.Enumeration elements()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
			}

			[JniSignatureAttribute("(Ljava/security/Permission;)Z", "public")]
			public bool implies(Dova.JDK.java.security.Permission arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/security/ProtectionDomain;[B)[B"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/loading/ClassFilePostProcessor$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.loading.ClassFilePostProcessor.NoOp>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/String;Ljava/security/ProtectionDomain;[B)[B", "public")]
		public JavaArray<byte> transform(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.security.ProtectionDomain arg2, JavaArray<byte> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
	}
}
