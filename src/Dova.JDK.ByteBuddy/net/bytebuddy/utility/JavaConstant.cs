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

namespace Dova.JDK.net.bytebuddy.utility;

[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant;", "public abstract interface")]
public partial interface JavaConstant
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaConstant()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDescription", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
	}

	[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object toDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
	public partial class Dynamic
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.utility.JavaConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dynamic()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Dynamic;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT_NAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bootstrap", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arguments", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/utility/JavaConstant$MethodHandle;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofField", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofField", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/String;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/String;Ljava/lang/reflect/Constructor;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/String;Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootstrap", "(Ljava/lang/String;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBootstrap", "()Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofVarHandle", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofVarHandle", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofArrayVarHandle", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofArrayVarHandle", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofNullConstant", "()Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPrimitiveType", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPrimitiveType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofEnumeration", "(Ljava/lang/Enum;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofEnumeration", "(Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInvocation", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInvocation", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInvocation", "(Ljava/lang/reflect/Method;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInvocation", "(Ljava/lang/reflect/Constructor;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInvocation", "(Ljava/lang/reflect/Method;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInvocation", "(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withType", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withType", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDescription", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
		public static Dova.JDK.java.lang.String DEFAULT_NAME_Property
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

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "private final")]
		public Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle bootstrap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List arguments_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Dynamic(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Lnet/bytebuddy/utility/JavaConstant$MethodHandle;Ljava/util/List;)V", "protected")]
		public Dynamic(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$Dynamic;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofField(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofField(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic bootstrap(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Constructor;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic bootstrap(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Constructor arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic bootstrap(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Constructor arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic bootstrap(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic bootstrap(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic bootstrap(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getArguments()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public")]
		public Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle getBootstrap()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofVarHandle(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofVarHandle(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofArrayVarHandle(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofArrayVarHandle(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofNullConstant()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofPrimitiveType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofPrimitiveType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Enum;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofEnumeration(Dova.JDK.java.lang.Enum arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/enumeration/EnumerationDescription;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofEnumeration(Dova.JDK.net.bytebuddy.description.enumeration.EnumerationDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofInvocation(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofInvocation(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofInvocation(Dova.JDK.java.lang.reflect.Method arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofInvocation(Dova.JDK.java.lang.reflect.Constructor arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofInvocation(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;[Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$Dynamic;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic ofInvocation(Dova.JDK.java.lang.reflect.Constructor arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
		public Dova.JDK.net.bytebuddy.utility.JavaConstant withType(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
		public Dova.JDK.net.bytebuddy.utility.JavaConstant withType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object toDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
	public partial class MethodHandle
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.utility.JavaConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodHandle()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodHandle;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLE_INFO", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandleInfo;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles$Lookup;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handleType", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupType", "(Ljava/lang/Object;)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSpecial", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSpecial", "(Ljava/lang/reflect/Method;Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSetter", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSetter", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDescription", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandleType", "()Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofGetter", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofGetter", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLoaded", "(Ljava/lang/Object;Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLoaded", "(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwnerType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandleInfo;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodHandleInfo METHOD_HANDLE_INFO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodHandleInfo>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodType;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodType METHOD_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodHandles METHOD_HANDLES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodHandles>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles$Lookup;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodHandles.Lookup METHOD_HANDLES_LOOKUP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.MethodHandles.Lookup>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "private final")]
		public Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType handleType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription ownerType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription returnType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List parameterTypes_Property
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

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MethodHandle(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;Lnet/bytebuddy/description/type/TypeDescription;Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
		public MethodHandle(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$MethodHandle;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle of(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle of(Dova.JDK.java.lang.reflect.Constructor arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle of(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getReturnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getParameterTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public static")]
		public static Dova.JDK.java.lang.Class lookupType(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofSpecial(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofSpecial(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofSetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofSetter(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object toDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public")]
		public Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType getHandleType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofGetter(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofGetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofLoaded(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle ofLoaded(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getOwnerType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles;", "protected abstract static interface")]
		public partial interface MethodHandles
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodHandles()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "publicLookup", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object publicLookup()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles$Lookup;", "public abstract static interface")]
			public partial interface Lookup
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Lookup()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandles$Lookup;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revealDirect", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupClass", "(Ljava/lang/Object;)Ljava/lang/Class;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object revealDirect(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
				Dova.JDK.java.lang.Class lookupClass(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodType;", "protected abstract static interface")]
		public partial interface MethodType
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType", "(Ljava/lang/Object;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray", "(Ljava/lang/Object;)[Ljava/lang/Class;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class returnType(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/Class;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Class> parameterArray(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandleInfo;", "protected abstract static interface")]
		public partial interface MethodHandleInfo
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodHandleInfo()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$MethodHandleInfo;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/lang/Object;)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDeclaringClass", "(Ljava/lang/Object;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReferenceKind", "(Ljava/lang/Object;)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodType", "(Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revealDirect", "(Ljava/lang/Object;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
			Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class getDeclaringClass(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
			int getReferenceKind(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object getMethodType(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
			Dova.JDK.java.lang.Object revealDirect(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
		public partial class HandleType
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static HandleType()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_VIRTUAL", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_STATIC", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_SPECIAL", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_INTERFACE", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE_SPECIAL_CONSTRUCTOR", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_FIELD", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_FIELD", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUT_STATIC_FIELD", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_STATIC_FIELD", "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identifier", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;IIZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(I)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isField", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSpecial", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSetter", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofGetter", "(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier", "()I"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType INVOKE_VIRTUAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType INVOKE_STATIC_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType INVOKE_SPECIAL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType INVOKE_INTERFACE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType INVOKE_SPECIAL_CONSTRUCTOR_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType PUT_FIELD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType GET_FIELD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType PUT_STATIC_FIELD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType GET_STATIC_FIELD_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private final")]
			public int identifier_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
				}
			}

			[JniSignatureAttribute("Z", "private final")]
			public bool field_Property
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

			[JniSignatureAttribute("[Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public HandleType(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;IIZ)V", "private")]
			public HandleType(Dova.JDK.java.lang.String arg0, int arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "public static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "protected static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType of(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}

			[JniSignatureAttribute("(I)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "protected static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType of(int arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isField()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "protected static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType ofSpecial(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "protected static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType ofSetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription$InDefinedShape;)Lnet/bytebuddy/utility/JavaConstant$MethodHandle$HandleType;", "protected static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType ofGetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription.InDefinedShape arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle.HandleType>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getIdentifier()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
				return ret;
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
	public partial class MethodType
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.utility.JavaConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DISPATCHER", "Lnet/bytebuddy/utility/JavaConstant$MethodType$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnType", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parameterTypes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/Class;[Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameterTypes", "()Lnet/bytebuddy/description/type/TypeList;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSetter", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSetter", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofConstant", "(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofConstant", "(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofConstant", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDescription", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofGetter", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofGetter", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLoaded", "(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodType;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodType$Dispatcher;", "private static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType.Dispatcher DISPATCHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription returnType_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "private final")]
		public Dova.JDK.java.util.List parameterTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
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
		public MethodType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)V", "protected")]
		public MethodType(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$MethodType;";
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

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType of(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType of(Dova.JDK.java.lang.reflect.Constructor arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType of(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static transient")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType of(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;Ljava/util/List;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getReturnType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeList;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeList getParameterTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofSetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofSetter(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofConstant(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofConstant(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofConstant(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object toDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofGetter(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofGetter(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant$MethodType;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType ofLoaded(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$MethodType$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$MethodType$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType", "(Ljava/lang/Object;)Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray", "(Ljava/lang/Object;)[Ljava/lang/Class;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Class;", "public abstract")]
			Dova.JDK.java.lang.Class returnType(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/Class;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Class> parameterArray(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple;", "public abstract static")]
	public partial class Simple
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.utility.JavaConstant
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Simple()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_DESC", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_DESC", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfClassDesc;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE_DESC", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodTypeDesc;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLE_DESC", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodHandleDesc;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_METHOD_HANDLE_DESC", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_METHOD_HANDLE_DESC_KIND", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc$ForKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DYNAMIC_CONSTANT_DESC", "Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDynamicConstantDesc;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROLLER", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrap", "(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "wrap", "(Ljava/util/List;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/security/PrivilegedAction;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDescription", "(Ljava/lang/Object;Ljava/lang/ClassLoader;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDescription", "(Ljava/lang/Object;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDescription", "(Ljava/lang/Object;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/utility/JavaConstant;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLoaded", "(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant;"));
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher CONSTANT_DESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfClassDesc;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfClassDesc CLASS_DESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfClassDesc>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodTypeDesc;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfMethodTypeDesc METHOD_TYPE_DESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfMethodTypeDesc>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodHandleDesc;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfMethodHandleDesc METHOD_HANDLE_DESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfMethodHandleDesc>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfDirectMethodHandleDesc DIRECT_METHOD_HANDLE_DESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfDirectMethodHandleDesc>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc$ForKind;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfDirectMethodHandleDesc.ForKind DIRECT_METHOD_HANDLE_DESC_KIND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfDirectMethodHandleDesc.ForKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDynamicConstantDesc;", "protected static final")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfDynamicConstantDesc DYNAMIC_CONSTANT_DESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher.OfDynamicConstantDesc>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "protected final")]
		public Dova.JDK.java.lang.Object value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private static final")]
		public static bool ACCESS_CONTROLLER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Simple(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
		public Simple(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$Simple;";
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

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant wrap(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public static")]
		public static Dova.JDK.java.util.List wrap(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant of(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/security/PrivilegedAction;)Ljava/lang/Object;", "private static")]
		public static Dova.JDK.java.lang.Object doPrivileged(Dova.JDK.java.security.PrivilegedAction arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/ClassLoader;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofDescription(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.ClassLoader arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/dynamic/ClassFileLocator;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofDescription(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofDescription(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/utility/JavaConstant;", "public static")]
		public static Dova.JDK.net.bytebuddy.utility.JavaConstant ofLoaded(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher;", "protected abstract static interface")]
		public partial interface Dispatcher
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Dispatcher()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toArray", "(I)[Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public abstract")]
			bool isInstance(Dova.JDK.java.lang.Object arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(I)[Ljava/lang/Object;", "public abstract")]
			JavaArray<Dova.JDK.java.lang.Object> toArray(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDynamicConstantDesc;", "public abstract static interface")]
			public partial interface OfDynamicConstantDesc
				: IJavaObject
				, Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfDynamicConstantDesc()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDynamicConstantDesc;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bootstrapMethod", "(Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constantType", "(Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constantName", "(Ljava/lang/Object;)Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bootstrapArgs", "(Ljava/lang/Object;)[Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofCanonical", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object bootstrapMethod(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object constantType(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String constantName(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/Object;", "public abstract")]
				JavaArray<Dova.JDK.java.lang.Object> bootstrapArgs(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object ofCanonical(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2, JavaArray<Dova.JDK.java.lang.Object> arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc;", "public abstract static interface")]
			public partial interface OfDirectMethodHandleDesc
				: IJavaObject
				, Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfDirectMethodHandleDesc()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodName", "(Ljava/lang/Object;)Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refKind", "(Ljava/lang/Object;)I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "owner", "(Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupDescriptor", "(Ljava/lang/Object;)Ljava/lang/String;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String methodName(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)I", "public abstract")]
				int refKind(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object owner(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String lookupDescriptor(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc$ForKind;", "public abstract static interface")]
				public partial interface ForKind
					: IJavaObject
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static ForKind()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfDirectMethodHandleDesc$ForKind;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueOf", "(IZ)Ljava/lang/Object;"));
					}

					[JniSignatureAttribute("(IZ)Ljava/lang/Object;", "public abstract")]
					Dova.JDK.java.lang.Object valueOf(int arg0, bool arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodHandleDesc;", "public abstract static interface")]
			public partial interface OfMethodHandleDesc
				: IJavaObject
				, Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfMethodHandleDesc()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodHandleDesc;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "of", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invocationType", "(Ljava/lang/Object;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object of(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object invocationType(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodTypeDesc;", "public abstract static interface")]
			public partial interface OfMethodTypeDesc
				: IJavaObject
				, Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfMethodTypeDesc()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfMethodTypeDesc;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnType", "(Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "of", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofDescriptor", "(Ljava/lang/String;)Ljava/lang/Object;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parameterArray", "(Ljava/lang/Object;)[Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object returnType(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object of(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object ofDescriptor(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/Object;", "public abstract")]
				JavaArray<Dova.JDK.java.lang.Object> parameterArray(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfClassDesc;", "public abstract static interface")]
			public partial interface OfClassDesc
				: IJavaObject
				, Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple.Dispatcher
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static OfClassDesc()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$Dispatcher$OfClassDesc;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "descriptorString", "(Ljava/lang/Object;)Ljava/lang/String;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ofDescriptor", "(Ljava/lang/String;)Ljava/lang/Object;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
				Dova.JDK.java.lang.String descriptorString(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
				Dova.JDK.java.lang.Object ofDescriptor(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$OfTypeDescription;", "protected static")]
		public partial class OfTypeDescription
			: Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfTypeDescription()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$OfTypeDescription;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDescription", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfTypeDescription(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public OfTypeDescription(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$Simple$OfTypeDescription;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object toDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Simple$OfTrivialValue;", "protected static")]
		public partial class OfTrivialValue
			: Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OfTrivialValue()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Simple$OfTrivialValue;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDescription", "()Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OfTrivialValue(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/Object;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
			public OfTrivialValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$Simple$OfTrivialValue;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Visitor;)Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object accept(Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
			public Dova.JDK.java.lang.Object toDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Visitor;", "public abstract static interface")]
	public partial interface Visitor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Visitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Visitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onValue", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDynamic", "(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodHandle", "(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodType", "(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onValue(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onDynamic(Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onMethodHandle(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onMethodType(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object onType(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;", "public static final")]
		public partial class NoOp
			: Dova.JDK.java.lang.Enum
			, Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static NoOp()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onValue_0", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Lnet/bytebuddy/utility/JavaConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onValue_1", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDynamic_0", "(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onDynamic_1", "(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Lnet/bytebuddy/utility/JavaConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodHandle_0", "(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Lnet/bytebuddy/utility/JavaConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodHandle_1", "(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodType_0", "(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Lnet/bytebuddy/utility/JavaConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onMethodType_1", "(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType_0", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Lnet/bytebuddy/utility/JavaConstant;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "onType_1", "(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;", "public static final")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp INSTANCE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;", "private static final")]
			public static JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp>>(ret);
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

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;", "public static")]
			public static JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/JavaConstant$Visitor$NoOp;", "public static")]
			public static Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant.Visitor.NoOp>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
			public Dova.JDK.net.bytebuddy.utility.JavaConstant onValue_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onValue_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onDynamic_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Dynamic;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
			public Dova.JDK.net.bytebuddy.utility.JavaConstant onDynamic_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.Dynamic arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
			public Dova.JDK.net.bytebuddy.utility.JavaConstant onMethodHandle_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodHandle;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onMethodHandle_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodHandle arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
			public Dova.JDK.net.bytebuddy.utility.JavaConstant onMethodType_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$MethodType;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onMethodType_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.MethodType arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Lnet/bytebuddy/utility/JavaConstant;", "public")]
			public Dova.JDK.net.bytebuddy.utility.JavaConstant onType_0(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaConstant>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/utility/JavaConstant$Simple;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object onType_1(Dova.JDK.net.bytebuddy.utility.JavaConstant.Simple arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
		}
	}
}
