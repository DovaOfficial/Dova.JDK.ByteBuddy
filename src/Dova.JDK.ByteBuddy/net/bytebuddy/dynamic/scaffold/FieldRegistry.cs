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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;", "public abstract interface")]
public partial interface FieldRegistry
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldRegistry()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;", "public abstract")]
	Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry prepend(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default;", "public static")]
	public partial class Default
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepend", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List entries_Property
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
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Default() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
		public Default(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled compile(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry prepend(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Compiled;", "protected static")]
		public partial class Compiled
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Compiled()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Compiled;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/description/type/TypeDescription;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "entries", "Ljava/util/List;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
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

			[JniSignatureAttribute("Ljava/util/List;", "private final")]
			public Dova.JDK.java.util.List entries_Property
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
			public Compiled(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
			public Compiled(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Compiled;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
			public bool equals(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record target(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int hashCode()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Compiled$Entry;", "protected static")]
			public partial class Entry
				: Dova.JDK.java.lang.Object
				, Dova.JDK.net.bytebuddy.matcher.ElementMatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Entry()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Compiled$Entry;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAttributeAppender", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Ljava/lang/Object;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lnet/bytebuddy/description/field/FieldDescription;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bind", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher;", "private final")]
				public Dova.JDK.net.bytebuddy.matcher.ElementMatcher matcher_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;", "private final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender fieldAttributeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
				public Dova.JDK.java.lang.Object defaultValue_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
				public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
				public Entry(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Compiled$Entry;";
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

				[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Z", "public")]
				public bool matches(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
				public bool matches(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "protected")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record bind(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Entry;", "protected static")]
		public partial class Entry
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Entry()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Entry;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/LatentMatcher;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue", "()Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransformer", "()Lnet/bytebuddy/dynamic/Transformer;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFieldAttributeAppenderFactory", "()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "private final")]
			public Dova.JDK.net.bytebuddy.matcher.LatentMatcher matcher_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;", "private final")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory fieldAttributeAppenderFactory_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
			public Dova.JDK.java.lang.Object defaultValue_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Entry(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Ljava/lang/Object;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
			public Entry(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Default$Entry;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;", "public")]
			public Dova.JDK.net.bytebuddy.matcher.ElementMatcher resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
			public Dova.JDK.java.lang.Object getDefaultValue()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/Transformer;", "protected")]
			public Dova.JDK.net.bytebuddy.dynamic.Transformer getTransformer()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;", "protected")]
			public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory getFieldAttributeAppenderFactory()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled;", "public abstract static interface")]
	public partial interface Compiled
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Compiled()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;", "public static final")]
		public partial class NoOp
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoOp()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "target", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;", "public static final")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/scaffold/TypeWriter$FieldPool$Record;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record target(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeWriter.FieldPool.Record>(ret);
			}

			[JniSignatureAttribute("()[Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/scaffold/FieldRegistry$Compiled$NoOp;", "public static")]
			public static Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry.Compiled.NoOp>(ret);
			}
		}
	}
}
