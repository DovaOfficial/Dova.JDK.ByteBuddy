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

namespace Dova.JDK.net.bytebuddy.dynamic.scaffold.inline;

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;", "public abstract interface")]
public partial interface MethodRebaseResolver
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodRebaseResolver()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenMap", "()Ljava/util/Map;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getAuxiliaryTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map asTokenMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Default;", "public static")]
	public partial class Default
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolutions", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dynamicTypes", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Map;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "make", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Set;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenMap", "()Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map resolutions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List dynamicTypes_Property
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
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Map;Ljava/util/List;)V", "protected")]
		public Default(Dova.JDK.java.util.Map arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Default;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/Set;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver make(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.net.bytebuddy.ClassFileVersion arg2, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg3, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg4)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getAuxiliaryTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map asTokenMap()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "public abstract static interface")]
	public partial interface Resolution
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolution()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppendedParameters", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRebased", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResolvedMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeList getAppendedParameters()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isRebased()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getResolvedMethod()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedConstructor;", "public static")]
		public partial class ForRebasedConstructor
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForRebasedConstructor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedConstructor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "placeholderType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppendedParameters", "()Lnet/bytebuddy/description/type/TypeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRebased", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResolvedMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
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

			[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
			public Dova.JDK.net.bytebuddy.description.type.TypeDescription placeholderType_Property
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
			public ForRebasedConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public ForRebasedConstructor(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedConstructor;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution of(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList getAppendedParameters()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRebased()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getResolvedMethod()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedConstructor$RebasedConstructor;", "protected static")]
			public partial class RebasedConstructor
				: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RebasedConstructor()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedConstructor$RebasedConstructor;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "placeholderType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_0", "()Lnet/bytebuddy/description/type/TypeDescription;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringType_1", "()Lnet/bytebuddy/description/type/TypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeVariables", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription placeholderType_Property
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
				public RebasedConstructor(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
				public RebasedConstructor(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedConstructor$RebasedConstructor;";
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
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedMethod;", "public static")]
		public partial class ForRebasedMethod
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ForRebasedMethod()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedMethod;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppendedParameters", "()Lnet/bytebuddy/description/type/TypeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRebased", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResolvedMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ForRebasedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
			public ForRebasedMethod(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedMethod;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg2)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList getAppendedParameters()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRebased()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getResolvedMethod()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedMethod$RebasedMethod;", "protected static")]
			public partial class RebasedMethod
				: Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static RebasedMethod()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedMethod$RebasedMethod;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodNameTransformer", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaredAnnotations", "()Lnet/bytebuddy/description/annotation/AnnotationList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionTypes", "()Lnet/bytebuddy/description/type/TypeList$Generic;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Lnet/bytebuddy/description/annotation/AnnotationValue;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Lnet/bytebuddy/description/method/ParameterList;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalName", "()Ljava/lang/String;"));
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

				[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
				public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape methodDescription_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer methodNameTransformer_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public RebasedMethod(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/dynamic/scaffold/inline/MethodNameTransformer;)V", "protected")]
				public RebasedMethod(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodNameTransformer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$ForRebasedMethod$RebasedMethod;";
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
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$Preserved;", "public static")]
		public partial class Preserved
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Preserved()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$Preserved;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAppendedParameters", "()Lnet/bytebuddy/description/type/TypeList;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRebased", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResolvedMethod", "()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "private final")]
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Preserved(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "public")]
			public Preserved(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution$Preserved;";
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

			[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
			public Dova.JDK.net.bytebuddy.description.type.TypeList getAppendedParameters()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isRebased()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;", "public")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape getResolvedMethod()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;", "public static final")]
	public partial class Disabled
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Disabled()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asTokenMap", "()Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;", "public static final")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled INSTANCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Disabled(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Disabled(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Disabled;", "public static")]
		public static Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Disabled>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/scaffold/inline/MethodRebaseResolver$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution resolve(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.inline.MethodRebaseResolver.Resolution>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getAuxiliaryTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map asTokenMap()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}
}
