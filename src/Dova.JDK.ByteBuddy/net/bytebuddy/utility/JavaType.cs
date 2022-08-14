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

[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public final")]
public partial class JavaType
	: Dova.JDK.java.lang.Enum
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavaType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTABLE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_DESCRIPTOR", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_DESCRIPTOR_OF_FIELD", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_DESCRIPTOR_OF_METHOD", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_DESCRIPTION", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DYNAMIC_CONSTANT_DESCRIPTION", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_DESCRIPTION", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE_DESCRIPTION", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLE_DESCRIPTION", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIRECT_METHOD_HANDLE_DESCRIPTION", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_TYPE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_HANDLES_LOOKUP", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CALL_SITE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR_HANDLE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAMETER", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXECUTABLE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_BOOTSTRAPS", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_METHODS", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCESS_CONTROL_CONTEXT", "Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lnet/bytebuddy/utility/JavaType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loaded", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "available", "Ljava/lang/Boolean;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;ILnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/type/TypeDefinition;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeList$Generic;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;ILjava/lang/reflect/Type;[Ljava/lang/reflect/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lnet/bytebuddy/utility/JavaType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInstance", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "()Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lnet/bytebuddy/utility/JavaType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeStub", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadAsDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAvailable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doIsAvailable", "()Ljava/lang/Boolean;"));
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType CONSTABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType TYPE_DESCRIPTOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType TYPE_DESCRIPTOR_OF_FIELD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType TYPE_DESCRIPTOR_OF_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType CONSTANT_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType DYNAMIC_CONSTANT_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType CLASS_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType METHOD_TYPE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType METHOD_HANDLE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType DIRECT_METHOD_HANDLE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType METHOD_HANDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType METHOD_HANDLES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType METHOD_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType METHOD_HANDLES_LOOKUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType CALL_SITE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType VAR_HANDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType PARAMETER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType EXECUTABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType CONSTANT_BOOTSTRAPS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType RECORD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType OBJECT_METHODS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType;", "public static final")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType ACCESS_CONTROL_CONTEXT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "private final")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lnet/bytebuddy/utility/JavaType;", "private static final")]
	public static JavaArray<Dova.JDK.net.bytebuddy.utility.JavaType> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.JavaType>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "private transient")]
	public Dova.JDK.java.lang.Class loaded_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Boolean;", "private transient")]
	public Dova.JDK.java.lang.Boolean available_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavaType(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;ILnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/type/TypeDefinition;)V", "private transient")]
	public JavaType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg4, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Lnet/bytebuddy/description/type/TypeList$Generic;)V", "private")]
	public JavaType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg4, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;ILjava/lang/reflect/Type;[Ljava/lang/reflect/Type;)V", "private transient")]
	public JavaType(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, Dova.JDK.java.lang.reflect.Type arg4, JavaArray<Dova.JDK.java.lang.reflect.Type> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaType;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Lnet/bytebuddy/utility/JavaType;", "public static")]
	public static JavaArray<Dova.JDK.net.bytebuddy.utility.JavaType> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.net.bytebuddy.utility.JavaType>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool isInstance(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class load()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/utility/JavaType;", "public static")]
	public static Dova.JDK.net.bytebuddy.utility.JavaType valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.utility.JavaType>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeStub()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
	public Dova.JDK.net.bytebuddy.description.type.TypeDescription loadAsDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAvailable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Boolean;", "private")]
	public Dova.JDK.java.lang.Boolean doIsAvailable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Boolean>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/utility/JavaType$LatentTypeWithSimpleName;", "protected static")]
	public partial class LatentTypeWithSimpleName
		: Dova.JDK.net.bytebuddy.description.type.TypeDescription.Latent
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LatentTypeWithSimpleName()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/utility/JavaType$LatentTypeWithSimpleName;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LatentTypeWithSimpleName(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILnet/bytebuddy/description/type/TypeDescription$Generic;Ljava/util/List;)V", "protected")]
		public LatentTypeWithSimpleName(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/utility/JavaType$LatentTypeWithSimpleName;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getSimpleName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
