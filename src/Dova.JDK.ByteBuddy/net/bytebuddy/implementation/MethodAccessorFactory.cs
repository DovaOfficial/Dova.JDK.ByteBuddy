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

[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory;", "public abstract interface")]
public partial interface MethodAccessorFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodAccessorFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodAccessorFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerGetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerAccessorFor", "(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerSetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerGetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerAccessorFor(Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerSetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;", "public static final")]
	public partial class Illegal
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Illegal()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerGetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerAccessorFor", "(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerSetterFor", "(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodAccessorFactory$Illegal;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.Illegal>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerGetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation$SpecialMethodInvocation;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerAccessorFor(Dova.JDK.net.bytebuddy.implementation.Implementation.SpecialMethodInvocation arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape registerSetterFor(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0, Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;", "public static final")]
	public partial class AccessType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC", "Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibility", "Lnet/bytebuddy/description/modifier/Visibility;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/modifier/Visibility;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibility", "()Lnet/bytebuddy/description/modifier/Visibility;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType PUBLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;", "public static final")]
		public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/Visibility;", "private final")]
		public Dova.JDK.net.bytebuddy.description.modifier.Visibility visibility_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/modifier/Visibility;)V", "private")]
		public AccessType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.modifier.Visibility arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/implementation/MethodAccessorFactory$AccessType;", "public static")]
		public static Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.MethodAccessorFactory.AccessType>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/modifier/Visibility;", "public")]
		public Dova.JDK.net.bytebuddy.description.modifier.Visibility getVisibility()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.Visibility>(ret);
		}
	}
}
