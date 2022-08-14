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

namespace Dova.JDK.net.bytebuddy.dynamic;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "public abstract interface")]
public partial interface Transformer
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Transformer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$Compound;", "public static")]
	public partial class Compound
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.Transformer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Compound()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$Compound;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformers", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/dynamic/Transformer;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List transformers_Property
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

		[JniSignatureAttribute("([Lnet/bytebuddy/dynamic/Transformer;)V", "public transient")]
		public Compound(JavaArray<Dova.JDK.net.bytebuddy.dynamic.Transformer> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Compound(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$Compound;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod;", "public static")]
	public partial class ForMethod
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.Transformer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/Transformer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withModifiers", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/Transformer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/Transformer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForMethod(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)V", "public")]
		public ForMethod(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForMethod;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/description/method/MethodDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/Transformer;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer withModifiers(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/Transformer;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer withModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;", "protected static")]
		public partial class TransformedMethod
			: Dova.JDK.net.bytebuddy.description.method.MethodDescription.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TransformedMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDefinition;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/method/MethodDescription$Token;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/method/MethodDescription$Token;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)Lnet/bytebuddy/description/method/MethodDescription$Token;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)Lnet/bytebuddy/description/type/TypeDescription;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition declaringType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$Token;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token token_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape methodDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TransformedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/method/MethodDescription$Token;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
			public TransformedMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg2, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int getModifiers()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReturnType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getExceptionTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationValue;", "public")]
			public Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue getDefaultValue()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterList;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.ParameterList getParameters()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterList>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getInternalName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)Lnet/bytebuddy/description/method/MethodDescription$Token;", "static")]
			public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token access_000(Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "static")]
			public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape access_100(Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)Lnet/bytebuddy/description/type/TypeDescription;", "static")]
			public static Dova.JDK.net.bytebuddy.description.type.TypeDescription access_200(Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getReceiverType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape asDefined_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList$Generic;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic getTypeVariables()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$AttachmentVisitor;", "protected")]
			public partial class AttachmentVisitor
				: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic.Visitor.Substitutor.WithoutTypeSubstitution
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AttachmentVisitor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$AttachmentVisitor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_0", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onTypeVariable_1", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;", "final")]
				public Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AttachmentVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)V", "protected")]
				public AttachmentVisitor(Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$AttachmentVisitor;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic onTypeVariable_0(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object onTypeVariable_1(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$TransformedParameter;", "protected")]
			public partial class TransformedParameter
				: Dova.JDK.net.bytebuddy.description.method.ParameterDescription.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TransformedParameter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$TransformedParameter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterToken", "Lnet/bytebuddy/description/method/ParameterDescription$Token;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;ILnet/bytebuddy/description/method/ParameterDescription$Token;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNamed", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasModifiers", "()Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringMethod", "()Lnet/bytebuddy/description/method/MethodDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$Token;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token parameterToken_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;", "final")]
				public Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public TransformedParameter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;ILnet/bytebuddy/description/method/ParameterDescription$Token;)V", "protected")]
				public TransformedParameter(Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod arg0, int arg1, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$TransformedParameter;";
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
				public bool isNamed()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/annotation/AnnotationList;", "public")]
				public Dova.JDK.net.bytebuddy.description.annotation.AnnotationList getDeclaredAnnotations()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.annotation.AnnotationList>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription$Generic;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic getType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int getIndex()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
					return ret;
				}

				[JniSignatureAttribute("()Z", "public")]
				public bool hasModifiers()
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
					return ret;
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription getDeclaringMethod()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
				public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_0()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/method/ParameterDescription$InDefinedShape;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape asDefined_1()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.InDefinedShape>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$TransformedParameterList;", "protected")]
			public partial class TransformedParameterList
				: Dova.JDK.net.bytebuddy.description.method.ParameterList.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TransformedParameterList()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$TransformedParameterList;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_0", "(I)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get_1", "(I)Lnet/bytebuddy/description/method/ParameterDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "size", "()I"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;", "final")]
				public Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod this0_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public TransformedParameterList(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod;)V", "protected")]
				public TransformedParameterList(Dova.JDK.net.bytebuddy.dynamic.Transformer.ForMethod.TransformedMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForMethod$TransformedMethod$TransformedParameterList;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Ljava/lang/Object;", "public volatile")]
				public Dova.JDK.java.lang.Object get_0(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/description/method/ParameterDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.method.ParameterDescription get_1(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription>(ret);
				}

				[JniSignatureAttribute("()I", "public")]
				public int size()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
					return ret;
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForMethod$MethodModifierTransformer;", "protected static")]
		public partial class MethodModifierTransformer
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.Transformer
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodModifierTransformer()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForMethod$MethodModifierTransformer;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolver", "Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/description/method/MethodDescription$Token;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "private final")]
			public Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver resolver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MethodModifierTransformer(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;)V", "protected")]
			public MethodModifierTransformer(Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForMethod$MethodModifierTransformer;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$Token;)Lnet/bytebuddy/description/method/MethodDescription$Token;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForField;", "public static")]
	public partial class ForField
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.Transformer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/Transformer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/description/field/FieldDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withModifiers", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/Transformer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "withModifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/Transformer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
		public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
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

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)V", "public")]
		public ForField(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForField;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/description/field/FieldDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/Transformer;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer withModifiers(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/Transformer;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer withModifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForField$TransformedField;", "protected static")]
		public partial class TransformedField
			: Dova.JDK.net.bytebuddy.description.field.FieldDescription.AbstractBase
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TransformedField()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForField$TransformedField;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaringType", "Lnet/bytebuddy/description/type/TypeDefinition;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/field/FieldDescription$Token;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldDescription", "Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/field/FieldDescription$Token;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_0", "()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asDefined_1", "()Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDefinition;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition declaringType_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$Token;", "private final")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token token_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "private final")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape fieldDescription_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TransformedField(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/type/TypeDefinition;Lnet/bytebuddy/description/field/FieldDescription$Token;Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)V", "protected")]
			public TransformedField(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg2, Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForField$TransformedField;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/description/ByteCodeElement$TypeDependant;", "public volatile")]
			public Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant asDefined_0()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.ByteCodeElement.TypeDependant>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape asDefined_1()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDefinition getDeclaringType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDefinition>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$ForField$FieldModifierTransformer;", "protected static")]
		public partial class FieldModifierTransformer
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.Transformer
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldModifierTransformer()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$ForField$FieldModifierTransformer;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolver", "Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/description/field/FieldDescription$Token;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;", "private final")]
			public Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver resolver_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FieldModifierTransformer(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/modifier/ModifierContributor$Resolver;)V", "protected")]
			public FieldModifierTransformer(Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.Resolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$ForField$FieldModifierTransformer;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription$Token;)Lnet/bytebuddy/description/field/FieldDescription$Token;", "public")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$NoOp;", "public static final")]
	public partial class NoOp
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.Transformer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NoOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/Transformer$NoOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/Transformer$NoOp;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/Transformer$NoOp;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/Transformer$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/Transformer$NoOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/Transformer;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer$NoOp;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/Transformer$NoOp;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp>>(ret);
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

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/Transformer$NoOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/Transformer$NoOp;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/Transformer$NoOp;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer.NoOp>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object transform(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/Transformer;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.Transformer make()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
		}
	}
}
