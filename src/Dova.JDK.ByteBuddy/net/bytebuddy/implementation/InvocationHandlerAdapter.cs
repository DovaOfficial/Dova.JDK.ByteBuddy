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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter;", "public abstract")]
public partial class InvocationHandlerAdapter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InvocationHandlerAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOCATION_HANDLER_TYPE", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNCACHED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CACHED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNPRIVILEGED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVILEGED", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNING", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DROPPING", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldName", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cached", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "privileged", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returning", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ZZZLnet/bytebuddy/implementation/bytecode/assign/Assigner;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/InvocationHandler;Ljava/lang/String;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/InvocationHandler;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toField", "(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "argumentValuesOf", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutMethodCache", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPrivilegedLookup", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private static final")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic INVOCATION_HANDLER_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool UNCACHED_Property
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

	[JniSignatureAttribute("Z", "private static final")]
	public static bool CACHED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool UNPRIVILEGED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool PRIVILEGED_Property
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

	[JniSignatureAttribute("Z", "private static final")]
	public static bool RETURNING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DROPPING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected final")]
	public Dova.JDK.java.lang.String fieldName_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected final")]
	public bool cached_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Z", "protected final")]
	public bool privileged_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "protected final")]
	public bool returning_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InvocationHandlerAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZZZLnet/bytebuddy/implementation/bytecode/assign/Assigner;)V", "protected")]
	public InvocationHandlerAdapter(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvocationHandlerAdapter;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;", "protected")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size apply(Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor arg0, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg2, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg3, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender.Size>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/InvocationHandler;Ljava/lang/String;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter of(Dova.JDK.java.lang.reflect.InvocationHandler arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/InvocationHandler;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter of(Dova.JDK.java.lang.reflect.InvocationHandler arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "static")]
	public static Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic access_000()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation;", "public abstract")]
	public Dova.JDK.net.bytebuddy.implementation.Implementation withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter toField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/InvocationHandlerAdapter;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter toField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List argumentValuesOf(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;", "public abstract")]
	public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration withoutMethodCache()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;", "public abstract")]
	public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable withPrivilegedLookup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;", "protected static")]
	public partial class ForField
		: Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter
		, Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ZZZLnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner_0", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner_1", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutMethodCache", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPrivilegedLookup", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory fieldLocatorFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ZZZLnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "protected")]
		public ForField(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation withAssigner_0(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner_1(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration withoutMethodCache()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable withPrivilegedLookup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField$Appender;", "protected")]
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
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField$Appender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;Lnet/bytebuddy/description/field/FieldDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.ForField this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.ForField>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField;Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
			public Appender(Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.ForField arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForField$Appender;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;", "protected static")]
	public partial class ForInstance
		: Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter
		, Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForInstance()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREFIX", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invocationHandler", "Ljava/lang/reflect/InvocationHandler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ZZZLnet/bytebuddy/implementation/bytecode/assign/Assigner;Ljava/lang/reflect/InvocationHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner_0", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner_1", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutMethodCache", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPrivilegedLookup", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String PREFIX_Property
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

		[JniSignatureAttribute("Ljava/lang/reflect/InvocationHandler;", "protected final")]
		public Dova.JDK.java.lang.reflect.InvocationHandler invocationHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.InvocationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForInstance(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ZZZLnet/bytebuddy/implementation/bytecode/assign/Assigner;Ljava/lang/reflect/InvocationHandler;)V", "protected")]
		public ForInstance(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, bool arg3, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg4, Dova.JDK.java.lang.reflect.InvocationHandler arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation;", "public volatile")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation withAssigner_0(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner_1(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration withoutMethodCache()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.WithoutPrivilegeConfiguration>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable withPrivilegedLookup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance$Appender;", "protected")]
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
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance$Appender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.ForInstance this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.ForInstance>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public Appender(Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.ForInstance arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/InvocationHandlerAdapter$ForInstance$Appender;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;", "public abstract static interface")]
	public partial interface WithoutPrivilegeConfiguration
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithoutPrivilegeConfiguration()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$WithoutPrivilegeConfiguration;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPrivilegedLookup", "()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable withPrivilegedLookup()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.InvocationHandlerAdapter.AssignerConfigurable>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;", "public abstract static interface")]
	public partial interface AssignerConfigurable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AssignerConfigurable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/InvocationHandlerAdapter$AssignerConfigurable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}
	}
}
