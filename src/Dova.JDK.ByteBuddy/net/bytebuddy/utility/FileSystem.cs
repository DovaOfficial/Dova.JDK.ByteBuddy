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

namespace Dova.JDK.net.bytebuddy.utility;

[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem;", "public abstract")]
public partial class FileSystem
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileSystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FileSystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/utility/FileSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lnet/bytebuddy/utility/FileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljava/io/File;Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/io/File;Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem;", "private static")]
	public static Dova.JDK.net.bytebuddy.utility.FileSystem INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FileSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
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
	public FileSystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public FileSystem() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/FileSystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/utility/FileSystem;", "public static")]
	public static Dova.JDK.net.bytebuddy.utility.FileSystem getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public abstract")]
	public void copy(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public abstract")]
	public void move(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object access_000(Dova.JDK.java.security.PrivilegedAction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm;", "protected static")]
	public partial class ForNio2CapableVm
		: Dova.JDK.net.bytebuddy.utility.FileSystem
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForNio2CapableVm()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FILES", "Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Files;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDARD_COPY_OPTION", "Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$StandardCopyOption;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljava/io/File;Ljava/io/File;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/io/File;Ljava/io/File;)V"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Dispatcher;", "private static final")]
		public static Dova.JDK.net.bytebuddy.utility.FileSystem.ForNio2CapableVm.Dispatcher DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FileSystem.ForNio2CapableVm.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Files;", "private static final")]
		public static Dova.JDK.net.bytebuddy.utility.FileSystem.ForNio2CapableVm.Files FILES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FileSystem.ForNio2CapableVm.Files>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$StandardCopyOption;", "private static final")]
		public static Dova.JDK.net.bytebuddy.utility.FileSystem.ForNio2CapableVm.StandardCopyOption STANDARD_COPY_OPTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.FileSystem.ForNio2CapableVm.StandardCopyOption>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForNio2CapableVm(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public ForNio2CapableVm() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm;";
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

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public")]
		public void copy(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public")]
		public void move(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$StandardCopyOption;", "protected abstract static interface")]
		public partial interface StandardCopyOption
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static StandardCopyOption()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$StandardCopyOption;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "(I)[Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(I)[Ljava/lang/Object;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Object> toArray(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Files;", "protected abstract static interface")]
		public partial interface Files
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Files()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Files;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object copy(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object move(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FileSystem$ForNio2CapableVm$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toPath", "(Ljava/io/File;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object toPath(Dova.JDK.java.io.File arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/FileSystem$ForLegacyVm;", "protected static")]
	public partial class ForLegacyVm
		: Dova.JDK.net.bytebuddy.utility.FileSystem
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLegacyVm()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/FileSystem$ForLegacyVm;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljava/io/File;Ljava/io/File;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/io/File;Ljava/io/File;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForLegacyVm(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public ForLegacyVm() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/FileSystem$ForLegacyVm;";
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

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public")]
		public void copy(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)V", "public")]
		public void move(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}
	}
}
