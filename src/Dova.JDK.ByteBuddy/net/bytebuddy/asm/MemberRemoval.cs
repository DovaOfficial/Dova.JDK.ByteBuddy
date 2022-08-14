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

namespace Dova.JDK.net.bytebuddy.asm;

[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberRemoval;", "public")]
public partial class MemberRemoval
	: Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper.AbstractBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemberRemoval()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberRemoval;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldMatcher", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodMatcher", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/matcher/ElementMatcher$Junction;Lnet/bytebuddy/matcher/ElementMatcher$Junction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripFields", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripMethods", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripInvokables", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stripConstructors", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction fieldMatcher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
	public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction methodMatcher_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MemberRemoval(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MemberRemoval() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher$Junction;Lnet/bytebuddy/matcher/ElementMatcher$Junction;)V", "protected")]
	public MemberRemoval(Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberRemoval;";
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

	[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/implementation/Implementation$Context;Lnet/bytebuddy/pool/TypePool;Lnet/bytebuddy/description/field/FieldList;Lnet/bytebuddy/description/method/MethodList;II)Lnet/bytebuddy/jar/asm/ClassVisitor;", "public")]
	public Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor wrap(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg1, Dova.JDK.net.bytebuddy.implementation.Implementation.Context arg2, Dova.JDK.net.bytebuddy.pool.TypePool arg3, Dova.JDK.net.bytebuddy.description.field.FieldList arg4, Dova.JDK.net.bytebuddy.description.method.MethodList arg5, int arg6, int arg7)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberRemoval stripFields(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberRemoval>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberRemoval stripMethods(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberRemoval>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberRemoval stripInvokables(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberRemoval>(ret);
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/asm/MemberRemoval;", "public")]
	public Dova.JDK.net.bytebuddy.asm.MemberRemoval stripConstructors(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.MemberRemoval>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/asm/MemberRemoval$MemberRemovingClassVisitor;", "protected static")]
	public partial class MemberRemovingClassVisitor
		: Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MemberRemovingClassVisitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/asm/MemberRemoval$MemberRemovingClassVisitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REMOVE_FIELD", "Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REMOVE_METHOD", "Lnet/bytebuddy/jar/asm/MethodVisitor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldMatcher", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodMatcher", "Lnet/bytebuddy/matcher/ElementMatcher$Junction;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fields", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/matcher/ElementMatcher$Junction;Lnet/bytebuddy/matcher/ElementMatcher$Junction;Ljava/util/Map;Ljava/util/Map;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitField", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethod", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/FieldVisitor;", "private static final")]
		public static Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor REMOVE_FIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/jar/asm/MethodVisitor;", "private static final")]
		public static Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor REMOVE_METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction fieldMatcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/matcher/ElementMatcher$Junction;", "private final")]
		public Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction methodMatcher_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map fields_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map methods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MemberRemovingClassVisitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/jar/asm/ClassVisitor;Lnet/bytebuddy/matcher/ElementMatcher$Junction;Lnet/bytebuddy/matcher/ElementMatcher$Junction;Ljava/util/Map;Ljava/util/Map;)V", "protected")]
		public MemberRemovingClassVisitor(Dova.JDK.net.bytebuddy.jar.asm.ClassVisitor arg0, Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg1, Dova.JDK.net.bytebuddy.matcher.ElementMatcher.Junction arg2, Dova.JDK.java.util.Map arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/asm/MemberRemoval$MemberRemovingClassVisitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)Lnet/bytebuddy/jar/asm/FieldVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor visitField(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.Object arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.FieldVisitor>(ret);
		}

		[JniSignatureAttribute("(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Lnet/bytebuddy/jar/asm/MethodVisitor;", "public")]
		public Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor visitMethod(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.String> arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.jar.asm.MethodVisitor>(ret);
		}
	}
}
