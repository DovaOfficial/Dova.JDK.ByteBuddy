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

[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType;", "public abstract interface")]
public partial interface DynamicType
	: IJavaObject
	, Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DynamicType()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllTypes", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializers", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasAliveLoadedTypeInitializers", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveIn", "(Ljava/io/File;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toJar", "(Ljava/io/File;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toJar", "(Ljava/io/File;Ljava/util/jar/Manifest;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/io/File;)Ljava/io/File;"));
	}

	[JniSignatureAttribute("()[B", "public abstract")]
	JavaArray<byte> getBytes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
	Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getAuxiliaryTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getAllTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getLoadedTypeInitializers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool hasAliveLoadedTypeInitializers()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map saveIn(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/io/File;", "public abstract")]
	Dova.JDK.java.io.File toJar(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/util/jar/Manifest;)Ljava/io/File;", "public abstract")]
	Dova.JDK.java.io.File toJar(Dova.JDK.java.io.File arg0, Dova.JDK.java.util.jar.Manifest arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "public abstract")]
	Dova.JDK.java.io.File inject(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/io/File;", "public abstract")]
	Dova.JDK.java.io.File inject(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Default;", "public static")]
	public partial class Default
		: Dova.JDK.java.lang.Object
		, Dova.JDK.net.bytebuddy.dynamic.DynamicType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Default()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Default;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_FILE_EXTENSION", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MANIFEST_VERSION", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUFFER_SIZE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FROM_BEGINNING", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_OF_FILE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEMP_SUFFIX", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "binaryRepresentation", "[B"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypeInitializer", "Lnet/bytebuddy/implementation/LoadedTypeInitializer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypes", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBytes", "()[B"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doInject", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAuxiliaryTypes", "()Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllTypes", "()Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedTypeInitializers", "()Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasAliveLoadedTypeInitializers", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "saveIn", "(Ljava/io/File;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toJar", "(Ljava/io/File;)Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toJar", "(Ljava/io/File;Ljava/util/jar/Manifest;)Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locate", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/io/File;Ljava/io/File;)Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inject", "(Ljava/io/File;)Ljava/io/File;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String CLASS_FILE_EXTENSION_Property
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
		public static Dova.JDK.java.lang.String MANIFEST_VERSION_Property
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

		[JniSignatureAttribute("I", "private static final")]
		public static int BUFFER_SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int FROM_BEGINNING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int END_OF_FILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String TEMP_SUFFIX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeDescription;", "protected final")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription typeDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[B", "protected final")]
		public JavaArray<byte> binaryRepresentation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/implementation/LoadedTypeInitializer;", "protected final")]
		public Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer loadedTypeInitializer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "protected final")]
		public Dova.JDK.java.util.List auxiliaryTypes_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Default(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;Ljava/util/List;)V", "public")]
		public Default(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg2, Dova.JDK.java.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Default;";
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

		[JniSignatureAttribute("()[B", "public")]
		public JavaArray<byte> getBytes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "private")]
		public Dova.JDK.java.io.File doInject(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
		public Dova.JDK.net.bytebuddy.description.type.TypeDescription getTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map getAuxiliaryTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map getAllTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map getLoadedTypeInitializers()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasAliveLoadedTypeInitializers()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/util/Map;", "public")]
		public Dova.JDK.java.util.Map saveIn(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File toJar(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/util/jar/Manifest;)Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File toJar(Dova.JDK.java.io.File arg0, Dova.JDK.java.util.jar.Manifest arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/ClassFileLocator$Resolution;", "public")]
		public Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution locate(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.ClassFileLocator.Resolution>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/io/File;)Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File inject(Dova.JDK.java.io.File arg0, Dova.JDK.java.io.File arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File inject(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Default$Loaded;", "protected static")]
		public partial class Loaded
			: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Default
			, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Loaded()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Default$Loaded;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedTypes", "Ljava/util/Map;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;Ljava/util/List;Ljava/util/Map;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoaded", "()Ljava/lang/Class;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllLoaded", "()Ljava/util/Map;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedAuxiliaryTypes", "()Ljava/util/Map;"));
			}

			[JniSignatureAttribute("Ljava/util/Map;", "private final")]
			public Dova.JDK.java.util.Map loadedTypes_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Loaded(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;Ljava/util/List;Ljava/util/Map;)V", "protected")]
			public Loaded(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.Map arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Default$Loaded;";
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

			[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
			public Dova.JDK.java.lang.Class getLoaded()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Map;", "public")]
			public Dova.JDK.java.util.Map getAllLoaded()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Map;", "public")]
			public Dova.JDK.java.util.Map getLoadedAuxiliaryTypes()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Default$Unloaded;", "public static")]
		public partial class Unloaded
			: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Default
			, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Unloaded()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Default$Unloaded;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeResolutionStrategy", "Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;Ljava/util/List;Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "include", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "include", "([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;", "private final")]
			public Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved typeResolutionStrategy_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Unloaded(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;Ljava/util/List;Lnet/bytebuddy/dynamic/TypeResolutionStrategy$Resolved;)V", "public")]
			public Unloaded(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg2, Dova.JDK.java.util.List arg3, Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy.Resolved arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Default$Unloaded;";
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

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded load(Dova.JDK.java.lang.ClassLoader arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded load(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded include(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded include(JavaArray<Dova.JDK.net.bytebuddy.dynamic.DynamicType> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Loaded;", "public abstract static interface")]
	public partial interface Loaded
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.DynamicType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Loaded()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Loaded;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoaded", "()Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllLoaded", "()Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLoadedAuxiliaryTypes", "()Ljava/util/Map;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public abstract")]
		Dova.JDK.java.lang.Class getLoaded()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
		Dova.JDK.java.util.Map getAllLoaded()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Map;", "public abstract")]
		Dova.JDK.java.util.Map getLoadedAuxiliaryTypes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract static interface")]
	public partial interface Unloaded
		: IJavaObject
		, Dova.JDK.net.bytebuddy.dynamic.DynamicType
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Unloaded()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Unloaded;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "load", "(Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "include", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "include", "([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded load(Dova.JDK.java.lang.ClassLoader arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/ClassLoader;Lnet/bytebuddy/dynamic/loading/ClassLoadingStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Loaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded load(Dova.JDK.java.lang.Object arg0, Dova.JDK.net.bytebuddy.dynamic.loading.ClassLoadingStrategy arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Loaded>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded include(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded include(JavaArray<Dova.JDK.net.bytebuddy.dynamic.DynamicType> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}
	}

	[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract static interface")]
	public partial interface Builder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suffix", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constructor", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestHost", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestHost", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noNestMate", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsealed", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Lnet/bytebuddy/description/type/TypeDescription;[B)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serialVersionUid", "(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Ljava/lang/reflect/Type;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withHashCodeEquals", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withToString", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineRecordComponent", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineRecordComponent", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder name(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition method(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder suffix(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder transform(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder merge(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder merge(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable field(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable field(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition constructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder visit(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder attribute(Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestHost(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestHost(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder topLevelType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType innerTypeOf(Dova.JDK.java.lang.Class arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType innerTypeOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.java.lang.reflect.Constructor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder noNestMate()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(JavaArray<Dova.JDK.java.lang.Class> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder unsealed()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[B)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(JavaArray<Dova.JDK.net.bytebuddy.dynamic.DynamicType> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.reflect.Type> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.util.Collection arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.util.Collection arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.util.Collection arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.util.Collection arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract transient")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition define(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional define(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition define(Dova.JDK.java.lang.reflect.Method arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable define(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable define(Dova.JDK.java.lang.reflect.Field arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition define(Dova.JDK.java.lang.reflect.Constructor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional serialVersionUid(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition invokable(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition invokable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder withHashCodeEquals()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder withToString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional defineRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional defineRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
		}

		[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public abstract")]
		Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
		}

		[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public abstract")]
		Dova.JDK.net.bytebuddy.description.type.TypeDescription toTypeDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95]);
			return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase;", "public abstract static")]
		public partial class AbstractBase
			: Dova.JDK.java.lang.Object
			, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AbstractBase()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "constructor", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestHost", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noNestMate", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Lnet/bytebuddy/description/type/TypeDescription;[B)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/reflect/Field;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "serialVersionUid", "(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Ljava/lang/reflect/Type;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineProperty", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withHashCodeEquals", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withToString", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineRecordComponent", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "public")]
			public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition method(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder merge(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForType> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable field(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition constructor(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestHost(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(JavaArray<Dova.JDK.java.lang.Class> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.java.lang.reflect.Constructor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.java.lang.reflect.Method arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType innerTypeOf(Dova.JDK.java.lang.Class arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(JavaArray<Dova.JDK.java.lang.Class> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder noNestMate()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(JavaArray<Dova.JDK.java.lang.Class> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[B)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/dynamic/DynamicType;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(JavaArray<Dova.JDK.net.bytebuddy.dynamic.DynamicType> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;[BLnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0, JavaArray<byte> arg1, Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.reflect.Type> arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.util.Collection arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForMethod;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForMethod> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.util.Collection arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, Dova.JDK.java.util.Collection arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForField;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public transient")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForField> arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, Dova.JDK.java.util.Collection arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition define(Dova.JDK.net.bytebuddy.description.method.MethodDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional define(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/description/field/FieldDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable define(Dova.JDK.net.bytebuddy.description.field.FieldDescription arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Field;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable define(Dova.JDK.java.lang.reflect.Field arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition define(Dova.JDK.java.lang.reflect.Method arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition define(Dova.JDK.java.lang.reflect.Constructor arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
			}

			[JniSignatureAttribute("(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional serialVersionUid(long arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1, bool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defineProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, bool arg2)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition invokable(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder withHashCodeEquals()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder withToString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional defineRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Type arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public")]
			public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "public abstract static")]
			public partial class Adapter
				: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Adapter()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "instrumentedType", "Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldRegistry", "Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodRegistry", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentRegistry", "Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeAttributeAppender", "Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asmVisitorWrapper", "Lnet/bytebuddy/asm/AsmVisitorWrapper;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classFileVersion", "Lnet/bytebuddy/ClassFileVersion;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypeNamingStrategy", "Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationValueFilterFactory", "Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationRetention", "Lnet/bytebuddy/implementation/attribute/AnnotationRetention;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementationContextFactory", "Lnet/bytebuddy/implementation/Implementation$Context$Factory;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodGraphCompiler", "Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeValidation", "Lnet/bytebuddy/dynamic/scaffold/TypeValidation;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibilityBridgeStrategy", "Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classWriterStrategy", "Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoredMethods", "Lnet/bytebuddy/matcher/LatentMatcher;"));
					FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "auxiliaryTypes", "Ljava/util/List;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suffix", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestHost", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsealed", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineRecordComponent", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName instrumentedType_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry fieldRegistry_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry methodRegistry_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry recordComponentRegistry_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;", "protected final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender typeAttributeAppender_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/asm/AsmVisitorWrapper;", "protected final")]
				public Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper asmVisitorWrapper_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/ClassFileVersion;", "protected final")]
				public Dova.JDK.net.bytebuddy.ClassFileVersion classFileVersion_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.ClassFileVersion>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;", "protected final")]
				public Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy auxiliaryTypeNamingStrategy_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;", "protected final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory annotationValueFilterFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/AnnotationRetention;", "protected final")]
				public Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention annotationRetention_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/implementation/Implementation$Context$Factory;", "protected final")]
				public Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory implementationContextFactory_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler methodGraphCompiler_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/TypeValidation;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation typeValidation_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy visibilityBridgeStrategy_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;", "protected final")]
				public Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy classWriterStrategy_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/matcher/LatentMatcher;", "protected final")]
				public Dova.JDK.net.bytebuddy.matcher.LatentMatcher ignoredMethods_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
					}
					set
					{
						DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Ljava/util/List;", "protected final")]
				public Dova.JDK.java.util.List auxiliaryTypes_Property
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

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)V", "protected")]
				public Adapter(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg8, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg12, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg13, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg14, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg15, Dova.JDK.java.util.List arg16) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder name(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
				public bool equals(Dova.JDK.java.lang.Object arg0)
				{
					var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return ret;
				}

				[JniSignatureAttribute("()I", "public")]
				public int hashCode()
				{
					var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
					return ret;
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder suffix(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder transform(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder merge(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable field(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder visit(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder attribute(Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/InstrumentedType$WithFlexibleName;Lnet/bytebuddy/dynamic/scaffold/FieldRegistry;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry;Lnet/bytebuddy/dynamic/scaffold/RecordComponentRegistry;Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;Lnet/bytebuddy/asm/AsmVisitorWrapper;Lnet/bytebuddy/ClassFileVersion;Lnet/bytebuddy/implementation/auxiliary/AuxiliaryType$NamingStrategy;Lnet/bytebuddy/implementation/attribute/AnnotationValueFilter$Factory;Lnet/bytebuddy/implementation/attribute/AnnotationRetention;Lnet/bytebuddy/implementation/Implementation$Context$Factory;Lnet/bytebuddy/dynamic/scaffold/MethodGraph$Compiler;Lnet/bytebuddy/dynamic/scaffold/TypeValidation;Lnet/bytebuddy/dynamic/VisibilityBridgeStrategy;Lnet/bytebuddy/dynamic/scaffold/ClassWriterStrategy;Lnet/bytebuddy/matcher/LatentMatcher;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.InstrumentedType.WithFlexibleName arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.FieldRegistry arg1, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry arg2, Dova.JDK.net.bytebuddy.dynamic.scaffold.RecordComponentRegistry arg3, Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg4, Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg5, Dova.JDK.net.bytebuddy.ClassFileVersion arg6, Dova.JDK.net.bytebuddy.implementation.auxiliary.AuxiliaryType.NamingStrategy arg7, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationValueFilter.Factory arg8, Dova.JDK.net.bytebuddy.implementation.attribute.AnnotationRetention arg9, Dova.JDK.net.bytebuddy.implementation.Implementation.Context.Factory arg10, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodGraph.Compiler arg11, Dova.JDK.net.bytebuddy.dynamic.scaffold.TypeValidation arg12, Dova.JDK.net.bytebuddy.dynamic.VisibilityBridgeStrategy arg13, Dova.JDK.net.bytebuddy.dynamic.scaffold.ClassWriterStrategy arg14, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg15, Dova.JDK.java.util.List arg16)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestHost(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder topLevelType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType innerTypeOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder unsealed()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition invokable(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional defineRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription toTypeDescription()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$RecordComponentMatchAdapter;", "protected")]
				public partial class RecordComponentMatchAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static RecordComponentMatchAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$RecordComponentMatchAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/LatentMatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory recordComponentAttributeAppenderFactory_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
					public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public RecordComponentMatchAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;)V", "protected")]
					public RecordComponentMatchAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
					public RecordComponentMatchAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg1, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$RecordComponentMatchAdapter;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional attribute(Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$RecordComponentDefinitionAdapter;", "protected")]
				public partial class RecordComponentDefinitionAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static RecordComponentDefinitionAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$RecordComponentDefinitionAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recordComponentAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/type/RecordComponentDescription$Token;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;", "private final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory recordComponentAttributeAppenderFactory_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/RecordComponentDescription$Token;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token token_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "private final")]
					public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public RecordComponentDefinitionAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V", "protected")]
					public RecordComponentDefinitionAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Lnet/bytebuddy/description/type/RecordComponentDescription$Token;)V", "protected")]
					public RecordComponentDefinitionAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2, Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription.Token arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$RecordComponentDefinitionAdapter;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional attribute(Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$OptionalMethodMatchAdapter;", "protected")]
				public partial class OptionalMethodMatchAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static OptionalMethodMatchAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$OptionalMethodMatchAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "Lnet/bytebuddy/description/type/TypeList$Generic;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/TypeList$Generic;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaceType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeList$Generic;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeList.Generic interfaces_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeList.Generic>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public OptionalMethodMatchAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/TypeList$Generic;)V", "protected")]
					public OptionalMethodMatchAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.type.TypeList.Generic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$OptionalMethodMatchAdapter;";
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

					[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "private")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition interfaceType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;", "protected")]
				public partial class MethodMatchAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MethodMatchAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/LatentMatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;)Lnet/bytebuddy/matcher/LatentMatcher;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MethodMatchAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;)V", "protected")]
					public MethodMatchAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "private")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;)Lnet/bytebuddy/matcher/LatentMatcher;", "static")]
					public static Dova.JDK.net.bytebuddy.matcher.LatentMatcher access_100(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodMatchAdapter arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.matcher.LatentMatcher>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter$AnnotationAdapter;", "protected")]
					public partial class AnnotationAdapter
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.AbstractBase.Adapter
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AnnotationAdapter()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter$AnnotationAdapter;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)V"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiverType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodMatchAdapter this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodMatchAdapter>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AnnotationAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)V", "protected")]
						public AnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodMatchAdapter arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
						public AnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodMatchAdapter arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodMatchAdapter$AnnotationAdapter;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition receiverType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}

						[JniSignatureAttribute("(ILjava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, Dova.JDK.java.util.Collection arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;", "protected")]
				public partial class MethodDefinitionAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static MethodDefinitionAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/method/MethodDescription$Token;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/method/MethodDescription$Token;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;)Lnet/bytebuddy/description/method/MethodDescription$Token;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public MethodDefinitionAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/method/MethodDescription$Token;)V", "protected")]
					public MethodDefinitionAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "private")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;)Lnet/bytebuddy/description/method/MethodDescription$Token;", "static")]
					public static Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token access_000(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter arg0)
					{
						var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.MethodDescription.Token>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, int arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$AnnotationAdapter;", "protected")]
					public partial class AnnotationAdapter
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.AbstractBase.Adapter
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AnnotationAdapter()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$AnnotationAdapter;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)V"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiverType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AnnotationAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;)V", "protected")]
						public AnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
						public AnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter arg0, Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg1, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg2, Dova.JDK.net.bytebuddy.dynamic.Transformer arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$AnnotationAdapter;";
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

						[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition receiverType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}

						[JniSignatureAttribute("(ILjava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, Dova.JDK.java.util.Collection arg1)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$SimpleParameterAnnotationAdapter;", "protected")]
					public partial class SimpleParameterAnnotationAdapter
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable.AbstractBase.Adapter
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static SimpleParameterAnnotationAdapter()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$SimpleParameterAnnotationAdapter;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/method/ParameterDescription$Token;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/description/method/ParameterDescription$Token;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$Token;", "private final")]
						public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token token_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public SimpleParameterAnnotationAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/description/method/ParameterDescription$Token;)V", "protected")]
						public SimpleParameterAnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$SimpleParameterAnnotationAdapter;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple materialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$ParameterAnnotationAdapter;", "protected")]
					public partial class ParameterAnnotationAdapter
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable.AbstractBase.Adapter
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static ParameterAnnotationAdapter()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$ParameterAnnotationAdapter;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/method/ParameterDescription$Token;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/description/method/ParameterDescription$Token;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/method/ParameterDescription$Token;", "private final")]
						public Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token token_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public ParameterAnnotationAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/description/method/ParameterDescription$Token;)V", "protected")]
						public ParameterAnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter arg0, Dova.JDK.net.bytebuddy.description.method.ParameterDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$ParameterAnnotationAdapter;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition materialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$TypeVariableAnnotationAdapter;", "protected")]
					public partial class TypeVariableAnnotationAdapter
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable.AbstractBase.Adapter
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static TypeVariableAnnotationAdapter()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$TypeVariableAnnotationAdapter;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/type/TypeVariableToken;"));
							FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;"));
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/description/type/TypeVariableToken;)V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						}

						[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeVariableToken;", "private final")]
						public Dova.JDK.net.bytebuddy.description.type.TypeVariableToken token_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeVariableToken>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;", "final")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter this1_Property
						{
							get
							{
								var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter>(ret);
							}
							set
							{
								DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
							}
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public TypeVariableAnnotationAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter;Lnet/bytebuddy/description/type/TypeVariableToken;)V", "protected")]
						public TypeVariableAnnotationAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter.MethodDefinitionAdapter arg0, Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$MethodDefinitionAdapter$TypeVariableAnnotationAdapter;";
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

						[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;", "protected")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition materialize()
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$FieldMatchAdapter;", "protected")]
				public partial class FieldMatchAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable.AbstractBase.Adapter
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static FieldMatchAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$FieldMatchAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matcher", "Lnet/bytebuddy/matcher/LatentMatcher;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;Lnet/bytebuddy/matcher/LatentMatcher;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public FieldMatchAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/matcher/LatentMatcher;)V", "protected")]
					public FieldMatchAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;Lnet/bytebuddy/matcher/LatentMatcher;)V", "protected")]
					public FieldMatchAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$FieldMatchAdapter;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional materialize(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1, Dova.JDK.java.lang.Object arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$FieldDefinitionAdapter;", "protected")]
				public partial class FieldDefinitionAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable.AbstractBase.Adapter
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static FieldDefinitionAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$FieldDefinitionAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/field/FieldDescription$Token;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/field/FieldDescription$Token;)V"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription$Token;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public FieldDefinitionAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/field/FieldDescription$Token;)V", "protected")]
					public FieldDefinitionAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;Lnet/bytebuddy/description/field/FieldDescription$Token;)V", "protected")]
					public FieldDefinitionAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2, Dova.JDK.java.lang.Object arg3, Dova.JDK.net.bytebuddy.description.field.FieldDescription.Token arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$FieldDefinitionAdapter;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional materialize(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1, Dova.JDK.java.lang.Object arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$TypeVariableDefinitionAdapter;", "protected")]
				public partial class TypeVariableDefinitionAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static TypeVariableDefinitionAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$TypeVariableDefinitionAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "token", "Lnet/bytebuddy/description/type/TypeVariableToken;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/TypeVariableToken;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/description/type/TypeVariableToken;", "private final")]
					public Dova.JDK.net.bytebuddy.description.type.TypeVariableToken token_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeVariableToken>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public TypeVariableDefinitionAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/TypeVariableToken;)V", "protected")]
					public TypeVariableDefinitionAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.type.TypeVariableToken arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$TypeVariableDefinitionAdapter;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$InnerTypeDefinitionForMethodAdapter;", "protected")]
				public partial class InnerTypeDefinitionForMethodAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static InnerTypeDefinitionForMethodAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$InnerTypeDefinitionForMethodAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodDescription", "Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asAnonymousType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public InnerTypeDefinitionForMethodAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)V", "protected")]
					public InnerTypeDefinitionForMethodAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$InnerTypeDefinitionForMethodAdapter;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder asAnonymousType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$InnerTypeDefinitionForTypeAdapter;", "protected")]
				public partial class InnerTypeDefinitionForTypeAdapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static InnerTypeDefinitionForTypeAdapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$InnerTypeDefinitionForTypeAdapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeDescription", "Lnet/bytebuddy/description/type/TypeDescription;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/TypeDescription;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asAnonymousType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMemberType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
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

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;", "final")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter this0_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public InnerTypeDefinitionForTypeAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter;Lnet/bytebuddy/description/type/TypeDescription;)V", "protected")]
					public InnerTypeDefinitionForTypeAdapter(Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Adapter arg0, Dova.JDK.net.bytebuddy.description.type.TypeDescription arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Adapter$InnerTypeDefinitionForTypeAdapter;";
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

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder asAnonymousType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}

					[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder asMemberType()
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Delegator;", "public abstract static")]
			public partial class Delegator
				: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Delegator()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Delegator;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modifiers", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "suffix", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "()Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "make", "(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "field", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visit", "(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestHost", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "permittedSubclass", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "topLevelType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "innerTypeOf", "(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredTypes", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nestMembers", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unsealed", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateType", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializer", "(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "require", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implement", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineConstructor", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineMethod", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineField", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "define", "(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ignoreAlso", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokable", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineRecordComponent", "(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordComponent", "(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toTypeDescription", "()Lnet/bytebuddy/description/type/TypeDescription;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Delegator(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public Delegator() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$AbstractBase$Delegator;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder modifiers(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder name(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder suffix(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder transform(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0, Dova.JDK.net.bytebuddy.pool.TypePool arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/TypeResolutionStrategy;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.dynamic.TypeResolutionStrategy arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/pool/TypePool;)Lnet/bytebuddy/dynamic/DynamicType$Unloaded;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded make(Dova.JDK.net.bytebuddy.pool.TypePool arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Unloaded>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder merge(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable field(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/asm/AsmVisitorWrapper;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder visit(Dova.JDK.net.bytebuddy.asm.AsmVisitorWrapper arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/TypeAttributeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder attribute(Dova.JDK.net.bytebuddy.implementation.attribute.TypeAttributeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "protected abstract")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder materialize()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestHost(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder permittedSubclass(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder topLevelType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/method/MethodDescription$InDefinedShape;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition innerTypeOf(Dova.JDK.net.bytebuddy.description.method.MethodDescription.InDefinedShape arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType innerTypeOf(Dova.JDK.net.bytebuddy.description.type.TypeDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition.ForType>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder declaredTypes(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder nestMembers(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder unsealed()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder annotateType(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/LoadedTypeInitializer;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.LoadedTypeInitializer arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/bytecode/ByteCodeAppender;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder initializer(Dova.JDK.net.bytebuddy.implementation.bytecode.ByteCodeAppender arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder require(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional implement(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineConstructor(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial defineMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable defineField(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/RecordComponentDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional define(Dova.JDK.net.bytebuddy.description.type.RecordComponentDescription arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder ignoreAlso(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition invokable(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional defineRecordComponent(Dova.JDK.java.lang.String arg0, Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/ElementMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.ElementMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/matcher/LatentMatcher;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition recordComponent(Dova.JDK.net.bytebuddy.matcher.LatentMatcher arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/description/type/TypeDescription;", "public")]
				public Dova.JDK.net.bytebuddy.description.type.TypeDescription toTypeDescription()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.description.type.TypeDescription>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;", "public abstract static interface")]
		public partial interface RecordComponentDefinition
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static RecordComponentDefinition()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/RecordComponentAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional attribute(Dova.JDK.net.bytebuddy.implementation.attribute.RecordComponentAttributeAppender.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public abstract static interface")]
			public partial interface Optional
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }


				static Optional()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateRecordComponent", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(Dova.JDK.java.util.List arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$RecordComponentDefinition$Optional;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional annotateRecordComponent(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.RecordComponentDefinition.Optional>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract static interface")]
		public partial interface MethodDefinition
			: IJavaObject
			, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MethodDefinition()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(I[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(I[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition attribute(Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(ILjava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, Dova.JDK.java.util.Collection arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(ILjava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, Dova.JDK.java.util.List arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(I[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("(I[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$AbstractBase;", "public abstract static")]
			public partial class AbstractBase
				: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AbstractBase()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$AbstractBase;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateMethod", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(I[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(ILjava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(I[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$AbstractBase;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public transient")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public transient")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateMethod(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("(I[Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public transient")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("(ILjava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, Dova.JDK.java.util.List arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("(I[Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public transient")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition annotateParameter(int arg0, JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$AbstractBase$Adapter;", "protected abstract static")]
				public partial class Adapter
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition.AbstractBase
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Adapter()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$AbstractBase$Adapter;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methodAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;"));
						FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;", "protected final")]
					public Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler handler_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;", "protected final")]
					public Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory methodAttributeAppenderFactory_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "protected final")]
					public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
					{
						get
						{
							var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
						}
						set
						{
							DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
						}
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)V", "protected")]
					public Adapter(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$AbstractBase$Adapter;";
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

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition attribute(Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/scaffold/MethodRegistry$Handler;Lnet/bytebuddy/implementation/attribute/MethodAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "protected abstract")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition materialize(Dova.JDK.net.bytebuddy.dynamic.scaffold.MethodRegistry.Handler arg0, Dova.JDK.net.bytebuddy.implementation.attribute.MethodAttributeAppender.Factory arg1, Dova.JDK.net.bytebuddy.dynamic.Transformer arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;", "public abstract static interface")]
			public partial interface ParameterDefinition
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ParameterDefinition()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract transient")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForParameter> arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.java.lang.String arg1, int arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/Type;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract transient")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForParameter> arg2)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition.AbstractBase
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/reflect/Type;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.java.lang.String arg1, int arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForParameter> arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Type;Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Type;Ljava/lang/String;[Lnet/bytebuddy/description/modifier/ModifierContributor$ForParameter;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.net.bytebuddy.description.modifier.ModifierContributor.ForParameter> arg2)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;", "public abstract static interface")]
				public partial interface Initial
					: IJavaObject
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Initial()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract transient")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(Dova.JDK.java.util.List arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract transient")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial$AbstractBase;", "public abstract static")]
					public partial class AbstractBase
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.AbstractBase
						, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Initial
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AbstractBase()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial$AbstractBase;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameters", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("()V", "public")]
						public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Initial$AbstractBase;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}

						[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public transient")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(Dova.JDK.java.util.List arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
						}

						[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public transient")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition withParameters(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple;", "public abstract static interface")]
				public partial interface Simple
					: IJavaObject
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Simple()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
					}

					[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$AbstractBase;", "public abstract static")]
					public partial class AbstractBase
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition.AbstractBase
						, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AbstractBase()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$AbstractBase;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("()V", "public")]
						public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$AbstractBase;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable withParameter(Dova.JDK.java.lang.reflect.Type arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract static interface")]
					public partial interface Annotatable
						: IJavaObject
						, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static Annotatable()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
						}

						[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(Dova.JDK.java.util.Collection arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}

						[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract transient")]
						Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract")]
						Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(Dova.JDK.java.util.List arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}

						[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public abstract transient")]
						Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable$AbstractBase;", "public abstract static")]
						public partial class AbstractBase
							: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.AbstractBase
							, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static AbstractBase()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable$AbstractBase;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("()V", "public")]
							public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable$AbstractBase;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public transient")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
							}

							[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(Dova.JDK.java.util.List arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
							}

							[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public transient")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable annotateParameter(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable$AbstractBase$Adapter;", "protected abstract static")]
							public partial class Adapter
								: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable.AbstractBase
							{
								public new static CSharpSystem.IntPtr ClassPtr { get; }
								public new static CSharpSystem.IntPtr ClassRefPtr { get; }

								private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
								private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

								static Adapter()
								{
									ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable$AbstractBase$Adapter;");
									ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
									ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
									MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								}

								[JniSignatureAttribute("(System.IntPtr)V", "public")]
								public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
								{
								}

								[JniSignatureAttribute("()V", "protected")]
								public Adapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
								{
								}

								public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable$AbstractBase$Adapter;";
								public override IntPtr GetJavaClassRaw() => ClassPtr;
								public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

								[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
								}

								[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple;", "protected abstract")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple materialize()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple>(ret);
								}

								[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(Dova.JDK.java.util.Collection arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
								}

								[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Simple$Annotatable;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Simple.Annotatable>(ret);
								}

								[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
								}

								[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
								public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
								{
									var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
								}
							}
						}
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract static interface")]
				public partial interface Annotatable
					: IJavaObject
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Annotatable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract transient")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(Dova.JDK.java.util.List arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public abstract transient")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable$AbstractBase;", "public abstract static")]
					public partial class AbstractBase
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.AbstractBase
						, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AbstractBase()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable$AbstractBase;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateParameter", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("()V", "public")]
						public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable$AbstractBase;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public transient")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(Dova.JDK.java.util.List arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
						}

						[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public transient")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable annotateParameter(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable$AbstractBase$Adapter;", "protected abstract static")]
						public partial class Adapter
							: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable.AbstractBase
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Adapter()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable$AbstractBase$Adapter;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withParameter", "(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("()V", "protected")]
							public Adapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable$AbstractBase$Adapter;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;", "protected abstract")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition materialize()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition>(ret);
							}

							[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(Dova.JDK.java.util.Collection arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDefinition;Ljava/lang/String;I)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition$Annotatable;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable withParameter(Dova.JDK.net.bytebuddy.description.type.TypeDefinition arg0, Dova.JDK.java.lang.String arg1, int arg2)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition.Annotatable>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract static interface")]
			public partial interface ExceptionDefinition
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ExceptionDefinition()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
				}

				[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(Dova.JDK.java.util.Collection arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
				}

				[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract transient")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
				}

				[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public abstract transient")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.AbstractBase
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwing", "([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("([Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(Dova.JDK.java.util.List arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}

					[JniSignatureAttribute("([Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ExceptionDefinition;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition throwing(JavaArray<Dova.JDK.java.lang.reflect.Type> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ExceptionDefinition>(ret);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition;", "public abstract static interface")]
			public partial interface TypeVariableDefinition
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static TypeVariableDefinition()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract transient")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract transient")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.reflect.Type> arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition.AbstractBase
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/String;[Lnet/bytebuddy/description/type/TypeDefinition;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.net.bytebuddy.description.type.TypeDefinition> arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/reflect/Type;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.reflect.Type> arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract static interface")]
				public partial interface Annotatable
					: IJavaObject
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static Annotatable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
					}

					[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(Dova.JDK.java.util.Collection arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract transient")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(Dova.JDK.java.util.List arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public abstract transient")]
					Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable$AbstractBase;", "public abstract static")]
					public partial class AbstractBase
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.AbstractBase
						, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AbstractBase()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable$AbstractBase;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("()V", "public")]
						public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable$AbstractBase;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public transient")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
						}

						[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(Dova.JDK.java.util.List arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
						}

						[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public transient")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable annotateTypeVariable(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable$AbstractBase$Adapter;", "protected abstract static")]
						public partial class Adapter
							: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable.AbstractBase
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Adapter()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable$AbstractBase$Adapter;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeVariable", "(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
							}

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("()V", "protected")]
							public Adapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable$AbstractBase$Adapter;";
							public override IntPtr GetJavaClassRaw() => ClassPtr;
							public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

							[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ParameterDefinition;", "protected abstract")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition materialize()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ParameterDefinition>(ret);
							}

							[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$TypeVariableDefinition$Annotatable;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable typeVariable(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Collection arg1)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.TypeVariableDefinition.Annotatable>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
							}
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;", "public abstract static interface")]
			public partial interface ImplementationDefinition
				: IJavaObject
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ImplementationDefinition()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withoutCode", "()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intercept", "(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
				}

				[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/annotation/AnnotationValue;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.net.bytebuddy.description.annotation.AnnotationValue arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition withoutCode()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/implementation/Implementation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition intercept(Dova.JDK.net.bytebuddy.implementation.Implementation arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.java.lang.Object
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition defaultValue(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;", "public abstract static interface")]
				public partial interface Optional
					: IJavaObject
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ImplementationDefinition
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }


					static Optional()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ImplementationDefinition$Optional;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;", "public abstract static interface")]
			public partial interface ReceiverTypeDefinition
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ReceiverTypeDefinition()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiverType", "(Ljava/lang/reflect/AnnotatedElement;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiverType", "(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
				}

				[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition receiverType(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("(Lnet/bytebuddy/description/type/TypeDescription$Generic;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition receiverType(Dova.JDK.net.bytebuddy.description.type.TypeDescription.Generic arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.AbstractBase
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition.ReceiverTypeDefinition
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "receiverType", "(Ljava/lang/reflect/AnnotatedElement;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition$ReceiverTypeDefinition$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("(Ljava/lang/reflect/AnnotatedElement;)Lnet/bytebuddy/dynamic/DynamicType$Builder$MethodDefinition;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition receiverType(Dova.JDK.java.lang.reflect.AnnotatedElement arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.MethodDefinition>(ret);
					}
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition;", "public abstract static interface")]
		public partial interface FieldDefinition
			: IJavaObject
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FieldDefinition()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional attribute(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract static interface")]
			public partial interface Optional
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }


				static Optional()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$AbstractBase;", "public abstract static")]
				public partial class AbstractBase
					: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }

					private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
					private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

					static AbstractBase()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$AbstractBase;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
						ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
						MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateField", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
					}

					[JniSignatureAttribute("(System.IntPtr)V", "public")]
					public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
					{
					}

					[JniSignatureAttribute("()V", "public")]
					public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
					{
					}

					public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$AbstractBase;";
					public override IntPtr GetJavaClassRaw() => ClassPtr;
					public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

					[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(Dova.JDK.java.util.List arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}

					[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public transient")]
					public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional annotateField(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
					{
						var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
						return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
					}
				}

				[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;", "public abstract static interface")]
				public partial interface Valuable
					: IJavaObject
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Valuable
					, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional
				{
					public new static CSharpSystem.IntPtr ClassPtr { get; }
					public new static CSharpSystem.IntPtr ClassRefPtr { get; }


					static Valuable()
					{
						ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable;");
						ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					}

					[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable$AbstractBase;", "public abstract static")]
					public partial class AbstractBase
						: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.AbstractBase
						, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable
					{
						public new static CSharpSystem.IntPtr ClassPtr { get; }
						public new static CSharpSystem.IntPtr ClassRefPtr { get; }

						private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
						private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

						static AbstractBase()
						{
							ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable$AbstractBase;");
							ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
							ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(F)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(D)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
						}

						[JniSignatureAttribute("(System.IntPtr)V", "public")]
						public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
						{
						}

						[JniSignatureAttribute("()V", "public")]
						public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
						{
						}

						public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable$AbstractBase;";
						public override IntPtr GetJavaClassRaw() => ClassPtr;
						public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

						[JniSignatureAttribute("(F)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(float arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("(D)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(double arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(Dova.JDK.java.lang.String arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(bool arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(int arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(long arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "protected abstract")]
						public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defaultValue(Dova.JDK.java.lang.Object arg0)
						{
							var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
							return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
						}

						[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable$AbstractBase$Adapter;", "private abstract static")]
						public partial class Adapter
							: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional.Valuable.AbstractBase
						{
							public new static CSharpSystem.IntPtr ClassPtr { get; }
							public new static CSharpSystem.IntPtr ClassRefPtr { get; }

							private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
							private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

							static Adapter()
							{
								ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable$AbstractBase$Adapter;");
								ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fieldAttributeAppenderFactory", "Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "transformer", "Lnet/bytebuddy/dynamic/Transformer;"));
								FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Ljava/lang/Object;"));
								ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)V"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "transform", "(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultValue", "(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "attribute", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
								MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "materialize", "(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
							}

							[JniSignatureAttribute("Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;", "protected final")]
							public Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory fieldAttributeAppenderFactory_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Lnet/bytebuddy/dynamic/Transformer;", "protected final")]
							public Dova.JDK.net.bytebuddy.dynamic.Transformer transformer_Property
							{
								get
								{
									var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
									return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.Transformer>(ret);
								}
								set
								{
									DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
								}
							}

							[JniSignatureAttribute("Ljava/lang/Object;", "protected final")]
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

							[JniSignatureAttribute("(System.IntPtr)V", "public")]
							public Adapter(IntPtr currentRefPtr) : base(currentRefPtr)
							{
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)V", "protected")]
							public Adapter(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1, Dova.JDK.java.lang.Object arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
							{
							}

							public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional$Valuable$AbstractBase$Adapter;";
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

							[JniSignatureAttribute("(Lnet/bytebuddy/dynamic/Transformer;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional transform(Dova.JDK.net.bytebuddy.dynamic.Transformer arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
							}

							[JniSignatureAttribute("(Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "protected")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional defaultValue(Dova.JDK.java.lang.Object arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional attribute(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
							}

							[JniSignatureAttribute("(Lnet/bytebuddy/implementation/attribute/FieldAttributeAppender$Factory;Lnet/bytebuddy/dynamic/Transformer;Ljava/lang/Object;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "protected abstract")]
							public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional materialize(Dova.JDK.net.bytebuddy.implementation.attribute.FieldAttributeAppender.Factory arg0, Dova.JDK.net.bytebuddy.dynamic.Transformer arg1, Dova.JDK.java.lang.Object arg2)
							{
								var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
								return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
							}
						}
					}
				}
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;", "public abstract static interface")]
			public partial interface Valuable
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Valuable()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Valuable;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(D)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(F)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "value", "(Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;"));
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(D)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(double arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(F)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(float arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(J)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(long arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(I)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(int arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
				}

				[JniSignatureAttribute("(Z)Lnet/bytebuddy/dynamic/DynamicType$Builder$FieldDefinition$Optional;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional value(bool arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.FieldDefinition.Optional>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract static interface")]
		public partial interface TypeVariableDefinition
			: IJavaObject
			, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TypeVariableDefinition()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
			}

			[JniSignatureAttribute("(Ljava/util/Collection;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(Dova.JDK.java.util.Collection arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(Dova.JDK.java.util.List arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public abstract transient")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition$AbstractBase;", "public abstract static")]
			public partial class AbstractBase
				: Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.AbstractBase.Delegator
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static AbstractBase()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition$AbstractBase;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "annotateTypeVariable", "([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;"));
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public AbstractBase(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("()V", "public")]
				public AbstractBase() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
				{
				}

				public override string GetJavaClassSignature() => "Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition$AbstractBase;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("([Lnet/bytebuddy/description/annotation/AnnotationDescription;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public transient")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(JavaArray<Dova.JDK.net.bytebuddy.description.annotation.AnnotationDescription> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
				}

				[JniSignatureAttribute("(Ljava/util/List;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(Dova.JDK.java.util.List arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
				}

				[JniSignatureAttribute("([Ljava/lang/annotation/Annotation;)Lnet/bytebuddy/dynamic/DynamicType$Builder$TypeVariableDefinition;", "public transient")]
				public Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition annotateTypeVariable(JavaArray<Dova.JDK.java.lang.annotation.Annotation> arg0)
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.TypeVariableDefinition>(ret);
				}
			}
		}

		[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;", "public abstract static interface")]
		public partial interface InnerTypeDefinition
			: IJavaObject
			, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static InnerTypeDefinition()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asAnonymousType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
			}

			[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
			Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder asAnonymousType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
			}

			[JniSignatureAttribute("Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;", "public abstract static interface")]
			public partial interface ForType
				: IJavaObject
				, Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder.InnerTypeDefinition
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static ForType()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lnet/bytebuddy/dynamic/DynamicType$Builder$InnerTypeDefinition$ForType;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asMemberType", "()Lnet/bytebuddy/dynamic/DynamicType$Builder;"));
				}

				[JniSignatureAttribute("()Lnet/bytebuddy/dynamic/DynamicType$Builder;", "public abstract")]
				Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder asMemberType()
				{
					var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.net.bytebuddy.dynamic.DynamicType.Builder>(ret);
				}
			}
		}
	}
}
