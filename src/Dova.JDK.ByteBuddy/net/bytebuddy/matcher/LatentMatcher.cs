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

namespace Dova.JDK.net.bytebuddy.matcher;

[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "public abstract interface")]
public partial interface LatentMatcher
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LatentMatcher()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;", "public abstract")]
	Dova.JDK.net.bytebuddy.matcher.ElementMatcher resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$Disjunction;", "public static")]
	public partial class Disjunction
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Disjunction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$Disjunction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchers", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/matcher/LatentMatcher;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List matchers_Property
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
		public Disjunction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/matcher/LatentMatcher;)V", "public transient")]
		public Disjunction(JavaArray<Dova.JDK.net.bytebuddy.matcher.LatentMatcher> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Disjunction(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$Disjunction;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$Conjunction;", "public static")]
	public partial class Conjunction
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Conjunction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$Conjunction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchers", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Lnet/bytebuddy/matcher/LatentMatcher;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List matchers_Property
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
		public Conjunction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/matcher/LatentMatcher;)V", "public transient")]
		public Conjunction(JavaArray<Dova.JDK.net.bytebuddy.matcher.LatentMatcher> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
		public Conjunction(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$Conjunction;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForRecordComponentToken;", "public static")]
	public partial class ForRecordComponentToken
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForRecordComponentToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$ForRecordComponentToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/type/RecordComponentDescription$Token;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$Token;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token token_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForRecordComponentToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V", "public")]
		public ForRecordComponentToken(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$ForRecordComponentToken;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForMethodToken;", "public static")]
	public partial class ForMethodToken
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForMethodToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$ForMethodToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/method/MethodDescription$Token;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$Token;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$Token;", "private final")]
		public Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token token_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForMethodToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$Token;)V", "public")]
		public ForMethodToken(Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$ForMethodToken;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForMethodToken$ResolvedMatcher;", "protected static")]
		public partial class ResolvedMatcher
			: Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction.ForNonNullValues
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ResolvedMatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$ForMethodToken$ResolvedMatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureToken", "Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch", "(Lnet/bytebuddy/description/method/MethodDescription;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch", "(Ljava/lang/Object;)Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;", "private final")]
			public Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken signatureToken_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ResolvedMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$SignatureToken;)V", "protected")]
			public ResolvedMatcher(Dova.JDK.net.bytebuddy.description.method.MethodDescription.SignatureToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$ForMethodToken$ResolvedMatcher;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Z", "public")]
			public bool doMatch(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
			public bool doMatch(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForFieldToken;", "public static")]
	public partial class ForFieldToken
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForFieldToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$ForFieldToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/field/FieldDescription$Token;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription$Token;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$Token;", "private final")]
		public Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token token_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForFieldToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$Token;)V", "public")]
		public ForFieldToken(Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$ForFieldToken;";
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

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForFieldToken$ResolvedMatcher;", "protected static")]
		public partial class ResolvedMatcher
			: Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction.ForNonNullValues
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ResolvedMatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$ForFieldToken$ResolvedMatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signatureToken", "Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch", "(Lnet/bytebuddy/description/field/FieldDescription;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doMatch", "(Ljava/lang/Object;)Z"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;", "private final")]
			public Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken signatureToken_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ResolvedMatcher(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$SignatureToken;)V", "protected")]
			public ResolvedMatcher(Dova.JDK.net.bytebuddy.description.field.FieldDescription.SignatureToken arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$ForFieldToken$ResolvedMatcher;";
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

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Z", "protected")]
			public bool doMatch(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "protected volatile")]
			public bool doMatch(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$Resolved;", "public static")]
	public partial class Resolved
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resolved()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$Resolved;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/ElementMatcher;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Resolved(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)V", "public")]
		public Resolved(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$Resolved;";
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
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;", "public static final")]
	public partial class ForSelfDeclaredMethod
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.net.bytebuddy.matcher.LatentMatcher
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ForSelfDeclaredMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DECLARED", "Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT_DECLARED", "Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inverted", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod DECLARED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;", "public static final")]
		public static Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod NOT_DECLARED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool inverted_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("[Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;", "private static final")]
		public static JavaArray<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ForSelfDeclaredMethod(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;IZ)V", "private")]
		public ForSelfDeclaredMethod(Dova.JDK.java.lang.String arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;", "public static")]
		public static JavaArray<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/matcher/LatentMatcher$ForSelfDeclaredMethod;", "public static")]
		public static Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher.ForSelfDeclaredMethod>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/matcher/ElementMatcher;", "public")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher resolve(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher>(ret);
		}
	}
}
