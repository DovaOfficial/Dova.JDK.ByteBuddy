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

namespace Dova.JDK.net.bytebuddy.implementation;

[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation;", "public abstract interface")]
public partial interface Implementation
	: IJavaObject
	, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Implementation()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public abstract")]
	Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Simple;", "public static")]
	public partial class Simple
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Simple()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Simple;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ADDITIONAL_VARIABLES", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteCodeAppender", "Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;I)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;I)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int NO_ADDITIONAL_VARIABLES_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender byteCodeAppender_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V", "public transient")]
		public Simple(JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "public transient")]
		public Simple(JavaArray<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Simple;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;)Lnet/bytebuddy/implementation/Implementation;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.Implementation of(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;I)Lnet/bytebuddy/implementation/Implementation;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.Implementation of(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;)Lnet/bytebuddy/implementation/Implementation;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.Implementation of(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;I)Lnet/bytebuddy/implementation/Implementation;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.Implementation of(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;", "protected static")]
		public partial class ForDispatcher
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.Implementation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForDispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dispatcher", "Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prepareable", "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "additionalVariableLength", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$400", "(Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;)Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$500", "(Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher dispatcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable prepareable_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int additionalVariableLength_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;I)V", "protected")]
			public ForDispatcher(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;)Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;", "static")]
			public static Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher access_400(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.ForDispatcher arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.Dispatcher>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;)I", "static")]
			public static int access_500(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.ForDispatcher arg0)
			{
				var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher$Appender;", "protected")]
			public partial class Appender
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Appender()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher$Appender;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationTarget", "Lnet/bytebuddy/implementation/Implementation$Target;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;Lnet/bytebuddy/implementation/Implementation$Target;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Target implementationTarget_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;", "final")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.ForDispatcher this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.ForDispatcher>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher;Lnet/bytebuddy/implementation/Implementation$Target;)V", "protected")]
				public Appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Simple.ForDispatcher arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Simple$ForDispatcher$Appender;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;", "public abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Simple$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation apply(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementations", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/implementation/Implementation;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$300", "(Lnet/bytebuddy/implementation/Implementation$Compound;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List implementations_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/implementation/Implementation;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Compound;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Compound;)Ljava/util/List;", "static")]
		public static Dova.JDK.java.util.List access_300(Dova.JDK.net.bytebuddy.implementation.Implementation.Compound arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Compound$Composable;", "public static")]
		public partial class Composable
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Composable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Compound$Composable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "composable", "Lnet/bytebuddy/implementation/Implementation$Composable;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementations", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/Implementation;Lnet/bytebuddy/implementation/Implementation$Composable;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Lnet/bytebuddy/implementation/Implementation$Composable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/implementation/Implementation$Compound$Composable;)Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/implementation/Implementation$Compound$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Composable;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable composable_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List implementations_Property
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
			public Composable(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;Lnet/bytebuddy/implementation/Implementation$Composable;)V", "public")]
			public Composable(Dova.JDK.net.bytebuddy.implementation.Implementation arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/util/List;Lnet/bytebuddy/implementation/Implementation$Composable;)V", "public")]
			public Composable(Dova.JDK.java.util.List arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Compound$Composable;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Compound$Composable;)Ljava/util/List;", "static")]
			public static Dova.JDK.java.util.List access_100(Dova.JDK.net.bytebuddy.implementation.Implementation.Compound.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Compound$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "static")]
			public static Dova.JDK.net.bytebuddy.implementation.Implementation.Composable access_200(Dova.JDK.net.bytebuddy.implementation.Implementation.Compound.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context;", "public abstract static interface")]
	public partial interface Context
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Context()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cache", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;)Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape cache(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;)Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription register(Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public abstract")]
		Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default;", "public static")]
		public partial class Default
			: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESSOR_METHOD_SUFFIX", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_CACHE_PREFIX", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypeNamingStrategy", "Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInitializer", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryClassFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredAccessorMethods", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredGetters", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredSetters", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypes", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredFieldCacheEntries", "Ljava/util/Map;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "registeredFieldCacheFields", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suffix", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldCacheCanAppendEntries", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cache", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;)Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerGetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerAccessorFor", "(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerSetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drain", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
			public static Dova.JDK.java.lang.String ACCESSOR_METHOD_SUFFIX_Property
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

			[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
			public static Dova.JDK.java.lang.String FIELD_CACHE_PREFIX_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy auxiliaryTypeNamingStrategy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer typeInitializer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "private final")]
			public Dova.JDK.net.bytebuddy.ClassFileVersion auxiliaryClassFileVersion_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map registeredAccessorMethods_Property
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
			public Dova.JDK.java.util.Map registeredGetters_Property
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
			public Dova.JDK.java.util.Map registeredSetters_Property
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
			public Dova.JDK.java.util.Map auxiliaryTypes_Property
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
			public Dova.JDK.java.util.Map registeredFieldCacheEntries_Property
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

			[JniSignatureAttribute("Ljava/util/Set;", "private final")]
			public Dova.JDK.java.util.Set registeredFieldCacheFields_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/String;", "private final")]
			public Dova.JDK.java.lang.String suffix_Property
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

			[JniSignatureAttribute("Z", "private")]
			public bool fieldCacheCanAppendEntries_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Ljava/lang/String;)V", "protected")]
			public Default(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg3, Dova.JDK.net.bytebuddy.ClassFileVersion arg4, Dova.JDK.java.lang.String arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape cache(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription register(Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List getAuxiliaryTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerGetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerAccessorFor(Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerSetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
			public void drain(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;", "public static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.ClassFileVersion arg3, Dova.JDK.net.bytebuddy.ClassFileVersion arg4)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory$WithFixedSuffix;", "public static")]
				public partial class WithFixedSuffix
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static WithFixedSuffix()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory$WithFixedSuffix;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "suffix", "Ljava/lang/String;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
					}

					[JniSignatureAttribute("Ljava/lang/String;", "private final")]
					public Dova.JDK.java.lang.String suffix_Property
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
					public WithFixedSuffix(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
					public WithFixedSuffix(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$Factory$WithFixedSuffix;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "public")]
					public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.ClassFileVersion arg3, Dova.JDK.net.bytebuddy.ClassFileVersion arg4)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldSetterDelegation;", "protected static")]
			public partial class FieldSetterDelegation
				: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldSetterDelegation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldSetterDelegation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;Lnet/bytebuddy/description/field/FieldDescription;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldSetterDelegation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
				public FieldSetterDelegation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;Lnet/bytebuddy/description/field/FieldDescription;)V", "private")]
				public FieldSetterDelegation(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldSetterDelegation;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord with(Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldGetterDelegation;", "protected static")]
			public partial class FieldGetterDelegation
				: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldGetterDelegation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldGetterDelegation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;Lnet/bytebuddy/description/field/FieldDescription;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;Lnet/bytebuddy/description/field/FieldDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldGetterDelegation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
				public FieldGetterDelegation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;Lnet/bytebuddy/description/field/FieldDescription;)V", "private")]
				public FieldGetterDelegation(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldGetterDelegation;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord with(Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$AccessorMethodDelegation;", "protected static")]
			public partial class AccessorMethodDelegation
				: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AccessorMethodDelegation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$AccessorMethodDelegation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessorMethodInvocation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation accessorMethodInvocation_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AccessorMethodDelegation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;)V", "protected")]
				public AccessorMethodDelegation(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg2, Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "private")]
				public AccessorMethodDelegation(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$AccessorMethodDelegation;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord with(Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;", "protected abstract static")]
			public partial class DelegationRecord
				: Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.ForDefinedMethod
				, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static DelegationRecord()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod_0", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod_1", "()Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSort", "()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyHead", "(Lnet/bytebuddy/jar/asm/MethodVisitor;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyBody", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyAttributes", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyCode", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "protected final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "protected final")]
				public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public DelegationRecord(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/modifier/Visibility;)V", "protected")]
				public DelegationRecord(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getMethod_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethod_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record prepend(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record$Sort;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort getSort()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record.Sort>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/implementation/Implementation$Context$Default$DelegationRecord;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord with(Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.DelegationRecord>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
				public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;)V", "public")]
				public void applyHead(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void applyBody(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
				public void applyAttributes(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg1)
				{
					DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size applyCode(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldSetter;", "protected static")]
			public partial class FieldSetter
				: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.AbstractPropertyAccessorMethod
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldSetter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldSetter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldSetter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;Ljava/lang/String;)V", "protected")]
				public FieldSetter(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldSetter;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReturnType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getExceptionTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getDefaultValue()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterList getParameters()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getInternalName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()I", "protected")]
				public int getBaseModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldGetter;", "protected static")]
			public partial class FieldGetter
				: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.AbstractPropertyAccessorMethod
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldGetter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldGetter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription fieldDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldGetter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;Ljava/lang/String;)V", "protected")]
				public FieldGetter(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldGetter;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReturnType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getExceptionTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getDefaultValue()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterList getParameters()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getInternalName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()I", "protected")]
				public int getBaseModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$AccessorMethod;", "protected static")]
			public partial class AccessorMethod
				: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Default.AbstractPropertyAccessorMethod
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AccessorMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$AccessorMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AccessorMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;)V", "protected")]
				public AccessorMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$AccessorMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReturnType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getExceptionTypes()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getDefaultValue()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterList getParameters()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
				}

				[JniSignatureAttribute("()Ljava/lang/String;", "public")]
				public Dova.JDK.java.lang.String getInternalName()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("()I", "protected")]
				public int getBaseModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$AbstractPropertyAccessorMethod;", "protected abstract static")]
			public partial class AbstractPropertyAccessorMethod
				: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AbstractPropertyAccessorMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$AbstractPropertyAccessorMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseModifiers", "()I"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AbstractPropertyAccessorMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "protected")]
				public AbstractPropertyAccessorMethod() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$AbstractPropertyAccessorMethod;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()I", "public")]
				public int getModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
					return ret;
				}

				[JniSignatureAttribute("()I", "protected abstract")]
				public int getBaseModifiers()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
					return ret;
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldCacheEntry;", "protected static")]
			public partial class FieldCacheEntry
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static FieldCacheEntry()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldCacheEntry;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldValue", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeIn", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation fieldValue_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription fieldType_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public FieldCacheEntry(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public FieldCacheEntry(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$FieldCacheEntry;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "protected")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getFieldType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool isValid()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "protected")]
				public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender storeIn(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Default$CacheValueField;", "protected static")]
			public partial class CacheValueField
				: Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static CacheValueField()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Default$CacheValueField;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldType", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic fieldType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public CacheValueField(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/lang/String;I)V", "protected")]
				public CacheValueField(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, Dova.JDK.java.lang.String arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Default$CacheValueField;";
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

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Disabled;", "public static")]
		public partial class Disabled
			: Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Disabled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Disabled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cache", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;)Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerGetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerAccessorFor", "(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerSetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drain", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Disabled(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;)V", "protected")]
			public Disabled(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Disabled;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape cache(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType;)Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription register(Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/List;", "public")]
			public Dova.JDK.java.util.List getAuxiliaryTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerGetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerAccessorFor(Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerSetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
			public void drain(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;", "public static final")]
			public partial class Factory
				: Dova.JDK.java.lang.Enum
				, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Factory()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory INSTANCE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Factory(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Factory(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Context$Disabled$Factory;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Disabled.Factory>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "public")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.ClassFileVersion arg3, Dova.JDK.net.bytebuddy.ClassFileVersion arg4)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg2, Dova.JDK.net.bytebuddy.ClassFileVersion arg3, Dova.JDK.net.bytebuddy.ClassFileVersion arg4)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;", "public abstract static interface")]
		public partial interface ExtractableView
			: IJavaObject
			, Dova.JDK.net.bytebuddy.implementation.Implementation.Context
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ExtractableView()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "drain", "(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
			}

			[JniSignatureAttribute("()Z", "public abstract")]
			bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
			Dova.JDK.java.util.List getAuxiliaryTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public abstract")]
			void drain(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView$AbstractBase;", "public abstract static")]
			public partial class AbstractBase
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.ExtractableView
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AbstractBase()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView$AbstractBase;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "protected final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

				[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "protected final")]
				public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/ClassFileVersion;)V", "protected")]
				public AbstractBase(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.ClassFileVersion arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Context$ExtractableView$AbstractBase;";
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
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
				public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target;", "public abstract static interface")]
	public partial interface Target
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Target()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Target;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeSuper", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDominant", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDefault", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDefault", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeSuper(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeDominant(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDefinition getOriginType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeDefault(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeDefault(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.Implementation.Target
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraph", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultMethodInvocation", "Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstrumentedType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDominant", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDefault", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeDefault", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "protected final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription instrumentedType_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;", "protected final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked methodGraph_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "protected final")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation defaultMethodInvocation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;)V", "protected")]
			public AbstractBase(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase;";
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
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getInstrumentedType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeDominant(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeDefault(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation invokeDefault(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "protected abstract static")]
			public partial class DefaultMethodInvocation
				: Dova.JDK.java.lang.Enum
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static DefaultMethodInvocation()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENABLED", "Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISABLED", "Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/Implementation$1;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation ENABLED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "public static final")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation DISABLED_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "private static final")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public DefaultMethodInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public DefaultMethodInvocation(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/Implementation$1;)V", "")]
				public DefaultMethodInvocation(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.Implementation arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "public static")]
				public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Node;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation apply(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Node arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target$AbstractBase$DefaultMethodInvocation;", "public static")]
				public static Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation of(Dova.JDK.net.bytebuddy.ClassFileVersion arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target.AbstractBase.DefaultMethodInvocation>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Target$Factory;", "public abstract static interface")]
		public partial interface Factory
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Factory()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Target$Factory;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Linked;Lnet/bytebuddy/ClassFileVersion;)Lnet/bytebuddy/implementation/Implementation$Target;", "public abstract")]
			Dova.JDK.net.bytebuddy.implementation.Implementation.Target make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Linked arg1, Dova.JDK.net.bytebuddy.ClassFileVersion arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Target>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract static interface")]
	public partial interface SpecialMethodInvocation
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SpecialMethodInvocation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCheckedCompatibilityTo", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodDescription", "()Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation withCheckedCompatibilityTo(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethodDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Simple;", "public static")]
		public partial class Simple
			: Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Simple()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Simple;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCheckedCompatibilityTo", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodDescription", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription methodDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "protected")]
			public Simple(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Simple;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation of(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation withCheckedCompatibilityTo(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethodDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.AbstractBase
			, Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
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
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$AbstractBase;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;", "public static final")]
		public partial class Illegal
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Illegal()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValid", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withCheckedCompatibilityTo", "(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodDescription", "()Lnet/bytebuddy/description/method/MethodDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation$Illegal;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation.Illegal>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;)Lnet/bytebuddy/implementation/bytecode/StackManipulation$Size;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation.Size>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isValid()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$TypeToken;)Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation withCheckedCompatibilityTo(Dova.JDK.net.bytebuddy.description.method.MethodDescription.TypeToken arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription getMethodDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract static interface")]
	public partial interface Composable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Composable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/Implementation$Composable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}
	}
}
