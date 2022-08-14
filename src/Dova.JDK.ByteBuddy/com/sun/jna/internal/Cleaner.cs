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

namespace Dova.JDK.com.sun.jna.@internal;

[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner;", "public")]
public partial class Cleaner
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Cleaner()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/internal/Cleaner;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lcom/sun/jna/internal/Cleaner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "referenceQueue", "Ljava/lang/ref/ReferenceQueue;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanerThread", "Ljava/lang/Thread;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstCleanable", "Lcom/sun/jna/internal/Cleaner$CleanerRef;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lcom/sun/jna/internal/Cleaner$CleanerRef;)Lcom/sun/jna/internal/Cleaner$CleanerRef;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Lcom/sun/jna/internal/Cleaner$CleanerRef;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/lang/Object;Ljava/lang/Runnable;)Lcom/sun/jna/internal/Cleaner$Cleanable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getCleaner", "()Lcom/sun/jna/internal/Cleaner;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lcom/sun/jna/internal/Cleaner;Lcom/sun/jna/internal/Cleaner$CleanerRef;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lcom/sun/jna/internal/Cleaner;)Ljava/lang/ref/ReferenceQueue;"));
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner;", "private static final")]
	public static Dova.JDK.com.sun.jna.@internal.Cleaner INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/ref/ReferenceQueue;", "private final")]
	public Dova.JDK.java.lang.@ref.ReferenceQueue referenceQueue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Thread;", "private final")]
	public Dova.JDK.java.lang.Thread cleanerThread_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$CleanerRef;", "private")]
	public Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef firstCleanable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Cleaner(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public Cleaner() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jna/internal/Cleaner;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner$CleanerRef;)Lcom/sun/jna/internal/Cleaner$CleanerRef;", "private synchronized")]
	public Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef add(Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner$CleanerRef;)Z", "private synchronized")]
	public bool remove(Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Runnable;)Lcom/sun/jna/internal/Cleaner$Cleanable;", "public synchronized")]
	public Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable register(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jna/internal/Cleaner;", "public static")]
	public static Dova.JDK.com.sun.jna.@internal.Cleaner getCleaner()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner;Lcom/sun/jna/internal/Cleaner$CleanerRef;)Z", "static")]
	public static bool access_100(Dova.JDK.com.sun.jna.@internal.Cleaner arg0, Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner;)Ljava/lang/ref/ReferenceQueue;", "static")]
	public static Dova.JDK.java.lang.@ref.ReferenceQueue access_000(Dova.JDK.com.sun.jna.@internal.Cleaner arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.ReferenceQueue>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$Cleanable;", "public abstract static interface")]
	public partial interface Cleanable
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Cleanable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/internal/Cleaner$Cleanable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clean", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void clean()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$CleanerRef;", "private static")]
	public partial class CleanerRef
		: Dova.JDK.java.lang.@ref.PhantomReference
		, Dova.JDK.com.sun.jna.@internal.Cleaner.Cleanable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CleanerRef()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jna/internal/Cleaner$CleanerRef;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleaner", "Lcom/sun/jna/internal/Cleaner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cleanupTask", "Ljava/lang/Runnable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previous", "Lcom/sun/jna/internal/Cleaner$CleanerRef;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "next", "Lcom/sun/jna/internal/Cleaner$CleanerRef;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jna/internal/Cleaner;Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clean", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNext", "()Lcom/sun/jna/internal/Cleaner$CleanerRef;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNext", "(Lcom/sun/jna/internal/Cleaner$CleanerRef;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrevious", "(Lcom/sun/jna/internal/Cleaner$CleanerRef;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrevious", "()Lcom/sun/jna/internal/Cleaner$CleanerRef;"));
		}

		[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner;", "private final")]
		public Dova.JDK.com.sun.jna.@internal.Cleaner cleaner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable cleanupTask_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$CleanerRef;", "private")]
		public Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef previous_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/jna/internal/Cleaner$CleanerRef;", "private")]
		public Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CleanerRef(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner;Ljava/lang/Object;Ljava/lang/ref/ReferenceQueue;Ljava/lang/Runnable;)V", "public")]
		public CleanerRef(Dova.JDK.com.sun.jna.@internal.Cleaner arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.@ref.ReferenceQueue arg2, Dova.JDK.java.lang.Runnable arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/jna/internal/Cleaner$CleanerRef;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void clean()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Lcom/sun/jna/internal/Cleaner$CleanerRef;", "")]
		public Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef getNext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner$CleanerRef;)V", "")]
		public void setNext(Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/jna/internal/Cleaner$CleanerRef;)V", "")]
		public void setPrevious(Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/jna/internal/Cleaner$CleanerRef;", "")]
		public Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef getPrevious()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jna.@internal.Cleaner.CleanerRef>(ret);
		}
	}
}
