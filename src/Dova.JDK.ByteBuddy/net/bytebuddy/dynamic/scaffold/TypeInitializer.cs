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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public abstract interface")]
public partial interface TypeInitializer
	: IJavaObject
	, Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TypeInitializer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandWith", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record wrap(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isDefined()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer expandWith(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Simple;", "public static")]
	public partial class Simple
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Simple()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Simple;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "byteCodeAppender", "Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandWith", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender byteCodeAppender_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)V", "public")]
		public Simple(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Simple;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record wrap(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDefined()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer expandWith(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;", "public static final")]
	public partial class None
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static None()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefined", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandWith", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public None(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public None(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$None;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.None>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool$Record;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record wrap(Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool.Record>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDefined()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer expandWith(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;", "public abstract static interface")]
	public partial interface Drain
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Drain()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V", "public abstract")]
		void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain$Default;", "public static")]
		public partial class Default
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer.Drain
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodPool", "Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;", "protected final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool methodPool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "protected final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/dynamic/scaffold/TypeWriter$MethodPool;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;)V", "public")]
			public Default(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.MethodPool arg1, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer$Drain$Default;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/Implementation$Context;)V", "public")]
			public void apply(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			}
		}
	}
}
