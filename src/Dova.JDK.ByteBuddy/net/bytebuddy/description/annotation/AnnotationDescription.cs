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

namespace Dova.JDK.net.bytebuddy.description.annotation;

[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription;", "public abstract interface")]
public partial interface AnnotationDescription
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AnnotationDescription()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInherited", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRetention", "()Ljava/lang/annotation/RetentionPolicy;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementTypes", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOn", "(Ljava/lang/annotation/ElementType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOn", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocumented", "()Z"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public static final")]
	public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable UNDEFINED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isInherited()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getAnnotationType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable prepare(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/annotation/RetentionPolicy;", "public abstract")]
	Dova.JDK.java.lang.annotation.RetentionPolicy getRetention()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.RetentionPolicy>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public abstract")]
	Dova.JDK.java.util.Set getElementTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/annotation/ElementType;)Z", "public abstract")]
	bool isSupportedOn(Dova.JDK.java.lang.annotation.ElementType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public abstract")]
	bool isSupportedOn(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isDocumented()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public static")]
	public partial class Builder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValues", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Lnet/bytebuddy/description/annotation/AnnotationDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "(Z)Lnet/bytebuddy/description/annotation/AnnotationDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[S)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[Z)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[J)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[B)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[C)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[I)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[D)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineArray", "(Ljava/lang/String;[F)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineEnumerationArray", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineEnumerationArray", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;[Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineEnumerationArray", "(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/Enum;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineAnnotationArray", "(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineAnnotationArray", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineTypeArray", "(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineTypeArray", "(Ljava/lang/String;[Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;D)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;F)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;C)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Ljava/lang/Enum;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;J)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;I)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;S)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;B)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Z)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofType", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription annotationType_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map annotationValues_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Builder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V", "protected")]
		public Builder(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;";
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

		[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription>(ret);
		}

		[JniSignatureAttribute("(Z)Lnet/bytebuddy/description/annotation/AnnotationDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription build(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[S)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<short> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Z)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<bool> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[J)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<long> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[B)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[C)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<char> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[I)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<int> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[D)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<double> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[F)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineArray(Dova.JDK.java.lang.String arg0, JavaArray<float> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineEnumerationArray(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, JavaArray<Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;[Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineEnumerationArray(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, JavaArray<Dova.JDK.java.lang.String> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/Enum;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineEnumerationArray(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineAnnotationArray(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineAnnotationArray(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineTypeArray(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public transient")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder defineTypeArray(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;D)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, double arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;F)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, float arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;C)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, char arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.annotation.Annotation arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Enum;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Enum arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;J)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;S)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, short arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;B)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, byte arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder define(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder ofType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Builder;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder ofType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Builder>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;", "public static")]
	public partial class Latent
		: Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.AbstractBase
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Latent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValues", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare_0", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare_1", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent$Loadable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;)Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription annotationType_Property
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

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map annotationValues_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Latent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Map;)V", "protected")]
		public Latent(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getAnnotationType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public volatile")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable prepare_0(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent$Loadable;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Latent.Loadable prepare_1(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Latent.Loadable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;)Ljava/util/Map;", "static")]
		public static Dova.JDK.java.util.Map access_100(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Latent arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent$Loadable;", "protected")]
		public partial class Loadable
			: Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.AbstractBase
			, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Loadable()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent$Loadable;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljava/lang/Class;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;Ljava/lang/Class;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()Ljava/lang/annotation/Annotation;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
			}

			[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
			public Dova.JDK.java.lang.Class annotationType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;", "final")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Latent this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Latent>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Loadable(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent;Ljava/lang/Class;)V", "protected")]
			public Loadable(Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Latent arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$Latent$Loadable;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/annotation/Annotation;", "public")]
			public Dova.JDK.java.lang.Object load()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription getAnnotationType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable prepare(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$ForLoadedAnnotation;", "public static")]
	public partial class ForLoadedAnnotation
		: Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.AbstractBase
		, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForLoadedAnnotation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$ForLoadedAnnotation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARGUMENT", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotation", "Ljava/lang/annotation/Annotation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/annotation/Annotation;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/annotation/Annotation;Ljava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepare", "(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asValue", "(Ljava/lang/annotation/Annotation;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "asValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Object> NO_ARGUMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/annotation/Annotation;", "private final")]
		public Dova.JDK.java.lang.Object annotation_Property
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

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class annotationType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForLoadedAnnotation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;)V", "protected")]
		public ForLoadedAnnotation(Dova.JDK.java.lang.Object arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;Ljava/lang/Class;)V", "private")]
		public ForLoadedAnnotation(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$ForLoadedAnnotation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/annotation/Annotation;", "public")]
		public Dova.JDK.java.lang.Object load()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable of(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getAnnotationType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable prepare(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.Loadable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/annotation/Annotation;)Ljava/util/Map;", "private static")]
		public static Dova.JDK.java.util.Map asValue(Dova.JDK.java.lang.annotation.Annotation arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue asValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$AbstractBase;", "public abstract static")]
	public partial class AbstractBase
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractBase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$AbstractBase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_TARGET", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETENTION_VALUE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TARGET_VALUE", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationValue;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInherited", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRetention", "()Ljava/lang/annotation/RetentionPolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementTypes", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOn", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOn", "(Ljava/lang/annotation/ElementType;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDocumented", "()Z"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
		public static Dova.JDK.java.util.Set DEFAULT_TARGET_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape RETENTION_VALUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private static final")]
		public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape TARGET_VALUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$AbstractBase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
		public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getValue(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInherited()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/annotation/RetentionPolicy;", "public")]
		public Dova.JDK.java.lang.annotation.RetentionPolicy getRetention()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.annotation.RetentionPolicy>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set getElementTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
		public bool isSupportedOn(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/annotation/ElementType;)Z", "public")]
		public bool isSupportedOn(Dova.JDK.java.lang.annotation.ElementType arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDocumented()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$AnnotationInvocationHandler;", "public static")]
	public partial class AnnotationInvocationHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.reflect.InvocationHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotationInvocationHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$AnnotationInvocationHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HASH_CODE", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQUALS", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TO_STRING", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION_TYPE", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_ARGUMENT", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "values", "Ljava/util/LinkedHashMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hashCode", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/util/LinkedHashMap;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/ClassLoader;Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/annotation/Annotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toStringRepresentation", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCodeRepresentation", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equalsRepresentation", "(Ljava/lang/Object;Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String HASH_CODE_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String EQUALS_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String TO_STRING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String ANNOTATION_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private static final")]
		public static JavaArray<Dova.JDK.java.lang.Object> NO_ARGUMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class annotationType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/LinkedHashMap;", "private final")]
		public Dova.JDK.java.util.LinkedHashMap values_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.LinkedHashMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private transient")]
		public int hashCode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotationInvocationHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/LinkedHashMap;)V", "protected")]
		public AnnotationInvocationHandler(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.LinkedHashMap arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$AnnotationInvocationHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Ljava/lang/Class;Ljava/util/Map;)Ljava/lang/annotation/Annotation;", "public static")]
		public static Dova.JDK.java.lang.Object of(Dova.JDK.java.lang.ClassLoader arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.util.Map arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String toStringRepresentation()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "private")]
		public int hashCodeRepresentation()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Z", "private")]
		public bool equalsRepresentation(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static")]
	public partial class RenderingDispatcher
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RenderingDispatcher()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEGACY_VM", "Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_14_CAPABLE_VM", "Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_19_CAPABLE_VM", "Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CURRENT", "Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/annotation/AnnotationDescription$1;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendType", "(Ljava/lang/StringBuilder;Lnet/bytebuddy/description/type/TypeDescription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendPrefix", "(Ljava/lang/StringBuilder;Ljava/lang/String;I)V"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher LEGACY_VM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher JAVA_14_CAPABLE_VM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher JAVA_19_CAPABLE_VM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static final")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher CURRENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RenderingDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public RenderingDispatcher(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/annotation/AnnotationDescription$1;)V", "")]
		public RenderingDispatcher(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/description/annotation/AnnotationDescription$RenderingDispatcher;", "public static")]
		public static Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription.RenderingDispatcher>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Lnet/bytebuddy/description/type/TypeDescription;)V", "public")]
		public void appendType(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;Ljava/lang/String;I)V", "public")]
		public void appendPrefix(Dova.JDK.java.lang.StringBuilder arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;", "public abstract static interface")]
	public partial interface Loadable
		: IJavaObject
		, Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Loadable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/description/annotation/AnnotationDescription$Loadable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()Ljava/lang/annotation/Annotation;"));
		}

		[JniSignatureAttribute("()Ljava/lang/annotation/Annotation;", "public abstract")]
		Dova.JDK.java.lang.Object load()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
