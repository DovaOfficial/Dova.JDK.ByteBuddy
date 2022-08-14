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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor;", "public abstract")]
public partial class FieldAccessor
	: Dova.JDK.java.lang.Object
	, Dova.JDK.net.bytebuddy.implementation.Implementation
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldAccessor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocation", "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assigner", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typing", "Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofField", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofBeanProperty", "()Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation fieldLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner assigner_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;", "protected final")]
	public Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing typing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FieldAccessor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "protected")]
	public FieldAccessor(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor;";
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

	[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable of(Dova.JDK.java.lang.reflect.Field arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable of(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable of(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable ofField(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;", "public static")]
	public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable ofBeanProperty()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;", "protected abstract static")]
	public partial class ForSetter
		: Dova.JDK.net.bytebuddy.implementation.FieldAccessor
		, Dova.JDK.net.bytebuddy.implementation.Implementation.Composable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForSetter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "terminationHandler", "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;)Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler terminationHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForSetter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;)V", "protected")]
		public ForSetter(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "protected abstract")]
		public Dova.JDK.java.lang.Object initialize(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected abstract")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;)Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "static")]
		public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler access_100(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$Appender;", "protected")]
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
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$Appender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialized", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocation", "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;)V"));
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

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object initialized_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared fieldLocation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Appender(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$ForSetter;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;)V", "protected")]
			public Appender(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$Appender;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfFieldValue;", "protected static")]
		public partial class OfFieldValue
			: Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfFieldValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfFieldValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation target_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfFieldValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;)V", "protected")]
			public OfFieldValue(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler arg3, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfFieldValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object initialize_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared initialize_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected volatile")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfReferenceValue;", "protected static")]
		public partial class OfReferenceValue
			: Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfReferenceValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfReferenceValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREFIX", "Ljava/lang/String;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;Ljava/lang/Object;Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			}

			[JniSignatureAttribute("Ljava/lang/String;", "protected static final")]
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

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object value_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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
			public OfReferenceValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;Ljava/lang/Object;Ljava/lang/String;)V", "protected")]
			public OfReferenceValue(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler arg3, Dova.JDK.java.lang.Object arg4, Dova.JDK.java.lang.String arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfReferenceValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object initialize_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "protected")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape initialize_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected volatile")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfConstantValue;", "protected static")]
		public partial class OfConstantValue
			: Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfConstantValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfConstantValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stackManipulation", "Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Void;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic typeDescription_Property
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

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation stackManipulation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfConstantValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;Lnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/implementation/bytecode/StackManipulation;)V", "protected")]
			public OfConstantValue(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler arg3, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg4, Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfConstantValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object initialize_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Void;", "protected")]
			public Dova.JDK.java.lang.Void initialize_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected volatile")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Void;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Void arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfDefaultValue;", "protected static")]
		public partial class OfDefaultValue
			: Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfDefaultValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfDefaultValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Void;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfDefaultValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;)V", "protected")]
			public OfDefaultValue(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfDefaultValue;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object initialize_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Void;", "protected")]
			public Dova.JDK.java.lang.Void initialize_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected volatile")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Void;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Void arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfParameterValue;", "protected static")]
		public partial class OfParameterValue
			: Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfParameterValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfParameterValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialize_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/lang/Void;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "andThen", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;"));
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
			public OfParameterValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;I)V", "protected")]
			public OfParameterValue(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$OfParameterValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Object;", "protected volatile")]
			public Dova.JDK.java.lang.Object initialize_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Ljava/lang/Void;", "protected")]
			public Dova.JDK.java.lang.Void initialize_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected volatile")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Void;Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.java.lang.Void arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Composable;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable andThen(Dova.JDK.net.bytebuddy.implementation.Implementation.Composable arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/implementation/Implementation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.Implementation andThen(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "protected abstract static")]
		public partial class TerminationHandler
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TerminationHandler()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNING", "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NON_OPERATIONAL", "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/implementation/FieldAccessor$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler RETURNING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler NON_OPERATIONAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TerminationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public TerminationHandler(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/implementation/FieldAccessor$1;)V", "")]
			public TerminationHandler(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.implementation.FieldAccessor arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/FieldAccessor$ForSetter$TerminationHandler;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForSetter.TerminationHandler>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/StackManipulation;", "protected abstract")]
			public Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;", "protected static")]
	public partial class ForImplicitProperty
		: Dova.JDK.net.bytebuddy.implementation.FieldAccessor
		, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.OwnerTypeLocatable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForImplicitProperty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/FieldAccessor$PropertyConfigurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appender", "(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsDefaultValue", "()Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsArgumentAt", "(I)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsReference", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsReference", "(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForImplicitProperty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;)V", "protected")]
		public ForImplicitProperty(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)V", "private")]
		public ForImplicitProperty(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg1, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable @in(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable @in(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable @in(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/FieldAccessor$PropertyConfigurable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.PropertyConfigurable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.PropertyConfigurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$Target;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender appender(Dova.JDK.net.bytebuddy.implementation.Implementation.Target arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsDefaultValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsArgumentAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.reflect.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.utility.JavaConstant arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsReference(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsReference(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty$Appender;", "protected")]
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
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty$Appender;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocation", "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "apply", "(Lnet/bytebuddy/jar/asm/MethodVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender$Size;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared fieldLocation_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;", "final")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForImplicitProperty this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForImplicitProperty>(ret);
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

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty;Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;)V", "protected")]
			public Appender(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.ForImplicitProperty arg0, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$ForImplicitProperty$Appender;";
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

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;", "public abstract static interface")]
	public partial interface OwnerTypeLocatable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OwnerTypeLocatable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$OwnerTypeLocatable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Ljava/lang/Class;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "in", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;"));
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable @in(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable @in(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable @in(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.AssignerConfigurable>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;", "public abstract static interface")]
	public partial interface AssignerConfigurable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.PropertyConfigurable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AssignerConfigurable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$AssignerConfigurable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAssigner", "(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/FieldAccessor$PropertyConfigurable;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/assign/Assigner;Lnet/bytebuddy/implementation/bytecode/assign/Assigner$Typing;)Lnet/bytebuddy/implementation/FieldAccessor$PropertyConfigurable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.FieldAccessor.PropertyConfigurable withAssigner(Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner arg0, Dova.JDK.net.bytebuddy.implementation.bytecode.assign.Assigner.Typing arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.PropertyConfigurable>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$PropertyConfigurable;", "public abstract static interface")]
	public partial interface PropertyConfigurable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.implementation.Implementation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PropertyConfigurable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$PropertyConfigurable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsDefaultValue", "()Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsArgumentAt", "(I)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsValue", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsReference", "(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsReference", "(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setsFieldValueOf", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/Implementation$Composable;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsDefaultValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsArgumentAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Ljava/lang/reflect/Type;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.java.lang.reflect.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/StackManipulation;Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.implementation.bytecode.StackManipulation arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.utility.JavaConstant arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsValue(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsReference(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsReference(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/implementation/Implementation$Composable;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.Implementation.Composable setsFieldValueOf(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Composable>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;", "public abstract static interface")]
	public partial interface FieldNameExtractor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldNameExtractor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForFixedValue;", "public static")]
		public partial class ForFixedValue
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForFixedValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForFixedValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;"));
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
			public ForFixedValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "protected")]
			public ForFixedValue(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForFixedValue;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;", "public static final")]
		public partial class ForBeanProperty
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForBeanProperty()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;", "public static final")]
			public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForBeanProperty(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ForBeanProperty(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor$ForBeanProperty;", "public static")]
			public static Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor.ForBeanProperty>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;", "protected abstract static interface")]
	public partial interface FieldLocation
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FieldLocation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared prepare(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;", "public abstract")]
		Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation with(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Relative;", "public static")]
		public partial class Relative
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Relative()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Relative;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldNameExtractor", "Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocatorFactory", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor fieldNameExtractor_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory fieldLocatorFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Relative(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;)V", "protected")]
			public Relative(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)V", "private")]
			public Relative(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Relative;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared prepare(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation with(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Relative$Prepared;", "protected static")]
			public partial class Prepared
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Prepared()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Relative$Prepared;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldNameExtractor", "Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldLocator", "Lnet/bytebuddy/dynamic/scaffold/FieldLocator;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;Lnet/bytebuddy/dynamic/scaffold/FieldLocator;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor fieldNameExtractor_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldLocator;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator fieldLocator_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Prepared(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/FieldAccessor$FieldNameExtractor;Lnet/bytebuddy/dynamic/scaffold/FieldLocator;)V", "protected")]
				public Prepared(Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldNameExtractor arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Relative$Prepared;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Absolute;", "public static")]
		public partial class Absolute
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation
			, Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Absolute()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Absolute;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;"));
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
			public Absolute(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)V", "protected")]
			public Absolute(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Absolute;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared prepare(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation.Prepared>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/FieldLocator$Factory;)Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation;", "public")]
			public Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation with(Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldLocator.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.FieldAccessor.FieldLocation>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;", "public abstract static interface")]
		public partial interface Prepared
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Prepared()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/FieldAccessor$FieldLocation$Prepared;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public abstract")]
			Dova.JDK.net.bytebuddy.description.field.FieldDescription resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
			}
		}
	}
}
