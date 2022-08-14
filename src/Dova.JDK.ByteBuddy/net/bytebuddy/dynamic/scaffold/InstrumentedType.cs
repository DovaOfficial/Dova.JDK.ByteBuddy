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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract interface")]
public partial interface InstrumentedType
	: IJavaObject
	, Dova.JDK.net.bytebuddy.description.type.TypeDescription
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InstrumentedType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validated", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAuxiliaryField", "(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaringType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnonymousClass", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPermittedSubclasses", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalClass", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingMethod", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecordComponent", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaredTypes", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withModifiers", "(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariable", "(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnnotations", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestHost", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestMembers", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInterfaces", "(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethod", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecord", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription validated()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAuxiliaryField(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInitializer(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInitializer(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withDeclaringType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withField(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAnonymousClass(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public abstract")]
	Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withPermittedSubclasses(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withLocalClass(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withEnclosingMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withRecordComponent(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withDeclaredTypes(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withModifiers(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAnnotations(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withNestHost(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withNestMembers(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withEnclosingType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInterfaces(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withRecord(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Frozen;", "public static")]
	public partial class Frozen
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Frozen()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Frozen;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypeInitializer", "Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/LoadedTypeInitializer;)V"));
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
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validated", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withName", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAuxiliaryField_0", "(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAuxiliaryField_1", "(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_0", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_1", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_0", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_1", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaringType_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaringType_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField_0", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField_1", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnonymousClass_0", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnonymousClass_1", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPermittedSubclasses_0", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPermittedSubclasses_1", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalClass_0", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalClass_1", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingMethod_0", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingMethod_1", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecordComponent_0", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecordComponent_1", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaredTypes_0", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaredTypes_1", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withModifiers_0", "(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withModifiers_1", "(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnnotations_0", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnnotations_1", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestHost_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestHost_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestMembers_0", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestMembers_1", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingType_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingType_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInterfaces_0", "(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInterfaces_1", "(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethod_0", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethod_1", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecord_0", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecord_1", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualModifiers", "(Z)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFileVersion", "()Lnet/bytebuddy/ClassFileVersion;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariables", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
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

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer loadedTypeInitializer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Frozen(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/implementation/LoadedTypeInitializer;)V", "protected")]
		public Frozen(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Frozen;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription validated()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAuxiliaryField_0(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAuxiliaryField_1(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInitializer_0(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInitializer_1(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInitializer_0(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInitializer_1(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withDeclaringType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withDeclaringType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withField_0(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withField_1(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAnonymousClass_0(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAnonymousClass_1(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withPermittedSubclasses_0(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withPermittedSubclasses_1(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withLocalClass_0(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withLocalClass_1(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withEnclosingMethod_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withEnclosingMethod_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withRecordComponent_0(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withRecordComponent_1(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withDeclaredTypes_0(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withDeclaredTypes_1(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withModifiers_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withModifiers_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAnnotations_0(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAnnotations_1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withNestHost_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withNestHost_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withNestMembers_0(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withNestMembers_1(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withEnclosingType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withEnclosingType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInterfaces_0(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInterfaces_1(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withMethod_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withMethod_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withRecord_0(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withRecord_1(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Z)I", "public")]
		public int getActualModifiers(bool arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[63]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[64]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/ClassFileVersion;", "public")]
		public Dova.JDK.net.bytebuddy.ClassFileVersion getClassFileVersion()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withTypeVariables(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Default;", "public static")]
	public partial class Default
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.AbstractBase.OfSimpleType
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KEYWORDS", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modifiers", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superClass", "Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeVariables", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaceTypes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldTokens", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryFields", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodTokens", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentTokens", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationDescriptions", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeInitializer", "Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypeInitializer", "Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingMethod", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enclosingType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredTypes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "permittedSubclasses", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anonymousClass", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localClass", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "record", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestHost", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nestMembers", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;Ljava/util/List;ZZZLnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
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
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validated", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withName", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAuxiliaryField_0", "(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAuxiliaryField_1", "(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_0", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_1", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_0", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer_1", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaringType_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaringType_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField_0", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField_1", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnonymousClass_0", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnonymousClass_1", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializer", "()Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPermittedSubclasses_0", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPermittedSubclasses_1", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalClass_0", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalClass_1", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeInitializer", "()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingMethod_0", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingMethod_1", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecordComponent_0", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecordComponent_1", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaredTypes_0", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaredTypes_1", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withModifiers_0", "(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withModifiers_1", "(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnnotations_0", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnnotations_1", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestHost_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestHost_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestMembers_0", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestMembers_1", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingType_0", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingType_1", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidIdentifier", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidIdentifier", "([Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInterfaces_0", "(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInterfaces_1", "(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethod_0", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethod_1", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecord_0", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecord_1", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymousType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLocalType", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermittedSubtypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSuperClass", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariables", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
		public static Dova.JDK.java.util.Set KEYWORDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
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

		[JniSignatureAttribute("I", "private final")]
		public int modifiers_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription$Generic;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic superClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List typeVariables_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List interfaceTypes_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map auxiliaryFields_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List methodTokens_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List recordComponentTokens_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List annotationDescriptions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer typeInitializer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "private final")]
		public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer loadedTypeInitializer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription declaringType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape enclosingMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription enclosingType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List declaredTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List permittedSubclasses_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool anonymousClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool localClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool record_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[20]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[20], value);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription nestHost_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List nestMembers_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/Map;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;Lnet/bytebuddy/implementation/LoadedTypeInitializer;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;Ljava/util/List;ZZZLnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
		public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.util.List arg5, Dova.JDK.java.util.Map arg6, Dova.JDK.java.util.List arg7, Dova.JDK.java.util.List arg8, Dova.JDK.java.util.List arg9, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer arg10, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg11, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg12, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg13, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg14, Dova.JDK.java.util.List arg15, Dova.JDK.java.util.List arg16, bool arg17, bool arg18, bool arg19, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg20, Dova.JDK.java.util.List arg21) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Default;";
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

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType of(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription$Generic;I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType of(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isRecord()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getInterfaces()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getNestHost()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/PackageDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.PackageDescription getPackage()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.PackageDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getEnclosingMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldList;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldList getDeclaredFields()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/RecordComponentList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentList getRecordComponents()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodList;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodList getDeclaredMethods()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getNestMembers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSealed()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription validated()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAuxiliaryField_0(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAuxiliaryField_1(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInitializer_0(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInitializer_1(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInitializer_0(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInitializer_1(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withDeclaringType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withDeclaringType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withField_0(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withField_1(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAnonymousClass_0(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAnonymousClass_1(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer getLoadedTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withPermittedSubclasses_0(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withPermittedSubclasses_1(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withLocalClass_0(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withLocalClass_1(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/scaffold/TypeInitializer;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer getTypeInitializer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeInitializer>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withEnclosingMethod_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withEnclosingMethod_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withRecordComponent_0(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withRecordComponent_1(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withDeclaredTypes_0(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withDeclaredTypes_1(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withModifiers_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withModifiers_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAnnotations_0(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withAnnotations_1(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withNestHost_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withNestHost_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withNestMembers_0(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withNestMembers_1(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withEnclosingType_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withEnclosingType_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "private static")]
		public static bool isValidIdentifier(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[53], arg0);
			return ret;
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Z", "private static")]
		public static bool isValidIdentifier(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[54], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInterfaces_0(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withInterfaces_1(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withMethod_0(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withMethod_1(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public volatile")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType withRecord_0(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withRecord_1(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getDeclaringType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getDeclaredTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getEnclosingType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAnonymousType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[65]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLocalType()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getPermittedSubtypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getSuperClass()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withTypeVariables(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;", "public abstract static interface")]
	public partial interface Factory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "represent", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName subclass(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName represent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;", "public abstract static")]
		public partial class Default
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Default()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIABLE", "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FROZEN", "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/InstrumentedType$1;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclass", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default MODIFIABLE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default FROZEN_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Default(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Default(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/dynamic/scaffold/InstrumentedType$1;)V", "")]
			public Default(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Factory$Default;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Factory.Default>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName subclass(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;", "public abstract static interface")]
	public partial interface Prepareable
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Prepareable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;", "public static final")]
		public partial class NoOp
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoOp()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$Prepareable$NoOp;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.Prepareable.NoOp>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType prepare(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract static interface")]
	public partial interface WithFlexibleName
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WithFlexibleName()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withName", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAuxiliaryField", "(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInitializer", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaringType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withField", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnonymousClass", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withPermittedSubclasses", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocalClass", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingMethod", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecordComponent", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDeclaredTypes", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withModifiers", "(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariable", "(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withAnnotations", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestHost", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNestMembers", "(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEnclosingType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withInterfaces", "(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMethod", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withRecord", "(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withTypeVariables", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAuxiliaryField(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInitializer(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInitializer(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withDeclaringType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withField(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAnonymousClass(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withPermittedSubclasses(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withLocalClass(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withEnclosingMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withRecordComponent(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withDeclaredTypes(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withModifiers(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeVariableToken;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withTypeVariable(Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withAnnotations(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withNestHost(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withNestMembers(Dova.JDK.net.bytebuddy.description.type.TypeList arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withEnclosingType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeList$Generic;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withInterfaces(Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withRecord(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName withTypeVariables(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
		}
	}
}
