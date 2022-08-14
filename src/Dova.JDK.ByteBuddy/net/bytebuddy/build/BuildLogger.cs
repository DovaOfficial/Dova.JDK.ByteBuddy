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

[JniSignatureAttribute("Lnet/bytebuddy/build/BuildLogger;", "public abstract interface")]
public partial interface BuildLogger
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BuildLogger()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/BuildLogger;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDebugEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInfoEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWarnEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrorEnabled", "()Z"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void info(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public abstract")]
	void info(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public abstract")]
	void debug(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void debug(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public abstract")]
	void error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void error(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public abstract")]
	void warn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void warn(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isDebugEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isInfoEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isWarnEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isErrorEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/BuildLogger$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.build.BuildLogger
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/BuildLogger$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buildLoggers", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/build/BuildLogger;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDebugEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInfoEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWarnEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrorEnabled", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List buildLoggers_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/build/BuildLogger;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.build.BuildLogger> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/BuildLogger$Compound;";
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

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDebugEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInfoEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isWarnEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErrorEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/BuildLogger$StreamWriting;", "public static")]
	public partial class StreamWriting
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.build.BuildLogger
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StreamWriting()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/BuildLogger$StreamWriting;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printStream", "Ljava/io/PrintStream;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/PrintStream;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemOut", "()Lnet/bytebuddy/build/BuildLogger;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toSystemError", "()Lnet/bytebuddy/build/BuildLogger;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDebugEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInfoEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWarnEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrorEnabled", "()Z"));
		}

		[JniSignatureAttribute("Ljava/io/PrintStream;", "private final")]
		public Dova.JDK.java.io.PrintStream printStream_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StreamWriting(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/PrintStream;)V", "public")]
		public StreamWriting(Dova.JDK.java.io.PrintStream arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/BuildLogger$StreamWriting;";
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

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/BuildLogger;", "public static")]
		public static Dova.JDK.net.bytebuddy.build.BuildLogger toSystemOut()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.BuildLogger>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/build/BuildLogger;", "public static")]
		public static Dova.JDK.net.bytebuddy.build.BuildLogger toSystemError()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.BuildLogger>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDebugEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInfoEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isWarnEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErrorEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/BuildLogger$Adapter;", "public abstract static")]
	public partial class Adapter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.build.BuildLogger
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Adapter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/BuildLogger$Adapter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDebugEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInfoEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWarnEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrorEnabled", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Adapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/BuildLogger$Adapter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDebugEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInfoEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isWarnEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErrorEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/build/BuildLogger$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.build.BuildLogger
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/build/BuildLogger$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/build/BuildLogger$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/build/BuildLogger$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/build/BuildLogger$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/build/BuildLogger$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "info", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debug", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDebugEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInfoEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isWarnEnabled", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isErrorEnabled", "()Z"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/build/BuildLogger$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/build/BuildLogger$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/build/BuildLogger$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/build/BuildLogger$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/build/BuildLogger$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.build.BuildLogger.NoOp>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void info(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void debug(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void error(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void warn(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDebugEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInfoEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isWarnEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isErrorEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}
	}
}
